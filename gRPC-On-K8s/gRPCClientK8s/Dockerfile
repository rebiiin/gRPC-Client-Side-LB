FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["GrpcClientK8s.csproj", "./"]
RUN dotnet restore "GrpcClientK8s.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "GrpcClientK8s.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GrpcClientK8s.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GrpcClientK8s.dll"]
