import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GenericService } from '../utils/generic/generic.service';
import { TradingInfo } from '../models';

@Injectable({
  providedIn: 'root'
})
export class TradingInfoService extends GenericService<TradingInfo>{

  constructor(http: HttpClient) 
  {
    super("tradinginfos", http);
  }
}
