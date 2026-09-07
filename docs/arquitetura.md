## O caminho de uma requisição

```mermaid
sequenceDiagram
    participant N as Navegador do paciente
    participant D as Servidor DNS
    participant S as Servidor da Clínica Vida+
    N->D: clinicavidamais.com.br?
    D-->N: 200.0.113.42
    N->S: conexão TCP e TLS na porta 443
    N->S: GET /consultas/agendar
    S-->N: 200 OK, HTML da agenda
[13:20, 9/7/2026] Otavio Junior: Servidor:  Unknown
Address:  fe80::1

Não é resposta autoritativa:
Nome:    github.com
Address:  4.228.31.158
[13:21, 9/7/2026] Otavio Junior: 1ª Requisição: text_defaults_md.css | Status: 200 | Tipo: stylesheet
 2ª Requisição: text_direction.mojom-webui.js | Status: 200 | Tipo: script
 3ª Requisição: tile_source.mojom-webui.js | Status: 200 | Tipo: script
 4ª Requisição: time.mojom-converters.js | Status: 200 | Tipo: script
[13:21, 9/7/2026] Otavio Junior: Justificativa do HTTPS
O formulário de agendamento da Clínica Vida+ precisa de HTTPS para garantir a segurança dos dados dos pacientes. Informações sensíveis como CPF, dados de contato e histórico médico precisam trafegar criptografadas por um túnel seguro.
