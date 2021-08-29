-----------------------------EJECUTAR PRIMERO-----------------------------
create database Sistema_Web_de_Control_de_Personal1

use Sistema_Web_de_Control_de_Personal1
-----------------------------EJECUTAR SEGUNDO-----------------------------
--EMPLEADO
create table empleado(
emp_no int primary key not null,
fecha_nacimiento date not null,
nombre varchar(14) not null,
paterno varchar(16) not null,
materno varchar(16),
genero bit not null, ------0 mujeres, 1 hombres------
fecha_contrato date not null
)

--DEPARTAMENTO
create table departamento(
depto_no char(4) primary key,
depto_nombre varchar(40),
)
-----------------------------EJECUTAR TERCERO-----------------------------
--DEPTO_EMP
create table depto_emp(
departamento_depto_no CHAR(4) not null,
empleado_emp_no int not null,
fecha_ini DATE primary key not null,
fecha_fin DATE,
constraint fk_emp_no foreign key (empleado_emp_no) references empleado(emp_no),
constraint fk_depto_no foreign key (departamento_depto_no) references departamento(depto_no)
)

-- JEFE
create table depto_jefe(
empleado_emp_no int not null,
departamento_depto_no char(4) not null,
fecha_ini DATE not null,
fecha_fin DATE,
constraint fk_depto_jefe_e foreign key (empleado_emp_no) references empleado(emp_no),
constraint fk_depto_jefe_d foreign key (departamento_depto_no) references departamento(depto_no)
)

--CARGO
create table cargo(
empleado_emp_no int not null,
cargo varchar(50) primary key not null,
fecha_ini DATE not null,
fecha_fin DATE,
constraint fk_cargo_empleado foreign key (empleado_emp_no) references empleado(emp_no)
)

--SUELDOS
create table sueldos(
emp_no int not null,
desde_fecha DATE primary key not null,
sueldo int not null,
hasta_fecha DATE,
constraint fk_sueldo_empleado foreign key (emp_no) references empleado(emp_no)
)
-----------------------------EJECUTAR CUARTO-----------------------------

--Insertanto Empleados--
insert into empleado values(1,'1995-10-31','Lucia','Duran','Flores',0,'2021-05-20');
insert into empleado values(2,'1980-10-13','Edgar','Duran','Quisbert',1,'2021-01-15');
insert into empleado values(3,'1997-07-31','Mayra','Duran','Flores',0,'2021-03-01');
insert into empleado values(4,'1990-02-17','Ariel','Cortez','Davila',1,'2021-02-15');
insert into empleado values(5,'1992-12-20','Abigail','Arias','Espinoza',0,'2020-02-20');
insert into empleado values(6,'1991-09-15','Martin','Ajacopa','Laime',1,'2020-01-15');
insert into empleado values(7,'1988-08-20','Ruth','Zabaleta','Cespedes',0,'2021-04-22');
insert into empleado values(8,'1985-08-10','Armando','Paredes','Rojas',1,'2020-08-10');
insert into empleado values(9,'1970-03-13','Luis','Tito','Tejerina',1,'2020-07-15');
insert into empleado values(10,'1985-06-06','Rene','Gando','Pasto',1,'2021-01-05');

--Insertando Departamento--
insert into departamento values (1,'Rectorado');
insert into departamento values (2,'Gerencia');
insert into departamento values (3,'Secretaria');
insert into departamento values (4,'Sistemas');
insert into departamento values (5,'Tecnica');
insert into departamento values (6,'Legal');
insert into departamento values (7,'Marketing');
insert into departamento values (8,'Operaciones y Logistica');
insert into departamento values (9,'Ventas');
insert into departamento values (10,'Finanzas');

-----------------------------EJECUTAR QUINTO-----------------------------+-----------------------------
--Insertando Cargo--
insert into cargo values (1,'Rector','2021-08-29','2021-10-20');
insert into cargo values (2,'Vicerrector','2021-08-29','2021-11-20');
insert into cargo values (3,'SecretarioGeneral','2021-08-29','2021-11-20');
insert into cargo values (4,'Fiscal','2021-08-29','2021-11-20');
insert into cargo values (5,'Decanos','2021-08-29','2021-11-20');
insert into cargo values (6,'DirectorElectronica','2021-08-29','2021-11-20');
insert into cargo values (7,'DirectorSistemasInformaticos','2021-08-29','2021-11-20');
insert into cargo values (8,'DirectorTelecomunicaciones','2021-08-29','2021-11-20');
insert into cargo values (9,'Docente','2021-08-29','2021-11-20');
insert into cargo values (10,'Finanzas','2021-08-29','2021-11-20');

----------------------------Ejecutar Sexto ----------------------------------------------------------
--Insertando Sueldo--
insert into sueldos values (1,'2021-08-29',42000,'2021-12-24');
insert into sueldos values (2,'2021-08-29',40000,'2021-12-24');
insert into sueldos values (3,'2021-08-29',32000,'2021-12-24');
insert into sueldos values (4,'2021-08-29',30000,'2021-12-24');
insert into sueldos values (5,'2021-08-29',22000,'2021-12-24');
insert into sueldos values (6,'2021-08-29',20000,'2021-12-24');
insert into sueldos values (7,'2021-08-29',12000,'2021-12-24');
insert into sueldos values (8,'2021-08-29',11000,'2021-12-24');
insert into sueldos values (9,'2021-08-29',10000,'2021-12-24');
insert into sueldos values (10,'2021-08-29',9000,'2021-12-24');
----------------------------Ejecutar Septimo ----------------------------------------------------------
--Insertando depto_emp--
 insert into depto_emp values (1,1,'2021-08-29','2021-12-24');
 insert into depto_emp values (2,2,'2021-08-29','2021-12-24');
 insert into depto_emp values (3,3,'2021-08-29','2021-12-24');
 insert into depto_emp values (4,4,'2021-08-29','2021-12-24');
 insert into depto_emp values (5,5,'2021-08-29','2021-12-24');
 insert into depto_emp values (6,6,'2021-08-29','2021-12-24');
 insert into depto_emp values (7,7,'2021-08-29','2021-12-24');
 insert into depto_emp values (8,8,'2021-08-29','2021-12-24');
 insert into depto_emp values (9,9,'2021-08-29','2021-12-24');
 insert into depto_emp values (10,10,'2021-08-29','2021-12-24');

 ----------------------------Ejecutar Octavo ----------------------------------------------------------
--Insertando depto_Jefe--
insert into depto_jefe values (1,1,'2021-08-29','2021-12-24');
insert into depto_jefe values (2,2,'2021-08-29','2021-12-24');
insert into depto_jefe values (3,3,'2021-08-29','2021-12-24');
insert into depto_jefe values (4,4,'2021-08-29','2021-12-24');
insert into depto_jefe values (5,5,'2021-08-29','2021-12-24');
insert into depto_jefe values (5,6,'2021-08-29','2021-12-24');
insert into depto_jefe values (5,7,'2021-08-29','2021-12-24');
insert into depto_jefe values (5,8,'2021-08-29','2021-12-24');
insert into depto_jefe values (5,9,'2021-08-29','2021-12-24');
insert into depto_jefe values (5,10,'2021-08-29','2021-12-24');