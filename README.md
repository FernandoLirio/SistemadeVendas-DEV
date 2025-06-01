# SistemadeVendas-DEV
# Sistema de Vendas (.NET + PostgreSQL via ODBC)

## ✅ Objetivo Geral
Sistema de vendas com cadastro de produtos, registro de vendas, gerenciamento de itens vendidos e geração de relatórios por cliente. Utiliza PostgreSQL com acesso via ODBC.

---

## 🗃️ Estrutura de Banco de Dados (PostgreSQL)

### Tabela `usuario`
Armazena todos os usuários (clientes e administradores):

```sql
CREATE TABLE usuario (
    id SERIAL PRIMARY KEY,
    nome TEXT NOT NULL,
    cpf_cnpj TEXT NOT NULL,
    senha TEXT NOT NULL,
    tipo TEXT NOT NULL CHECK (tipo IN ('cliente', 'admin'))
);
#Tabela produto
CREATE TABLE produto (
    id SERIAL PRIMARY KEY,
    descricao TEXT NOT NULL,
    preco_unitario NUMERIC(10, 2) NOT NULL
);
#Tabela venda
CREATE TABLE venda (
    id SERIAL PRIMARY KEY,
    cliente_id INTEGER NOT NULL REFERENCES usuario(id),
    data_venda TIMESTAMP NOT NULL DEFAULT NOW(),
    valor_total NUMERIC(10, 2) NOT NULL
);
#Tabela item_venda
CREATE TABLE item_venda (
    id SERIAL PRIMARY KEY,
    venda_id INTEGER NOT NULL REFERENCES venda(id),
    produto_id INTEGER NOT NULL REFERENCES produto(id),
    quantidade INTEGER NOT NULL,
    valor NUMERIC(10, 2) NOT NULL
);
----------
##Funcionalidades Implementadas
Cadastro de Produtos
Inserção, edição e exclusão

Salvo no PostgreSQL via OdbcConnection

##Cadastro de Clientes
Clientes são registros na tabela usuario com tipo = 'cliente'

Tela de Venda
Lista de produtos, carrinho, seleção de quantidade

Finalização grava na tabela venda e item_venda
Validações
Quantidade deve ser > 0

Produto deve ser selecionado

Carrinho não pode estar vazio

 Melhorias Futuras (Extras)
Seleção de cliente com ComboBox

Exportação de relatório em PDF/TXT

Filtro de vendas por data

Soft delete via coluna ativo
