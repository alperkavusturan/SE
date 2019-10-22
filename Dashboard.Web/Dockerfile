FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Dashboard.Web/Dashboard.Web.csproj", "Dashboard.Web/"]
RUN dotnet restore "Dashboard.Web/Dashboard.Web.csproj"
COPY . .
WORKDIR "/src/Dashboard.Web"
RUN dotnet build "Dashboard.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dashboard.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dashboard.Web.dll"]