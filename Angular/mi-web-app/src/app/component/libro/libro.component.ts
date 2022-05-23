import { Component, Input, OnInit, EventEmitter,Output } from '@angular/core';
import { LibrosService } from 'src/app/services/libros.service';

@Component({
  selector: 'app-libro',
  templateUrl: './libro.component.html',
  styleUrls: ['./libro.component.css'],
})
export class LibroComponent implements OnInit {
  constructor(private librosService: LibrosService) {}

  ngOnInit(): void {}

  //Recibir parametros en el Hijo
  @Input() tituloLibro!: string;

  //Enviar parametros al padre
  @Output() libroClicked = new EventEmitter();

  onClicked () {
    this.librosService.eliminarLibro(this.tituloLibro);
  }
}
