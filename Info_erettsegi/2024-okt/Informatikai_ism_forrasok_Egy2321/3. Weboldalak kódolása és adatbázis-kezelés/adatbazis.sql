use cukraszda;

-- Kiszerelések
CREATE TABLE IF NOT EXISTS `kiszereles`(
	`id` int(11) NOT NULL AUTO_INCREMENT,
	`mennyiseg` varchar(9) CHARACTER SET utf8 NOT NULL,
	PRIMARY KEY (`id`)
)ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=7 ;

INSERT `kiszereles` (`id`, `mennyiseg`) VALUES (1, '200g');
INSERT `kiszereles` (`id`, `mennyiseg`) VALUES (2, '250g');
INSERT `kiszereles` (`id`, `mennyiseg`) VALUES (3, '500g');
INSERT `kiszereles` (`id`, `mennyiseg`) VALUES (4, 'darab');
INSERT `kiszereles` (`id`, `mennyiseg`) VALUES (5, 'pohár');
INSERT `kiszereles` (`id`, `mennyiseg`) VALUES (6, 'szelet');

-- Termékek
CREATE TABLE IF NOT EXISTS `termek`(
	`id` int(11) NOT NULL AUTO_INCREMENT,
	`nev` varchar(43) CHARACTER SET utf8 NOT NULL,
	`ar` int(11) NOT NULL,
	`kiszerelesId` int(11) NOT NULL,
	`szenhidrat` decimal(10,2) DEFAULT NULL,
	`kaloria` int(11) DEFAULT NULL,
	`laktozmentes` boolean DEFAULT false,
	`tejmentes` boolean DEFAULT false,
	`tojasmentes` boolean DEFAULT false,
	PRIMARY KEY (`id`),
	KEY `kiszerelesId` (`kiszerelesId`),
	CONSTRAINT FK_kiszerelesek_kiszerelesId FOREIGN KEY (kiszerelesId)
		REFERENCES kiszereles(id)
)ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=73 ;

INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (1, 'Áfonyás citromos sajttorta', 1350, 6, 40.1, 248, True, False, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (2, 'Almás krémes', 1390, 6, 24.8, 150, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (3, 'Barackos köles', 1190, 6, 22.4, 236, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (4, 'Baritúró', 1190, 6, 7.4, 99, True, False, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (5, 'Belga csoki torta', 1350, 6, 20, 303, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (6, 'Bounty éden', 1190, 6, 12.3, 146, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (7, 'Diós hókifli', 2100, 1, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (8, 'Duplacsokis tallér', 2100, 1, 23.15, 198, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (9, 'Eklerfánk', 1150, 4, 18, 179, True, False, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (10, 'Eperkrém szelet', 1190, 6, 14.5, 170, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (11, 'Epres fehércsoki', 1390, 6, 15.6, 288, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (12, 'Epres sajttorta', 990, 6, 18, 314, True, False, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (13, 'Erdei túró', 1190, 6, 15.2, 195, True, False, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (14, 'Eszterke', 1190, 6, 26, 228, False, False, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (15, 'Feri dobosa', 1190, 6, 21, 281, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (16, 'Gesztenye alagút', 1190, 6, 14.2, 157, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (17, 'Képviselőfánk', 1190, 4, 18, 169, True, False, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (18, 'Kerekerdő', 1190, 5, 16.8, 228, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (19, 'Kókuszgolyó', 690, 4, 29, 215, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`,  `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (20, 'Kókuszos hókifli', 2100, 1, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (21, 'Kókuszos málnás tallér', 2100, 1, 23.15, 198, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (22, 'Madártej szelet', 1190, 6, 15.9, 155, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (23, 'Málnakrém szelet', 1190, 6, 14.4, 275, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (24, 'Málnás citromkrém', 1190, 5, 14.8, 275, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (25, 'Málnás kókusz mousse', 1190, 5, 10.6, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (26, 'Málnás linzervirág', 1150, 4, 23.4, 330, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (27, 'Málnás túró mousse', 1350, 5, 22.4, 186, True, False, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (28, 'Mangós sajttorta', 990, 6, 18, 314, True, False, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (29, 'Meggyes fehércsokis isler', 4200, 3, 45, 493, False, False, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (30, 'Nagyi Kedvence', 1350, 6, 11.9, False, False, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (31, 'Növényi sajtos sós pogácsa', 1900, 2, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (32, 'Oroszkrém', 1190, 6, 16, 248, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (33, 'Paleo Eszti', 1350, 6, 10.9, 268, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (34, 'Paleo Ferrero', 1350, 6, 27, 465, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (35, 'Paleo körtés diókrém', 1350, 5, 19, 249, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (36, 'Paleo málnás csoki mousse', 1350, 5, 18, 301, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (37, 'Puncstorta', 990, 6, 25, 226, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (38, 'Répatorta', 1190, 6, 18, 169, True, False, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (39, 'Részeges meggyes', 1190, 6, 13.8, 192, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (40, 'Rudi szelet', 1190, 6, 7.4, 99, True, False, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (41, 'Sacher', 1190, 6, 25, 296, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (42, 'Snickers sajttorta', 990, 6, 15, 259, True, False, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (43, 'Somlói revolúció', 1190, 6, 17.2, 333, False, False, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (44, 'Sós karamellás túrótorta', 1350, 6, 29.2, 229, True, False, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (45, 'Sós omlós pogácsa', 1900, 2, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (46, 'Szabolcsi almás mák', 1190, 6, 11.2, 135, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (47, 'Szamóca szelet', 990, 6, 11, 145, True, False, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (48, 'Tejmentes feketeerdő', 1350, 6, 17, 240, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (49, 'Tejmentes kókusztekercs', 290, 6, 20, 297, True, True, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (50, 'Tiramisu pohárkrém', 1190, 5, 19, 235, False, False, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (51, 'Tiramisu szelet', 1190, 6, 18, 169, True, False, False);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (52, 'Tojásmentes túrós pite', 990, 4, 36, 484, True, False, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (53, 'Túró rudi gömb', 820, 4, 11.5, 134, False, False, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (54, 'Vaníliás hókifli', 2100, 1, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (55, 'Vegán almás karamellás csoki', 1350, 4, 29.3, 119, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (56, 'Vegán almás pite', 990, 4, 36, 484, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (57, 'Vegán barackos islerke', 4200, 3, 45, 493, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (58, 'Vegán barackos linzike', 4200, 3, 46, 484, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (59, 'Vegán citromos málna', 1350, 6, 21.4, 217, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (60, 'Vegán diós szilvás linzike', 4200, 3, 46, 484, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (61, 'Vegán erdei sajttorta', 1290, 6, 21, 232, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (62, 'Vegán gesztenyegolyó', 820, 4, 11, 124, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (63, 'Vegán gesztenyepüré', 990, 5, 14.2, 157, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (64, 'Vegán habos meggyes', 1350, 6, 14.6, 223, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (65, 'Vegán mákos pite', 990, 4, 26, 484, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (66, 'Vegán meggyes bounty', 1350, 6, 32.6, 242, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (67, 'Vegán meggyes gesztenye', 1350, 6, 34.6, 189, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (68, 'Vegán meggyes kakaós linzer', 4200, 3, 36, 384, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (69, 'Vegán meggyes pite', 990, 4, 36, 484, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (70, 'Vegán nutellás sajttorta', 1290, 6, 26, 228, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (71, 'Vegán pilóta keksz', 390, 4, 34.8, 419, True, True, True);
INSERT `termek` (`id`, `nev`, `ar`, `kiszerelesId`, `szenhidrat`, `kaloria`, `laktozmentes`, `tejmentes`, `tojasmentes`) VALUES (72, 'Vegán tejszínes vaníliás eper', 1350, 6, 25.7, 232, True, True, True);



-- Allergének
CREATE TABLE IF NOT EXISTS `allergen`(
	`id` int(11) NOT NULL AUTO_INCREMENT,
	`nev` varchar(19) CHARACTER SET utf8 NOT NULL,
	PRIMARY KEY (`id`)
)ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=8 ;

INSERT `allergen` (`id`, `nev`) VALUES (1, 'diófélék');
INSERT `allergen` (`id`, `nev`) VALUES (2, 'földimogyoró');
INSERT `allergen` (`id`, `nev`) VALUES (3, 'kén-dioxid');
INSERT `allergen` (`id`, `nev`) VALUES (4, 'mandula');
INSERT `allergen` (`id`, `nev`) VALUES (5, 'szója');
INSERT `allergen` (`id`, `nev`) VALUES (6, 'szója-leticin');
INSERT `allergen` (`id`, `nev`) VALUES (7, 'szójabab');


-- Allergén információk
CREATE TABLE IF NOT EXISTS `allergenInfo`(
	`id` int(11) NOT NULL AUTO_INCREMENT,
	`allergenId` int(11) NOT NULL,
	`termekId` int(11) NOT NULL,
	PRIMARY KEY (`id`),
	KEY `allergenId` (`allergenId`),
	KEY `termekId` (`termekId`),
	CONSTRAINT FK_allergen_allergenId FOREIGN KEY (allergenId)
        REFERENCES allergen (id),
	CONSTRAINT FK_termek_termekId FOREIGN KEY (termekId)
        REFERENCES termek (id)
)ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci AUTO_INCREMENT=49 ;

INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (1, 1, 15);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (2, 1, 33);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (3, 1, 35);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (4, 1, 38);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (5, 1, 43);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (6, 1, 52);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (7, 1, 56);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (8, 1, 60);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (9, 1, 65);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (10, 1, 69);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (11, 2, 9);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (12, 2, 34);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (13, 2, 42);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (14, 2, 70);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (15, 3, 49);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (16, 4, 30);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (17, 4, 33);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (18, 4, 37);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (19, 4, 44);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (20, 5, 4);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (21, 5, 12);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (22, 5, 14);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (23, 5, 15);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (24, 5, 31);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (25, 6, 2);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (26, 6, 5);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (27, 6, 6);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (28, 6, 8);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (29, 6, 9);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (30, 6, 11);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (31, 6, 16);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (32, 6, 18);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (33, 6, 38);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (34, 6, 40);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (35, 6, 41);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (36, 6, 42);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (37, 6, 47);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (38, 6, 48);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (39, 6, 50);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (40, 6, 51);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (41, 6, 53);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (42, 6, 57);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (43, 6, 62);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (44, 6, 63);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (45, 6, 66);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (46, 6, 71);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (47, 7, 17);
INSERT `allergenInfo` (`id`, `allergenId`, `termekId`) VALUES (48, 7, 28);





