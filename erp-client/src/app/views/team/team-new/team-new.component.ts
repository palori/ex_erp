import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';

import { TeamMember } from "../../../models";
import { TeamMemberService } from '../../../services';
import { rawListeners } from 'process';
// import { INITIAL_CONFIG } from '@angular/platform-server';

@Component({
  selector: 'app-team-new',
  templateUrl: './team-new.component.html',
  styleUrls: ['./team-new.component.css']
})
export class TeamNewComponent implements OnInit {

  constructor(
    private teamService: TeamMemberService,
    private location: Location
  ) {}

  ngOnInit(): void { }

  add(name: string, surnames: string, phone: string, email: string, gender: string, year: string, role: string, isAdmin: string, nif: string, salary:string){
    // verify inputs
    name = name.trim();
    surnames = surnames.trim();
    phone = phone.trim();
    email = email.trim();
    gender = gender.trim(); var gen = false;
    year = year.trim(); var yy = 1800;
    role = role.trim();
    isAdmin = isAdmin.trim(); var ia = false;
    nif = nif.trim();
    salary = salary.trim(); var sal = 1;

    // if(!name && !surnames && !phone && !email && !gender && !year && !notify){
    if(true){
      this.teamService.add(this.initEntity(name, surnames, phone, email, gen, yy, role, ia, nif, sal) as TeamMember)
      //.subscribe(employee => this.employee = employee);
      .subscribe(() => this.goBack());
      //.subscribe();
    }
  }

  goBack(): void {
    this.location.back();
  }

  initEntity(n:string, s: string, p:string, e:string, g:boolean, y:number, r:string, ia:boolean, nif:string, ss:number){
    return {
      name: n,
      surnames: s,
      phoneNumber: p,
      email: e,
      gender: g,
      year: y,
      role: r,
      isAdmin: ia,
      nif: nif,
      salary: ss
    };
  }

}

