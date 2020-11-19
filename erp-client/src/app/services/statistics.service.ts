import { Injectable } from '@angular/core';

import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { environment } from '../../environments/environment';
import { Statistics } from '../models';

@Injectable({
    providedIn: 'root'
})
export class StatisticsService {

    // URL to web api
    private url = `${environment.apiUrl}/statistics`;

    httpOptions = {
        headers: new HttpHeaders({'Content-Type': 'application/json'})
    };

  constructor(private http: HttpClient) { }

    get_newClientsMonth(): Observable<Statistics>
    {
        const url = `${this.url}/clientsmonth`;
        return this.http.get<Statistics>(url, this.httpOptions).pipe(
            //tap(_ => this.log(`fetched hero id=${id}`)),
            catchError(this.handleError<Statistics>(`statistics/clientsmonth`))
        );
    }
  
    get_ordersDay_avgCart(): Observable<Statistics[]>
    {
        const url = `${this.url}/ordersday_avgcart`;
        return this.http.get<Statistics[]>(url, this.httpOptions).pipe(
            //tap(_ => this.log(`fetched hero id=${id}`)),
            catchError(this.handleError<Statistics[]>(`statistics/ordersday_avgcart`))
        );
    }

    /**
     * Handle Http operation that failed.
     * Let the app continue.
     * @param operation - name of the operation that failed
     * @param result - optional value to return as the observable result
     */
    handleError<TT>(operation = 'operation', result?: TT) {
        return (error: any): Observable<TT> => {

            // TODO: send the error to remote logging infrastructure
            console.error(error); // log to console instead

            // TODO: better job of transforming error for user consumption
            //this.log(`${operation} failed: ${error.message}`);

            // Let the app keep running by returning an empty result.
            return of(result as TT);
        };
    }
}
