dotnet ef migrations add Initial --startup-project MercadoLivre  --project MercadoLivre --context UsuarioDbContext 

dotnet ef database update --startup-project MercadoLivre --project MercadoLivre --context UsuarioDbContext 

=

dotnet ef migrations add AddIdentity --startup-project MercadoLivre  --project MercadoLivre --context IdentityDBContext

dotnet ef database update --project MercadoLivre --context IdentityDBContext


