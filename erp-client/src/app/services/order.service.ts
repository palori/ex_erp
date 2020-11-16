import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GenericService } from '../utils/generic/generic.service';
import { Order } from '../models';

@Injectable({
  providedIn: 'root'
})
export class OrderService extends GenericService<Order>{

  constructor(http: HttpClient) 
  {
    super("orders", http);
  }
}
