import { Component } from '@angular/core';
import { IEmployee } from 'src/app/model/Employee';
import { FileReassignService } from 'src/app/services/services/realpageapi.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent {
  p: number;
  pageItemNumber: number = 10;
  dataLength: number;
  currentPage: number = 1;
  endItemNumber: number;
  startItemNumber: number = 1;
  
  page: number = 1;  // current page
  pageSize: number = 5;

  employeesList : IEmployee[];
  constructor(private fileReassignService: FileReassignService) {}


  ngOnInit(): void {
   
    this.fileReassignService.getemployees().subscribe({
      next: (data) => {
        this.employeesList = data;
        console.log('API Data:', data);
      },
      error: (err) => {
        console.error('API Error:', err);
      }
    });
  }

  
  // pageChanged(event: any) {
  //   this.currentPage = event;
  //   this.startItemNumber = (((this.currentPage) - 1) * this.pageItemNumber) + 1;
  //   this.endItemNumber = ((this.currentPage) * this.pageItemNumber);
  //   if (this.endItemNumber > this.dataLength)
  //     this.endItemNumber = this.dataLength;
  // }
}
