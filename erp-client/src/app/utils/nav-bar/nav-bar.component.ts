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

  home() {
    // uncheck radiobutton menu!

    //option1
    // var menu = document.getElementsByClassName("btn-group");
    // // document.getElementsByClassName("btn-group")[0]
    // for (var i=0; i < menu.length; i++){
    //   // menu[i].setAttribute("checked","defaultChoice");
    //   menu[i][0].removeAttribute("checked");
    //   console.log(menu[i]);
    // }

    // option2
    var menu1 = document.querySelectorAll('[id^=option]');
    console.log(menu1);
    for (var i=0; i<menu1.length; i++){
      console.log(menu1[0].removeAttribute("checked"));
    }
      
  }

}
