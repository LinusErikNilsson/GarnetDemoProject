FROM mcr.microsoft.com/dotnet/runtime:8.0

WORKDIR /app
COPY ./app ./

EXPOSE 3278

ENTRYPOINT ["dotnet", "/app/GarnetServer.dll", "--config-import-path", "/app/garnet.conf"]