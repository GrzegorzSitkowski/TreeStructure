import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddLeafComponent } from './add-leaf.component';

describe('AddLeafComponent', () => {
  let component: AddLeafComponent;
  let fixture: ComponentFixture<AddLeafComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddLeafComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddLeafComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
