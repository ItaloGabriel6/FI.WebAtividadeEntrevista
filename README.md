# FI.WebAtividadeEntrevista

📝 **Visão Geral**  
Este projeto consiste em um sistema de manutenção dos dados básicos de clientes, com foco na implementação de um campo de CPF validado e formatado, além de um modal para o gerenciamento de beneficiários.

---

### ✅ Funcionalidades

#### 📌 Cadastro de Cliente

- **Campo CPF**:
  - Adição do campo **CPF** na tela de cadastro/alteração de clientes.
  - O CPF é **obrigatório** e deve ser **único** (não permite duplicação no banco de dados).
  - O CPF segue o formato **999.999.999-99** e é validado pelo algoritmo de verificação do dígito verificador do CPF.
  - Caso o CPF já exista no banco, o sistema exibirá uma mensagem de erro.

#### 📌 Modal de Beneficiários

- **Beneficiários**: Na tela de cadastro/alteração de clientes, foi adicionado um botão para **inclusão, edição e exclusão de beneficiários**.
- Cada **beneficiário** possui os campos: **Nome** e **CPF**.
- O sistema realiza a validação de CPF para garantir que o mesmo não seja duplicado para o **mesmo cliente**.
- O beneficiário é **salvo na base de dados** quando o botão "Salvar" for acionado na tela de "Cadastrar Cliente".


### 🗃️ Banco de Dados

- **Tabela CLIENTES**:
  - Foi adicionado o campo **CPF** na tabela `CLIENTES`.
  
- **Tabela BENEFICIARIOS**:
  - Foi criada a tabela `BENEFICIARIOS` para armazenar os dados dos beneficiários com os campos:
    - `ID`
    - `CPF`
    - `NOME`
    - `IDCLIENTE` (chave estrangeira para a tabela `CLIENTES`)

📦 O banco de dados é armazenado localmente na pasta `App_Data`, com o arquivo `BancoDeDados.mdf` e o respectivo arquivo de log.

---

### 🧪 Cenários de Teste

#### 📌 Cadastro de Cliente

| Cenário                     | Entrada                     | Resultado Esperado                      |
|----------------------------|-----------------------------|-----------------------------------------|
| CPF Válido e Inexistente   | `123.456.789-09`            | Cliente cadastrado com sucesso          |
| CPF Inválido               | `123.456.789-00`            | Mensagem de erro de CPF inválido        |
| CPF já existente           | CPF duplicado               | Mensagem: "CPF já cadastrado"           |

#### 📌 Cadastro de Beneficiário

| Cenário                            | Entrada                             | Resultado Esperado                         |
|-----------------------------------|-------------------------------------|--------------------------------------------|
| CPF Válido e único                | Nome e CPF válidos                  | Beneficiário adicionado com sucesso        |
| CPF Inválido                      | CPF com dígito verificador errado  | Mensagem de erro de CPF inválido           |
| CPF duplicado para o mesmo cliente| Mesmo CPF já incluído              | Mensagem de erro de CPF já cadastrado      |
| Editar beneficiário               | Modificar dados existentes         | Beneficiário atualizado corretamente       |
| Excluir beneficiário              | Ação de excluir no grid            | Beneficiário removido da lista             |

---

### 📂 Estrutura do Banco de Dados

O banco de dados foi estruturado da seguinte maneira:

- **Tabela CLIENTES**:
  - `ID` (PK)
  - `NOME`
  - `SOBRENOME`
  - `CPF` (novo campo adicionado)
  - Outros campos como `TELEFONE`, `EMAIL`, etc.

- **Tabela BENEFICIARIOS**:
  - `ID` (PK)
  - `CPF` (referência ao CPF do beneficiário)
  - `NOME` (nome do beneficiário)
  - `IDCLIENTE` (chave estrangeira para a tabela `CLIENTES`)


### 🚀 Como Executar

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/ItaloGabriel6/FI.WebAtividadeEntrevista.git
