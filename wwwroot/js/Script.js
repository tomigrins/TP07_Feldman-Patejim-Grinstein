let palabraAAdivinar;
let palabraSeparada;
let letrasAdivinadas;
let letrasUsadas;
let intentos = 0;
let palabra;

function inicializarJuego(palabraRecibida) {
    palabra = palabraRecibida.toUpperCase();
    let cantLetras = palabra.length;

    palabraAAdivinar = Array(cantLetras).fill("_");
    letrasAdivinadas = Array(cantLetras).fill("_");
    palabraSeparada = palabra.split("");
    letrasUsadas = [];
    intentos = 0;

    actualizarPantalla();
}

function actualizarPantalla() {
    document.getElementById("palabra").innerHTML = letrasAdivinadas.join(" ");
    document.getElementById("intentos").innerHTML = "Intentos: " + intentos;
}

function insertarLetra(letra) {
    letra = letra.toUpperCase();

    if (letrasUsadas.includes(letra)) {
        alert("Ya usaste esa letra.");
        return;
    }

    letrasUsadas.push(letra);

    if (palabraSeparada.includes(letra)) {
        for (let i = 0; i < palabraSeparada.length; i++) {
            if (palabraSeparada[i] === letra) {
                letrasAdivinadas[i] = letra;
            }
        }

        if (!letrasAdivinadas.includes("_")) {
            alert("¡Ganaste en " + intentos + " intentos!");
            document.getElementById("hiddenIntentos").value = intentos;
            document.getElementById("FINAL").style.display = "block";
        }
    } else {
        intentos++;
        if (intentos > 9) {
            alert("¡Perdiste! La palabra era: " + palabra);
            document.getElementById("PERDISTE").style.display = "block";
        }
    }

    actualizarPantalla();
}

function arriesgarPalabra() {
    const palabraArriesgada = document.getElementById('inputPalabra').value.toUpperCase();

    if (palabraArriesgada === palabra) {
        alert("¡Ganaste en " + intentos + " intentos!");
        document.getElementById("hiddenIntentos").value = intentos;
        document.getElementById("FINAL").style.display = "block";
    } else {
        alert("Esa no es");
        intentos++;
        if (intentos > 9) {
            alert("¡Perdiste! La palabra era: " + palabra);
            document.getElementById("PERDISTE").style.display = "block";
        }
    }

    actualizarPantalla();
}
