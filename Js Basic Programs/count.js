function countEvenOddZero(arr) {
    let evenCount = 0;
    let oddCount = 0;
    let zeroCount = 0;

    for (let num of arr) {
        if (num === 0) {
            zeroCount++;
        } else if (num % 2 === 0) {
            evenCount++;
        } else {
            oddCount++;
        }
    }

    return {
        evens: evenCount,
        odds: oddCount,
        zeros: zeroCount
    };
}

let numbers = [0, 1, 2, 3, 4, 5, 0, 6];
let result = countEvenOddZero(numbers);

console.log("Even numbers:", result.evens);
console.log("Odd numbers:", result.odds);
console.log("Zero numbers:", result.zeros);
