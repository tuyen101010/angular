import { Component, Injector, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { AppComponentBase } from '@shared/common/app-component-base';
import { TenantCustomPageItemDto } from '@shared/service-proxies/service-proxies';

@Component({
    templateUrl: './custom-page.component.html',
    animations: [appModuleAnimation()],
})
export class I3TCustomPageComponent extends AppComponentBase implements OnInit {

    alertVisible = true;

    customPageId: number = undefined;
    customPageTitle: string = "DemoUiComponents";

    dateValue = '';
    phoneValue = '';
    serialValue = '';
    phoneExtValue = '';
    htmlEditorInput: string;

    constructor(
        injector: Injector,
        private _activatedRoute: ActivatedRoute
    ) {
        super(injector);
    }

    ngOnInit(): void {
        this.customPageId = undefined;
        this.customPageTitle = "DemoUiComponents";
        this.init();
    }

    hideAlert(): void {
        this.alertVisible = false;
    }

    init(): void {
        this._activatedRoute.params.subscribe((params: Params) => {
            this.customPageId = Number(params['id']);
            if (this.customPageId) {
                this.tenantCustomPages.forEach(e => {
                    if (e.id === this.customPageId) {
                        this.customPageTitle = this.l(e.pageTitleKey);
                        return;
                    }
                });
            }
        });
    }

    submitDateValue(): void {
    }

    submiPhoneValue(): void {
    }

    submitSerialValue(): void {
    }

    submitPhoneExtValue(): void {
    }

    submitValue(): void {
    }
}
