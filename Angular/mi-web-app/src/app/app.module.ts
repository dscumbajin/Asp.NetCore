import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { UserComponent } from './component/user/user.component';
import { LibrosComponent } from './component/libros/libros.component';
import { LibroComponent } from './component/libro/libro.component';

@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
    LibrosComponent,
    LibroComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
