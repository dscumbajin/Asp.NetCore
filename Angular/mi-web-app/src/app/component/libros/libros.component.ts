import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-libros',
  templateUrl: './libros.component.html',
  styleUrls: ['./libros.component.css'],
})
export class LibrosComponent implements OnInit {
  constructor() {}

  libros = ['Matematicas', 'Algoritmos', 'Programación .Net'];
  ngOnInit(): void {
  }
}
