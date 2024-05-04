function distributionOf(golds) {
    let golds1 = Array.from(golds);
    let result = [0,0];
    function recursive(golds1) {
      if (golds1.length === 0) {
        return result;
      }
      if ((golds1.length % 2 === 0 && golds.length % 2 === 0) || (golds1.length % 2 !== 0 && golds.length % 2 !== 0)) {
        if (golds1[0] >= golds1[golds1.length-1]) {
          result[0] += golds1[0];
          golds1.shift();
          return recursive(golds1);
        } else {
          result[0] += golds1[golds1.length-1];
          golds1.pop();
          return recursive(golds1);
        }
      } else {
        if (golds1.length === 1) {
          result[1] += golds1[0];
          return result;
        }
        if (golds1[0] >= golds1[golds1.length-1]) {
          result[1] += golds1[0];
          golds1.shift();
          return recursive(golds1);
        } else {
          result[1] += golds1[golds1.length-1];
          golds1.pop();
          return recursive(golds1);
        }     
      }
    }
    recursive(golds1);
    return result;
  }
  /*
  Task

In the field, two beggars A and B found some gold at the same time. They all wanted the gold, and they decided to use simple rules to distribute gold:

They divided gold into n piles and be in line. 
The amount of each pile and the order of piles all are randomly.

They took turns to take away a pile of gold from the 
far left or the far right.

They always choose the bigger pile. That is to say, 
if the left is 1, the right is 2, then choose to take 2.

If the both sides are equal, take the left pile.
Given an integer array golds, and assume that A always takes first. Please calculate the final amount of gold obtained by A and B. returns a two-element array [amount of A, amount of B].

*/