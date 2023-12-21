CREATE TABLE IF NOT EXISTS public.Employer (
    EmployerID SERIAL PRIMARY KEY,
    EmployerName VARCHAR(200) NOT NULL,
    EmployerDescription VARCHAR NULL,
    UNIQUE (EmployerName),
    CHECK (EmployerName <> '')
);

CREATE TABLE IF NOT EXISTS public.Experience (
    ExperienceID SERIAL PRIMARY KEY,
    EmployerID INT NOT NULL REFERENCES public.Employer(EmployerID),
    JobTitle VARCHAR(200) NOT NULL,
    JobDescription VARCHAR NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NULL,
    UNIQUE (EmployerID, JobTitle),
    CHECK (StartDate < EndDate),
    CHECK (ExperienceID > 0 AND EmployerID > 0)
);

CREATE TABLE IF NOT EXISTS public.Education (
    EducationID SERIAL PRIMARY KEY,
    SchoolName VARCHAR(200) NOT NULL,
    SchoolLocation VARCHAR(200),
    Degree VARCHAR(200) NOT NULL,
    Major VARCHAR(200),
    StartDate DATE NOT NULL,
    EndDate DATE NULL,
    UNIQUE (SchoolName, Degree),
    CHECK (StartDate < EndDate),
    CHECK (EducationID > 0),
    CHECK (SchoolName <> '' AND Degree <> '' AND Major <> '')
);

CREATE TABLE IF NOT EXISTS public.Skill (
    SkillID SERIAL PRIMARY KEY,
    SkillName VARCHAR(100) NOT NULL,
    SkillDescription VARCHAR NULL,
    UNIQUE (SkillName),
    CHECK (SkillID > 0),
    CHECK (SkillName <> '')
);

CREATE TABLE IF NOT EXISTS public.ExperienceSkill (
    ExperienceID INT REFERENCES public.Experience(ExperienceID),
    SkillID INT REFERENCES public.Skill(SkillID),
    PRIMARY KEY (ExperienceID, SkillID),
    CHECK (ExperienceID > 0 AND SkillID > 0)
);


