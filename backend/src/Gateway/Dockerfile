# Gateway Dockerfile (sửa lại chuẩn như API)

# Base runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj file đầu tiên
COPY Gateway/Gateway.csproj Gateway/
RUN dotnet restore Gateway/Gateway.csproj

# Copy toàn bộ mã nguồn sau khi restore
COPY . .
RUN dotnet publish Gateway/Gateway.csproj -c Release -o /app/publish

# Final image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Gateway.dll"]