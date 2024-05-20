function moveZeros(arr) {
    let arrOrder = [];
    let arrZero = [];
    for (let i=0; i < arr.length; i++) {
      if (arr[i] === 0) {
        arrZero.push(arr[i]);
      } else {
        arrOrder.push(arr[i]);
      }
    }
    return arrOrder.concat(arrZero);
  }
  /*
Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
  */