FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /src
COPY ["WebApiIdentity/WebApiIdentity.csproj", "WebApiIdentity/"]

RUN dotnet restore "WebApiIdentity/WebApiIdentity.csproj"
COPY . .

WORKDIR "/src/WebApiIdentity"
RUN dotnet build "WebApiIdentity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebApiIdentity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApiIdentity.dll","--urls","http://0.0.0.0:4003"]