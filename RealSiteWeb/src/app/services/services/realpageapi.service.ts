
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IFileReassign } from 'src/app/model/FileReassign';
import { IEmployee } from 'src/app/model/Employee';

@Injectable({
  providedIn: 'root'
})

export class FileReassignService {
 
  private apiUrl = 'https://realsiteapi-f9g5cydrgfdfg4dc.centralindia-01.azurewebsites.net/api/RealSite/'  // change port if needed
   
  constructor(private http: HttpClient) { }

  getTop100(): Observable<IFileReassign[]> {
    return this.http.get<IFileReassign[]>(`${this.apiUrl}/top100`);
  }
  getplain(): Observable<string> {
    return this.http.get<string>('https://localhost:7240/api/RealSite/top300');
  }

  getemployees(): Observable<IEmployee[]> {
    return this.http.get<IEmployee[]>(`${this.apiUrl}/?service=GetEmployeeDetails`);
  }
}
