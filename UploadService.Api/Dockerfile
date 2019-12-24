FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["UploadService.Api/UploadService.Api.csproj", "UploadService.Api/"]
RUN dotnet restore "UploadService.Api/UploadService.Api.csproj"
COPY . .
WORKDIR "/src/UploadService.Api"
RUN dotnet build "UploadService.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UploadService.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENV ASPNETCORE_URLS http://*:52824
ENV ASPNETCORE_ENVIRONMENT docker
EXPOSE 60300
ENTRYPOINT ["dotnet", "UploadService.Api.dll"]
