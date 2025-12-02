# 🛒 Application de Gestion de Commandes  

**C# / WinForms / MySQL – Projet CRUD complet avec procédures, fonctions et triggers**



Une application de gestion commerciale permettant d'administrer les **clients**, **produits**, **commandes**, **lignes de commande**, **fournisseurs** et la mise à jour du stock en temps réel grâce à des **triggers MySQL**.



Développée en C# WinForms avec une architecture claire, ce projet simule une petite application de gestion utilisée en entreprise.



---



## 📁 Arborescence du projet

```
/PrinBoutique
 ├── PrinBoutique/
 │   ├── FrmConnexion.cs              → Fenêtre de connexion
 │   ├── FrmDemarrage.cs              → Menu principal / Accueil
 │   ├── FrmGestionClients.cs         → Gestion des clients
 │   ├── FrmGestionProduits.cs        → Gestion des produits
 │   ├── FrmGestionCommandes.cs       → Gestion des commandes
 │   ├── FrmGestionDeLaCommande.cs    → Détails d'une commande
 │   ├── FrmGestionLignedecommandes.cs → Gestion des lignes de commandes
 │   ├── FrmGestionFournisseurs.cs    → Gestion des fournisseurs
 │   ├── FrmGestionCategories.cs      → Gestion des catégories
 │   ├── GestionInterface.cs          → Utilitaires d'interface
 │   ├── Program.cs                   → Point d'entrée
 │   └── Properties/                  → Propriétés de l'application
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
 ├── docs/
 │   ├── assets/                      → Captures d'écran de l'application
 │   │   ├── gestion_commande.jpg
 │   │   ├── gestion_client.jpg
 │   │   ├── gestion_produit.jpg
 │   │   ├── gestion_categorie.jpg
 │   │   ├── gestion_fournisseur.jpg
 │   │   └── gestion_LigneDeCommande.jpg
 │   └── database/                    → Schémas de la base de données
 │       ├── tables.png
 │       ├── procedures.png
 │       ├── fonctions.png
 │       └── triggers.png
 ├── PrinBoutique.sln                 → Solution Visual Studio
 ├── README.md                        → Documentation du projet
 └── LICENSE                          → Licence du projet
```



---



## 🖼️ Captures du site (client + admin)

### Interface principale – Gestion des commandes

![Gestion Commande](./docs/assets/gestion_commande.jpg)



### Gestion des produits

![Gestion Produit](./docs/assets/gestion_produit.jpg)



### Gestion des clients

![Gestion Client](./docs/assets/gestion_client.jpg)



### Gestion des fournisseurs

![Gestion Fournisseur](./docs/assets/gestion_fournisseur.jpg)



### Gestion des catégories

![Gestion Catégorie](./docs/assets/gestion_categorie.jpg)



### Gestion des lignes de commande

![Gestion Ligne de Commande](./docs/assets/gestion_LigneDeCommande.jpg)



---



## 🗄️ Base de données (schémas + images)

L'ensemble des éléments SQL est documenté dans `docs/database`.



### 📁 Tables

![Tables](./docs/database/tables.png)



### ⚙️ Procédures stockées

![Procédures](./docs/database/procedures.png)



### 🧮 Fonctions SQL

![Fonctions](./docs/database/fonctions.png)



### 🔄 Triggers MySQL

![Triggers](./docs/database/triggers.png)



---



## ✨ Fonctionnalités (client + admin)

### 👤 Gestion des clients

- Ajout, modification et suppression de clients  

- Sélection et affichage instantané des informations  

- Chargement automatique des informations liées



### 🛍️ Gestion des produits

- CRUD complet produit  

- Stock mis à jour automatiquement  

- Affichage dynamique du prix unitaire et total  



### 📦 Gestion des commandes

- Création d'une commande liée à un client  

- Gestion des lignes de commande  

- Calcul automatique du total via une fonction SQL  

- Supprimer, actualiser, récapitulatif  



### 🏬 Gestion des fournisseurs

- Ajout / modification / suppression  

- Attribution des produits aux fournisseurs  



### 📊 Base de données avancée

- **Triggers** pour mise à jour automatique du stock  

- **Procédures stockées** pour simplifier les opérations  

- **Fonctions SQL** pour calcul du total d'une commande  

- Sécurisation des opérations via transactions internes



---



## ⚙️ Technologies utilisées

- **C# WinForms**  

- **MySQL**  

- **POO (Programmation Orientée Objet)**  

- **Xampp / WAMP**  

- **Procédures stockées**  

- **Triggers MySQL**  

- **Fonctions SQL**  

- **ADO.NET**



---



## 🚀 Installation

### Prérequis

- **Visual Studio** (2019 ou version ultérieure)
- **MySQL** (via XAMPP ou WAMP)
- **.NET Framework** (version compatible avec le projet)

### Étapes d'installation

1. **Cloner ou télécharger le projet**

   ```bash
   git clone [URL_DU_REPO]
   cd PrinBoutique
   ```

2. **Configurer la base de données**

   - Démarrer MySQL via XAMPP ou WAMP
   - Importer le script SQL de création de la base de données
   - Configurer les paramètres de connexion dans `GestionBD/MysqlConfig.cs`

3. **Ouvrir la solution**

   - Ouvrir `PrinBoutique.sln` dans Visual Studio

4. **Restaurer les packages NuGet**

   - Visual Studio restaurera automatiquement les dépendances au chargement du projet
   - Ou via : `Outils` → `Gestionnaire de packages NuGet` → `Restaurer les packages`

5. **Compiler et exécuter**

   - Appuyer sur `F5` ou cliquer sur `Démarrer` pour lancer l'application

### Configuration de la connexion MySQL

Modifier les paramètres dans `GestionBD/MysqlConfig.cs` :

```csharp
// Exemple de configuration
private string server = "localhost";
private string database = "prin_boutique";
private string uid = "root";
private string password = "";
```



---



## 🎓 Objectifs scolaires / Structure MVC / Sécurité

### 🎯 Objectifs scolaires

Ce projet démontre les compétences suivantes :

- Développement d'une application complète en WinForms  

- Maîtrise de la POO en C#  

- Connexion à MySQL via ADO.NET  

- Création et utilisation :
  - de **procédures stockées**
  - de **fonctions SQL**
  - de **triggers avancés**

- Gestion d'une base de données relationnelle complète  

- Architecture propre et structurée  

- Gestion du CRUD global sur plusieurs entités  

- Automatisation des tâches via SQL

### 🏗️ Structure MVC (Modèle-Vue-Contrôleur)

L'application suit une architecture en couches inspirée du pattern MVC :

- **Modèle (Model)** : 
  - `GestionBD/` → Classes de gestion de la base de données
  - `GestionClients.cs`, `GestionProduits.cs`, `GestionCommandes.cs`, etc.
  - Encapsulation de la logique métier et des opérations CRUD

- **Vue (View)** : 
  - `PrinBoutique/` → Formulaires WinForms (Frm*.cs)
  - Interface utilisateur et présentation des données

- **Contrôleur (Controller)** : 
  - Logique de coordination entre les vues et le modèle
  - Gestion des événements utilisateur et validation des données
  - `GestionInterface.cs` pour les utilitaires d'interface

### 🔒 Sécurité

- **Sécurisation des opérations** :
  - Utilisation de transactions SQL pour garantir l'intégrité des données
  - Paramètres SQL pour éviter les injections SQL
  - Validation des entrées utilisateur

- **Gestion des erreurs** :
  - Try-catch pour la gestion des exceptions
  - Messages d'erreur clairs pour l'utilisateur

- **Configuration sécurisée** :
  - Paramètres de connexion centralisés dans `MysqlConfig.cs`
  - Possibilité d'utiliser des chaînes de connexion chiffrées (à implémenter en production)



---



## 📬 Contact

👨‍💻 **Cédric Prin**  

Développeur IA & Fullstack (POEI) – Futur DevOps & CDA Bac+3  

🔗 Portfolio : https://cedric-prin-portfolio.vercel.app/

🔗 LinkedIn : https://www.linkedin.com/in/cedric-prin-dev/



---



## 📄 Licence

Ce projet est sous **licence propriétaire**. Voir le fichier [LICENSE](LICENSE) pour plus de détails.



---
