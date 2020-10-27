import { Component, OnInit } from '@angular/core';
import { Client } from '../../../models/client';
import { ClientService } from '../../../client.service';

@Component({
  selector: 'app-clients-list',
  templateUrl: './clients-list.component.html',
  styleUrls: ['./clients-list.component.css']
})
export class ClientsListComponent implements OnInit {
  
  public clients: Client[];

  constructor(private clientService: ClientService) { }

  ngOnInit() {
    this.getClients();
  }

  getClients(): void {
    this.clientService.getEmployees()
    .subscribe(employees => this.clients = employees);
  }

  deleteEmployee(client: Client){
    this.clients = this.clients.filter(h => h !== client);
    this.clientService.deleteEmployee(client).subscribe();
  }
  
}
