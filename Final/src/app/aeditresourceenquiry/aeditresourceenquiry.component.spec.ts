import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AeditresourceenquiryComponent } from './aeditresourceenquiry.component';

describe('AeditresourceenquiryComponent', () => {
  let component: AeditresourceenquiryComponent;
  let fixture: ComponentFixture<AeditresourceenquiryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AeditresourceenquiryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AeditresourceenquiryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
