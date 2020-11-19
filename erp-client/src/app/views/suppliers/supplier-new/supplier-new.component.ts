import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';

import { Supplier } from "../../../models";
import { SupplierService } from '../../../services';
import { rawListeners } from 'process';
// import { INITIAL_CONFIG } from '@angular/platform-server';

@Component({
  selector: 'app-supplier-new',
  templateUrl: './supplier-new.component.html',
  styleUrls: ['./supplier-new.component.css']
})
export class SupplierNewComponent implements OnInit {

  constructor(
    private supplierService: SupplierService,
    private location: Location
  ) {}

  ngOnInit(): void { }

  add(name: string, phone: string, email: string, cif: string){
    // verify inputs
    name = name.trim();
    phone = phone.trim();
    email = email.trim();
    cif = cif.trim();

    // if(!name && !surnames && !phone && !email && !gender && !year && !notify){
    if(true){
      this.supplierService.add(this.initEntity(name, phone, email, cif) as Supplier)
      //.subscribe(employee => this.employee = employee);
      .subscribe(() => this.goBack());
      //.subscribe();
    }
  }

  goBack(): void {
    this.location.back();
  }

  initEntity(n:string, p:string, e:string, c:string){
    return {
      name: n,
      phoneNumber: p,
      email: e,
      cif: c
    };
  }

}


