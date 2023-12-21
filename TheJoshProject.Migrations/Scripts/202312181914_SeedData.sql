-- Employers
INSERT INTO public.Employer (EmployerName, EmployerDescription) VALUES ('Roof Maintenance Systems, LLC', 'A commercial roofing company that specializes in roof maintenance and repair.')
ON CONFLICT (EmployerName) DO NOTHING;

INSERT INTO public.Employer (EmployerName, EmployerDescription) VALUES ('Rice University Department of Physics', 'The physics department at Rice University in Houston, Texas.')
ON CONFLICT (EmployerName) DO NOTHING;

INSERT INTO public.Employer (EmployerName, EmployerDescription) VALUES ('Clear Creek ISD', 'A public school district in League City, Texas.')
ON CONFLICT (EmployerName) DO NOTHING;

INSERT INTO public.Employer (EmployerName, EmployerDescription) VALUES ('Datagration Solutions, Inc', 'A software company that specializes in oil and gas data management.')
ON CONFLICT (EmployerName) DO NOTHING;

INSERT INTO public.Employer (EmployerName, EmployerDescription) VALUES ('Ameriflex', 'An employer benefits company that specializes in health care, FSA, HSA, HRA, & Commuter Benefits administration.')
ON CONFLICT (EmployerName) DO NOTHING;

-- Experience
INSERT INTO public.Experience (EmployerID, JobTitle, JobDescription, StartDate, EndDate) VALUES (1, 'Office manager', 'Managed all office operations including bookkeeping, payroll, vendor accounts, billing, and company data management.', '2007-01-01', '2012-08-01')
ON CONFLICT (EmployerID, JobTitle) DO NOTHING;

INSERT INTO public.Experience (EmployerID, JobTitle, JobDescription, StartDate, EndDate) VALUES (2, 'Research Assistant', 'Conducted independent research on exoplanet detection in the Department of Physics and Astronomy. Received multiple research grants, co-authored paper that was published in the Astrophysical Journal, and received university honors for distinction in research and creative design.', '2013-08-01', '2016-05-01')
ON CONFLICT (EmployerID, JobTitle) DO NOTHING;

INSERT INTO public.Experience (EmployerID, JobTitle, JobDescription, StartDate, EndDate) VALUES (3, 'High School Science Teacher', 'Taught AP Physics and Astronomy to students of diverse backgrounds. Sponsored multiple student groups and clubs, and served as AP Physics team lead.', '2016-08-01', '2021-06-01')
ON CONFLICT (EmployerID, JobTitle) DO NOTHING;

INSERT INTO public.Experience (EmployerID, JobTitle, JobDescription, StartDate, EndDate) VALUES (4, 'Senior Solutions Developer', 'As a member of the Datagration team, I had a multifaceted role that involved working with various teams and stakeholders to enhance and optimize the web and server-side applications. This included collaborating with the front-end development team to build new features, working with the back-end team to improve existing features, and partnering with the engineering team to evaluate client business needs and develop custom solutions on the platform. ', '2021-06-01', '2023-09-25')
ON CONFLICT (EmployerID, JobTitle) DO NOTHING;

INSERT INTO public.Experience (EmployerID, JobTitle, JobDescription, StartDate, EndDate) VALUES (5, 'Software Developer', '', '2023-09-25', '2025-12-31')
ON CONFLICT (EmployerID, JobTitle) DO NOTHING;

-- Education
INSERT INTO public.Education (SchoolName, SchoolLocation, Degree, Major, StartDate, EndDate) VALUES ('Rice University', 'Houston, Texas', 'Bachelor of Science', 'Astrophysics', '2012-08-01', '2016-05-01')
ON CONFLICT (SchoolName, Degree) DO NOTHING;

-- Skills
INSERT INTO public.Skill (SkillName) VALUES ('.NET Development') -- 1
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('C#') -- 2
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('ASP.NET') -- 3
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Dapper') -- 4
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Entity Framework') -- 5
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('LINQ') -- 6
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('MVC') -- 7
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('SQL') -- 8
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('RESTful APIs') -- 9
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Front-end Development') -- 10
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('HTML') -- 11
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('CSS') -- 12
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('JavaScript') -- 13
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('TypeScript') -- 14
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Vue.js') -- 15
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('React') -- 16
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Chakra UI') -- 17
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Node.js') -- 18
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Express') -- 19
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Git') -- 20
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('GitHub') -- 21
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('PostgreSQL') -- 22
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('SQL Server') -- 23
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('MongoDB') -- 24
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Docker') -- 25
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Teaching') -- 26
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Public Speaking') -- 27
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Communication') -- 28
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Leadership') -- 29
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Data Analysis') -- 30
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Data Visualization') -- 31
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Research') -- 32
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Data Modeling') -- 33
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Azure') -- 34
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Azure Functions') -- 35
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Azure DevOps') -- 36
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Azure Pipelines') -- 37
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Octopus Deploy') -- 38
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Agile Development') -- 39
ON CONFLICT (SkillName) DO NOTHING;
INSERT INTO public.Skill (SkillName) VALUES ('Scrum') -- 40
ON CONFLICT (SkillName) DO NOTHING;

-- ExperienceSkill

-- Research (experience 2)
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (2, 30)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (2, 31)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (2, 32)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (2, 33)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;

-- Teaching (experience 3)
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (3, 26)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (3, 27)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (3, 28)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (3, 29)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;

-- Software Development @ Datagration (experience 4)
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 1)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 2)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 3)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 6)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 7)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 8)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 9)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 10)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 11)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 12)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 13)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 14)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 16)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 17)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 18)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 19)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 20)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 21)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 22)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 23)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 24)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 25)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 34)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 35)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 36)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 37)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (4, 39)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;

-- Software Development @ Ameriflex (experience 5)
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 1)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 2)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 3)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 4)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 6)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 7)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 8)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 9)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 10)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 11)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 12)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 13)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 20)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 21)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 23)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 24)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 25)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 32)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 33)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 38)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 39)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;
INSERT INTO public.ExperienceSkill (ExperienceID, SkillID) VALUES (5, 40)
ON CONFLICT (ExperienceID, SkillID) DO NOTHING;










