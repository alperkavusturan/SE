FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["ArtistService.Api/", "ArtistService.Api/"]
COPY ["ArtistService.Domain/", "ArtistService.Domain/"]
COPY ["ArtistService.Data/", "ArtistService.Data/"]
COPY ["ArtistService.Business/", "ArtistService.Business/"]
RUN dotnet restore "ArtistService.Api/ArtistService.Api.csproj"
COPY . .
WORKDIR "/src/ArtistService.Api"
RUN dotnet build "ArtistService.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ArtistService.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENV ASPNETCORE_URLS http://*:60188
ENV ASPNETCORE_ENVIRONMENT docker
EXPOSE 60188
ENTRYPOINT ["dotnet", "ArtistService.Api.dll"]