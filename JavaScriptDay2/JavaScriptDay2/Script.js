'use strict';

var teams = [
    'Astros',
    'Dynamo',
    'Texans',
    'Rockets'
]

teams.forEach(function (team) {
    console.log(team);
});

var products = new Array();

products.push({ name: 'Cheese', price: 7.00 });
products.push({ name: 'Milk', price: 3.00 });
products.push({ name: 'Wine', price: 97.30 });
products.push({ name: 'Grapes', price: 4.00 });

var filteredProducts = products.filter(function (product) {
    return product.price > 5.00;
});

filteredProducts.forEach(function (product) {
    console.log(product);
});

var cart = [
  { name: 'Milk', price: 23.44 },
  { name: 'Cheese', price: 3.50 },
  { name: 'Peanuts', price: 8.00 },
  { name: 'Wine', price: 7.50 }

];

var total = cart.reduce(function (previous, current, index, arr) {
    return { price: previous.price + current.price };

});

console.log(total.price);



var sentence = 'The cat and the cat ate the rat';


var obj = {
    countUnique: function(sentence) {
        var wordArray = sentence.toLowerCase().split(' ');
        var wordSet = new Set(wordArray);
        return wordSet.size
    }
}

console.log(obj.countUnique(sentence));

var listOfNumbers = new Set([
    17, 2, 3, 78, 4, 5, 12
])

var counter = {
    _count: 0,
    addCount: function () {
        this._count++;
        console.log(this._count);
    }
};

//window.setInterval(counter.addCount.bind(counter), 1000);

var module = (function () {
    function _calculatePrice(price) {
        return price + _calculateTax(price);
    }

    function _calculateTax(price) {
        return price * .08;
    }
    return {
        calculatePrice: _calculatePrice
    };
})();

var result = module.calculatePrice(43.54);
console.log(result);
