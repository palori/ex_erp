import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GenericService } from '../utils/generic/generic.service';
import { TeamMember } from '../models';

@Injectable({
  providedIn: 'root'
})
export class TeamMemberService extends GenericService<TeamMember>{

  constructor(http: HttpClient) 
  {
    super("teammemberscontacts", http);
  }
}
