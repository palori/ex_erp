import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GenericService } from '../utils/generic/generic.service';
import { Supplier } from '../models';

@Injectable({
  providedIn: 'root'
})
export class SupplierService extends GenericService<Supplier>{

  constructor(http: HttpClient) 
  {
    super("suppliers", http);
  }
}
