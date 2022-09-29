import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LeafsListComponent } from './leafs-list.component';

describe('LeafsListComponent', () => {
  let component: LeafsListComponent;
  let fixture: ComponentFixture<LeafsListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LeafsListComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LeafsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
