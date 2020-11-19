import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { OrdersDayAvgCartComponent } from './orders-day-avg-cart.component';

describe('OrdersDayAvgCartComponent', () => {
  let component: OrdersDayAvgCartComponent;
  let fixture: ComponentFixture<OrdersDayAvgCartComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ OrdersDayAvgCartComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(OrdersDayAvgCartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
