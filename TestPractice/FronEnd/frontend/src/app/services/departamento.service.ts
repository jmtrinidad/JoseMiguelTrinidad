import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
 

@Injectable({
  providedIn: 'root'
})
export class DepartamentoService {

  constructor(private _httpClient: HttpClient) 
  {}

  api_url: string = 'http://localhost:56923';

  getDepartamentos(): Observable<any> {
    return this._httpClient.get<any>(`${this.api_url}/api/Departamentos`)
  }
}
