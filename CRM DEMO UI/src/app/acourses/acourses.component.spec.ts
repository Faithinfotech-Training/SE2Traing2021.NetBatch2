import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ACoursesComponent } from './acourses.component';

describe('ACoursesComponent', () => {
  let component: ACoursesComponent;
  let fixture: ComponentFixture<ACoursesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ACoursesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ACoursesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
