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
insert into departamento values (1,'Finanzas');
insert into departamento values (2,'Gerencia');
insert into departamento values (3,'Limpieza');
insert into departamento values (4,'Sistemas');
insert into departamento values (5,'Tecnica');
insert into departamento values (6,'Legal');
insert into departamento values (7,'Marketing');
insert into departamento values (8,'Operaciones y Logistica');
insert into departamento values (9,'Ventas');
insert into departamento values (10,'Cocina');

-----------------------------EJECUTAR QUINTO-----------------------------+-----------------------------

