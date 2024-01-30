# HGD Game Launcher
Game launcher to launch Game Jam games.

# How to Use
1. Clone the repository to your local machine.
1. Download the games to be displayed from the club Google Drive, i.e.
```https://drive.google.com/drive/folders/1BfsKjhs85AAJOebjDKF0JaSLbC-H_edz```
1. Download the game cover images from the club Google Drive, i.e.
```https://drive.google.com/drive/folders/1MZuO-qJCorpd5OEtnI7Nw0pFrHZ_0E62```
1. Unzip and add games to the game folder, i.e.
```{root}\game-launcher\Game Launcher\Builds\Game Builds```
1. Unzip and add images to the image asset folder, i.e.
```{root}\game-launcher\Game Launcher\Assets\Resources```
1. Open the application with Unity version ***2022.3.17*** or any ***2022.3.x*** version
1. Build the game in the launcher folder, i.e.
```{root}\game-launcher\Game Launcher\Builds\Launcher Build```
1. The launcher is now ready to use

# How to Add Games
1. (**EXE Only**) Upload the game folder to the club Google Drive, i.e.
```https://drive.google.com/drive/folders/1BfsKjhs85AAJOebjDKF0JaSLbC-H_edz```
1. Upload cover image to the club Google Drive, i.e.
```https://drive.google.com/drive/folders/1MZuO-qJCorpd5OEtnI7Nw0pFrHZ_0E62```
1. Edit game_list config and add a new entry for your game, config location:
```E:\Unity Projects\Tracked Projects\game-launcher\Game Launcher\Assets\Config\games_list.json```
1. Set the game title
1. (**EXE Only**) Set the path
1. (**Web Only**) Set the URL
1. If using web url, set the useURL to true. Else set to false
1. Add the image name to the imagePath, do not include the file extension
1. Push changes to github repository

# Notes
+ Try to keep a minimum of 4 games listed. The UI gitches out a bit if it's less than 4 games.