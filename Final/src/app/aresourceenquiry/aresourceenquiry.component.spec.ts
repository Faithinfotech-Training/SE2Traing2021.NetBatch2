import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AresourceenquiryComponent } from './aresourceenquiry.component';

describe('AresourceenquiryComponent', () => {
  let component: AresourceenquiryComponent;
  let fixture: ComponentFixture<AresourceenquiryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AresourceenquiryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AresourceenquiryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
