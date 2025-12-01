# 🛒 Projet PrinBoutique – Application de Gestion de Boutique (C# / Windows Forms)

Application Windows Forms en C# permettant de gérer une boutique en ligne avec gestion complète des clients, produits, commandes, fournisseurs et catégories. Interface moderne avec connexion MySQL et génération de documents PDF.

## ✨ Fonctionnalités principales

- 🔐 **Système de connexion** (authentification utilisateur)
- 👥 **Gestion des clients** (CRUD complet)
- 📦 **Gestion des produits** (stock, prix, catégories)
- 🛍️ **Gestion des commandes** (création, modification, suivi)
- 📋 **Gestion des lignes de commandes** (détails des commandes)
- 🏢 **Gestion des fournisseurs** (informations et contacts)
- 📂 **Gestion des catégories** (organisation des produits)
- 📄 **Génération de documents PDF** (factures, commandes)
- 💾 **Base de données MySQL** (stockage et gestion des données)
- 🎨 **Interface Windows Forms moderne**

👉 Ajoute ici un screenshot ou un GIF de ton interface, ça fait une énorme différence.

## 🛠️ Technologies utilisées

- **C# / .NET Framework 4.7.2**
- **Windows Forms**
- **MySQL** (MySql.Data)
- **iTextSharp 5.5.13.4** (génération de PDF)
- **BouncyCastle.Cryptography 2.4.0** (cryptographie)
- **MSTest** (tests unitaires)

## 🏗️ Architecture du projet

```
/PrinBoutique
 ├── PrinBoutique/
 │   ├── FrmConnexion.cs              → Fenêtre de connexion
 │   ├── FrmDemarrage.cs              → Menu principal / Accueil
 │   ├── FrmGestionClients.cs         → Gestion des clients
 │   ├── FrmGestionProduits.cs        → Gestion des produits
 │   ├── FrmGestionCommandes.cs       → Gestion des commandes
 │   ├── FrmGestionDeLaCommande.cs     → Détails d'une commande
 │   ├── FrmGestionLignedecommandes.cs → Gestion des lignes de commandes
 │   ├── FrmGestionFournisseurs.cs    → Gestion des fournisseurs
 │   ├── FrmGestionCategories.cs      → Gestion des catégories
 │   ├── GestionInterface.cs          → Utilitaires d'interface
 │   └── Program.cs                   → Point d'entrée
 ├── GestionBD/
 │   ├── GestionBoutique.cs           → Classe principale de gestion BD
 │   ├── GestionClients.cs            → Opérations CRUD clients
 │   ├── GestionProduits.cs           → Opérations CRUD produits
 │   ├── GestionCommandes.cs          → Opérations CRUD commandes
 │   ├── GestionLigneDeCommandes.cs   → Opérations CRUD lignes de commandes
 │   ├── GestionFournisseurs.cs       → Opérations CRUD fournisseurs
 │   ├── GestionCategories.cs         → Opérations CRUD catégories
 │   ├── GestionPS.cs                 → Procédures stockées
 │   └── MysqlConfig.cs               → Configuration MySQL
 ├── PrinBoutique.Tests/
 │   └── UnitTest1.cs                 → Tests unitaires
 └── PrinBoutique.sln                 → Solution Visual Studio
```

## 🚀 Installation & exécution

### Prérequis

- **Visual Studio 2017+** (ou version compatible)
- **.NET Framework 4.7.2**
- **MySQL Server** (local ou distant)
- **Base de données** `prin_boutique` créée

### Cloner le projet

```bash
git clone https://github.com/cedric-prin/PrinBoutique.git
cd PrinBoutique
```

### Configuration de la base de données

1. Créer la base de données MySQL `prin_boutique`
2. Modifier les paramètres de connexion dans `GestionBD/MysqlConfig.cs` :

```csharp
public const string SERVEUR = "localhost";
public const string BASE = "prin_boutique";
public static string UTILISATEUR = "root";
public static string MOT_DE_PASSE = "";
```

### Ouvrir la solution dans Visual Studio

```
PrinBoutique.sln
```

### Restaurer les packages NuGet

Les packages suivants seront restaurés automatiquement :
- `MySql.Data`
- `iTextSharp.5.5.13.4`
- `BouncyCastle.Cryptography.2.4.0`
- `MSTest.TestAdapter.2.2.10`
- `MSTest.TestFramework.2.2.10`

### Lancer le projet

1. Compiler la solution (F6)
2. Exécuter le projet (F5)
3. Se connecter avec les identifiants configurés

## 📖 Utilisation

1. **Connexion** : Saisir les identifiants de connexion
2. **Menu principal** : Accéder aux différentes sections de gestion
3. **Gestion des clients** : Ajouter, modifier, supprimer des clients
4. **Gestion des produits** : Gérer le catalogue de produits
5. **Gestion des commandes** : Créer et suivre les commandes
6. **Génération de PDF** : Exporter les documents (factures, commandes)

## 🔧 Fonctionnalités techniques

- **Connexion MySQL** : Gestion centralisée via `GestionBoutique`
- **CRUD complet** : Opérations Create, Read, Update, Delete pour toutes les entités
- **Procédures stockées** : Utilisation de procédures MySQL pour les opérations complexes
- **Génération PDF** : Création de documents PDF avec iTextSharp
- **Tests unitaires** : Suite de tests avec MSTest

## 📄 Licence

Ce projet est sous licence propriétaire. Tous droits réservés © Cédric Prin.

👉 Aucun usage, copie ou distribution sans autorisation.

## 👤 Auteur

**Cédric Prin**

- GitHub : https://github.com/cedric-prin
- LinkedIn : https://www.linkedin.com/in/cedric-prin-dev/

