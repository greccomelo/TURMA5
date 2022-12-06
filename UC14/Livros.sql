CREATE DATABASE Chapter;

USE Chapter;

CREATE TABLE Livros (
	ID INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR(150) NOT NULL,
	QuantidadePaginas INT,
	Disponivel BIT
)

INSERT INTO Livros VALUES ('Titulo A', 120, 1);
INSERT INTO Livros VALUES ('Titulo B', 220, 0);
INSERT INTO Livros VALUES ('Titulo C', 410, 1);

SELECT * FROM Livros