// let validParantheses = (str) => {
//   let map = [];
//   for (let i = 0; i < str.length; i++) {

//     if (str[i] == "[" || str[i] == "{" || str[i] == "(") {
//       map.push(str[i]);
//     }

//     if (str[i] == "]") {
//       if (map[map.length-1] == "[") {
//         map.pop();
//       } else return false;
//     } else if (str[i] == "}") {
//       if (map[map.length-1] == "{") {
//         map.pop();
//       } else return false;
//     } else if (str[i] == ")") {
//       if (map[map.length-1] == "(") {
//         map.pop();
//       } else return false;
//     }
//   }

//   return map.length == 0;
// };

// console.log(validParantheses("(){}{{]}"));

let isValid = (s) => {
  let stack = new Array();
  for(const i in s){
    console.log(s[i]);
    
      if(i == '{' || i == '[' || i == '('){
         stack.push(i); 
         continue;
      }
      if(i == '}'){
          if(!(stack.at(-1) == '{'))
              return false;
          stack.pop();
      }
        if(i == ')'){
          if(!(stack.at(-1) == '('))
              return false;
          stack.pop();
      }
        if(i == ']'){
          if(!(stack.at(-1) == '['))
              return false;
          stack.pop();
      }
  }
  return stack.length == 0;
}

let arr= "[(])"
console.log(isValid(arr));
