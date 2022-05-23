import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class LibrosService {

  constructor() {}

  librosSubject = new Subject();
  private libros = ['Matematicas', 'Algoritmos 2', 'Programación .Net'];

  agregarLibro(libro: string) {
    this.libros.push(libro);
    this.librosSubject.next(libro);
  }

  obtenerLibros() {
    return [...this.libros];
  }

  eliminarLibro(libro: string){
    this.libros = this.libros.filter((p) => p != libro);
    this.librosSubject.next(libro);
  }
}
