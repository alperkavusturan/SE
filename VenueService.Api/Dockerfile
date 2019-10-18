FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["VenueService.Api/", "VenueService.Api/"]
COPY ["VenueService.Business/", "VenueService.Business/"]
COPY ["VenueService.Data/", "VenueService.Data/"]
COPY ["VenueService.Domain/", "VenueService.Domain/"]
RUN dotnet restore "VenueService.Api/VenueService.Api.csproj"
COPY . .
WORKDIR "/src/VenueService.Api"
RUN dotnet build "VenueService.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "VenueService.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENV ASPNETCORE_URLS http://*:57641
ENV ASPNETCORE_ENVIRONMENT docker
EXPOSE 57641
ENTRYPOINT ["dotnet", "VenueService.Api.dll"]