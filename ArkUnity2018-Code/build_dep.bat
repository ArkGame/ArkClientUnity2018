@echo off

echo Building dependencies...
cd Assets

REM ######################################################################################################
echo Building GameFramework...

if exist GameFramework (rd GameFramework /q /s)
git clone https://github.com/EllanJiang/UnityGameFramework.git

echo Building GameFramework Success.

cd GameMain
REM ######################################################################################################
echo BUilding ArkGameClient

if exist ArkGameClient (rd ArkGameClient /q /s)
git clone https://github.com/ArkGame/ArkGameClient.git

cd ArkGameClient
call build_dep.bat
echo Building ArkGameClient Success.