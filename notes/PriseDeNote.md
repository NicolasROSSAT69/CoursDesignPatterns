# Design patterns

## Définition
Schéma d’objet qui permette de trouver une solution à un problème courant.

## Pré requis 

-Créer un repo Git bien documenter avec les prises de note de la semaine et les exercices.
-C# / Dotnet 6.
-Faire le code en anglais.
-Commenter en anglais le code si possible sinon en français.
-Base solide en POO.

## Objectifs

-Applis console pour les exercices.
- Pattern de construction.
-Pattern de structuration.
-Pattern de comportement.


## Designs patterns de construction

### Abstract factory 

Permet de déresponsabiliser le classe mère. Elle permet de pouvoir modifier un comportement sans modifier la classe mère.

La classe mère détient la signature des méthodes.

![alt text](./img/AbstractFactory.png)

Description partie de la classe scooter

La classes FabriqueVéhiculeElectrique et FabriqueVéhiculeEssence implémente une méthode qui permet de créer un scooter en fonction de son type ScooterElectrique ou ScooterEssence.

![alt text](./img/AbstractFactory2.png)

