function score( dice ) {
    let greed = 0;
    let t1 = 0; let t2 = 0; let t3 = 0; let t4 = 0; let t5 = 0; let t6 = 0;
    for (let i=0; i < dice.length; i++) {
      if (dice[i] === 1) {
        greed += 100;
        t1 += 1;
      } else if (dice[i] === 2) {
        t2 += 1;
      } else if (dice[i] === 3) {
        t3 += 1;
      } else if (dice[i] === 4) {
        t4 += 1;
      } else if (dice[i] === 5) {
        greed += 50;
        t5 += 1;
      } else if (dice[i] === 6) {
        t6 += 1;
      }
    }
    if (t1 >= 3) {
      greed += 700; 
    }
    if (t2 >= 3) {
      greed += 200;
    } 
    if (t3 >= 3) {
      greed += 300;
    } 
    if (t4 >= 3) {
      greed += 400;
    } 
    if (t5 >= 3) {
      greed += 350;
    } 
    if (t6 >= 3) {
      greed += 600;
    } 
    return greed;
  }
  /*
  Greed is a dice game played with five six-sided dice. Your mission, should you choose to accept it, is to score a throw according to these rules. You will always be given an array with five six-sided dice values.

 Three 1's => 1000 points
 Three 6's =>  600 points
 Three 5's =>  500 points
 Three 4's =>  400 points
 Three 3's =>  300 points
 Three 2's =>  200 points
 One   1   =>  100 points
 One   5   =>   50 point
A single die can only be counted once in each roll. For example, a given "5" can only count as part of a triplet (contributing to the 500 points) or as a single 50 points, but not both in the same roll.

Example scoring

 Throw       Score
 ---------   ------------------
 5 1 3 4 1   250:  50 (for the 5) + 2 * 100 (for the 1s)
 1 1 1 3 1   1100: 1000 (for three 1s) + 100 (for the other 1)
 2 4 4 5 4   450:  400 (for three 4s) + 50 (for the 5)
Note: your solution must not modify the input array.
  */