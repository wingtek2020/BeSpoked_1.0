import { Injectable } from '@angular/core';
import { Sales } from "../models/sales";
import { inject, signal } from '@angular/core';
import { environment } from "../environments/environment";

import {HttpClient} from "@angular/common/http";
import {HttpClientModule} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class ReportingService {

  constructor() { }

  sales = signal<Sales[]>([]);
  baseUrl = environment.apiUrl;

  private http = inject(HttpClient);

  loadSalesReport(){
    console.log(this.baseUrl);
    return this.http.get<any>(this.baseUrl + "sales").subscribe({
      next: data =>{
        this.sales.set(data)
      } 
    })

  }
}
