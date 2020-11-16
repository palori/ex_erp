import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GenericService } from '../utils/generic/generic.service';
import { Contact } from '../models';

@Injectable({
  providedIn: 'root'
})
export class ContactService extends GenericService<Contact>{

  constructor(http: HttpClient) 
  {
    super("contacts", http);
  }
}
