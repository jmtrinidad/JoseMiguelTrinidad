import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Usuario } from '../models/usuario';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  constructor(private _httpClient:HttpClient) { }

  api_url: string = 'http://localhost:56923';

  registrar(usuario:Usuario): Observable<boolean> {
    return this._httpClient.post<boolean>(`${this.api_url}/api/Usuarios`, usuario)
  }
}
