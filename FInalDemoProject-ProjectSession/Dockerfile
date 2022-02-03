#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["FInalDemoProject-ProjectSession/FInalDemoProject-ProjectSession.csproj", "FInalDemoProject-ProjectSession/"]
COPY ["Data_Layer/Data_Layer.csproj", "Data_Layer/"]
COPY ["Entity_Layer/Entity_Layer.csproj", "Entity_Layer/"]
COPY ["Repository_Layer/Repository_Layer.csproj", "Repository_Layer/"]
COPY ["ServiceLayer/ServiceLayer.csproj", "ServiceLayer/"]
RUN dotnet restore "FInalDemoProject-ProjectSession/FInalDemoProject-ProjectSession.csproj"
COPY . .
WORKDIR "/src/FInalDemoProject-ProjectSession"
RUN dotnet build "FInalDemoProject-ProjectSession.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FInalDemoProject-ProjectSession.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FInalDemoProject-ProjectSession.dll"]