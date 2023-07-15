import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEditPcComponent } from './add-edit-pc.component';

describe('AddEditPcComponent', () => {
  let component: AddEditPcComponent;
  let fixture: ComponentFixture<AddEditPcComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddEditPcComponent]
    });
    fixture = TestBed.createComponent(AddEditPcComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
