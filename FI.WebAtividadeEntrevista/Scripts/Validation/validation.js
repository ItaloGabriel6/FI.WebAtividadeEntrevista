function maskCPF(input) {
    let valor = input.replace(/\D/g, '');
    if (valor.length > 11) valor = valor.slice(0, 11);

    valor = valor.replace(/(\d{3})(\d)/, '$1.$2');
    valor = valor.replace(/(\d{3})(\d)/, '$1.$2');
    valor = valor.replace(/(\d{3})(\d{1,2})$/, '$1-$2');

    return valor;
}

function validateCPF(cpf) {
    cpf = cpf.replace(/\D/g, "");
    if (cpf.length !== 11 || /^(\d)\1{10}$/.test(cpf)) return false;

    const calcDigito = (tamanho) => {
        let soma = 0;
        for (let i = 0; i < tamanho; i++) {
            soma += parseInt(cpf[i]) * (tamanho + 1 - i);
        }
        let resto = (soma * 10) % 11;
        return resto === 10 ? 0 : resto;
    };

    return calcDigito(9) === parseInt(cpf[9]) && calcDigito(10) === parseInt(cpf[10]);
}