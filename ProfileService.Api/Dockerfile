FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["ProfileService.Api/", "ProfileService.Api/"]
COPY ["ProfileService.Domain/", "ProfileService.Domain/"]
COPY ["ProfileService.Data/", "ProfileService.Data/"]
COPY ["ProfileService.Business/", "ProfileService.Business/"]
RUN dotnet restore "ProfileService.Api/ProfileService.Api.csproj"
COPY . .
WORKDIR "/src/ProfileService.Api"
RUN dotnet build "ProfileService.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ProfileService.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENV ASPNETCORE_URLS http://*:54272
ENV ASPNETCORE_ENVIRONMENT docker
EXPOSE 54272
ENTRYPOINT ["dotnet", "ProfileService.Api.dll"]