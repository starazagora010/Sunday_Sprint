function solution(params) {
    "use strict"
    let numArr = params[1].split(" ").map(x => Number(x));
    let resultMaxSubseq = numArr[0];
    let currentMaxSubseq = 0;
    let lastAddedNum = 0;
    let len = Number(params[0]);
    for (let i = 0; i < len; i++) {
        lastAddedNum = numArr[i];
        // 0 vs 1
        if (lastAddedNum >= numArr[i+1]) {
            currentMaxSubseq += lastAddedNum;
        }
        else{
            //
            if(currentMaxSubseq > resultMaxSubseq){
                resultMaxSubseq = currentMaxSubseq;
                currentMaxSubseq = 0;
            }//
        }
    }

    return resultMaxSubseq;
}
solution(["11","10 2 3 -6 -1 2 -1 6 4 -8 8"]);