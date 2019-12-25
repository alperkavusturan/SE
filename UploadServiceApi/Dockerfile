FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["UploadServiceApi/UploadServiceApi.csproj", "UploadServiceApi/"]
RUN dotnet restore "UploadServiceApi/UploadServiceApi.csproj"
COPY . .
WORKDIR "/src/UploadServiceApi"
RUN dotnet build "UploadServiceApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "UploadServiceApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "UploadServiceApi.dll"]