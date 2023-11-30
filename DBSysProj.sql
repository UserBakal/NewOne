Create Database DBSysProj
USE DBSysProj
CREATE VIEW CombinedView AS
SELECT
    s.studentID,
    s.IDNumber AS StudentIDNumber,
    s.FirstName AS StudentFirstName,
    s.LastName AS StudentLastName,
    s.Course,
    e.EventID,
    e.EventName,
    e.EventDate,
    p.Position
FROM
    Student s
    LEFT JOIN Event e ON s.studentID = e.EventID
    LEFT JOIN PSITS p ON s.psitsID = p.psitsID;


