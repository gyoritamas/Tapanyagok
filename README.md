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

## Presenter réteg
* Készítsen egy osztályt TablazatPresenter néven a Presenter mappában. Az osztálynak legyen egy TapanyagRepository és egy ITablazatView tulajdonsága.
* Hozzon létre egy konstruktort, ami megköveteli ITablazatView paramétert, majd a paraméter értéket adja át a presenter azonos tulajdonságának.
* Hozzon létre egy metódust LoadData néven, ami az ITablazatView listáját feltölti az adatbázisban lévő elemekkel.
* Készítsen további metódusokat Add, Remove, Modify, Save néven, amik a repository hozzá tartozó CRUD műveleteit hívja meg.
  * Az Add metódushoz egy tapanyag típusú paraméter szükséges.
  * A Modify metódushoz egy index és egy tapanyag típusú paraméter fog kellene. Az index alapján a listában lehet kikeresni az elemet és frissíteni a nézetben, majd a repository-nak átadni.
  * A Remove metódushoz elég egy index paraméter.

## UI réteg
### TablazatForm
* Készítse el a csatolt kép szerint a TablazatForm képernyőt a Views mappában.
* A Program.cs írja át a következő sort a megadott Form-ra: Application.Run(new TablazatForm());
* A következő elemek szerepeljenek benne:
  * Eszköztár menüszalag (ToolStrip): 4 gomb (Mentés, Új, Törlés, Keresés), 1 szöveges beviteli mező (a keresésnek)
  * Táblázatnézet (DataGridView – későbbiekben DGV). Két tulajdonsága legyen False értékű: AllowUserToAddRows, AllowUserToDeleteRows.
  * 4 navigáló gomb (Button) és középen egy címke (Label)
  * Context MenuStrip, 2 elemmel (Szerkesztés, Törlés). Legyen társítva a DataGridView-hoz!
* Impelementálja a Form kód részébe az ITablazatView interfészt és társítsa a Form vezérlőelemeivel (Control).
* A kód részben szerepeljen a TablazatPresenter, amit a Form létrehozásakor példányosít!
* A felső menüszalag gombjainak és a Context menü elemeinek hozzon létre klikk eseményeket.
* Kösse össze az interfészben deklarált bindingListet a DGV elemmel. Készítse el a következő műveleteket:
  * DGV elemeinek lapozása, keresése, sorrendezése.
  * A TablazatForm betöltésekor töltődjön fel a DGV elemekkel.
* A Context menü Törlés gombja és a felső eszköztár Törlés gombja törölje ki a kijelölt elemeket a táblázatból.

### TapanyagForm
* Készítse el a mellékelt kép alapján a TapanyagForm képernyőt!
* A következő elemek szerepeljenek benne:
  * 5 db címke elem (Label)
  * Szöveges beviteli elem (TextBox MultiLine)
  * 4 db szám beviteli elem (NumbericUpDown). Állítsa be a DecimalPlaces értékét 1-re.
  * 2 db gomb (OK, Mégse). A Button elemeknek állítsa be a DialogResult érékét OK-ra és Cancel-re.
* A TapanyagForm kód részében implementálja az ITapanyagView interfészt!
  * Az új tapanyag tulajdonság értékét társítsa a form beviteli elemeivel.
  * Segítségül hozzon létre egy belső egész számos változót az elsődleges kulcs kezelésére (int id).

### TablazatForm
* Az Új gomb lenyomáskor jelenlen meg az elkészült TapanyagForm dialógus ablaka! Az OK gomb lenyomása után adódjon hozzá az elem a DGV-hez és az adatbázisba.
* A Szerkesztés gomb lenyomásakor jelenlen meg a TapanyagForm dialógus a megadott sor értékeivel. Az OK gomb lenyomása után frissítse a DGV sorát és az adatbázis rekordot is.
