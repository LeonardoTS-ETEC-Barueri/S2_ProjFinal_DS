# DROP DATABASE db_listacontatos_ds_fims2;

CREATE DATABASE db_listacontatos_ds_fims2;

USE db_listacontatos_ds_fims2;

# Criação das Tabelas.

CREATE TABLE tbl_contato (
	nome_contato VARCHAR(100) UNIQUE NOT NULL,
    telefone VARCHAR(20) UNIQUE NOT NULL,
    email VARCHAR(200),
    empresa VARCHAR(100),
    cargo VARCHAR(100),
    PRIMARY KEY (nome_contato)
);

CREATE TABLE tbl_compromisso (
	cod_compromisso INT UNSIGNED UNIQUE NOT NULL AUTO_INCREMENT,
    assunto VARCHAR(50) NOT NULL,
    data_compromisso DATE NOT NULL,
    horario TIME NOT NULL,
    descricao VARCHAR(255),
    estaAtivo TINYINT(1) NOT NULL DEFAULT 1,
    PRIMARY KEY (cod_compromisso)
);

CREATE TABLE tbl_convidado_compromisso (
	nome_contato VARCHAR(100),
    cod_compromisso INT UNSIGNED NOT NULL,
    estaConfirmado TINYINT(1) NOT NULL DEFAULT 1,
    FOREIGN KEY (nome_contato) REFERENCES tbl_contato(nome_contato) ON DELETE SET NULL,
    FOREIGN KEY (cod_compromisso) REFERENCES tbl_compromisso(cod_compromisso) ON DELETE CASCADE
);

# Descrição da Estrutura das Tabelas #

DESCRIBE tbl_contato;
DESCRIBE tbl_compromisso;
DESCRIBE tbl_convidado_compromisso;

# Selects gerais #

SELECT * FROM tbl_contato;
SELECT * FROM tbl_compromisso;
SELECT * FROM tbl_convidado_compromisso;

# Inserção dos valores iniciais #

INSERT INTO tbl_contato
	(nome_contato, telefone, email, empresa, cargo)
VALUES 
	('Alfino Testeiro', '011916886312', 'thegreatalfino@testeiro.com', 'QA Services', 'Quality Assurance Tester'),
	('Bell Testeira', '011964203471', 'littlebell@testeira.com', 'QA Services', 'Quality Assurance Tester');
    
# UPDATE tbl_contato
# SET cargo = 'Quality Assurance Tester'
# WHERE nome_contato = 'Alfino Testeiro'
# LIMIT 1;
    
INSERT INTO tbl_compromisso
	(cod_compromisso, assunto, data_compromisso, horario, descricao, estaAtivo)
VALUES
	(DEFAULT, 'Primeiro Teste', '2020-11-30', '20:00:00', 'Primeiro teste de qualidade do software "Lista Contatos"', DEFAULT),
    (DEFAULT, 'Segundo Teste', '2020-12-03', '07:00:00', 'Segundo teste de qualidade do software "Lista Contatos"', DEFAULT);
    
INSERT INTO tbl_convidado_compromisso
	(nome_contato, cod_compromisso, estaConfirmado)
VALUES
	('Alfino Testeiro', '1', DEFAULT),
    ('Bell Testeira', '1', DEFAULT),
    ('Alfino Testeiro', '2', DEFAULT);
    
# SET FOREIGN_KEY_CHECKS = 0;
# TRUNCATE TABLE tbl_contato;
# TRUNCATE TABLE tbl_compromisso;
# TRUNCATE TABLE tbl_convidado_compromisso;
# SET FOREIGN_KEY_CHECKS = 1;

# Template das Queries para as funcionalidades do Sistema / Testes #

DELETE FROM tbl_compromisso
WHERE cod_compromisso = 1
LIMIT 1;

DELETE FROM tbl_contato
WHERE nome_contato = 'Bell Testeira'
LIMIT 1;

DELETE FROM tbl_convidado_compromisso
WHERE nome_contato = ' ' OR nome_contato IS NULL AND cod_compromisso = 2;

UPDATE tbl_compromisso
SET assunto = 'Terceiro Teste',
	data_compromisso = '2020-12-04',
    horario = '19:00:00',
    descricao = 'Teste final de alteração nos detalhes de um compromisso',
    estaAtivo = true
WHERE cod_compromisso = 1;

DELETE FROM tbl_convidado_compromisso
WHERE nome_contato = 'Alfino Testeiro' AND cod_compromisso = '1';

SELECT nome_contato, estaConfirmado FROM tbl_convidado_compromisso
WHERE cod_compromisso = 1;