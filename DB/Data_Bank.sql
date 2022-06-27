--EVENTO--
INSERT INTO EVENTO VALUES ('Lectura Infatil by Alberto Bonilla','ASSETS/IMG/EVENT/EventoLecturaInfantil.jpg',CONVERT(DATETIME,'2022-07-25 13:00:00'),CONVERT(DATETIME,'2022-07-25 15:00:00'),50,9);
INSERT INTO EVENTO VALUES ('Competencia de Programacioon ICPC','ASSETS/IMG/EVENT/EventoICPC.png',CONVERT(DATETIME,'2022-07-06 14:00:00'),CONVERT(DATETIME,'2022-07-06 16:30:00'),35,17);
INSERT INTO EVENTO VALUES ('Conferencia de Becas Internacionales','ASSETS/IMG/EVENT/EventoAuditorio.jpg',CONVERT(DATETIME,'2022-07-26 09:00:00'),CONVERT(DATETIME,'2022-07-26 11:00:00'),100,2);
INSERT INTO EVENTO VALUES ('Torneo Gaming de PC','ASSETS/IMG/EVENT/EventoPcGaming.jpg',CONVERT(DATETIME,'2022-07-08 12:00:00'),CONVERT(DATETIME,'2022-07-08 15:00:00'),85,4);

--COLECCION--
INSERT INTO COLECCION VALUES ('Saga de Harry Potter','Libros','Fantasia',5);
INSERT INTO COLECCION VALUES ('Curso de C++','Videos','Educativo',25);
INSERT INTO COLECCION VALUES ('ESPN','Revistas','Deportivos',5);
INSERT INTO COLECCION VALUES ('Mi Chero','Periodico','Informativo',19);

--MATERIAL--
INSERT INTO MATERIAL VALUES ('Harry Potter y la piedra filosofal','ASSETS/IMG/MATERIAL/HarryPotter.jpg','J. K. Rowling','Español','Bloomsbury Salamandra Scholastic',CONVERT(DATE,'1997-06-26'),1,1);
INSERT INTO MATERIAL VALUES ('ESPN Deportes n°51','ASSETS/IMG/MATERIAL/espnNEYMAR.jpg','ESPN','Español','René Tovar',CONVERT(DATE,'2019-03-21'),1,3);
INSERT INTO MATERIAL VALUES ('Primer programa c++','ASSETS/IMG/MATERIAL/cursoC++.jpg','Programacion ATS','Español','YouTube',CONVERT(DATE,'2016-03-15'),2,2);
INSERT INTO MATERIAL VALUES ('Periodico Mi Chero','ASSETS/IMG/MATERIAL/MiChero10-05-2014.jpg','Mi Chero SV','Español','Mi Chero SV',CONVERT(DATE,'2014-05-10'),1,4);

--PALABRAS--
INSERT INTO PALABRAS VALUES ('filosofal',1);
INSERT INTO PALABRAS VALUES ('filo',1);
INSERT INTO PALABRAS VALUES ('rayo',1);
INSERT INTO PALABRAS VALUES ('champions',2);
INSERT INTO PALABRAS VALUES ('neymar',2);
INSERT INTO PALABRAS VALUES ('futbol',2);
INSERT INTO PALABRAS VALUES ('c++',3);
INSERT INTO PALABRAS VALUES ('curso',3);
INSERT INTO PALABRAS VALUES ('programacion',3);
INSERT INTO PALABRAS VALUES ('chero',4);
INSERT INTO PALABRAS VALUES ('noticias',4);
INSERT INTO PALABRAS VALUES ('clima',4);

--USUARIO--
INSERT INTO USUARIO VALUES ('Henry Menjivar','Planes de Renderos,Col. Miramar','UES','7566-5498','henrymenjivar01@gmail.com','ASSETS/IMG/USER/henry.jpg','Estudiante');
INSERT INTO USUARIO VALUES ('Diego Torres','Ciudad Marsella, San Juan Opico','UES','6530-4756','dj90001@gmail.com','ASSETS/IMG/USER/diego.png','Estudiante');
INSERT INTO USUARIO VALUES ('Diego Orellana','Jardines de la Sabana, Ciudad Merliot','UCA','7950-5050','misterdio101@yahoo.com','ASSETS/IMG/USER/dio.jpg','Estudiante');
INSERT INTO USUARIO VALUES ('Jefferson Vasquez','San Salvador, Soyapango','UES','7253-3000','SrAdn2001@outlook.com','ASSETS/IMG/USER/jefferson.jpg','Estudiante');