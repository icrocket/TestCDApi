FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["TestCDApi/TestCDApi.csproj", "TestCDApi/"]
RUN dotnet restore "TestCDApi/TestCDApi.csproj"
COPY . .
WORKDIR "/src/TestCDApi"
RUN dotnet build "TestCDApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestCDApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestCDApi.dll"]