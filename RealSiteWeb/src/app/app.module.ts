import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { MenuComponent } from './menu/menu.component';
import { ContentComponent } from './content/content.component';
import { FooterComponent } from './footer/footer.component';
import { AboutComponent } from './about/about.component';
import { ContactComponent } from './contact/contact.component';
import { BanksComponent } from './banks/banks.component';
import { AddbankComponent } from './banks/addbank/addbank.component';
import { ListBankComponent } from './banks/listbanks/listbanks.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FileReassignComponent } from './files/file-reassign/file-reassign.component';
import { HttpClientModule } from '@angular/common/http';
import { EmployeeComponent } from './Employees/employee/employee.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    MenuComponent,
    ContentComponent,
    FooterComponent,
    AboutComponent,
    ContactComponent,
    BanksComponent,
    AddbankComponent,
    ListBankComponent,
    FileReassignComponent,
    EmployeeComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
