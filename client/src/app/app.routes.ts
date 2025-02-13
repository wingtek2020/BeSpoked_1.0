import { Routes } from '@angular/router';
import { UserListComponent } from './_components/users/user-list/user-list.component';
import { ProductListComponent } from './_components/products/product-list/product-list.component';
import { ProductDetailComponent } from './_components/products/product-detail/product-detail.component';
import { HomeComponent } from './_components/home/home.component';

export const routes: Routes = [
    {path: '', component: HomeComponent},
    {path: 'products', component: ProductListComponent},
    {path: 'users', component: UserListComponent},
];
