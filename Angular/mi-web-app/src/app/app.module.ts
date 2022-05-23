import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserComponent } from './component/user/user.component';
import { LibrosComponent } from './component/libros/libros.component';
import { LibroComponent } from './component/libro/libro.component';
import { LibrosService } from './services/libros.service';
import { InicioComponent } from './component/inicio/inicio.component';

@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
    LibrosComponent,
    LibroComponent,
    InicioComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [
    LibrosService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
