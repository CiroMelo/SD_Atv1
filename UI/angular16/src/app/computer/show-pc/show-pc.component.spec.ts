import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowPcComponent } from './show-pc.component';

describe('ShowPcComponent', () => {
  let component: ShowPcComponent;
  let fixture: ComponentFixture<ShowPcComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ShowPcComponent]
    });
    fixture = TestBed.createComponent(ShowPcComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
