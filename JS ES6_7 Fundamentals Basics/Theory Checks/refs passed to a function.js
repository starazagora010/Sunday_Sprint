function SwapDogs(thedogge){
    'use strict';
    thedogge.Name = "Pesho";
    thedogge = {
        Type: "DOG",
        Name: "TheKing",
        Age: 100
    };
    console.log(thedogge);
}

let d1 = {
     Type: "DOG",
     Name: "JJ",
     Age: 1
};

console.log(d1);
SwapDogs(d1);
console.log(`Swapped:`);
console.log(d1);


