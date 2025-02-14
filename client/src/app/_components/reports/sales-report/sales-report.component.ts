import { Component } from '@angular/core';
import {inject, OnInit} from '@angular/core';
import {ReportingService} from "../../../_services/reporting.service";
import { NgFor, NgIf } from '@angular/common';

@Component({
  selector: 'app-sales-report',
  standalone: true,
  imports: [NgFor, NgIf],
  templateUrl: './sales-report.component.html',
  styleUrl: './sales-report.component.css'
})
export class SalesReportComponent {
  public salesReport = inject(ReportingService);
 
  ngOnInit(): void {
    this.salesReport.loadSalesReport();
  }
}
