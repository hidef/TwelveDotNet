FROM microsoft/dotnet:latest

RUN ["mkdir", "/app"]

COPY TwelveDotNet/project.json /app

WORKDIR /app

RUN ["dotnet", "restore"]

COPY TwelveDotNet /app

RUN ["dotnet", "build"]

EXPOSE 5000/tcp

CMD ["dotnet", "run", "--server.urls", "http://*:5000"]
