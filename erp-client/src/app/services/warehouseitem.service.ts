import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GenericService } from '../utils/generic/generic.service';
import { WarehouseItem } from '../models';

@Injectable({
  providedIn: 'root'
})
export class WarehouseItemService extends GenericService<WarehouseItem>{

  constructor(http: HttpClient) 
  {
    super("warehouseitems", http);
  }
}
