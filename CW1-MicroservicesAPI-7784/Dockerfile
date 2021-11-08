#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["CW1-MicroservicesAPI-7784/CW1-MicroservicesAPI-7784.csproj", "CW1-MicroservicesAPI-7784/"]
RUN dotnet restore "CW1-MicroservicesAPI-7784/CW1-MicroservicesAPI-7784.csproj"
COPY . .
WORKDIR "/src/CW1-MicroservicesAPI-7784"
RUN dotnet build "CW1-MicroservicesAPI-7784.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CW1-MicroservicesAPI-7784.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CW1-MicroservicesAPI-7784.dll"]