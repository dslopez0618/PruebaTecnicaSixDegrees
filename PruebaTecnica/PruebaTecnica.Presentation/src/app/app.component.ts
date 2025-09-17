import { CommonModule } from "@angular/common";
import { HttpClient } from '@angular/common/http';
import { Component } from "@angular/core";
import { catchError, throwError } from 'rxjs';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent{
  usuarios: { id: number; nombre: string }[]=[];
  errorMessage: string = '';
  loading: boolean = false;

  private apiUrl = 'http://localhost:5026/api/Usuarios';

  constructor(private http: HttpClient){}

  buscarUsuarios(): void {
    this.errorMessage = '';
    this.loading = true;
    this.http.get<{ id:number; nombre: string}[]>(this.apiUrl)
      .pipe(
        catchError(error => {
          this.errorMessage = `Error al consultar usuarios: ${error.statusText || 'Verifique la conexion o el servidor.'}`;
          console.error('Error HTTP:', error);
          this.loading = false;
          return throwError(() => new Error('Peticion Fallida'));
        })
      )
      .subscribe(
        (data) => {
          this.usuarios = data;
          this.loading = false;
        },
        (error) => {
          console.error('Error en suscripcion:', error);
          this.loading = false;
        }
      );
  }
}


