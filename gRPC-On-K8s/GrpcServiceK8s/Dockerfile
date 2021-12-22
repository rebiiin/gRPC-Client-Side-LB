FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /src
COPY ["GrpcServiceK8s.csproj", "./"]
RUN dotnet restore "GrpcServiceK8s.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "GrpcServiceK8s.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GrpcServiceK8s.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GrpcServiceK8s.dll"]
