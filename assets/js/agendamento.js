console.log('agendamento.js carregado');

const form = document.querySelector('#form-agendamento');
const cpf = document.querySelector('#cpf');
const resumo = document.querySelector('#resumo-agendamento');
const avisoCpf = document.querySelector('#aviso-cpf');
const data = document.querySelector('#data');
const avisoData = document.querySelector('#aviso-data');
const horario = document.querySelector('#horario');
const avisoHorario = document.querySelector('#aviso-horario');
const email = document.querySelector('#email');
const avisoEmail = document.querySelector('#aviso-email');
const telefone = document.querySelector('#telefone');
const avisoTelefone = document.querySelector('#aviso-telefone');
const nome = document.querySelector('#nome');
const avisoNome = document.querySelector('#aviso-nome');
const nascimento = document.querySelector('#nascimento');
const avisoNascimento = document.querySelector('#aviso-nascimento');

form.addEventListener('submit', (event) => {
    event.preventDefault();
    console.log('submit interceptado');
    let formularioValido = true;

    if (!validarNome(nome.value)) {
        avisoNome.textContent = 'Digite o nome completo.';
        formularioValido = false;
    } else {    
        avisoNome.textContent = '';
}

    if (!validarNascimento(nascimento.value)) {
        avisoNascimento.textContent = 'A data de nascimento não pode ser futura.';
        formularioValido = false;
    } else {
        avisoNascimento.textContent = '';
}

    if (!validarCPF(cpf.value)) {
        avisoCpf.textContent = 'O CPF precisa ter 11 dígitos.';
        formularioValido = false;
    } else {
        avisoCpf.textContent = '';
}
   
    if (!validarEmail(email.value)) {
        avisoEmail.textContent = 'Digite um e-mail válido.';
        formularioValido = false;
    } else {
        avisoEmail.textContent = '';
}

    if (!validarTelefone(telefone.value)) {
        avisoTelefone.textContent = 'Digite um telefone válido com DDD.';
        formularioValido = false;
    } else {
        avisoTelefone.textContent = '';
}

    if (!validarData(data.value)) {
        avisoData.textContent = 'A data da consulta não pode ser anterior a hoje.';
        formularioValido = false;
    } else {
        avisoData.textContent = '';
}

    if (!horario.value) {
        avisoHorario.textContent = 'Selecione um horário para a consulta.';
        formularioValido = false;
    } else if (!validarHorario(horario.value)) {
        avisoHorario.textContent = 'A Clínica Vida+ atende das 07h às 19h.';
        formularioValido = false;
    } else {
        avisoHorario.textContent = '';
}

    if (formularioValido) {
        alert('Consulta agendada com sucesso!');

        resumo.textContent = `${nome.value} agendou ${document.querySelector('#especialidade').value} em ${data.value} às ${horario.value}.`;
    resumo.classList.remove('oculto');

        form.reset();
        avisoTelefone.textContent = '';
        avisoNome.textContent = '';
        avisoCpf.textContent = '';
        avisoEmail.textContent = '';
        avisoData.textContent = '';
        avisoHorario.textContent = '';
        avisoNascimento.textContent = '';
}

});

function validarCPF(cpf) {
    const somenteNumeros = cpf.replace(/\D/g, '');

    if (somenteNumeros.length !== 11) {
        return false;
    }

    return true;
}

function validarData(data) {
    const hoje = new Date();
    const dataSelecionada = new Date(data + 'T00:00:00');

    hoje.setHours(0, 0, 0, 0);

    return dataSelecionada > hoje;
}

function validarHorario(horario) {
    if (!horario) {
        return false;
    }

    const hora = Number(horario.split(':')[0]);

    console.log('HORÁRIO TESTADO:', horario);
    console.log('HORA CONVERTIDA:', hora);

    return hora >= 7 && hora < 19;
}

function validarEmail(email) {
    return email.includes('@') && email.includes('.');
}

function validarTelefone(telefone) {
    const somenteNumeros = telefone.replace(/\D/g, '');

    if (somenteNumeros.length < 10 || somenteNumeros.length > 11) {
        return false;
    }

    return true;
}

function validarNome(nome) {
    const nomeLimpo = nome.trim();

    if (nomeLimpo.length < 5 || !nomeLimpo.includes(' ')) {
        return false;
    }

    return true;
}

function validarNascimento(nascimento) {
    const hoje = new Date();
    const dataNascimento = new Date(nascimento + 'T00:00:00');

    return dataNascimento <= hoje;
}

const botao = document.querySelector('#ver-observacoes');
const bloco = document.querySelector('#bloco-observacoes');

botao.addEventListener('click', () => {
    bloco.classList.toggle('oculto');
});