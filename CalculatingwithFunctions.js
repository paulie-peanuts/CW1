function plus(operand) {
    o = String(operand)
    return o.splice(0,2)
}
function two(operand) {
    // return operand.splice(2)
    return 2 + operand
}
// console.log(two(plus(4)))
string = 2+String(4)
console.log(string)

function dirReduc(arr){
    let newArr = [];
    let oldArr = [...arr];
    for (let i=0; i<arr.length; i++) {
      if ((arr[i] === "NORTH" && arr[i+1] === "SOUTH") || (arr[i] === "SOUTH" && arr[i+1] === "NORTH") || (arr[i] === "WEST" && arr[i+1] === "EAST") || (arr[i] === "EAST" && arr[i+1] === "WEST")) {
      arr.splice(i,2);
      } else {
        newArr.push(arr[i]);
  //       newArr.push(arr[i+1]);
      }
      
    }
  //   console.log(newArr);
  //   console.log(oldArr);
    if (newArr.length === oldArr.length) {
      console.log(newArr.length)
      return newArr
    } else {
      dirReduc(newArr);
    }
  }
  // console.log("hey")