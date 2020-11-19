import { Component, OnInit } from '@angular/core';
import { Supplier } from '../../../models';
import { SupplierService } from '../../../services';

@Component({
  selector: 'app-suppliers-list',
  templateUrl: './suppliers-list.component.html',
  styleUrls: ['./suppliers-list.component.css']
})
export class SuppliersListComponent implements OnInit {

  public suppliers: Supplier[];

  constructor(private supplierService: SupplierService) { }

  ngOnInit() {
    this.getSuppliers();
  }

  getSuppliers(): void {
    this.supplierService.getAll()
    .subscribe(suppliers => this.suppliers = suppliers);
  }

  delete(supplier: Supplier){
    this.suppliers = this.suppliers.filter(h => h !== supplier);
    this.supplierService.delete(supplier).subscribe();
  }
  
}

