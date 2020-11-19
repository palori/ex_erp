import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GenericService } from '../utils/generic/generic.service';
import { ItemInfo } from '../models';

@Injectable({
  providedIn: 'root'
})
export class ItemInfoService extends GenericService<ItemInfo>{

  constructor(http: HttpClient) 
  {
    super("iteminfos", http);
  }
}
