import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MinsightComponent } from './minsight.component';

describe('MinsightComponent', () => {
  let component: MinsightComponent;
  let fixture: ComponentFixture<MinsightComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MinsightComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MinsightComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
