﻿FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["ConsoleApp7/ConsoleApp7.csproj", "ConsoleApp7/"]
RUN dotnet restore "ConsoleApp7/ConsoleApp7.csproj"
COPY . .
WORKDIR "/src/ConsoleApp7"
RUN dotnet build "ConsoleApp7.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ConsoleApp7.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ConsoleApp7.dll"]
