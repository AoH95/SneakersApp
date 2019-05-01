# SneakersApp

- SneakersApp : Web project
	- Class : Contient nos validators
	- Controllers : Contient nos Views Controllers et notre CRUD
	- Logger : Contient nos fichiers de log. 1 par jour.
	- Migrations : Contient toutes les migrations pour la database
	- Models : Contient les models pour nos views
	- Views : Contient les fichiers front
	- Appsettings : Contient notre connection string dans laquelle sera push les éléments sensibles d'une chaine de connexion.
    - Handlers : Contient les task de logique des claims
    - Requirements : Contients les "models" des claims
- SneakersApp.Data : Models
	- Models : Les models utilisés pour communiquer les informations entre les services et le web project
	- IColllection : interface définissant les methods utilisés dans le service Collection
	- IShoe : interface définissant les methods utilisés dans le service Shoe
- SneakersApp.Services : Service pour nos models
	- CollectionsService : Toutes les methods utilisés pour traiter les data relatives aux collections
	- ShoeService : Toutes les methods utilisés pour traiter les data relatives aux chaussures
- SneakersApp.xUnit : Tests unitaires

# Secret manager

{
    "AzureStorageConnectionString": "Votre chaine de connexion",
    "DbServer": "Votre serveur",
    "DbUser": "Votre user",
    "DbPassword": "Votre MDP",
}

Ne pas oublier de modifier l'attribut "Initial Catalog" par le votre dans la chaine de connexion.

( Le contenu de notre secret manager est disponible dans le mail )