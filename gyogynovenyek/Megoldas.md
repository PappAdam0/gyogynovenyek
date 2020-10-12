# Megoldás
# Osztály létrehozása
- kétféle mód közül bármelyik
- Ctrl +.
- Adjunk hozzá egy új osztályt
- 5 tulajdonság
  - public get
  - private set
- 1 konstruktor
  - 1 paraméter(string)
  - például: Acsalapu;levél;6;8
  - ;-vel vannak elválasztva
  - 4 darab adat -> 5 db tulajdonság?
  - átadott beolvasott sort, fájlból beolvasott sort: 
    - ';' mentén tagoljuk, 
    - [0] - Nev
    - [1] - Resz
    - [2] - Kezd
    - [3] - Veg
    - Idotartam --> szamolas
 - 5-dik tulajdonság az időtartam -> idotartam
    - konstruktorban számoljuk
    - Számolása: Vég - Kezdet HA Vég > Kezdet
    - Vég > kezdet ->Vég - Kezdet +1
    - Egyébként 12- Vég +kezdet +1
 ## Adatok beolvasása és tárolása
- Listában tároljuk az objektum példányokat
- olvassuk be
  - System.IO
  - StreamReader
  - while(!EndOfStream)
  - Cikluson belül listához hozzáadunk egy új objektum példát( beolvas sor a paraméter)
 ## 1. Feladat
  - Hány növény (lista hossza)
  
## 2. Feladat
  - Milyen gyűjthető részek vannak
  - Hány darab van ezekből 
  - static Dictionary<string,int>
  - 1. milyen gyűjthető részek
    - foreach lista
    - ha a rész nem kulcs akkor adja hozzá 0-val
   - 2. Hány darab
       - foreach lista
       - Ha "Resz" == "Key" akkor value értéket növeljük egyel
 
## 3. Feladat
- maximum keresés, időtartam alapján 
  - max valtozo = 0
  - foreach lista
  - ha max < idotartam akk max = idotartam
- növények amelyeket a legtöbb ideig szedték



## 4. Feladat
- Időtartam átlag számítás (összegzés)