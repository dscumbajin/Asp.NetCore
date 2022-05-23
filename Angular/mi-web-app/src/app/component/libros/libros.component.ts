import { Component, OnInit, OnDestroy } from '@angular/core';
import { NgForm } from '@angular/forms';
import { LibrosService } from 'src/app/services/libros.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-libros',
  templateUrl: './libros.component.html',
  styleUrls: ['./libros.component.css'],
})
export class LibrosComponent implements OnInit, OnDestroy {
  libros = [''];
  constructor(private librosService: LibrosService) {}

  private libroSubscription!: Subscription;

  ngOnInit(): void {
    this.libros = this.librosService.obtenerLibros();
    this.libroSubscription = this.librosService.librosSubject.subscribe(() => {
      this.libros = this.librosService.obtenerLibros();
    });
  }

  ngOnDestroy(): void {
    this.libroSubscription.unsubscribe();
  }

  //Eliminar el elemento y actualizar la lista
  eliminarLibro(libro: string) {
   // this.librosService.eliminarLibro(libro);
  }

  guardarLibro(f: NgForm) {
    if (f.valid) {
      this.librosService.agregarLibro(f.value.nombreLibro);
    }
  }
}
