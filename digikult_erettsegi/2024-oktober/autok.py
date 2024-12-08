#2024 október érettségi
#2024-12-06
#
#
import math
def ido(idok):
    return ":".join(list(map(str,idok)))
def idoKulonbseg(idok1,idok2):
    kulonbseg=(idok2[0]*60+idok2[1]) - (idok1[0]*60+idok1[1])
    return kulonbseg
    
#1. feladat
autok=[]
idok=[]
sebessegek=[]
f=open("jeladas.txt","r")
for sor in f:
    vag=sor.strip().split("\t")
    autok.append(vag[0])
    idok.append(list(map(int,vag[1:3])))
    sebessegek.append(int(vag[3]))
f.close()

#2. feladat
print("2. feladat:")
print(f"Az utolsó jeladás időpontja {idok[-1][0]}:{idok[-1][1]}, a jármú rendszáma {autok[-1]}")

#3. feladat
elso=autok[0]
elsoIdok=[]
for i in range(len(autok)-1):
    if autok[i]==elso:
        elsoIdok.append(idok[i])
elsoIdok=list(map(ido,elsoIdok))
print("3. feladat:")
print(f"Az első jármű: {elso}")
print(f"A jeladásainak időpontjai: {' '.join(elsoIdok)}")

#4. feladat
print("4. feladat:")
"""ora= int(input("Kérem, adja meg az órát: "))
perc= int(input("Kérem, adja meg a percet: "))
jeladasok=0
for i in range(len(idok)):
    if idok[i][0]==ora and idok[i][1]==perc:
        jeladasok+=1
print(f"A jeladások száma: {jeladasok}")"""

#5. feladat
maxSebesseg=max(sebessegek)
rendszamok = [autok[i] for i, x in enumerate(sebessegek) if x == maxSebesseg]
print("5. feladat:")
print(f"A legnagyobb sebesség km/h: {maxSebesseg}")
print("A járművek: "+" ".join(rendszamok))

#6. feladat
print("6. feladat:")
rendszam = input("Kérem, adja mega rendszámot: ")
jeladasai=[]
for i in range(len(autok)):
    if autok[i]==rendszam:
        ut=0
        print(ido(idok[i]), end=" ")
        if len(jeladasai)==0:
            print("0.0 km")
        else:
            perc=idoKulonbseg(jeladasai[-1][0],idok[i])
            ut=round(perc/60*jeladasai[-1][1],1)+jeladasai[-1][2]
            print(f"{round(ut,1)} km")
        jeladasai.append([idok[i],sebessegek[i],ut])

#7. feladat
f=open("ido.txt","w")
jarmuvek=[]
for i in range(len(autok)):
    if len(jarmuvek)!=0:
        if autok[i] not in jarmuvek[-1][0]:
            utolso=len(autok) - 1 - autok[::-1].index(autok[i])
            #print(autok[i],idok[i],idok[utolso])
            jarmuvek.append([autok[i],idok[i][0],idok[i][1],idok[utolso][0],idok[utolso][1]])
            f.write(" ".join(list(map(str,jarmuvek[-1])))+'\n')
    else:
        utolso=len(autok) - 1 - autok[::-1].index(autok[i])
        #print(autok[i],idok[i],idok[utolso])
        jarmuvek.append([autok[i],idok[i][0],idok[i][1],idok[utolso][0],idok[utolso][1]])
        f.write(" ".join(list(map(str,jarmuvek[-1])))+"\n")

f.close()