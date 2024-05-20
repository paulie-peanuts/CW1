function longest(s1, s2) {
    let result = '';
    for (let i=0; i<s1.length; i++) {
      if (!result.includes(s1[i])) {
        result += s1[i];
      }
    }
    for (let i=0; i<s2.length; i++) {
      if (!result.includes(s2[i])) {
        result += s2[i];
      }
    }
    result = result.split('').sort().join('');
    return result;
  }
  /*
Take 2 strings s1 and s2 including only letters from a to z. Return a new sorted string, the longest possible, containing distinct letters - each taken only once - coming from s1 or s2.


  */