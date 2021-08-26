import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'PrimerProyecto';
  edadUno : number = 0;
  edadDos : number = 0;
  promedio : number = 0;
  suma : number = 0;

  calcular()
  {
    this.promedio = (this.edadUno + this.edadDos) / 2;
    this.suma = this.edadUno + this.edadDos;
  }

  limpiar()
  {
    this.edadUno = 0;
    this.edadDos = 0;
    this.promedio = 0;
    this.suma = 0;
  }
}
