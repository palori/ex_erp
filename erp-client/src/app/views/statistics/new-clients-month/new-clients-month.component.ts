import { getLocaleDateFormat } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Chart } from '../../../models';
import { StatisticsService } from '../../../services';

@Component({
    selector: 'app-new-clients-month',
    templateUrl: './new-clients-month.component.html',
    styleUrls: ['./new-clients-month.component.css']
})
export class NewClientsMonthComponent implements OnInit {

    constructor(private statisticsService: StatisticsService) { }

    ngOnInit(): void {
        this.getData();
    }

    public chart = {
        barChartOptions: {
            scaleShowVerticalLines: false,
            responsive: true
        },
        // barChartLabels: ['2006', '2007', '2008', '2009', '2010', '2011', '2012'],
        barChartType: 'bar',
        barChartLegend: true,
        // barChartData: [
        //     {data: [65, 59, 80, 81, 56, 55, 40], label: 'Series A'},
        //     {data: [28, 48, 40, 19, 86, 27, 90], label: 'Series B'}
        // ]
    } as Chart;

    getData():void{
        this.statisticsService.get_newClientsMonth()
            .subscribe(stats => {
                this.chart.barChartLabels = stats.x;
                this.chart.barChartData = [{data: stats.y, label: '# Clients'}];
                this.chart.title = stats.title;
            });
    }

}
