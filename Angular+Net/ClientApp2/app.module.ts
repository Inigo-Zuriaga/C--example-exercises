import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { SaludoComponent } from './saludo/saludo.component'; // Importa el componente

@NgModule({
    declarations: [
        AppComponent,
        SaludoComponent // Declara el componente aquí
    ],
    imports: [
        BrowserModule
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }