	$(document).ready(function(){
        $.getJSON("api/Contact", function (result) {
	        console.info(result);
	    });
    });

    function searchContact(){
        $.ajax({
            type: "GET",
            dataType: "json",
            url: "api/Contact/" + $('#searchID').val(),
            success: function (result) {
                console.info(result);
            }
        });
    }

    function addContact(){
        var newContact = {
            "Id" : 0,
            "FirstName" : "Tony",
            "LastName" : "Stark"
        }

        $.ajax({
            type: "POST",
            dataType: "json",
            url: "api/Contact",
            data: newContact,
            success: function (result) {
                console.info(result);
            }
        });
    }
    	   
    function putContact(){
        var changedContact = {
            "FirstName" : "John"
        }
        
        $.ajax({
            type: "PUT",
            dataType: "json",
            url: "api/Contact/0",
            data: changedContact,
            success: function (result) {
                console.info(result);
            }
        });
    }

    function deleteContact(){
        
        $.ajax({
            type: "DELETE",
            dataType: "json",
            url: "api/Contact/0",
            success: function (result) {
                console.info(result);
            }
        });
    }              