import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GenericService } from '../utils/generic/generic.service';
import { Address } from '../models';

@Injectable({
  providedIn: 'root'
})
export class AddressService extends GenericService<Address>{

  constructor(http: HttpClient) 
  {
    super("addresses", http);
  }
}
