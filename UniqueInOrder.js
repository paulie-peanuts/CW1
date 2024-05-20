var uniqueInOrder=function(iterable){
    if (Array.isArray(iterable)) {
      for (let i=iterable.length; i>0; i--) {
        if (iterable[i] === iterable[i+1]) {
          iterable.splice(i,1);
        }
      }
    } else {
      let array = [];
      array.unshift(iterable[iterable.length-1]);
      for (let i=iterable.length; i>0; i--) {
        if (iterable[i] !== iterable[i+1]) {
          array.unshift(iterable[i]);
        }
      }
      if (array[array.length-1] === array[array.length-2]) {
        array.pop();
      }
      if (iterable[0] !== array [0]) {
        array.unshift(iterable[0]);
      }
      return array;
    }
    return iterable;
  }
  /*
Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.
  */