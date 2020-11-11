import { Injectable } from '@angular/core';

import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})

export interface IGenericService{
  getAll(): Observable<any[]>
  get(id: number): Observable<any>
  update(item: any): Observable<any>
  delete(item: any): Observable<any>
  add(item: any): Observable<any>
}

export class GenericService implements IGenericService{
  
  private url: string; // URL to web api

  httpOptions = {
      headers: new HttpHeaders(
        {
            'Content-Type': 'application/json',
            'tk': "token_must_go_here",
            'id': "any_id"
        })
  };

  constructor(
      _url: string,
      private http: HttpClient
  )
  {
      this.url = _url;
  }

  set_token(token: string)
  {
        this.httpOptions.headers.set("tk",token);
  } 

  set_id(id: any)
  {
    id = typeof id === 'number' ? id.toString() : id;     // it can only be a number or a string
    this.httpOptions.headers.set("id", id);
  }

  getAll(): Observable<any[]> 
  {
      this.set_id(-1);
      return this.http.get<any[]>(this.url).pipe(
          //tap(_ => this.log('fetched heroes')),
          catchError(this.handleError<any[]>('getAll', []))
      );
  }

  get(item: any): Observable<any>
  {
      const url = `${this.url}/1`; //`${this.url}/${id}`;
      this.set_id(item.id);
      return this.http.get<any>(url).pipe(
          //tap(_ => this.log(`fetched hero id=${id}`)),
          catchError(this.handleError<any>(`get id=${item.id}`))
      );
  }

  update(item: any): Observable<any>
  {
      const url = `${this.url}/1`; //`${this.url}/${id}`;
      this.set_id(-1);
      return this.http.put(url, item, this.httpOptions).pipe(
          //tap(_ => this.log(`updated hero id=${hero.id}`)),
          catchError(this.handleError<any>(`update ${typeof item}`))
      );
  }

  delete(item: any): Observable<any>{
      //const url = `${this.url}/${id}`;
      this.set_id(item.id);
      return this.http.delete<any>(this.url, this.httpOptions).pipe(
          //tap(_ => this.log(`deleted hero id=${id}`)),
          catchError(this.handleError<any>(`delete ${typeof item}`)) // to imporve and add to others!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
      );
  }

  add(item: any): Observable<any> {
      this.set_id(-1);
      return this.http.post<any>(this.url, item, this.httpOptions).pipe(
          //tap((newHero: Hero) => this.log(`added hero w/ id=${newHero.id}`)),
          catchError(this.handleError<any>(`add ${typeof item}`))
      );
    }

  /**
 * Handle Http operation that failed.
 * Let the app continue.
 * @param operation - name of the operation that failed
 * @param result - optional value to return as the observable result
 */
  handleError<T>(operation = 'operation', result?: T) {
      return (error: any): Observable<T> => {

          // TODO: send the error to remote logging infrastructure
          console.error(error); // log to console instead

          // TODO: better job of transforming error for user consumption
          //this.log(`${operation} failed: ${error.message}`);

          // Let the app keep running by returning an empty result.
          return of(result as T);
      };
  }
}