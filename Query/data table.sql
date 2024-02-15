INSERT INTO Cities(Name)
VALUES ('Jerusalem'),
('Beit Shemesh'),
('Bnei Brak'),
('Zefat'),
('Elad'),
('more'),
('Kiryat Sefer'),
('Haifa'),
('Tiberias'),
('horizons');

INSERT INTO Categories(Name)
VALUES ('music'),
('Wedding Dresses'),
('Event dresses'),
('bridal guides'),
('Guides grooms'),
('photographer'),
('Shopping'),
('Halls'),
('orders'),
('Makeup and hair'),
('singularity'),
('singularity'),
('singularity'),
('singularity'),
('wigs');

ALTER TABLE Business
ALTER COLUMN CityId int   NULL; 

ALTER TABLE Business
ADD CONSTRAINT FK_CategoriesBusiness
FOREIGN KEY (Category) REFERENCES Categories(ID);

INSERT INTO Business(Name,Category,CityId,Adress,PhoneNum,OpeningHours,MoreInfo)
VALUES ('Malki Beloy',15,1,'Mintz 22 Ramot D','0527690806','Mon-Fri 9:00 - 15:00',null),
('Paigy',6,null,'Bnei Brak','052456086','Mon-Fri 10:00 - 22:00','Photographers, female photographers, screenwriters and screenwriters');

 select * from Business

 DELETE FROM Cities WHERE id>=11;