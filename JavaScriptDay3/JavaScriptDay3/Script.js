'use strict';

//class Product{
//    constructor(name, price){
//        this._name = name;
//        this._price = price;
//    }
//    calculateTax(){
//        return this._price * .08;
//    }
//}

//var product1 = new Product('Milk', 2.33);
//var product2 = new Product('Cheese', 4.33);

//class Car extends Product{
//    constructor(name, price, model){
//        super(name, price);
//        this._model = model;
//    }

//    static listModels(){
//        return new Set(['Mini S', 'Tesla S', 'BMW 328i'])
//    }
//}

//var car1 = new Car('Mini Cooper', 12000.00, 'Mini S')

//var models = Car.listModels();

function Product(name, price) {
    this.name = name;
    this.price = price;
    var that = this;

    function _calculateTax() {
        return that._price * .08
    }

    this.calculateTotalPrice = function () {
        return this._price + _calculateTax();
    }
}

Product.prototype = (function () {
    function _calculateTax(price) {
        return price * .08
    }

    function _calculateTotalPrice() {
        return this.price + _calculateTax(this.price)
    }

    return {
        calculateTotalPrice: _calculateTotalPrice
    }

})()


var product1 = new Product('Milk', 2.33);
