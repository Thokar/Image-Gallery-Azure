Select * from GalleryImages

Insert Into GalleryImages(Created, Title, [Url]) Values
(GETDATE(), 'My new Boat', '/images/boat1.jpeg'),
(GETDATE(), 'out Sailing', '/images/boat2.jpeg'),
(GETDATE(), 'My new Boat', '/images/boat3.jpeg'),
(GETDATE(), 'Skatpark', '/images/skate1.jpeg'),
(GETDATE(), 'Skateboarding', '/images/skate2.jpeg'),
(GETDATE(), 'Skating', '/images/skate3.jpeg')