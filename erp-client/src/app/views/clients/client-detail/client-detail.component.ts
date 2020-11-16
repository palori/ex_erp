import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { Client, Address } from "../../../models";
import { ClientService, AddressService } from '../../../services';

@Component({
  selector: 'app-client-detail',
  templateUrl: './client-detail.component.html',
  styleUrls: ['./client-detail.component.css']
})
export class ClientDetailComponent implements OnInit {

  client: Client;
  client_query: Client = {
    "id": "id",
    "name": "name",
    "surnames": "surnames",
    "phoneNumber": "phoneNumber",
    "email": "email",
    "registered": new Date(),
    "lastUpdated": new Date(),
    "gender": false,
    "year": 1,
    "sendNotifications": false,
    "addressId": "addressId"
  };
  address: Address;
  address_query: Address = {
    "id": "id",
    "street": "street",
    "number": 0,
    "floor_door": "floor_door",
    "city": "city",
    "postalCode": 0,
    "country": "country"
  };
  composed_address: string;

  constructor(
    private clientService: ClientService,
    private addressService: AddressService,
    private route: ActivatedRoute,
    private location: Location
  ) {}

  ngOnInit() {
    this.getClient();
    setTimeout(() => this.getAddress(), 2000); // need some secoonds to get the data from the client to be able to get the address
  }

  getClient(): void {
    this.client_query.id = this.route.snapshot.paramMap.get('id');
    // this.clientService.get(this.client_query)
    this.clientService.get(this.client_query)
      .subscribe(client => this.client = client);
    
  }

  getAddress(): void {
    if(this.client != null)
    {
      console.log(this.client.id);
      console.log(this.client.addressId);
      this.address_query.id = this.client.addressId;
      this.addressService.get(this.address_query)
        .subscribe(address => this.address = address);
      if (this.address != null) this.composed_address = `${this.address.street}, ${this.address.number}, ${this.address.floor_door}`;
    }
  }

  updateClient(){
    console.log("Not implemented yet ;)");
  }
  updateAddress(){
    console.log("Not implemented yet ;)");
  }
  // update(){
  //   if(!isNaN(Number(this.client.salary))){
  //     this.client.salary = Number(this.client.salary);

  //     this.update();
  //   } else{
  //       console.log("salary error:", this.client.salary);
  //   }
  // }

  // update(){
  //   this.clientService.update(this.client)
  //   //.subscribe(client => this.client = client);
  //   .subscribe(() => this.goBack());
  // }

  addAddress(): void{
    console.log("Not implemented yet ;)");
  }

  goBack(): void {
    this.location.back();
  }

}
