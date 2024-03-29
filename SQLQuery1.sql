ALTER TABLE TravelersGroup
ADD GuiderId nchar(9);

ALTER TABLE TravelersGroup
ADD CONSTRAINT FK_Travelers_Guider
FOREIGN KEY (GuiderId) REFERENCES TravelGuides(Id);