import { TestBed } from '@angular/core/testing';

import { FilesprocessService } from './realpageapi.service';

describe('FilesprocessService', () => {
  let service: FilesprocessService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(FilesprocessService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
