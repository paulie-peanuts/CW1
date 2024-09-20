function pigIt(str){
    array = [];
    extra = [];
    array = str.split(' ');
    if (array[array.length-1] === "!" || array[array.length-1] === "?") {
      extra.push(array[array.length-1]);
      array.pop();
    }
    array = array.map(x => x.slice(1)+x[0]+'ay').join(' ');
    if (extra.length !== 0) {
      array += ` ${extra[0]}`;
    }
    return array;
  }
  /*
  Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.

Examples

pig_it('Pig latin is cool') # igPay atinlay siay oolcay
pig_it('Hello world !')     # elloHay orldway !
*/