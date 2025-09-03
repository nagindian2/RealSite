import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { ContentComponent } from './content/content.component';
import { AddbankComponent } from './banks/addbank/addbank.component';
import { ListBankComponent } from './banks/listbanks/listbanks.component';
import { FileReassignComponent } from './files/file-reassign/file-reassign.component';  
import { EmployeeComponent } from './Employees/employee/employee.component';


const routes: Routes = [
  { path: '', component: ContentComponent }, // Default route
  { path: 'about', component: AboutComponent },
  { path: 'contact', component: ContactComponent },
  { path: 'add-bank', component: AddbankComponent },
  { path: 'list-bank', component: ListBankComponent },
  { path: 'file-reassign', component: FileReassignComponent },
  { path: 'emp-list', component:EmployeeComponent },
  { path: '', redirectTo: '/list-bank', pathMatch: 'full' } // default
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
 