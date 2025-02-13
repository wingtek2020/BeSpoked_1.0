import { Injectable } from '@angular/core';
import { Product } from "../models/product";
import { inject, signal } from '@angular/core';
import { environment } from "../environments/environment";

import {HttpClient} from "@angular/common/http";
import {HttpClientModule} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  constructor() { }

  products = signal<Product[]>([]);
  baseUrl = environment.apiUrl;

  private http = inject(HttpClient);


  loadProducts(){
    console.log(this.baseUrl);
    return this.http.get<any>(this.baseUrl + "products").subscribe({
      next: data =>{
        console.log(data);
        this.products.set(data)
      } 
    })

  }

  addProduct(){
    return this.http.post<any>(this.baseUrl + "appUsers", {}).subscribe({
      next: data =>{
        console.log(data);
        //this.users.set(data)
      }
    })
  }
  
}
