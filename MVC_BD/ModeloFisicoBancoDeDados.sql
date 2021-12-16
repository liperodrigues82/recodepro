
CREATE TABLE Clientes (
Id INT PRIMARY KEY,
Nome VARCHAR(40),
Rg VARCHAR(14),
Email VARCHAR(35),
Telefone VARCHAR(14)
)

CREATE TABLE Destinos (
Id Int PRIMARY KEY,
Origem VARCHAR(30),
Destino VARCHAR(30),
DataEmbarque DATE,
HorarioEmbarque TIME,
ClienteId INT,
FOREIGN KEY(ClienteId) REFERENCES Clientes (Id)
)

