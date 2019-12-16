FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["TrackService.Api/TrackService.Api.csproj", "TrackService.Api/"]
RUN dotnet restore "TrackService.Api/TrackService.Api.csproj"
COPY . .
WORKDIR "/src/TrackService.Api"
RUN dotnet build "TrackService.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TrackService.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TrackService.Api.dll"]