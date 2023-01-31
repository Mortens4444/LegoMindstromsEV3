docker build -t ev3-cli-image -f dockerfile .

if %ERRORLEVEL% NEQ 0 goto END

REM docker images

REM Run as image
REM https://docs.docker.com/engine/reference/commandline/run/
REM The --device option is only supported on process-isolated Windows containers.
REM This option fails if the container isolation is hyperv or when running Linux Containers on Windows (LCOW).
docker run --isolation=process --rm --name ev3-cli-container -it -a stderr -a stdout ev3-cli-image --device=class/86E0D1E0-8089-11D0-9CE4-08003E301F73

:END

pause