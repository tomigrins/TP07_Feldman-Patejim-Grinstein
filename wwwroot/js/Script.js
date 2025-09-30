function inicializarJuego(palabra){
    let cantLetras = palabra.length;
    for (let i = 0; i < cantLetras; i++)
    palabraAAdivinar = ["_"]
    document.getElementById("palabra").innerHTML = palabraAAdivinar;
    palabraSeparada = palabra.split("");
    for (let letra of palabra){
        palabraSeparada.push(letra)
    }
}
function insertarLetra(letra){
    if (letrasUsadas.includes(letra)) {
        alert("Ya usaste esa letra.");
        return;
    }
    if (palabraSeparada.includes(letra)) {
        intentos++;
        for (let i = 0; i < palabraSeparada.length; i++) {
            if (palabraSeparada[i] === letra) {
                letrasAdivinadas[i] = letra;
            }
            if (!letrasAdivinadas.includes("_")) {
                alert("¡Ganaste en " + intentos +  "intentos!");
            }
            else {
                intentos++;
                alert("Esa letra no está en la palabra.");
            }    
        }
    }
        document.getElementById("palabra").innerHTML = palabraAAdivinar;
        document.getElementById("intentos").innerHTML = "Intentos: " + intentos;
    // let letraEncontrada = -1
    // letraEncontrada = palabraSeparada.find(palabraSeparada => palabraSeparada === letra);
    // if(letraEncontrada = -1)
    //     alert("Esa letra no esta en la palabra.");
    //     letrasUsadas.push(letra);
    // else{
    //     alert("Esa se encuentra entre las letras de la palabra.");
    //     intentos++;
    //     letrasUsadas.push(letra);
    //     }
}
function arriesgarPalabra(){
    const palabraArriesgada = document.getElementById('palabra');
    if (palabraArriesgada === palabra){
        alert("¡Ganaste en " + intentos +  "intentos!");
        document.getElementById('intentos') = intentos;
        document.getElementById('FINAL').style.display = "block";
    }
    else{
        alert("Esa no es");
        intentos++;
    
    }
}