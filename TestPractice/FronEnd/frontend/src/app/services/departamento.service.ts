import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Departamento } from '../models/departamento';

@Injectable({
  providedIn: 'root'
})
export class DepartamentoService {

  constructor(private _httpClient: HttpClient) 
  {}

  api_url: string = 'http://localhost:56923';

  getDepartamentos(): Observable<Departamento> {
    return this._httpClient.get<Departamento>(`${this.api_url}/api/Departamentos`)
  }
}
