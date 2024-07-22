-- database: :memory:
-- SQLite
DROP TABLE IF EXISTS students;
DROP TABLE IF EXISTS enrol;
DROP TABLE IF EXISTS course;

CREATE TABLE students(
student_id integer PRIMARY KEY,
student_name text
);

CREATE TABLE course(
course_name text PRIMARY KEY
);

CREATE TABLE enrol(
student_id integer,
course_name text,
foreign key (student_id) references students(student_id),
foreign key (course_name) references course_name(course_name)
);

select * from students;
insert into students(student_id, student_name) values (1, "Simba");
insert into students(student_id, student_name) values (2, "Pinocchio");
insert into students(student_id, student_name) values (3, "lago");

insert into course(course_name) values ("woodwork");
insert into course(course_name) values ("programming");

insert into enrol(student_id, course_name) values (1, "woodwork");
insert into enrol(student_id, course_name) values (2, "woodwork");

-- This inner join will only show students who are enroled. How do we show students
-- in our system, that are not enroled??
select * from students
inner join enrol on (students.student_id = enrol.student_id)
inner join course on (enrol.course_name = course.course_name);

select * from students;
select * from enrol;

-- an Inner join on two tables...
select * from students
inner join enrol on (students.student_id = enrol.student_id);

-- an Outer (left) join on two tables...
select * from students
left join enrol on (students.student_id = enrol.student_id);

select students.student_id as "students.student_id", 
students.student_name as "students.student_name", 
enrol.student_id as "enrol.student_id", 
enrol.course_name as "enrol.course_name" from students
left join enrol on (students.student_id = enrol.student_id);

-- an Outer (left) join on two tables...
select * from students
left join enrol on (students.student_id = enrol.student_id)
where enrol.course_name is null;


-- using just the students and enrol table, show only results
-- where there is a null on enrol.course_name
select students.student_name, enrol.course_name from students
left join enrol on (students.student_id = enrol.student_id)
where enrol.course_name is null;

-- Add two new courses
insert into course(course_name) values ("Cooking");
insert into course(course_name) values ("Welding");
select * from course;

-- show all courses and enrolments
select * from course
left join enrol on (course.course_name = enrol.course_name);

select * from course
left join enrol on (course.course_name = enrol.course_name)
where enrol.student_id is null;

-- add a new student, and enrol them in welding. Rerun the query to show courses with no enrolments
insert into students(student_id, student_name) values (4, "Sauron");
insert into enrol(student_id, course_name) values (4, "Welding");

-- show all courses and enrolments
select students.student_name, course.course_name from students
join enrol on (students.student_id = enrol.student_id)
join course on (enrol.course_name = course.course_name);

select * from course
left join enrol on (course.course_name = enrol.course_name)
where enrol.student_id is null;
