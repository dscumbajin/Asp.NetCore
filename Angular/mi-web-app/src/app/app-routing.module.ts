import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { InicioComponent } from './component/inicio/inicio.component';
import { LibrosComponent } from './component/libros/libros.component';

const routes: Routes = [
  { path: '', component: InicioComponent },
  { path: 'libros', component: LibrosComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
