import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AresourcesComponent } from './aresources.component';

describe('AresourcesComponent', () => {
  let component: AresourcesComponent;
  let fixture: ComponentFixture<AresourcesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AresourcesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AresourcesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
