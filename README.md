# CarChatAI - Assistant IA pour la recherche automobile

## Présentation du projet

CarChatAI est une application web Blazor qui permet aux utilisateurs de rechercher, filtrer et comparer des annonces de voitures provenant de LeBonCoin. L'application utilise l'intelligence artificielle pour améliorer l'expérience utilisateur en offrant:

- **Recherche intelligente**: Trouvez des voitures selon vos critères spécifiques
- **Filtrage IA**: Affinez vos résultats avec des filtres basés sur l'IA
- **Comparaison détaillée**: Comparez plusieurs véhicules et obtenez une analyse complète

L'interface utilisateur est intuitive et réactive, offrant une expérience fluide sur tous les appareils.

## Fonctionnalités principales

- Recherche de voitures avec des requêtes en langage naturel
- Filtrage manuel (prix, année, kilométrage, carburant)
- Filtrage avancé par IA des résultats
- Sélection et comparaison de plusieurs véhicules
- Affichage des résultats avec carrousel d'images
- Interface responsive adaptée à tous les appareils

## Prérequis

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/fr/vs/) ou [Visual Studio Code](https://code.visualstudio.com/)
- [API CarChatAI](https://github.com/Onur45500/csharp-net-swagger-carchatai-api) (backend requis)

## Installation et configuration

### 1. Cloner les dépôts

```bash
# Cloner le frontend Blazor
git clone https://github.com/Onur45500/csharp-net-blazor-carchat.git

# Cloner l'API backend (nécessaire au fonctionnement)
git clone https://github.com/Onur45500/csharp-net-swagger-carchatai-api.git
```

### 2. Configurer et démarrer l'API backend

L'API backend est **indispensable** au fonctionnement de l'application. Elle gère les requêtes de recherche, le filtrage IA et la comparaison des véhicules.

```bash
cd csharp-net-swagger-carchatai-api
dotnet restore
dotnet run
```

L'API sera accessible à l'adresse: `http://localhost:5164`

### 3. Configurer et démarrer l'application Blazor

```bash
cd csharp-net-blazor-carchat
dotnet restore
dotnet run
```

L'application sera accessible à l'adresse: `http://localhost:5272`

## Structure du projet

- **Components/Pages**: Pages Blazor de l'application
- **Models**: Classes de modèles de données
- **Services**: Services pour la communication avec l'API
- **wwwroot**: Ressources statiques (CSS, JS, images)

## Utilisation

1. **Recherche de voitures**:
   - Entrez une requête en langage naturel (ex: "Trouve-moi des SUV diesel à moins de 20000€")
   - Les résultats s'affichent sous forme de cartes avec images et informations

2. **Filtrage des résultats**:
   - Utilisez les filtres manuels (prix, année, kilométrage, carburant)
   - Activez le filtre IA et entrez une requête spécifique pour affiner les résultats

3. **Comparaison de véhicules**:
   - Sélectionnez plusieurs voitures en cochant les cases correspondantes
   - Posez une question sur les véhicules sélectionnés
   - Consultez l'analyse détaillée générée par l'IA

## Dépendances principales

- **Blazor Server**: Framework web pour l'interface utilisateur
- **Markdig**: Traitement du markdown pour l'affichage des comparaisons
- **Bootstrap 5**: Framework CSS pour le design responsive
- **API CarChatAI**: Backend pour le traitement des requêtes IA

## Remarques importantes

- L'application nécessite une connexion à l'API backend pour fonctionner
- Les filtres IA et la sélection pour comparaison sont mutuellement exclusifs
- Toutes les annonces sont issues de LeBonCoin.fr

## Licence

Ce projet est sous licence MIT.
