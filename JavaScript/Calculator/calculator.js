/*jslint browser: true*/
/*global $, jQuery*/

$(document).ready(function () {
    // Stores the inputs from the user to calculate later
    var inputs = [""], totalString, operators1 = ["/", "*", "-", "+"];

    var operators2 = ["."], nums = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

    function getValue(input){
        
    }
    
    function update() {
        totalString = inputs.join("");
        $("#steps").html(totalString);
    }
    
    function getTotal(){
        
    }
});
