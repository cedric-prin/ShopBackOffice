# 🛒 Application de Gestion de Commandes  

**C# / WinForms / MySQL – Projet CRUD complet avec procédures, fonctions et triggers**



Une application de gestion commerciale permettant d'administrer les **clients**, **produits**, **commandes**, **lignes de commande**, **fournisseurs** et la mise à jour du stock en temps réel grâce à des **triggers MySQL**.



Développée en C# WinForms avec une architecture claire, ce projet simule une petite application de gestion utilisée en entreprise.



---



## ✨ Fonctionnalités principales



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



## 🖼️ Aperçus de l'application



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



## 🗄️ Base de données



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



## 📁 Structure du projet

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



## 🚀 Compétences démontrées



- Développement d'une application complète en WinForms  

- Maîtrise de la POO en C#  

- Connexion à MySQL via ADO.NET  

- Création et utilisation :

  - de **procédures**

  - de **fonctions SQL**

  - de **triggers avancés**

- Gestion d'une base de données relationnelle complète  

- Architecture propre et structurée  

- Gestion du CRUD global sur plusieurs entités  

- Automatisation des tâches via SQL



---



## 📄 Licence

Ce projet est sous **licence propriétaire**. Voir le fichier [LICENSE](LICENSE) pour plus de détails.



---



## 📬 Auteur



👨‍💻 **Cédric Prin**  

Développeur IA & Fullstack (POEI) – Futur DevOps & CDA Bac+3  

🔗 Portfolio : *bientôt public*  

🔗 LinkedIn : https://www.linkedin.com/in/cedric-prin-dev/



---
