import { Component } from '@angular/core';
import {inject, OnInit} from '@angular/core';
import {AppUsersService} from "../../../_services/app-users.service";
import {AppUser} from "../../../models/appUser";
import { signal } from '@angular/core';
import { NgFor, NgIf } from '@angular/common';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-user-list',
  standalone: true,
  templateUrl: './user-list.component.html',
  styleUrl: './user-list.component.css',
  imports: [NgFor, NgIf]
})
export class UserListComponent implements OnInit{
  public userService = inject(AppUsersService);
 
  ngOnInit(): void {
    this.userService.loadUsers();
  }
  addUser(): void {
    this.userService.addUser();
  }
 
}