"use strict"

let name = "Jake";

function makeUppercase(word) {
    return word.toUpperCase();
}

let template =
    `<h1>${makeUppercase("My Own Template")} by ${name}</h1> 
    <p>This is my simple template in ES6 Javascript</p>`;

document.getElementById('template').innerHTML = template;