import { NgModule } from '@angular/core';
import { AdminSharedModule } from '@app/admin/shared/admin-shared.module';
import { AppSharedModule } from '@app/shared/app-shared.module';
import { I3TCustomPageComponent } from './custom-page.component';
import { I3TCustomPageRoutingModule } from './custom-page-routing.module';

@NgModule({
    declarations: [
        I3TCustomPageComponent
    ],
    imports: [AppSharedModule, AdminSharedModule, I3TCustomPageRoutingModule],
})
export class I3TCustomPageModule { } 
