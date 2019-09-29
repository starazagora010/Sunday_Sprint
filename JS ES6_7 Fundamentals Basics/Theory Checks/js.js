var s  = function(some){
    'use strict';
    for (let index = 0; index < 5; index++) {
        if (index > 0 ) {
            const element = index;
            console.log(element);
        }
    }
    const element = 11;
    console.log(element);
}

s(-1);