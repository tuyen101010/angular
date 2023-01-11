import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { I3TCustomPageComponent } from './custom-page.component';

const routes: Routes = [
    {
        path: '',
        component: I3TCustomPageComponent,
        pathMatch: 'full',
    },
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class I3TCustomPageRoutingModule {}
