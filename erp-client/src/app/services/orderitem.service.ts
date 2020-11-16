import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GenericService } from '../utils/generic/generic.service';
import { OrderItem } from '../models';

@Injectable({
  providedIn: 'root'
})
export class OrderItemService extends GenericService<OrderItem>{

  constructor(http: HttpClient) 
  {
    super("orderitems", http);
  }
}
