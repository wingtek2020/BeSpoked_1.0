import { Component } from '@angular/core';
import {inject, OnInit} from '@angular/core';
import {ProductService} from "../../../_services/product.service";

import { NgFor, NgIf } from '@angular/common';

@Component({
  selector: 'app-product-list',
  standalone: true,
  imports: [NgFor, NgIf],
  templateUrl: './product-list.component.html',
  styleUrl: './product-list.component.css'
})
export class ProductListComponent implements OnInit{
  public productService = inject(ProductService);
 
  ngOnInit(): void {
    this.productService.loadProducts();
  }

}
