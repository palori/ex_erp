import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IGenericService, GenericService } from './generic.service';

@Component({
  selector: 'app-generic',
  template: `
    <p>
      generic works!
    </p>
  `,
  styles: [
  ]
})
/* export class GenericComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

} */

export class GenericComponent {
    
    constructor(
        private genServ: GenericService, // revisar si IGeneric o Generic?????????
        private route: ActivatedRoute,
        // private location: Location,
        // private _url: string,
    ){
        // pass _url to constructor of Services????????????? maybe done before creating this object
        // this.genServ = genServ;
    }

    // private genServ: IGenericService;
    public items: any[];
    public item: any;

    // ngOnInit() {
    //     // this.getAll();
    //     // this.get();
    // }
        
    getAll(): void {
        this.genServ.getAll()
        .subscribe(items => this.items = items);
    }

    get(): void {
        const id = +this.route.snapshot.paramMap.get('id');
        this.genServ.get(id)
            .subscribe(item => this.item = item);
    }
    
    update(item: any): void{
        this.genServ.update(item)
            // .subscribe();
            .subscribe(item => this.item =   item); // possibilitat
            // .subscribe(() => this.goBack());
    }
    
    delete(item: any){
        this.items = this.items.filter(h => h !== item);
        this.genServ.delete(item)
            // .subscribe();
            .subscribe(item => this.item = item); // possibilitat
    }
}

