// @flow

let another: number = require('./another.js')
let ignored = require('./ignored.js')
let string = require('magic-string')
let a: string = require('./lib/a.js')

function add(num1: number, num2: number): number {
  return num1 + num2;
}
var x: number = add(3, 4);
console.log('hi', x)
