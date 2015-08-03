'use strict';
//var firstNumber = 12;
//var secondNumber = 3;

//var result = addNumbers(firstNumber, secondNumber);
//console.assert(result == 15, "result is not 15");

//function addNumbers(val1, val2) {
//    var oops = val1 + val2;
//    return oops;
//}

//console.log(parseInt('20.33'));
//console.log(parseFloat('20.33'));
//console.log(parseFloat('20.33 is too much'));


//var input = prompt("Enter your favorite number")
//var value = parseFloat(input)

//if (isNaN(value) == true ) {
//    alert("input was invalid");
//}
//else {
//    alert(value * 100);
//}




//function calculateTax(price, taxRate) {
//    if (taxRate == undefined) {
//        return price + (price * .08)
//    }
//    else {
//        return price + (price * taxRate);
//    }
    
//}

//console.assert(calculateTax(20) === 21.6);
//console.assert(calculateTax(20, .05) === 21);
//console.assert(calculateTax(20, 0) === 20);



function addIntegers(value1, value2) {
    if (!typeof value1 == "number" || !typeof value2 =="number" ) {
        alert("this is strings")
    }
    else if (parseInt(value1) != value1  || parseInt(value2) != value2) {
        alert("Please enter a number")
    }
    else {
        return value1 + value2;
    }
    
}

var customer = {
    _firstName: "",
    _lastName: "",
    
    get firstName(){
       return this._firstName
    },
    get lastName() {
       return this._lastName
    },
    set lastName(value2) {
        if (value2 == false) {
            throw new Error("Please enter a valid name")
        }
        this._lastName = value2;
    
    },
    set firstName(value1){
        if(value1 == false){
            throw new Error("Please enter a vaild name")
        }
        this._firstName = value1;
    }
    
};


function dumpAll(object) {
    alert(JSON.stringify(object));
}

var customer = {
    required_firstName: "",
    required_lastName: "",

}


function addRequiredValidation(obj) {
    var newObj = {};
    for (var index in obj) {
        if (index.indexOf('required_') != -1) {
            (function (index) {
                Object.defineProperty(newObj, index.substring(9), {
                    get: function() {

                    }
                    set: function(value){

                    }
                })
            })(index);
        }
        
    }
    return newObj;
}





