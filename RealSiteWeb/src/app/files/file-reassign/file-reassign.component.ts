import { Component, OnInit } from '@angular/core'; 
import { IFileReassign } from 'src/app/model/FileReassign';
import { FileReassignService } from 'src/app/services/services/realpageapi.service';

@Component({
  selector: 'app-file-reassign',
  templateUrl: './file-reassign.component.html'
})
export class FileReassignComponent implements OnInit {

  fileReassignList : IFileReassign[];
  constructor(private fileReassignService: FileReassignService) {}

  ngOnInit(): void {
   
    this.fileReassignService.getTop100().subscribe({
      next: (data) => {
        this.fileReassignList = data;
        console.log('API Data:', data);
      },
      error: (err) => {
        console.error('API Error:', err);
      }
    });
  }
}
