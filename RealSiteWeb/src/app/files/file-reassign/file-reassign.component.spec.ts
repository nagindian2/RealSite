import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FileReassignComponent } from './file-reassign.component';

describe('FileReassignComponent', () => {
  let component: FileReassignComponent;
  let fixture: ComponentFixture<FileReassignComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FileReassignComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FileReassignComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
