CREATE VIEW VW_PSITS3 AS
SELECT  TOP 200
	CONCAT('(', s.IDNumber, ') ', s.LastName, ', ',  s.FirstName) AS STUDENTs_Name,
    s.Course AS COURSE,
    e.EventName,
    e.EventDate
FROM
    Student s
    JOIN Event e ON s.eventId = e.EventID
ORDER BY s.LastName;

CREATE VIEW VW_ADMIN3 AS
SELECT Top 200
	CONCAT(p.Position,', ', p.Name)AS PSITS_Officers,
	CONCAT('(', s.IDNumber, ') ', s.LastName, ', ',  s.FirstName) AS STUDENTs_Name,
    s.Course AS COURSE,
    e.EventName,
    e.EventDate
FROM
    Student s
    JOIN Event e ON s.eventId = e.EventID
    JOIN PSITS p ON s.psitsId = p.psitsID
ORDER BY s.LastName;
