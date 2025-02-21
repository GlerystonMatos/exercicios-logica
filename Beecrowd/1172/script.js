// https://judge.beecrowd.com/pt/problems/view/1172

const fs = require("fs");

function processarVetor(X) {
    for (let i = 0; i < X.length; i++) {
        if (X[i] <= 0) {
            X[i] = 1;
        }
    }
    return X;
}

const X = fs.readFileSync("/dev/stdin", "utf8")
    .trim()
    .split("\n")
    .map(Number);

const resultado = processarVetor(X);

for (let i = 0; i < resultado.length; i++) {
    console.log(`X[${i}] = ${resultado[i]}`);
}
