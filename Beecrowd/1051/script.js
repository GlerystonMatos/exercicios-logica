// https://judge.beecrowd.com/pt/problems/view/1051

const fs = require("fs");

function calcularImpostoDeRenda(salario) {
    let imposto = 0;
    const faixas = [
        { limite: 4500, taxa: 0.28 },
        { limite: 3000, taxa: 0.18 },
        { limite: 2000, taxa: 0.08 }
    ];

    for (const faixa of faixas) {
        if (salario > faixa.limite) {
            imposto += (salario - faixa.limite) * faixa.taxa;
            salario = faixa.limite;
        }
    }
    
    return imposto === 0 ? "Isento" : `R$ ${imposto.toFixed(2)}`;
}

const salario = parseFloat(fs.readFileSync("/dev/stdin", "utf8").trim());
console.log(calcularImpostoDeRenda(salario));