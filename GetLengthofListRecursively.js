function lenR(x) {
    if (Array.isArray(x)) {
      if (x.length === 0) {
        return 0;
      } else {
        x.pop();
        return 1 + lenR(x);
      }
    } else {
      if (x.length === 0) {
        return 0;
      } else {
        x=x.slice(1);
        return 1 + lenR(x);
      }
    }
  }
  /*
DESCRIPTION:

Write funcion lenR which returns the length of a given list. Try no to cheat and provide recursive solution.

  */