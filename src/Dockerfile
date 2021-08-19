FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["az-app-config-dotnet-sample/az-app-config-dotnet-sample.csproj", "./"]
RUN dotnet restore "az-app-config-dotnet-sample.csproj"
COPY az-app-config-dotnet-sample/ .
WORKDIR "/src/"
RUN dotnet build "az-app-config-dotnet-sample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "az-app-config-dotnet-sample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "az-app-config-dotnet-sample.dll"]

RUN apt-get update && apt-get install -y curl
