#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ImmageEffects/ImmageEffects.csproj", "ImmageEffects/"]
RUN dotnet restore "ImmageEffects/ImmageEffects.csproj"
COPY . .
WORKDIR "/src/ImmageEffects"
RUN dotnet build "ImmageEffects.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ImmageEffects.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ImmageEffects.dll"]