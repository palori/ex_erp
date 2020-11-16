import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { GenericService } from '../utils/generic/generic.service';
import { Component } from '../models';

@Injectable({
  providedIn: 'root'
})
export class ComponentService extends GenericService<Component>{

  constructor(http: HttpClient) 
  {
    super("components", http);
  }
}
