import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditLeafComponent } from './edit-leaf.component';

describe('EditLeafComponent', () => {
  let component: EditLeafComponent;
  let fixture: ComponentFixture<EditLeafComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditLeafComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EditLeafComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
