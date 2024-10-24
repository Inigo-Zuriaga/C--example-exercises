﻿@*
    For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
*@
@{
}

<style>

    /*      Tipos de selectores para estilos css
         https://www.w3schools.com/cssref/css_selectors.asp
         Clases, ID, Elementos, Atributos, Pseudo-clases, Pseudo-elementos
         ======  ==
     */

    /* Clase */
    /*
        * Estilo para un div personalizado.
        * - width: Ancho del div.
        * - height: Altura del div.
        * - margin: Margen alrededor del div.
        * - padding: Relleno dentro del div.
        * - color: Color del texto dentro del div.
        * - display: Muestra el div como un bloque en línea.
        */
    .myDiv {
        width: 200px;
        height: 200px;
        margin: 20px 10px; /* 20px arriba y abajo, 10px a los lados */
        padding: 20px;
        color: white;
        display: inline-block;
    }

    /* ID */
    /*
                         * Estilo para un div con fondo rojo.
                         * - background-color: Color de fondo rojo.
                         */
    #red {
        background-color: red;
    }
    /*
                         * Estilo para un div con fondo verde.
                         * - background-color: Color de fondo verde.
                         */
    #green {
        background-color: green;
    }

</style>

<div class="myDiv" id="red">Hello Bootstrap</div>
<div class="myDiv" id="green">Hello Bootstrap</div>
<hr />
<div class="myDiv bg-secondary">Hello Bootstrap</div>
<div class="myDiv bg-primary">Hello Bootstrap</div>
<div class="myDiv bg-success">Hello Bootstrap</div>
<div class="myDiv bg-danger">Hello Bootstrap</div>
<div class="myDiv bg-warning">Hello Bootstrap</div>
<hr>
<div class="myDiv bg-info">Hello Bootstrap</div>
<div class="myDiv bg-light text-dark">Hello Bootstrap</div>
<div class="myDiv bg-dark">Hello Bootstrap</div>
<div class="myDiv bg-white text-dark">Hello Bootstrap</div>
<div class="myDiv bg-transparent text-dark">Hello Bootstrap</div>