import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Departamento } from 'src/app/models/departamento';
import { DepartamentoService } from 'src/app/services/departamento.service';
import { UsuarioService } from 'src/app/services/usuario.service';

@Component({
  selector: 'app-usuario',
  templateUrl: './usuario.component.html',
  styleUrls: ['./usuario.component.css']
})
export class UsuarioComponent implements OnInit {

  departamentos=[];
  usuarioForm: FormGroup;
  constructor(
    private _usuarioService:UsuarioService,
    private _departamentoService:DepartamentoService,
    private _formBuilder: FormBuilder) {

      this.usuarioForm=_formBuilder.group({
        nombres: [''],
        apellidos:['', Validators.required],
        genero:  ['', Validators.required],
        genero2:  ['', Validators.required],
        cedula:  ['', Validators.required],
        fecha_Nacimiento:  ['', Validators.required],
        departamentoId:  ['', Validators.required],
        cargo:  ['', Validators.required],
        supervisor_Inmediato:  ['', Validators.required], 
      });
     }
  ngOnInit(): void {
    this._departamentoService.getDepartamentos().subscribe(response =>{
      console.log(response);
    });
   
  }



     registrar(values){
       console.log(values);
     }

 

}