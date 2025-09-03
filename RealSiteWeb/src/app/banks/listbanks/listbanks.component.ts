import { Component } from '@angular/core';


@Component({
  selector: 'app-list-bank',
  templateUrl: './listbanks.component.html',
})
export class ListBankComponent {
  banks = ['HDFC', 'SBI', 'ICICI'];
}
