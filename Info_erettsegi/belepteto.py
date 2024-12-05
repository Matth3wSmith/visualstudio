#2024. május Digitális kultúra emelt érettségi 
# 
#
import math
def idoKulonbseg(h1,p1,h2,p2):
    kulonbseg=(h2*60+p2) - (h1*60+p1)
    return math.floor(kulonbseg / 60), kulonbseg%60
#1. feladat
tanulok=[]
idok=[]
esemenyek=[]

f=open("bedat.txt","r")
for sor in f:
    vag = sor.strip().split(" ")
    tanulok.append(vag[0])
    idok.append(vag[1])
    esemenyek.append(int(vag[2]))
 
f.close()
print(tanulok)
#2. feladat
elsoIdo=""
utolsoIdo=""

for i in range(0,len(tanulok)-1):
    #print(tanulok[ember]["kod"])
    if esemenyek[i]==1 and elsoIdo=="":
        elsoIdo=idok[i]
    if esemenyek[i]==2:
        utolsoIdo=idok[i]

print("2. feladat")
print(f"Az első tanuló {elsoIdo}-kor lépett be a főkapun.")
print(f"Az utolsó tanuló {utolsoIdo}-kor lépett ki a főkapun.")

#3. feladat
f = open("kesok.txt","w")
for i in range(0,len(tanulok)):
    ora,perc=idok[i].split(":")
    perc=int(perc)
    ora=int(ora)
    if (ora==7 and perc>50) or (ora==8 and perc<=15):
        f.write(f"{idok[i]} {tanulok[i]}\n")
f.close()

#4. feladat
menza=0
for i in range(0,len(tanulok)-1):
    if esemenyek[i]==3:
        menza+=1
print("4. feladat")
print(f"A menzán aznap {menza} tanuló ebédelt.")

#5. feladat
kolcsonzok=[]
for  i in range(0,len(tanulok)-1):
    if esemenyek[i]==4 and tanulok[i] not in kolcsonzok:
        kolcsonzok.append(tanulok[i])

print("5. feladat")
print(f"Aznap {len(kolcsonzok)} tanuló kölcsönzött a könyvtárban.")
if len(kolcsonzok)>menza:
    print("Többen voltak, mint a menzán.")
else:
    print("Nem voltak többen, mint a menzán.")

#6. feladat
keses=[]
suliban10ig=[]
for i in range(0,len(tanulok)-1):
    ora,perc=idok[i].split(":")
    perc=int(perc)
    ora=int(ora)
    if ora<10 and esemenyek[i]==1:
        suliban10ig.append(tanulok[i])
    elif esemenyek[i]==2 and tanulok[i] in suliban10ig:
        suliban10ig.remove(tanulok[i])

    if ora==10 and 50<perc and esemenyek[i]==1 and tanulok[i] in suliban10ig:
        #print(idok[i],esemenyek[i])
        keses.append(tanulok[i])

print("6. feladat")
print("Az érintett tanulók:")
print(" ".join(keses))

#7. feladat
print("7. feladat")
tanulo=input("Egy tanulo azonosítója=")
erkezes=0
tavozas=0
for i in range(len(tanulok)-1):
    if tanulok[i]==tanulo:
        erkezes=idok[i]
        break

for i in range(len(tanulok)-1):
    i=len(tanulok)-1-i
    print(i)
    if tanulok[i]==tanulo:
        tavozas=idok[i]
        break

if erkezes==0:
    print("Ilyen azonosítójú tanuló aznap nem volt az iskolában.")
else:
    print(erkezes)
    print(tavozas)
    erkezes=erkezes.split(":")
    tavozas=tavozas.split(":")
    ora,perc=idoKulonbseg(int(erkezes[0]),int(erkezes[1]),int(tavozas[0]),int(tavozas[1]))
    print(f"A tanuló érkezése és távozása között {ora} óra {perc} perc telt el.")