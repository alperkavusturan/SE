FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["TicketingService.Api/", "TicketingService.Api/"]
COPY ["TicketingService.Data/", "TicketingService.Data/"]
COPY ["TicketingService.Domain/", "TicketingService.Domain/"]
COPY ["TicketingService.Business/", "TicketingService.Business/"]
RUN dotnet restore "TicketingService.Api/TicketingService.Api.csproj"
COPY . .
WORKDIR "/src/TicketingService.Api"
RUN dotnet build "TicketingService.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TicketingService.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENV ASPNETCORE_URLS http://*:52824
ENV ASPNETCORE_ENVIRONMENT docker
EXPOSE 52824
ENTRYPOINT ["dotnet", "TicketingService.Api.dll"]