# Loggare

Enkelt Windows-program skrivet i C# för att göra enkla logg-anteckningar när man arbetar vid datorn. Loggarna kommer att sparas med dagens datum och tid. För närvarande går det inte att logga på historiska datum. Däremot kan man ändra texten i loggar som man skrivit historiskt. 

Använder [sqlite-net](https://github.com/praeclarum/sqlite-net) för att lagra varje logg-text med datum. Ladda ner den senaste versionen [här](https://github.com/johandersson/Loggare/releases). Ladda ner zip-filen och zippa upp den. Kör sedan programmet Loggare.exe.


![Skärmbild](/images/screenshot.JPG?raw=true "Skärmbild av Loggare")

# Funktioner

## Logga
Alla datum som har loggar markeras i kalendern med fetstil. Klicka på ett datum för att se alla loggar för det datumet i listan längst ner till vänster.

- Skriv text i den översta textrutan för att logga.
- I listan längst ner till vänster visas sparade loggar. Klicka på någon logg i listan för att se den loggade texten.
- För att att kopiera en logg till urklipp. Högerklicka på en logg i listan och välj Kopiera till urklipp.

## Editera och ta bort en logg
- För att editera loggarna, klicka i den nedre textrutan, skriv och klicka sedan på Spara.
- För att ta bort en logg, högerklicka på en logg i listan välj Ta bort.

## Exportera

- För att exportera loggar för ett specifikt datum, välj datum i kalendern, klicka på menyn Arkiv -> Export -> Valt datum. 
- För att exportera alla loggar klicka på menyn Arkiv -> Alla datum. Exporten sker till en text-fil som öppnas i Windows Anteckningar. 

# Planerad kommande funktionalitet
- Logga på historiska datum
- Exportera till Word-fil.

# Licens
MIT-license
