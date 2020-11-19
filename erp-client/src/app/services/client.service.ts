import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GenericService } from '../utils/generic/generic.service';
import { Client } from '../models';

@Injectable({
  providedIn: 'root'
})
export class ClientService extends GenericService<Client>{

  constructor(http: HttpClient) 
  {
    super("clientscontacts", http);
  }
}
