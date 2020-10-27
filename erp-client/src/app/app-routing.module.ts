import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { LoginComponent } from './views/login/login.component';
import { ClientsComponent } from './views/clients/clients.component';
import { WarehouseComponent } from './views/warehouse/warehouse.component';
import { OrdersComponent } from './views/orders/orders.component';
import { TeamComponent } from './views/team/team.component';
import { StatisticsComponent } from './views/statistics/statistics.component';

const routes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'clients', component: ClientsComponent },
  { path: 'warehouse', component: WarehouseComponent },
  { path: 'orders', component: OrdersComponent },
  { path: 'team', component: TeamComponent },
  { path: 'statistics', component: StatisticsComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
  