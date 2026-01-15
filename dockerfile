
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["SklepAPI/SklepAPI.csproj", "SklepAPI/"]
RUN dotnet restore "SklepAPI/SklepAPI.csproj"

COPY . .
WORKDIR "/src/SklepAPI"
RUN dotnet build "SklepAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SklepAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "SklepAPI.dll"]