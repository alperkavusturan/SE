FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["EventService.Api/", "EventService.Api/"]
COPY ["EventService.Domain/", "EventService.Domain/"]
COPY ["EventService.Business/", "EventService.Business/"]
COPY ["EventService.Data/", "EventService.Data/"]
RUN dotnet restore "EventService.Api/EventService.Api.csproj"
COPY . .
WORKDIR "/src/EventService.Api"
RUN dotnet build "EventService.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "EventService.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENV ASPNETCORE_URLS http://*:59358
ENV ASPNETCORE_ENVIRONMENT docker
EXPOSE 59358
ENTRYPOINT ["dotnet", "EventService.Api.dll"]