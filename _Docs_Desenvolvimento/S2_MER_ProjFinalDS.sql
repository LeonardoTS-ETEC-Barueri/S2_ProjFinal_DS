CREATE DATABASE db_listacontatos_ds_fims2;

USE db_listacontatos_ds_fims2;

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

DESCRIBE tbl_contato;
DESCRIBE tbl_compromisso;
DESCRIBE tbl_convidado_compromisso;

SELECT * FROM tbl_contato;
SELECT * FROM tbl_compromisso;
SELECT * FROM tbl_convidado_compromisso;