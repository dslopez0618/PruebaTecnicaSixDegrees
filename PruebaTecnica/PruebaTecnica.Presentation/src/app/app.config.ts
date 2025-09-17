import { ApplicationConfig } from '@angular/core';
import { provideHttpClient } from '@angular/common/http';
import { provideRouter } from '@angular/router';

/**
 * Configuración de la aplicación Angular.
 * @desc Define los proveedores y enrutamiento para la aplicación standalone.
 */
export const appConfig: ApplicationConfig = {
  providers: [
    provideHttpClient(), // Provee HttpClient para toda la aplicación
    provideRouter([]) // Configura enrutamiento (vacío por ahora)
  ]
};