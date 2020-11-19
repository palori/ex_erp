import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { Supplier, Address } from "../../../models";
import { SupplierService, AddressService } from '../../../services';

@Component({
  selector: 'app-supplier-detail',
  templateUrl: './supplier-detail.component.html',
  styleUrls: ['./supplier-detail.component.css']
})
export class SupplierDetailComponent implements OnInit {

  supplier: Supplier;
  supplier_query: Supplier = {
    "id": "id",
    "name": "name",
    "phoneNumber": "phoneNumber",
    "email": "email",
    "registered": new Date(),
    "lastUpdated": new Date(),
    "cif": "cif",
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
    private supplierService: SupplierService,
    private addressService: AddressService,
    private route: ActivatedRoute,
    private location: Location
  ) {}

  ngOnInit() {
    this.getSupplier();
    setTimeout(() => this.getAddress(), 2000); // need some secoonds to get the data from the supplier to be able to get the address
  }

  getSupplier(): void {
    this.supplier_query.id = this.route.snapshot.paramMap.get('id');
    // this.supplierService.get(this.supplier_query)
    this.supplierService.get(this.supplier_query)
      .subscribe(supplier => this.supplier = supplier);
    
  }

  getAddress(): void {
    if(this.supplier != null)
    {
      console.log(this.supplier.id);
      console.log(this.supplier.addressId);
      this.address_query.id = this.supplier.addressId;
      this.addressService.get(this.address_query)
        .subscribe(address => this.address = address);
      if (this.address != null) this.composed_address = `${this.address.street}, ${this.address.number}, ${this.address.floor_door}`;
    }
  }

  updateSupplier(){
    // console.log("Not implemented yet ;)");
    this.supplierService.update(this.supplier)
    //.subscribe(employee => this.employee = employee);
    .subscribe(() => this.goBack());
  }
  updateAddress(){
    console.log("Not implemented yet ;)");
  }
  // update(){
  //   if(!isNaN(Number(this.supplier.salary))){
  //     this.supplier.salary = Number(this.supplier.salary);

  //     this.update();
  //   } else{
  //       console.log("salary error:", this.supplier.salary);
  //   }
  // }

  // update(){
  //   this.supplierService.update(this.supplier)
  //   //.subscribe(supplier => this.supplier = supplier);
  //   .subscribe(() => this.goBack());
  // }

  addAddress(): void{
    console.log("Not implemented yet ;)");
  }

  goBack(): void {
    this.location.back();
  }

}
