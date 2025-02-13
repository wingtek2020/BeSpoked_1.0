import { Injectable } from '@angular/core';
import { AppUser } from "../models/appUser";
import { inject, signal } from '@angular/core';
import { environment } from "../environments/environment";

import {HttpClient} from "@angular/common/http";
import {HttpClientModule} from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class AppUsersService {

  constructor() { }

  users = signal<AppUser[]>([]);
  baseUrl = environment.apiUrl;

  private http = inject(HttpClient);


  loadUsers(){
    console.log(this.baseUrl);
    return this.http.get<any>(this.baseUrl + "appUsers").subscribe({
      next: data =>{
        console.log(data);
        this.users.set(data)
      } 
    })

  }

  addUser(){
    return this.http.post<any>(this.baseUrl + "appUsers", {}).subscribe({
      next: data =>{
        console.log(data);
        //this.users.set(data)
      }
    })
  }
  getUser(username: string) {
    return this.http.get<AppUser>(this.baseUrl + "users/" + username)
  }
}
