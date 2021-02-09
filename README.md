# Tápanyagok

## Feladatleírás
Készítsen egy Windows Forms alkalmazást adatbázis kapcsolattal, amiben az ételeket
és a hozzájuk tartozó tápanyagokat lehet kezelni! Forrásként használja a mellékelt
tapanyag.sql fájlt.

## Előkészületek
1. MySQL szerveren hozza létre a tapanyagok adatbázist és a hozzá tartozó
tapanyag táblát a melléklet alapján.
2. Készítsen el egy Windows Forms alkalmazást Tapanyagok néven. Kapcsolja
össze az adatbázist a projekttel a Server Explorer használatával.
3. Telepítse az Entity Framework NuGet csomagot a projekthez és az App.config-ot
módosítsa a MySQL varázsló segítségével.
4. Hozzon létre 5 könyvtárat a projektben: Models, Presenters, Repositories,
ViewInterfaces, Views.

## Model réteg
1. Hozzon létre egy ADO.NET Entity Modelt a Models könyvtárban! Használja a már
meglévő MySQL kapcsolatot (Server Explorer), importálja be a tapanyag táblát!
2. A létrejött tapanyag osztályt egészítse ki egy másik részosztállyal (partial).
3. Hozzon létre egy osztályt a Models könyvtárban, majd kösse össze a két fájlt,
hogy az új fájl lássa a legenerált model tulajdonságait.
4. Hozzon létre egy paraméter nélküli, majd egy paraméteres konstruktort a
tapanyag osztálynak. A paraméteres konstruktor paraméterei: név, energia,
fehérje, zsír, szénhidrát.

## Repository réteg
1. Készítsen egy osztályt TapanyagRepository néven.
2. Példányosítsa a DbContext osztály egy példányát az osztályban.
3. Hozzon létre egy BindingListet GetAllTapanyag néven. Tervezze meg, hogy lista
kereshető, sorba rendezhető, illetve oldalakra tördelhető legyen.
Plusz pont: a keresés működik a számértékű tulajdonságokra is.
4. Hozzon létre egy metódust, amely GetTapanyag néven, amely a megadott
paraméter alapján kikeresi az adatbázisból a hozzá tartozó rekordot.
5. Hozzon létre további CRUD metódusokat, amelyek az adatbázisba írnak (Insert,
Update, Delete), illetve egy mentés metódust (Save).
6. Hozzon létre egy függvényt Exists néven, amely megadja, hogy a paraméterként
kapott tapanyag létezik-e az adatbázisban.

## ViewInterface réteg
1. Készítsen egy interfészt ITablazatView néven.
2. Az interfész tartalmazzon egy tapanyag tipusú BindingList elemet és azokat a
paramétereket, amelyek a repository GetAllTapanyag metódusához szükségesek.
3. Készítsen egy másik interfészt ITapanyagView néven.
4. Az interfész tartalmozzon egy tapanyag típusú tulajdonságot.
