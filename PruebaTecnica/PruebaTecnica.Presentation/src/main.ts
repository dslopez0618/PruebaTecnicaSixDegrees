import { bootstrapApplication } from '@angular/platform-browser';
import { AppComponent } from './app/app.component';
import { appConfig } from './app/app.config';

/**
 * Punto de entrada principal de la aplicación.
 * @desc Inicializa la aplicación con el componente standalone AppComponent y su configuración.
 */
bootstrapApplication(AppComponent, appConfig)
  .catch(err => console.error(err));