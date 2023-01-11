import { Component, ElementRef, EventEmitter, Injector, Output, ViewChild } from '@angular/core';
import { DateTimeService } from '@app/shared/common/timing/date-time.service';
import { AppComponentBase } from '@shared/common/app-component-base';
import {
    CommonLookupServiceProxy,
    SubscribableEditionComboboxItemDto,
    TenantCustomPageInputDto,
    TenantCustomPageItemDto,
    TenantEditDto,
    TenantServiceProxy,
} from '@shared/service-proxies/service-proxies';
import { filter as _filter } from 'lodash-es';
import { DateTime } from 'luxon';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { finalize } from 'rxjs/operators';

@Component({
    selector: 'groupJobSettingModal',
    templateUrl: './group-job-setting-modal.component.html',
})
export class GroupJobSettingModalComponent extends AppComponentBase {
    @ViewChild('nameInput', { static: true }) nameInput: ElementRef;
    @ViewChild('editModal', { static: true }) modal: ModalDirective;
    @ViewChild('SubscriptionEndDateUtc') subscriptionEndDateUtc: ElementRef;

    @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

    active = false;
    saving = false;

    tenantId: number = undefined;
    tenancyNameShow: string = undefined;
    listItem: TenantCustomPageItemDto[] = [];

    constructor(
        injector: Injector,
        private _tenantService: TenantServiceProxy
    ) {
        super(injector);
    }

    show(tenantId: number, tenancyName: string): void {
        this.tenantId = tenantId;
        this.tenancyNameShow = tenancyName;

        this._tenantService.getGroupJobSetting(tenantId).subscribe(items => {
            this.listItem = items;

            this.active = true;
            this.modal.show();
        });
    }

    onShown(): void {

    }

    onAddItem(): void {
        let maxInd: number = 1;
        this.listItem = this.listItem.map(e => {
            e.pageIndex = maxInd++;
            return e;
        })

        this.listItem.push(new TenantCustomPageItemDto({
            id: undefined,
            pageIndex: maxInd++,
            pageMenuKey: undefined,
            pageTitleKey: undefined
        }));
    }

    onRemoveItem(itemIndex?: number): void {
        if (!itemIndex) {
            return;
        }

        for (let i = 0; i < this.listItem.length; i++) {
            if (this.listItem[i].pageIndex === itemIndex) {
                this.listItem.splice(i, 1);
                break;
            }
        }

        let maxInd: number = 1;
        this.listItem = this.listItem.map(e => {
            e.pageIndex = maxInd++;
            return e;
        })
    }

    save(): void {
        this.saving = true;

        const DataAPI: TenantCustomPageInputDto = new TenantCustomPageInputDto({
            tenantId: this.tenantId,
            items: this.listItem
        });

        this._tenantService.setGroupJobSetting(DataAPI).pipe(finalize(() => (
            this.saving = false
        ))).subscribe(result => {
            if (result.status) {
                this.notify.success(this.l(result.message));
                this.close();
                this.modalSave.emit(null);
                return;
            }

            this.notify.error(this.l(result.message, result.data));
        });
    }

    close(): void {
        this.active = false;
        this.modal.hide();
    }
}
