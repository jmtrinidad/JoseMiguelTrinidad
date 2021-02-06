import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Usuario } from '../models/usuario';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  constructor(private _httpClient: HttpClient) { }

  api_url: string = 'http://localhost:56923';

  registrar(usuario: any): Observable<any> {
    console.log(usuario);
    return this._httpClient.post<any>(`${this.api_url}/api/Usuarios`, {
      nombres: usuario.nombres,
      apellidos: usuario.apellidos,
      genero: usuario.genero,
      cedula: usuario.cedula,
      fecha_Nacimiento: usuario.fecha_Nacimiento,
      departamentoId: usuario.departamentoId,
      cargo: usuario.cargo,
      supervisor_Inmediato: usuario.supervisor_Inmediato
    })
  }
}
