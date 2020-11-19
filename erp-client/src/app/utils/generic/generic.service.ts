import { Injectable } from '@angular/core';

import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { environment } from '../../../environments/environment';

// @Injectable({
//   providedIn: 'root'
// })

export interface IGenericService<T>{
  getAll(): Observable<T[]>
  get(id: any | T): Observable<T>
  update(item: T): Observable<T>
  delete(item: T): Observable<T>
  add(item: T): Observable<T>
}

export class GenericService<T> implements IGenericService<T>{
  
  private url: string; // URL to web api
  private item: T;
  private items: T[];

  httpOptions = {
      headers: new HttpHeaders(
        {
            'Content-Type': 'application/json',
            // 'tk': "token_must_go_here",
            // 'id': "any_id"
        })
  };

  constructor(
      _url: string,
      private http: HttpClient
  )
  {
    //   this.url = `${environment.apiUrl}/${_url}`;
      this.url = `${environment.apiUrl}/${_url}`;
  }

//   set_token(token: string)
//   {
//         this.httpOptions.headers.set("tk",token);
//   } 

  set_id(id: any)
  {
    id = typeof id === 'number' ? id.toString() : id;     // it can only be a number or a string
    // this.httpOptions.headers.set("id", id);
  }

  getAll(): Observable<T[]> 
  {
    //   this.set_id(-1);
      return this.http.get<T[]>(this.url, this.httpOptions).pipe(
          //tap(_ => this.log('fetched heroes')),
          catchError(this.handleError<T[]>('getAll', []))
      );
  }

  get(item: T): Observable<T>
  {
      const url = `${this.url}/1`; //`${this.url}/${id}`;
    //   this.set_id(item.id);
      return this.http.post<T>(url, item, this.httpOptions).pipe(
          //tap(_ => this.log(`fetched hero id=${id}`)),
          catchError(this.handleError<T>(`get ${item}`))//(`get id=${item.Id}`))
      );
  }

  update(item: T): Observable<T>
  {
    //   this.set_id(-1);
      return this.http.put<T>(this.url, item, this.httpOptions).pipe(
          //tap(_ => this.log(`updated hero id=${hero.id}`)),
          catchError(this.handleError<T>(`update ${typeof item}`))
      );
  }

  delete(item: T): Observable<T>{
      const url = `${this.url}/d`;
    //   this.set_id(item.id);
      return this.http.post<T>(url, item, this.httpOptions).pipe(
          //tap(_ => this.log(`deleted hero id=${id}`)),
          catchError(this.handleError<T>(`delete ${typeof item}`)) // to imporve and add to others!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      );
  }

  add(item: T): Observable<T> {
    //   this.set_id(-1);
      return this.http.post<T>(this.url, item, this.httpOptions).pipe(
          //tap((newHero: Hero) => this.log(`added hero w/ id=${newHero.id}`)),
          catchError(this.handleError<T>(`add ${typeof item}`))
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