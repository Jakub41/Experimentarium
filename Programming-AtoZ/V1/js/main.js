console.log("Start");

var textfield;
var output;

function setup() {
    
    noCanvas();
    textfield = createInput("your name");

    textfield.changed(newText);
    textfield.input(newTyping);

    output = select("#output");
}

function newTyping(){
    output.html(textfield.value());
    //createP(textfield.value());
}

function newText(){
    createP(textfield.value());
}