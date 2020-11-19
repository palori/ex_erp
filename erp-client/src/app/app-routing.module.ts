import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { LoginComponent } from './views/login/login.component';
import { ClientsComponent, ClientDetailComponent, ClientNewComponent } from './views/clients';
import { WarehouseComponent } from './views/warehouse/warehouse.component';
import { OrdersComponent } from './views/orders/orders.component';
import { TeamComponent, TeamDetailComponent, TeamNewComponent } from './views/team';
import { StatisticsComponent } from './views/statistics/statistics.component';
import { ProfileComponent } from './views/profile/profile.component';
import { AuthGuard } from './_helpers';
import { SuppliersComponent, SupplierDetailComponent, SupplierNewComponent } from './views/suppliers';

const routes: Routes = [
  // { path: '', redirectTo: 'login', pathMatch: 'full' },
  { path: '', component: ProfileComponent, canActivate: [AuthGuard] },
  { path: 'login', component: LoginComponent },
  { path: 'clients', component: ClientsComponent, canActivate: [AuthGuard] },
  { path: 'client/new', component: ClientNewComponent, canActivate: [AuthGuard] },
  { path: 'client/:id', component: ClientDetailComponent, canActivate: [AuthGuard] },
  { path: 'suppliers', component: SuppliersComponent, canActivate: [AuthGuard] },
  { path: 'supplier/new', component: SupplierNewComponent, canActivate: [AuthGuard] },
  { path: 'supplier/:id', component: SupplierDetailComponent, canActivate: [AuthGuard] },
  { path: 'warehouse', component: WarehouseComponent, canActivate: [AuthGuard] },
  { path: 'orders', component: OrdersComponent, canActivate: [AuthGuard] },
  { path: 'team', component: TeamComponent, canActivate: [AuthGuard] },
  { path: 'team/new', component: TeamNewComponent, canActivate: [AuthGuard] },
  { path: 'team/:id', component: TeamDetailComponent, canActivate: [AuthGuard] },
  { path: 'statistics', component: StatisticsComponent, canActivate: [AuthGuard] },

  // otherwise redirect to home
  { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
  