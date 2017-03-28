$('#menu-toggle').click(function(e){
    e.preventDefault();
    $('#wrapper').toggleClass('menuDisplayed');
});

var x = myFunction(4,3);

function myFunction(a,b){
    return a*b;
}