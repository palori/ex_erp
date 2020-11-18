import { getLocaleDateFormat } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Statistics } from '../../../models';
import { StatisticsService } from '../../../services';

@Component({
  selector: 'app-new-clients-month',
  templateUrl: './new-clients-month.component.html',
  styleUrls: ['./new-clients-month.component.css']
})
export class NewClientsMonthComponent implements OnInit {

  constructor(private statisticsService: StatisticsService) { }

  ngOnInit(): void {
    // this.getData();
  }

  public barChartOptions = {
    scaleShowVerticalLines: false,
    responsive: true
  };
  public barChartLabels = ['2006', '2007', '2008', '2009', '2010', '2011', '2012'];
  public barChartType = 'bar';
  public barChartLegend = true;
  public barChartData = [
    {data: [65, 59, 80, 81, 56, 55, 40], label: 'Series A'},
    {data: [28, 48, 40, 19, 86, 27, 90], label: 'Series B'}
  ];

  public title = "Title";

  getData():void{
    this.statisticsService.get_newClientsMonth()
      .subscribe(stats => {
        this.title = stats.title;
        this.barChartLabels = stats.x;
        this.barChartData = stats.y;
      });
  }

}
