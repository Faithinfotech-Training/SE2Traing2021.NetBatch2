import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AeditcourseenquiryComponent } from './aeditcourseenquiry.component';

describe('AeditcourseenquiryComponent', () => {
  let component: AeditcourseenquiryComponent;
  let fixture: ComponentFixture<AeditcourseenquiryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AeditcourseenquiryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AeditcourseenquiryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
