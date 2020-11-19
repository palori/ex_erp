import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { TeamMember, Address } from "../../../models";
import { TeamMemberService, AddressService } from '../../../services';

@Component({
  selector: 'app-team-detail',
  templateUrl: './team-detail.component.html',
  styleUrls: ['./team-detail.component.css']
})
export class TeamDetailComponent implements OnInit {

  tm: TeamMember;
  tm_query: TeamMember = {
    "id": "id",
    "name": "name",
    "surnames": "surnames",
    "phoneNumber": "phoneNumber",
    "email": "email",
    "registered": new Date(),
    "lastUpdated": new Date(),
    "gender": false,
    "year": 1,
    "role": "role",
    "isAdmin": false,
    "nif": "nif",
    "salary": 1,
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
    private tmService: TeamMemberService,
    private addressService: AddressService,
    private route: ActivatedRoute,
    private location: Location
  ) {}

  ngOnInit() {
    this.getTeamMember();
    setTimeout(() => this.getAddress(), 2000); // need some secoonds to get the data from the tm to be able to get the address
  }

  getTeamMember(): void {
    this.tm_query.id = this.route.snapshot.paramMap.get('id');
    // this.tmService.get(this.tm_query)
    this.tmService.get(this.tm_query)
      .subscribe(tm => this.tm = tm);
    
  }

  getAddress(): void {
    if(this.tm != null)
    {
      console.log(this.tm.id);
      console.log(this.tm.addressId);
      this.address_query.id = this.tm.addressId;
      this.addressService.get(this.address_query)
        .subscribe(address => this.address = address);
      if (this.address != null) this.composed_address = `${this.address.street}, ${this.address.number}, ${this.address.floor_door}`;
    }
  }

  updateTeamMember(){
    // console.log("Not implemented yet ;)");
    this.tmService.update(this.tm)
    //.subscribe(employee => this.employee = employee);
    .subscribe(() => this.goBack());
  }
  updateAddress(){
    console.log("Not implemented yet ;)");
  }

  addAddress(): void{
    console.log("Not implemented yet ;)");
  }

  goBack(): void {
    this.location.back();
  }

}

