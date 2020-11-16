CREATE TABLE TB_ARTIGO (
ART_ID INT PRIMARY KEY IDENTITY(1,1),
ART_CATEGORIA INT NOT NULL,
ART_CONTEUDO VARCHAR(MAX) NOT NULL
)

CREATE TABLE TB_RELATOS_CLIENTES (
REL_ID INT PRIMARY KEY IDENTITY(1,1),
REL_NOME_ARQUIVO VARCHAR(MAX) NOT NULL,
REL_CAMINHO_ARQUIVO VARCHAR(MAX) NOT NULL,
REL_DEPOIMENTO VARCHAR(MAX) NOT NULL,
REL_STATUS BIT NOT NULL DEFAULT 0 
)

CREATE TABLE TB_CADASTRO_IMAGENS (
IMG_ID INT PRIMARY KEY IDENTITY(1,1),
IMG_NOME_ARQUIVO VARCHAR(MAX) NOT NULL,
IMG_CAMINHO_ARQUIVO VARCHAR(MAX) NOT NULL,
IMG_TITULO VARCHAR(MAX) NOT NULL,
IMG_LEGENDA VARCHAR(MAX) NOT NULL,
IMG_LINK VARCHAR(MAX) NOT NULL,
IMG_STATUS BIT NOT NULL DEFAULT 0 
)