ALTER TABLE SitesToCountries
ADD CONSTRAINT FK_SitesToCountries_Sites
FOREIGN KEY (SiteId) REFERENCES Sites(Id);

ALTER TABLE SitesToCountries
ADD CONSTRAINT FK_SitesToCountries_Countries
FOREIGN KEY (CountryId) REFERENCES Countries(Id);

ALTER TABLE SitesToCountries
ADD CONSTRAINT FK_SitesToCountries_Sites
FOREIGN KEY (SiteId) REFERENCES Sites(Id);

ALTER TABLE SitesToCountries
drop CONSTRAINT FK_SitesToCountries_Sites;

ALTER TABLE SitesToCountries
drop CONSTRAINT FK_SitesToCountries_Countries;

ALTER TABLE SitesToTrip
ADD CONSTRAINT FK_Sites_Trip
FOREIGN KEY (SiteId) REFERENCES Sites(Id);

ALTER TABLE SitesToTrip
drop CONSTRAINT FK_Sites_Trip;

ALTER TABLE SitesToTrip
ADD CONSTRAINT FK_SitesToTrip_Sites
FOREIGN KEY (SiteId) REFERENCES Sites(Id);

ALTER TABLE SitesToTrip
ADD CONSTRAINT FK_SitesToTrip_Trip
FOREIGN KEY (TripId) REFERENCES Trips(Id);

ALTER TABLE Trips
ADD CONSTRAINT FK_Country_Trip
FOREIGN KEY (CountryId) REFERENCES Countries(Id);

