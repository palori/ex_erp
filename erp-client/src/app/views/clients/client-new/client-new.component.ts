import { Component, OnInit } from '@angular/core';

import { Location } from '@angular/common';

import { Client } from "../../../models";
import { ClientService } from '../../../services';
import { rawListeners } from 'process';
// import { INITIAL_CONFIG } from '@angular/platform-server';

@Component({
  selector: 'app-client-new',
  templateUrl: './client-new.component.html',
  styleUrls: ['./client-new.component.css']
})
export class ClientNewComponent implements OnInit {

  constructor(
    private clientService: ClientService,
    private location: Location
  ) {}

  ngOnInit(): void { }

  add(name: string, surnames: string, phone: string, email: string, gender: string, year: string, notify: string){
    // verify inputs
    name = name.trim();
    surnames = surnames.trim();
    phone = phone.trim();
    email = email.trim();
    gender = gender.trim(); var gen = false;
    year = year.trim(); var yy = 1800;
    notify = notify.trim(); var noti = false;

    // if(!name && !surnames && !phone && !email && !gender && !year && !notify){
    if(true){
      this.clientService.add(this.initEntity(name, surnames, phone, email, gen, yy, noti) as Client)
      //.subscribe(employee => this.employee = employee);
      .subscribe(() => this.goBack());
      //.subscribe();
    }
  }

  goBack(): void {
    this.location.back();
  }

  initEntity(n:string, s: string, p:string, e:string, g:boolean, y:number, sn:boolean){
    return {
      name: n,
      surnames: s,
      phoneNumber: p,
      email: e,
      gender: g,
      year: y,
      sendNotifications: sn
    };
  }

}

