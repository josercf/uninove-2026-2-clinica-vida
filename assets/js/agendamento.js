
console.log('agendamento.js carregado');

const form = document.querySelector('#form-agendamento');

if (form) {
    const cpf = document.querySelector('#cpf');
    const avisoCpf = document.querySelector('#aviso-cpf');
    const nome = document.querySelector('#nome');
    const especialidade = document.querySelector('#especialidade');
    const data = document.querySelector('#data');
    const horario = document.querySelector('#horario');
    const avisoData = document.querySelector('#aviso-data');
    const avisoHorario = document.querySelector('#aviso-horario');
    const resumo = document.querySelector('#resumo-agendamento');

    function validarCpf(campo, aviso) {
        const digitos = campo.value.replace(/\D/g, '');
        const valido = digitos.length === 11;

        aviso.textContent = valido
            ? ''
            : 'O CPF precisa ter 11 dígitos.';

        campo.classList.toggle('campo-invalido', !valido);
        return valido;
    }

    function validarData(campo, aviso) {
        const hoje = new Date();
        hoje.setHours(0, 0, 0, 0);

        const escolhida = new Date(`${campo.value}T00:00:00`);
        const valida = campo.value !== '' && escolhida > hoje;

        aviso.textContent = valida
            ? ''
            : 'A consulta precisa ser em uma data futura.';

        campo.classList.toggle('campo-invalido', !valida);
        return valida;
    }

    function validarHorario(campo, aviso) {
        const partes = campo.value.split(':');
        const minutos = Number(partes[0]) * 60 + Number(partes[1]);

        const valido = campo.value !== ''
            && minutos >= 420
            && minutos < 1140;

        aviso.textContent = valido
            ? ''
            : 'A Clínica Vida+ atende das 07h às 19h.';

        campo.classList.toggle('campo-invalido', !valido);
        return valido;
    }

    form.addEventListener('submit', (event) => {
        event.preventDefault();
        resumo.classList.add('oculto');

        const resultados = [
            validarCpf(cpf, avisoCpf),
            validarData(data, avisoData),
            validarHorario(horario, avisoHorario)
        ];

        if (resultados.includes(false)) {
            return;
        }

        resumo.textContent =
            `${nome.value} agendou ${especialidade.value} ` +
            `em ${data.value} às ${horario.value}.`;

        resumo.classList.remove('oculto');
    });
}

const busca = document.querySelector('#busca-especialidade');
const especialidades = document.querySelectorAll(
    '.lista-especialidades li'
);
const mensagemVazia = document.querySelector(
    '#nenhuma-especialidade'
);

if (busca) {
    busca.addEventListener('input', () => {
        const termo = busca.value.trim().toLowerCase();
        let encontradas = 0;

        especialidades.forEach((item) => {
            const corresponde = item.textContent
                .toLowerCase()
                .includes(termo);

            item.classList.toggle('oculto', !corresponde);

            if (corresponde) {
                encontradas++;
            }
        });

        if (mensagemVazia) {
            mensagemVazia.classList.toggle(
                'oculto',
                encontradas > 0
            );
        }
    });
}
