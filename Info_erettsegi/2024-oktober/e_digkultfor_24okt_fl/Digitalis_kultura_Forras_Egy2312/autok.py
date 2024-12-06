#2024 október érettségi
#2024-12-06
#
#

#1. feladat
autok=[]
idok=[]
sebessegek=[]
f=open("jeladas.txt","r")
for sor in f:
    vag=sor.strip().split("\t")
    autok.append(vag[0])
    idok.append(list(map(int,vag[1:3])))
    sebessegek.append(vag[3])
f.close()

#2. feladat
print("2. feladat")
print(f"Az utolsó jeladás időpontja {idok[-1][0]}:{idok[-1][1]}, a jármú rendszáma {autok[-1]}")

#3. feladat
def ido(idok):
    return ":".join(list(map(str,idok)))
elso=autok[0]
elsoIdok=[]
for i in range(len(autok)-1):
    if autok[i]==elso:
        elsoIdok.append(idok[i])
elsoIdok=list(map(ido,elsoIdok))
print("3. feladat")
print(f"Az első jármű: {elso}")
print(f"A jeladásainak időpontjai: {" ".join(elsoIdok)}")