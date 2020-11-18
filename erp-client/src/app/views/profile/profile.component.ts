import { Component, OnInit } from '@angular/core';
import { AuthenticationService } from '../../services';
import { Contact } from '../../models';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {

  currentUser: Contact;

  constructor(private authenticationService: AuthenticationService) {
    this.refresh();
  }

  ngOnInit(): void {
  }

  refresh(){
    this.authenticationService.currentUser.subscribe(x => this.currentUser = x);
  }

}
