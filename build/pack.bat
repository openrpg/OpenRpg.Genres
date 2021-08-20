set version=0.7.00
dotnet pack ../src/OpenRpg.Genres -c Release -o ../../_dist /p:version=%version%
dotnet pack ../src/OpenRpg.Genres.Fantasy -c Release -o ../../_dist /p:version=%version%
dotnet pack ../src/OpenRpg.Genres.Scifi -c Release -o ../../_dist /p:version=%version%