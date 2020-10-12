# Megoldás
## Osztály létrehozása
- Kétféle mód közül bármelyik 
    - ctrl+ .
    - adjunk hozzá egy osztályt
- 5 tulajdonság
  - Public get Private set   
- 1 konstruktor
  - 1 paraméter ami string 
  - például "Acsalapu;levél;6;8"
  - ;-vel vannak elválasztva
  - 4 darab adat --> 5 darab tulajdonság??
  - beolvasott sort átadjuk
    - ;-ként tagoljuk
    - [0] --> Nev
    - [1] --> Resz
    - [2] --> Kezd
    - [3] --> Vég
    - [4] --> Idotartam (lásd következő pont)
 - 5 tulajdonság --> időtartam
    - konstuktorban számoljuk
    - számolása vég-kezdet ha vég nagyobb mint kezdet
    - vég>kezdet --> vég - kezdet +1
    - egyébként --> 12 - vég + kezdet + 1
## Adatok beolvasása és eltárolása
- Listában tároljuk az objektum példányokat
- Olvassuk be
  - System.IO
  - StreamReader
  - While ciklussal --> amíg tart a fájl
  - Cikluson belül listához hozzáadunk egy új objektum példányt (Beolvasott sor a paraméter)
## 1.feladat
- Hány növény van(Lista count tulajdonság)
## 2.feladat
- Milyen gyüjthető részek vannak?
- Hány darab van ezekből
- adatszerkezet: Dictionary<string,int>
- 1 Milyen gyüjthető részek
  - foreach a "növények"
  - Ha a rész nem kulcs akkor adjuk hozzá 0-val
- 2 Hány darab van ezekből?
  - Foreach "novenyek"
  - Ha a "Resz" == Key --> Value++; 
## 3.feadat
- Maximum keresés --> Idotartam alapján
  - Maximum változo = 0;
  - Ha Idotartam > Maximum --> Maximum = Idotratam
- Növény(ek) amely(ek) a legtöbb ideig szedtek 
  - Foreach novenyek 
  - Kiirni ha Idotartam egyenlő max-al
## 4.feladat 
-Idotartam átlag számítás
   - szum = 0;
   - double átlag változó
   - foreach novenyek
   - szum += Idotartam
   - atlag = szum/Count
