import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { AuthenticationService } from '../../services';
import { Contact } from '../../models';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {

  currentUser: Contact;

  constructor(
      private router: Router,
      private authenticationService: AuthenticationService
  ) {
    this.refresh();
  }

  ngOnInit(): void {
  }

  logout() {
    this.authenticationService.logout();
    this.router.navigate(['/login']);
  }

  refresh(){
    this.authenticationService.currentUser.subscribe(x => this.currentUser = x);
  }

}
