SELECT *
FROM ExternalCandidate

SELECT ccandidateCode, vFirstName, vLastNAme, siTestScore
FROM externalcandidate

SELECT ccandidateCode, vFirstName + vLastNAme, siTestScore
FROM externalcandidate

SELECT ccandidateCode, 'Name' = vFirstName + space(1) + vLastNAme, siTestScore
FROM externalcandidate

SELECT ccandidateCode, CandidateName = vFirstName + space(1) + vLastNAme, siTestScore
FROM externalcandidate

SELECT ccandidateCode, 'Candidate Name' = vFirstName + space(1) + vLastNAme, siTestScore
FROM externalcandidate

SELECT ccandidateCode, vFirstName + space(1) + vLastNAme 'Candidate Name', siTestScore
FROM externalcandidate

-- Fetch candidate by specific code
SELECT ccandidateCode, vFirstName, vLastNAme, siTestScore
FROM externalcandidate
WHERE cCandidatecode = '000202';

-- Fetch candidate(s) by test score
SELECT ccandidateCode, vFirstName, vLastNAme, siTestScore
FROM externalcandidate
WHERE siTestScore = 80;

-- Comparison operators: only one value allowed on the right-hand side
SELECT ccandidateCode, vFirstName, vLastNAme, siTestScore
FROM externalcandidate
WHERE siTestScore > 80 AND siTestScore < 90;

-- Fetch all candidates
SELECT * FROM ExternalCandidate;

-- Get all candidates from the city Norton and Mentor
SELECT * FROM ExternalCandidate
WHERE ccity = 'Norton' OR ccity = 'Mentor';

-- Literal concatenated with column values
SELECT 'names' + vFirstName, vLastName
FROM externalcandidate;

-- Arithmetic operations on column data
SELECT ccandidateCode, vFirstName + vLastNAme, siTestScore, 'NewMarks' = siTestScore + 10
FROM externalcandidate;

SELECT ccandidateCode, vFirstName + vLastNAme, siTestScore, 'NewMarks' = siTestScore + 10
FROM externalcandidate;

-- WHERE clause usage
-- Note: MSSQL is case-insensitive by default
SELECT ccandidateCode, vFirstName, vLastNAme, siTestScore
FROM externalcandidate
WHERE vFirstName = 'angela';

-- Get all candidates from the city Norton and Mentor
SELECT * FROM ExternalCandidate
WHERE ccity = 'Norton' OR ccity = 'Mentor';

-- Get all candidates from Norton city with score greater than 90
SELECT * FROM ExternalCandidate
WHERE ccity = 'Norton' AND siTestScore > 90;

-- Same as above, improvement in performance if testscore results are lesser
SELECT * FROM ExternalCandidate
WHERE siTestScore > 90 AND ccity = 'Norton';


-- Fetch candidates NOT from Norton
SELECT * FROM ExternalCandidate
WHERE not ccity='Norton';

SELECT * FROM ExternalCandidate
WHERE ccity != 'Norton';

SELECT * FROM ExternalCandidate
WHERE ccity <> 'Norton';


-- BETWEEN, IN examples
SELECT * FROM ExternalCandidate
WHERE ccity = 'Norton' OR ccity = 'Mentor' OR ccity = 'Dublin' OR ccity = 'Seattle';

-- Same using IN clause
SELECT * FROM ExternalCandidate
WHERE ccity IN ('Norton', 'Mentor', 'Dublin', 'Seattle');

-- Fetch candidates with scores between 80 and 90 (inclusive)
SELECT * FROM ExternalCandidate
WHERE siTestScore >= 80 AND siTestScore <= 90;

-- Same using BETWEEN
SELECT * FROM ExternalCandidate
WHERE siTestScore BETWEEN 80 AND 90;


-- USAGE OF LIKE

-- Match address patterns
SELECT * FROM ExternalCandidate
WHERE vAddress LIKE '%state%';

SELECT * FROM ExternalCandidate
WHERE vAddress LIKE '%street%';

-- Candidates whose first name starts with 'J'
SELECT * FROM ExternalCandidate
WHERE vFirstname LIKE 'J%';

-- Get all candidates who have 6 as the last digit in their cCandidateCode
SELECT * FROM ExternalCandidate
WHERE cCandidateCode LIKE '%6';

-- Candidates with second-to-last character as 1
SELECT * FROM ExternalCandidate
WHERE cCandidateCode LIKE '%1_';

-- Candidates where cCandidateCode ends with 1 followed by 2, 6, or 8
SELECT * FROM ExternalCandidate
WHERE cCandidateCode LIKE '%1[268]';

-- Candidates where cCandidateCode ends with 1 followed by any digit from 2 to 8
SELECT * FROM ExternalCandidate
WHERE cCandidateCode LIKE '%1[2-8]';

-- Candidates whose first name starts with 'J' or 'A' or 'B' and ends with 'a', 'y', or 'h'
SELECT * FROM ExternalCandidate
WHERE vFirstname LIKE '[JAB]%[ayh]';

SELECT * FROM ExternalCandidate
ORDER BY cState, cCity, cCandidateCode

---order by

select * from ExternalCandidate

select cstate,ccity,ccandidatecode,vfirstname,vlastname,sitestscore 
from ExternalCandidate
order by cState

-- sp_help externalcandidate 

create index idxstateexcan on externalcandidate(cstate,ccity)

drop index idxstateexcan on externalcandidate

select cstate,ccity,ccandidatecode,vfirstname,vlastname,sitestscore 
from ExternalCandidate
order by cState,ccity desc

select ccandidatecode,vfirstname,sitestscore 
from ExternalCandidate
order by siTestScore desc

select top 10 percent ccandidatecode,vfirstname,sitestscore
from ExternalCandidate
order by sitestscore desc

select top 5 ccandidatecode,vfirstname,sitestscore
from ExternalCandidate
order by sitestscore desc

select top 5 ccandidatecode,vfirstname,sitestscore
from ExternalCandidate
order by sitestscore

--min max avg count

select sitestscore from ExternalCandidate

select max=max(sitestscore),min=min(sitestscore),count=count(sitestscore) from ExternalCandidate

select count=count(ccandidatecode),count(vemailid) from ExternalCandidate
select count=count(*) from ExternalCandidate

---group by

select *from ExternalCandidate
order by cState

select cstate,'no of candidates' = count(ccandidatecode)
from ExternalCandidate
group by cState

select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
group by cState

select cstate ,cCity, 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
group by cState,cCity

---need for having

select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
where sitestscore>80
group by cState
having count(ccandidatecode)>=2

select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
group by cState
having avg(sitestscore)>=70


-----difference b/w having and where


select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
group by cState
having cstate in ('nevada','ohio','texas')

select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
where cstate in ('nevada','ohio','texas')
group by cState

select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
where cstate in ('nevada','ohio','texas') and siTestScore>70
group by cState

select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
where siTestScore>70
group by cstate 
having cstate in ('nevada','ohio','texas')

select cstate , 'no of candidates' = count(ccandidatecode) ,max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from ExternalCandidate
where cstate in ('nevada','ohio','texas')
group by cState
having count(ccandidatecode)>2


-- JOINS

SELECT * FROM ExternalCandidate;

SELECT * FROM RecruitmentAgencies;


SELECT cCandidateCode, vFirstName, vLastName, cAgencyCode
FROM ExternalCandidate  
WHERE cAgencyCode IS NOT NULL;


SELECT cCandidateCode, vFirstName, cName
FROM ExternalCandidate
INNER JOIN RecruitmentAgencies
ON ExternalCandidate.cAgencyCode = RecruitmentAgencies.cAgencyCode;

select * from Position

SELECT ExternalCandidate.cCandidateCode, ExternalCandidate.vFirstName, ExternalCandidate.vLastName, Position.vDescription
FROM ExternalCandidate
INNER JOIN Position
ON ExternalCandidate.cPositionCode = Position.cPositionCode

select * from ContractRecruiter

SELECT ExternalCandidate.cCandidateCode, ExternalCandidate.vFirstName, ExternalCandidate.vLastName, ContractRecruiter.cName
FROM ExternalCandidate
INNER JOIN ContractRecruiter
ON ExternalCandidate.cContractRecruiterCode = ContractRecruiter.cContractRecruiterCode

select * from College

SELECT ExternalCandidate.cCandidateCode, ExternalCandidate.vFirstName, ExternalCandidate.vLastName, College.cCollegeName
FROM ExternalCandidate
INNER JOIN College
ON ExternalCandidate.cCollegeCode = College.cCollegeCode

-- Ambiguous Column
select ccandidatecode, vfirstname, cname, cPhone
from ExternalCandidate
join RecruitmentAgencies
on ExternalCandidate.cAgencyCode = RecruitmentAgencies.cAgencyCode

-- resolved
select ccandidatecode, vfirstname, 
       'Candidate phone' = ExternalCandidate.cphone, 
       cname, 
       'Recruiter phone' = RecruitmentAgencies.cphone
from ExternalCandidate
join RecruitmentAgencies
on ExternalCandidate.cAgencyCode = RecruitmentAgencies.cAgencyCode

-- Alias
select ccandidatecode, vfirstname, cname, RecruitmentAgencies.cphone
from ExternalCandidate
join RecruitmentAgencies
on ExternalCandidate.cAgencyCode = RecruitmentAgencies.cAgencyCode

select ccandidatecode, vfirstname, cname, r.cphone
from ExternalCandidate e
join RecruitmentAgencies r
on e.cAgencyCode = r.cAgencyCode

select * from ExternalCandidate

select e.cCandidateCode, e.vFirstName, e.vLastName, p.vDescription
from ExternalCandidate e
left join Position p
on e.cPositionCode = p.cPositionCode

select * from ContractRecruiter

select e., cr.
from ExternalCandidate e
inner join ContractRecruiter cr
on e.cContractRecruiterCode = cr.cContractRecruiterCode

select e.ccandidatecode, e.vfirstname, c.*
from ExternalCandidate e
right join College c
on e.cCollegeCode = c.cCollegeCode;

update employee
set cSupervisorCode='000001'
where cEmployeecode like '%[5-9]'

update employee
set cSupervisorCode='000002'
where cEmployeecode like '%[3-4]'

update employee
set cSupervisorCode='000001'
where cEmployeecode like '%[2]'

update employee
set cSupervisorCode='000003'
where cEmployeecode like '%1[1-2]'

select 
  "Employee" = emp.vFirstName + space(1) + emp.vLastName, 
  "Superior" = supr.vFirstName + space(1) + supr.vLastName
from employee emp
join employee supr
on emp.cSupervisorCode = supr.cEmployeeCode;



select cCandidatecode, vfirstname, vlastname
from ExternalCandidate
where cRating = (select cRating from ExternalCandidate
                 where vFirstName = 'Angela')

--join substitute
select e.cCandidatecode, e.vfirstname, e.vlastname
from ExternalCandidate e
join externalcandidate o
on e.cRating = o.cRating
where o.vFirstName='Angela'



--Subquery
--get all candidates having same rating as that of 'Angela'
select cRating from ExternalCandidate
where vFirstName = 'Angela';

select cCandidatecode, vfirstname, vlastname
from ExternalCandidate
where cRating = 8;

select cCandidatecode, vfirstname, vlastname
from ExternalCandidate
where cRating = (
    select cRating from ExternalCandidate 
    where vFirstName = 'Angela'
);

--join substitute
select e.cCandidatecode, e.vfirstname, e.vlastname
from ExternalCandidate e
join ExternalCandidate o
on e.cRating = o.cRating
where o.vFirstName = 'Angela';

select cCandidatecode, vfirstname, vlastname
from ExternalCandidate
where cRating = (
    select cRating from ExternalCandidate 
    where vFirstName = 'Angela'
);

-- get all candidates who have got score greater than Angela and Barbara -- greater than 82 -- greater than greatest
select cCandidatecode, vfirstname, vlastname, cRating
from ExternalCandidate
where cRating in (
    select cRating 
    from ExternalCandidate 
    where vFirstName in ('David', 'Angela')  -- selects ratings of David and Angela
)

-- max: selects candidates with sitestscore greater than the highest score among Angela and Barbara
select * from ExternalCandidate
where sitestscore > (
    select max(sitestscore) 
    from externalcandidate 
    where vFirstname = 'Angela' or vFirstname = 'Barbara'  -- gets the maximum sitestscore between Angela and Barbara
)

-- all: same result using ALL keyword – checks if sitestscore is greater than ALL values in the subquery
select * from ExternalCandidate
where sitestscore > all (
    select sitestscore 
    from externalcandidate 
    where vFirstname = 'Angela' or vFirstname = 'Barbara'  -- selects all sitestscores of Angela or Barbara
)

-- any: min – checks if sitestscore is greater than any one of the values (minimum also works here as lowest threshold)
select * from ExternalCandidate
where sitestscore > any (
    select sitestscore 
    from externalcandidate 
    where vFirstname = 'Angela' or vFirstname = 'Barbara'  -- any of the scores (either Angela's or Barbara's)
)

-- equivalent logic using MIN instead of ANY: checks if sitestscore is greater than the lowest of Angela/Barbara
select * from ExternalCandidate
where sitestscore > (
    select min(sitestscore) 
    from externalcandidate 
    where vFirstname = 'Angela' or vFirstname = 'Barbara'  -- gets the minimum sitestscore of Angela and Barbara
)


----------------- HOMEWORK START -----------------

-- get all candidates whose sitestscore is less than the smallest (MIN) of Angela or Barbara
select * from ExternalCandidate
where sitestscore < (
    select min(sitestscore)
    from ExternalCandidate
    where vFirstname = 'Angela' or vFirstname = 'Barbara'  -- gets lowest score between Angela and Barbara
)

-- same logic using ALL keyword (sitestscore should be less than both Angela and Barbara)
select * from ExternalCandidate
where sitestscore < all (
    select sitestscore
    from ExternalCandidate
    where vFirstname = 'Angela' or vFirstname = 'Barbara'  -- both values must be greater than current
)

-- get all candidates whose sitestscore is less than the maximum of Angela or Barbara
select * from ExternalCandidate
where sitestscore < (
    select max(sitestscore)
    from ExternalCandidate
    where vFirstname = 'Angela' or vFirstname = 'Barbara'  -- gets highest score between Angela and Barbara
)

-- same logic using ANY keyword (sitestscore should be less than at least one of Angela or Barbara)
select * from ExternalCandidate
where sitestscore < any (
    select sitestscore
    from ExternalCandidate
    where vFirstname = 'Angela' or vFirstname = 'Barbara'  -- even one match is enough
)

----------------- HOMEWORK END -----------------


--exists

select * from ExternalCandidate
where exists(select* from position where cpositioncode is null)

select * from ExternalCandidate
where exists(select* from Position where vFirstName='angela') and vFirstName='angela'

select * from ExternalCandidate where exists(
select * from ContractRecruiter where cName='John smith')


--select into  
--Only data and structure of table is copied to create new table  
--Constraint keys and indexes are lost in the new table

-- Create a new table newexcandidate with all data copied from externalcandidate
select * into newexcandidate  
from externalcandidate  

-- View all data from the newly created table
select * from newexcandidate  

-- Create a new table newexscore with selected columns and only rows where cState = 'Georgia'
select cCandidatecode, vFirstname, vLastname, sitestscore  
into newexscore  
from externalcandidate  
where cState = 'Georgia'  

-- Show structure and metadata of the newexscore table (only works in SQL Server)
sp_help newexscore  

-- View data from the newexscore table
select * from newexscore



-- UNION

-- union
select vFirstName, vLastName, cPhone
from ExternalCandidate
union
select vFirstName, vLastName, cPhone
from Employee

-- union all
select vFirstName, vLastName, cPhone
from ExternalCandidate
union all
select vFirstName, vLastName, cPhone
from Employee
order by vFirstName, vLastName

--number of column mismatch so Error
-- This will cause an error because the number of columns in both SELECT statements is not the same
select 'name'=vFirstname + vLastname, cphone  
from ExternalCandidate  
union all  
select cname  
from ContractRecruiter  


--datatype of column mismatch so Error  
-- This will cause an error because the data types of the columns in both SELECT statements are different  
select 'name'=vFirstname + vLastname, siTestScore  
from ExternalCandidate  
union all  
select cname, mTotalPaid  
from ContractRecruiter  


-- View all records from the ContractRecruiter table  
select * from ContractRecruiter  


--intersect  
-- This will return only the rows that are present in both ExternalCandidate and Employee tables  
SELECT vFirstName, vLastName, cphone FROM ExternalCandidate  
INTERSECT  
SELECT vFirstName, vLastName, cphone FROM Employee

-- Except
SELECT vFirstName, vLastName, cPhone FROM ExternalCandidate
except
SELECT vFirstName, vLastName, cPhone FROM Employee

create table ExternalCandidate2
(
    cCandidateCode     char(6) constraint Pk_ExternalCandidate2_ccandidatecode primary key
                       constraint eccd_ch check(cCandidateCode like('[0-9][0-9][0-9][0-9][0-9][0-9]')),
    
    vFirstName         varchar(20) not null,
    vLastName          varchar(20),
    
    cCity              char(20) default 'Mumbai' 
                       constraint ch_ccity check(cCity in ('Mumbai','Delhi','Hyderabad','Chennai','Bangalore')),
    
    cPhone             char(15) constraint ecp_ck1 check(cPhone like '([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
    
    cPositionCode      char(4) constraint fk_position_cPositioncode references Position(cPositionCode),
    
    dDateOfApplication datetime,
    
    siPrevWorkExperience smallint constraint ch_workexp check(siPrevWorkExperience > 0),
    
    mPrevAnnualSalary  money,
    
    vEmailId           varchar(20) constraint ec_UK unique
);



-- Drop the ExternalCandidate2 table if it exists
drop table ExternalCandidate2;
delete ExternalCandidate2;

-- Display metadata about the ExternalCandidate2 table
sp_help ExternalCandidate2;
insert ExternalCandidate2
values (
    '000001',                 -- cCandidateCode
    'Beena',                  -- vFirstName
    'Shah',                   -- vLastName
    Default,                  -- cCity (uses default value 'Mumbai')
    '(123)123-1234',          -- cPhone
    '0001',                   -- cPositionCode
    '06/06/2025',             -- dDateOfApplication
    1,                        -- siPrevWorkExperience
    1000000,                  -- mPrevAnnualSalary
    'beelnaj@gmail.com'       -- vEmailId
);

-- Display all data from the ExternalCandidate2 table
select * from ExternalCandidate2;





-- UPDATE

-- Update all records where cCity is 'Norton1' and set it to 'Norton'
UPDATE ExternalCandidate
SET cCity = 'Norton'
WHERE cCity = 'Norton1';

-- Set siPrevWorkExperience to 10 for candidate with first name 'Angela'
UPDATE ExternalCandidate
SET siPrevWorkExperience = 10
WHERE vFirstName = 'Angela';

-- Decrease previous work experience by 1 for all candidates
UPDATE ExternalCandidate
SET siPrevWorkExperience = siPrevWorkExperience - 1;

-- Update salary of candidate code '000204' to match Angela’s salary
UPDATE ExternalCandidate
SET mPrevAnnualSalary = (
    SELECT mPrevAnnualSalary 
    FROM ExternalCandidate 
    WHERE vFirstName = 'Angela'
)
WHERE cCandidateCode = '000204';

SELECT * FROM ExternalCandidate




-- FUNCTIONS

select upper(vfirstname) from externalcandidate
select lower(vfirstname) from externalcandidate
select val='   123' from externalcandidate
select ltrim('   123') from externalcandidate
select 'a'=rtrim('   123         ') from externalcandidate
 
select len('   1 23         ') from externalcandidate
select len(vfirstname),vfirstname from externalcandidate
select vfirstname,patindex('%an%',vfirstname) from externalcandidate
select vfirstname,charindex('A',vfirstname) from externalcandidate
 
select vfirstname,substring(vfirstname,5,2) from externalcandidate
 
select vfirstname,reverse(substring(reverse(vfirstname),1,2)) 
from ExternalCandidate
select vfirstname,substring(vfirstname,len(vfirstname)-1,2)
from ExternalCandidate