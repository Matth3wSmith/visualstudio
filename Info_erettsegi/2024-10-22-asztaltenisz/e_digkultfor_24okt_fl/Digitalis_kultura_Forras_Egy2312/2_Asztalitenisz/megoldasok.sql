--- 2. feladat ---
    SELECT ev, versenyszam.nev FROM bajnok INNER JOIN versenyszam ON vsz_id=versenyszam.id INNER JOIN jatekos ON jatekos.id=jatekos_id WHERE jatekos.nev = "Harczi Zsolt";

--- 3. feladat ---
    SELECT ev FROM bajnok INNER JOIN versenyszam ON vsz_id=versenyszam.id WHERE nev = "vegyes páros" ORDER BY ev LIMIT 1;

--- 4. feladat ---
    SELECT IF(neme=1,"Férfi","Nő") AS neme, COUNT(nev) AS letszam FROM jatekos GROUP BY neme;

--- 5. feladat ---
    SELECT orszag FROM egyesulet INNER JOIN bajnok ON egyesulet_id=egyesulet.id WHERE orszag!="Magyarország" AND ev>2000 GROUP BY orszag;

--- 6. feladat ---
    SELECT DISTINCT jatekos.nev, egyesulet.nev FROM jatekos INNER JOIN bajnok ON jatekos.id=jatekos_id INNER JOIN egyesulet ON egyesulet_id = egyesulet.id WHERE egyesulet.nev="MTK" ORDER BY neme ASC, jatekos.nev; 

--- 7. feladat ---
    SELECT jatekos.nev, ev, versenyszam.nev FROM jatekos INNER JOIN bajnok ON jatekos.id=jatekos_id INNER JOIN versenyszam ON versenyszam.id=vsz_id GROUP BY jatekos.nev HAVING COUNT(*) = 1;

    
