import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdatecenquiryComponent } from './updatecenquiry.component';

describe('UpdatecenquiryComponent', () => {
  let component: UpdatecenquiryComponent;
  let fixture: ComponentFixture<UpdatecenquiryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdatecenquiryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdatecenquiryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
