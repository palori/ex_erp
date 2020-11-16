import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GenericService } from '../utils/generic/generic.service';
import { Profile } from '../models';

@Injectable({
  providedIn: 'root'
})
export class ProfileService extends GenericService<Profile>{

  constructor(http: HttpClient) 
  {
    super("profiles", http);
  }
}
