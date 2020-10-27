import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

// Utils
import { NavBarComponent } from './utils/nav-bar/nav-bar.component';

// Views
import { LoginComponent } from './views/login/login.component';
import { ClientsComponent } from './views/clients/clients.component';
import { WarehouseComponent } from './views/warehouse/warehouse.component';
import { OrdersComponent } from './views/orders/orders.component';
import { TeamComponent } from './views/team/team.component';
import { StatisticsComponent } from './views/statistics/statistics.component';
import { ClientsListComponent } from './views/clients/clients-list/clients-list.component';
import { GenericComponent } from './utils/generic/generic.component';

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    ClientsComponent,
    WarehouseComponent,
    OrdersComponent,
    TeamComponent,
    StatisticsComponent,
    ClientsListComponent,
    LoginComponent,
    GenericComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
