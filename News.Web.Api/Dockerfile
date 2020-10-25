#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["News.Web.Api/News.Web.Api.csproj", "News.Web.Api/"]
RUN dotnet restore "News.Web.Api/News.Web.Api.csproj"
COPY . .
WORKDIR "/src/News.Web.Api"
RUN dotnet build "News.Web.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "News.Web.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "News.Web.Api.dll"]