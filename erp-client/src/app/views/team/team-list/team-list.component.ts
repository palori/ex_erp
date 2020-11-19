import { Component, OnInit } from '@angular/core';
import { TeamMember } from '../../../models';
import { TeamMemberService } from '../../../services';

@Component({
  selector: 'app-team-list',
  templateUrl: './team-list.component.html',
  styleUrls: ['./team-list.component.css']
})
export class TeamListComponent implements OnInit {
 
  public team: TeamMember[];

  constructor(private teamService: TeamMemberService) { }

  ngOnInit() {
    this.getTeamMembers();
  }

  getTeamMembers(): void {
    this.teamService.getAll()
    .subscribe(team => this.team = team);
  }

  delete(tm: TeamMember){
    this.team = this.team.filter(h => h !== tm);
    this.teamService.delete(tm).subscribe();
  }
  
}

