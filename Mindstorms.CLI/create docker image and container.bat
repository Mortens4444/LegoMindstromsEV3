docker build -t ev3-cli-image -f dockerfile .

if %ERRORLEVEL% NEQ 0 goto END

REM docker images
REM Run as image
REM docker run --rm -it ev3-cli-image

docker container create -it --name ev3-cli-container ev3-cli-image
docker start -ai ev3-cli-container

:END
