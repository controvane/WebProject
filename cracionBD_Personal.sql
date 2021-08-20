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
genero bit not null,
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
-----------------------------FIN EJECUCION-----------------------------
