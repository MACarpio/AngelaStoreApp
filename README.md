# AngelaStoreApp

dotnet tool install --global dotnet-aspnet-codegenerator --version 5.0.2

dotnet aspnet-codegenerator identity -dc frutosecoapp.Data.ApplicationDbContext --files "Account.Register;Account.Login"

dotnet tool update --global dotnet-ef --version 5.0.9

Cambio de tipo de dato en BD de int4 a bool:
#TwoFactorEnable
#EmailConfirmed
#PhoneNumberConfirmed
#LockOutEnable