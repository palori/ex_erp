import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

// External libraries
import { AngularEmojisModule } from 'angular-emojis';
import { ChartsModule } from 'ng2-charts';

// Utils
import { NavBarComponent } from './utils/nav-bar/nav-bar.component';

// Views
import { LoginComponent } from './views/login/login.component';
import { ClientsComponent } from './views/clients/clients.component';
import { SuppliersComponent } from './views/suppliers/suppliers.component';
import { WarehouseComponent } from './views/warehouse/warehouse.component';
import { OrdersComponent } from './views/orders/orders.component';
import { TeamComponent } from './views/team/team.component';
import { StatisticsComponent } from './views/statistics/statistics.component';
import { ClientsListComponent } from './views/clients/clients-list/clients-list.component';
// import { GenericComponent } from './utils/generic/generic.component';
import { JwtInterceptor, ErrorInterceptor } from './_helpers';
import { ClientDetailComponent } from './views/clients/client-detail/client-detail.component';
import { ProfileComponent } from './views/profile/profile.component';
import { ClientNewComponent } from './views/clients/client-new/client-new.component';
import { NewClientsMonthComponent } from './views/statistics/new-clients-month/new-clients-month.component';
import { OrdersDayAvgCartComponent } from './views/statistics/orders-day-avg-cart/orders-day-avg-cart.component';
import { SuppliersListComponent } from './views/suppliers/suppliers-list/suppliers-list.component';
import { SupplierDetailComponent } from './views/suppliers/supplier-detail/supplier-detail.component';
import { SupplierNewComponent } from './views/suppliers/supplier-new/supplier-new.component';
import { TeamListComponent } from './views/team/team-list/team-list.component';
import { TeamNewComponent } from './views/team/team-new/team-new.component';
import { TeamDetailComponent } from './views/team/team-detail/team-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    ClientsComponent,
    SuppliersComponent,
    WarehouseComponent,
    OrdersComponent,
    TeamComponent,
    StatisticsComponent,
    ClientsListComponent,
    LoginComponent,
    ClientDetailComponent,
    ProfileComponent,
    ClientNewComponent,
    NewClientsMonthComponent,
    OrdersDayAvgCartComponent,
    SuppliersListComponent,
    SupplierDetailComponent,
    SupplierNewComponent,
    TeamListComponent,
    TeamNewComponent,
    TeamDetailComponent,
    // GenericComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule,
    AngularEmojisModule,
    ChartsModule
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
