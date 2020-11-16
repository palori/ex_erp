import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { BehaviorSubject, Observable, of } from 'rxjs';
import { map, catchError  } from 'rxjs/operators';

import { environment } from '../../environments/environment';
import { User, Contact } from '../models';

@Injectable({ providedIn: 'root' })
export class AuthenticationService {
    private currentUserSubject: BehaviorSubject<Contact>;
    public currentUser: Observable<Contact>;
    errorMsg: string;

    httpOptions = {
        headers: new HttpHeaders(
          {
              'Content-Type': 'application/json',
              'responseType': 'json'
          })
    };

    constructor(private http: HttpClient) {
        this.currentUserSubject = new BehaviorSubject<Contact>(JSON.parse(localStorage.getItem('currentUser')));
        this.currentUser = this.currentUserSubject.asObservable();
    }

    public get currentUserValue(): Contact {
        return this.currentUserSubject.value;
    }

    login(username: string, password: string) {
        // console.log(`${environment.apiUrl}`);
        var userr = { "Username":username, "Password":password }
        // console.log(userr);
        var string_user = JSON.stringify(userr);
        return this.http.post<any>(`${environment.apiUrl}/authenticate`, string_user, this.httpOptions)
            .pipe(
                map(user => {
                // store user details and jwt token in local storage to keep user logged in between page refreshes
                // console.log(user);
                localStorage.setItem('currentUser', JSON.stringify(user));
                this.currentUserSubject.next(user);
                return user;
                }),
                catchError(this.handleError<any>(`error authenticate user`))
            );
    }

    logout() {
        // remove user from local storage to log user out
        localStorage.removeItem('currentUser');
        this.currentUserSubject.next(null);
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