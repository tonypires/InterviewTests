/**
 *  Given the JS code below, what will the result be when run within the context of a browser window?
 */

var fullname = 'Steve Jobs';
var obj = {
   fullname: 'Bill Gates',
   prop: {
      fullname: 'Elon Musk',
      getFullname: function() {
         return this.fullname;
      }
   }
};

// First output
console.log(obj.prop.getFullname());

// Second output
var test = obj.prop.getFullname;
console.log(test());