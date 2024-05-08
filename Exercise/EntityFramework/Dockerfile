FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["EntityFramework/EntityFramework.csproj", "EntityFramework/"]
RUN dotnet restore "EntityFramework/EntityFramework.csproj"
COPY . .
WORKDIR "/src/EntityFramework"
RUN dotnet build "EntityFramework.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EntityFramework.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EntityFramework.dll"]
