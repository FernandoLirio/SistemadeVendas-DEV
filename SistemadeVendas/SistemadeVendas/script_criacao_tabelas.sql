-- Criação da tabela de usuários (clientes e admins)
CREATE TABLE usuario (
    id SERIAL PRIMARY KEY,
    nome TEXT NOT NULL,
    cpf_cnpj TEXT NOT NULL,
    senha TEXT NOT NULL,
    tipo TEXT NOT NULL CHECK (tipo IN ('cliente', 'admin')) -- controla permissões
);

-- Produtos disponíveis para venda
CREATE TABLE produto (
    id SERIAL PRIMARY KEY,
    descricao TEXT NOT NULL,
    preco_unitario NUMERIC(10, 2) NOT NULL
);

-- Vendas registradas
CREATE TABLE venda (
    id SERIAL PRIMARY KEY,
    cliente_id INTEGER NOT NULL REFERENCES usuario(id) ON DELETE CASCADE,
    data_venda TIMESTAMP NOT NULL DEFAULT NOW(),
    valor_total NUMERIC(10, 2) NOT NULL
);

-- Itens de cada venda
CREATE TABLE item_venda (
    id SERIAL PRIMARY KEY,
    venda_id INTEGER NOT NULL REFERENCES venda(id) ON DELETE CASCADE,
    produto_id INTEGER NOT NULL REFERENCES produto(id),
    quantidade INTEGER NOT NULL,
    valor NUMERIC(10, 2) NOT NULL -- total daquele item (preco_unitario * quantidade)
);
