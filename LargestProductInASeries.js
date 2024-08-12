function greatestProduct(input) {
    let product = 0;
    for (let i=0; i<input.length-4; i++) {
      let mult = Number(input[i])*Number(input[i+1])*Number(input[i+2])*Number(input[i+3])*Number(input[i+4]);
      if (mult > product) {
        product = mult;
      }
    }
    return product;
  }

  /*
DESCRIPTION:

Complete the greatestProduct method so that it'll find the greatest product of five consecutive digits in the given string of digits.

For example: the greatest product of five consecutive digits in the string "123834539327238239583" is 3240.

The input string always has more than five digits.

Adapted from Project Euler.
  */