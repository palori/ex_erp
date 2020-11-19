import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NewClientsMonthComponent } from './new-clients-month.component';

describe('NewClientsMonthComponent', () => {
  let component: NewClientsMonthComponent;
  let fixture: ComponentFixture<NewClientsMonthComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NewClientsMonthComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NewClientsMonthComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
