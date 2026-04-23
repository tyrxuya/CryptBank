@echo off
setlocal EnableExtensions EnableDelayedExpansion
chcp 65001 >nul

title CryptBank Starter

REM ============================================
REM CryptBank START.bat
REM - Checks Docker availability
REM - Starts Docker containers
REM - Builds project in Release mode
REM - Tries to apply EF Core migrations
REM - Launches the app executable
REM - Waits for the app to close
REM - Stops Docker containers automatically
REM ============================================

cd /d "%~dp0"

call :banner

call :check_command docker "Docker"
if errorlevel 1 goto :fail

call :check_command dotnet ".NET SDK"
if errorlevel 1 goto :fail

call :check_docker_engine
if errorlevel 1 goto :fail

call :find_compose_file
if errorlevel 1 goto :fail

call :start_containers
if errorlevel 1 goto :fail

call :build_release
if errorlevel 1 goto :fail

call :apply_migrations
if errorlevel 1 (
    echo.
    echo [WARN] Database migration step failed.
    echo The app may still work if the database is already up to date.
    echo.
    choice /M "Do you want to continue and try to start the app anyway"
    if errorlevel 2 goto :shutdown_and_end
)

call :find_exe
if errorlevel 1 goto :shutdown_and_fail

call :launch_app
if errorlevel 1 goto :shutdown_and_fail

echo.
echo ============================================
echo CryptBank finished successfully.
echo ============================================
goto :end

:banner
echo ============================================
echo           CryptBank Smart Starter
echo ============================================
echo.
exit /b 0

:check_command
where %~1 >nul 2>nul
if errorlevel 1 (
    echo [ERROR] %~2 was not found in PATH.
    exit /b 1
)
echo [OK] %~2 detected.
exit /b 0

:check_docker_engine
echo.
echo [CHECK] Verifying Docker engine...
docker info >nul 2>nul
if errorlevel 1 (
    echo [ERROR] Docker is installed, but the engine is not running.
    echo Start Docker Desktop and try again.
    exit /b 1
)
echo [OK] Docker engine is running.
exit /b 0

:find_compose_file
set "COMPOSE_FILE="
if exist "docker-compose.yml" set "COMPOSE_FILE=docker-compose.yml"
if exist "docker-compose.yaml" set "COMPOSE_FILE=docker-compose.yaml"
if exist "compose.yml" set "COMPOSE_FILE=compose.yml"
if exist "compose.yaml" set "COMPOSE_FILE=compose.yaml"

if not defined COMPOSE_FILE (
    echo [ERROR] No compose file found in project root.
    echo Expected one of:
    echo   docker-compose.yml
    echo   docker-compose.yaml
    echo   compose.yml
    echo   compose.yaml
    exit /b 1
)

echo [OK] Compose file found: %COMPOSE_FILE%
exit /b 0

:start_containers
echo.
echo [STEP] Starting Docker containers...
docker compose -f "%COMPOSE_FILE%" up -d
if errorlevel 1 (
    echo [ERROR] Failed to start Docker containers.
    exit /b 1
)
echo [OK] Containers are up.
exit /b 0

:build_release
echo.
echo [STEP] Building solution in Release mode...
dotnet build -c Release
if errorlevel 1 (
    echo [ERROR] Release build failed.
    exit /b 1
)
echo [OK] Build completed.
exit /b 0

:apply_migrations
echo.
echo [STEP] Applying database migrations...

dotnet ef database update --project Data --startup-project View >nul 2>nul
if not errorlevel 1 (
    echo [OK] Migrations applied using --project Data --startup-project View
    exit /b 0
)

dotnet ef database update --project Data --startup-project Data >nul 2>nul
if not errorlevel 1 (
    echo [OK] Migrations applied using --project Data --startup-project Data
    exit /b 0
)

dotnet ef database update >nul 2>nul
if not errorlevel 1 (
    echo [OK] Migrations applied using default dotnet ef configuration.
    exit /b 0
)

echo [ERROR] Could not apply EF Core migrations automatically.
echo Make sure dotnet-ef is installed and the EF configuration is valid.
exit /b 1

:find_exe
echo.
echo [STEP] Searching for application executable...

set "EXE_PATH="

for %%F in ("View\bin\Release\net8.0-windows\*.exe") do (
    set "NAME=%%~nxF"
    if /I not "!NAME!"=="apphost.exe" if /I not "!NAME!"=="testhost.exe" (
        set "EXE_PATH=%%~fF"
        goto :found_exe
    )
)

for /r %%F in (*.exe) do (
    set "FULL=%%~fF"
    set "NAME=%%~nxF"
    echo !FULL! | find /I "bin\Release\net8.0-windows" >nul
    if not errorlevel 1 (
        if /I not "!NAME!"=="apphost.exe" if /I not "!NAME!"=="testhost.exe" (
            set "EXE_PATH=%%~fF"
            goto :found_exe
        )
    )
)

:found_exe
if not defined EXE_PATH (
    echo [ERROR] No executable was found in a Release output folder.
    exit /b 1
)

echo [OK] Executable found:
echo      !EXE_PATH!
exit /b 0

:launch_app
echo.
echo [STEP] Launching application...
start "" /wait "!EXE_PATH!"
if errorlevel 1 (
    echo [ERROR] Application crashed or failed to start.
    exit /b 1
)

echo.
echo [INFO] Application closed.
call :stop_containers
exit /b 0

:stop_containers
echo.
echo [STEP] Stopping Docker containers...
docker compose -f "%COMPOSE_FILE%" down
if errorlevel 1 (
    echo [WARN] Failed to stop containers automatically.
    echo You may need to run: docker compose down
    exit /b 1
)
echo [OK] Containers stopped successfully.
exit /b 0

:shutdown_and_fail
echo.
echo [INFO] Attempting to stop containers before exit...
call :stop_containers
goto :fail

:shutdown_and_end
echo.
echo [INFO] Attempting to stop containers before exit...
call :stop_containers
goto :end

:fail
echo.
echo ============================================
echo Startup failed.
echo ============================================
pause

:end
echo.
echo Press any key to close the launcher...
pause >nul
endlocal
exit /b