function rot13(message){
    let orig = 'abcdefghijklmnopqrstuvwxyz';
    let origCap = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ';
    let fix = 'nopqrstuvwxyzabcdefghijklm';
    let fixCap = 'NOPQRSTUVWXYZABCDEFGHIJKLM';
    let result = '';
    for (let i=0; i<message.length; i++) {
      if (orig.includes(message[i])) {
        result += fix[orig.indexOf(message[i])];
      } else if (origCap.includes(message[i])) {
        result += fixCap[origCap.indexOf(message[i])];
      } else {
        result += message[i];
      }
    }
    return result;
  }
  /*
  ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. ROT13 is an example of the Caesar cipher.

Create a function that takes a string and returns the string ciphered with Rot13. If there are numbers or special characters included in the string, they should be returned as they are. Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".
*/