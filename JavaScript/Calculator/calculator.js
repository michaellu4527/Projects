/*jslint browser: true*/
/*global $, jQuery*/

function clearScreen(val) {
    "use strict";
    document.getElementById("display").value = val;
}

function numInput(val) {
    "use strict";
    document.getElementById("display").value += val;
}

function evaluate() {
    "use strict";
    try {
        clearScreen(eval(document.getElementById("display").value));
    } catch (e) {
        clearScreen('Error');
    }
}
