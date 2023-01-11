﻿import { Component, ViewChild, Injector, Output, EventEmitter, ViewEncapsulation } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { AppComponentBase } from '@shared/common/app-component-base';
import { Table } from 'primeng/table';
import { Paginator } from 'primeng/paginator';
import { LazyLoadEvent } from 'primeng/api';
import { NameValueDto, NotificationServiceProxy } from '@shared/service-proxies/service-proxies';

@Component({
  selector: 'organization-unit-lookup-table-modal',
  templateUrl: './organization-unit-lookup-table-modal.component.html'
})
export class OrganizationUnitLookupTableModalComponent extends AppComponentBase {
  @ViewChild('organizationUnitLookupTableModal', { static: true }) modal: ModalDirective;
  @ViewChild('dataTable', { static: true }) dataTable: Table;
  @ViewChild('paginator', { static: true }) paginator: Paginator;

  filterText = '';

  @Output() modalSave: EventEmitter<NameValueDto[]> = new EventEmitter<NameValueDto[]>();
  active = false;
  saving = false;

  selectedOUs: NameValueDto[];

  constructor(injector: Injector,
    private _notificationServiceProxy: NotificationServiceProxy) {
    super(injector);
  }

  show(): void {
    this.active = true;
    this.paginator.rows = 5;
    this.getAll();
    this.modal.show();
  }

  getAll(event?: LazyLoadEvent) {
    if (!this.active) {
      return;
    }

    if (this.primengTableHelper.shouldResetPaging(event)) {
      this.paginator.changePage(0);
      if (this.primengTableHelper.records && this.primengTableHelper.records.length > 0) {
        return;
      }
    }

    this.primengTableHelper.showLoadingIndicator();

    this._notificationServiceProxy
      .getAllOrganizationUnitForLookupTable(
        this.filterText,
        this.primengTableHelper.getSorting(this.dataTable),
        this.primengTableHelper.getSkipCount(this.paginator, event),
        this.primengTableHelper.getMaxResultCount(this.paginator, event)
      )
      .subscribe((result) => {
        this.primengTableHelper.totalRecordsCount = result.totalCount;
        this.primengTableHelper.records = result.items;
        this.primengTableHelper.hideLoadingIndicator();
      });
  }

  reloadPage(): void {
    this.paginator.changePage(this.paginator.getPage());
  }

  save() {
    this.active = false;
    this.modal.hide();
    this.modalSave.emit(this.selectedOUs);
    this.selectedOUs = [];
  }

  close(): void {
    this.active = false;
    this.modal.hide();
    this.selectedOUs = [];
  }
}
