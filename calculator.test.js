// calculator.test.js
const calculate = require('./calculator');

test('adds 1 + 2 to equal 3', () => {
  expect(calculate('1', '2', 'add')).toBe(3);
});

test('subtracts 5 - 3 to equal 2', () => {
  expect(calculate('5', '3', 'subtract')).toBe(2);
});

test('multiplies 2 * 3 to equal 6', () => {
  expect(calculate('2', '3', 'multiply')).toBe(6);
});

test('divides 6 / 3 to equal 2', () => {
  expect(calculate('6', '3', 'divide')).toBe(2);
});

test('throws error when dividing by zero', () => {
  expect(() => calculate('6', '0', 'divide')).toThrow('Division by zero is not allowed.');
});

test('throws error when invalid operation is provided', () => {
  expect(() => calculate('6', '3', 'invalid')).toThrow('Invalid operation. Please enter add, subtract, multiply, or divide.');
});