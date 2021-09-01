import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AcourseenquiryComponent } from './acourseenquiry.component';

describe('AcourseenquiryComponent', () => {
  let component: AcourseenquiryComponent;
  let fixture: ComponentFixture<AcourseenquiryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AcourseenquiryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AcourseenquiryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
