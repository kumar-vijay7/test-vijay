--It is a pre filter it do not work with aggregate function, group by clause should after where clause
select * from student 
where marks>=75

--having is a post filter it works with aggregate functions, group by clause should be used before having clause
select marks,count(Marks) as No_of_student from Student
group by marks
having sum(Marks)>=75