// https://judge.beecrowd.com/pt/problems/view/1132

const fs = require("fs");

function somaNaoMultiplosDe13(x, y) {
    let soma = 0;
    const [menor, maior] = [Math.min(x, y), Math.max(x, y)];
    
    for (let i = menor; i <= maior; i++) {
        if (i % 13 !== 0) soma += i;
    }
    
    return soma;
}

const [x, y] = fs.readFileSync("/dev/stdin", "utf8").trim().split("\n").map(Number);
console.log(somaNaoMultiplosDe13(x, y));
