# Wheelchair Master 

**Wheelchair Master** est une simulation immersive en Réalité Virtuelle (VR) développée sous Unity 3D avec le XR Interaction Toolkit. Ce projet vous place aux commandes d'un fauteuil roulant manuel dans un environnement urbain interactif.

*Projet étudiant réalisé dans le cadre du module "Environnements Immersifs et Réalité Virtuelle" , encadré par Mr. Madeth May et Mr. Coupry Corentin.*

##  Concept et Activités
Accompagné par la mascotte du jeu (le "Docteur"), le joueur débute dans un couloir d'hôpital pensé comme un tutoriel, avant d'accéder à une zone urbaine ouverte proposant plusieurs activités :
* **Slalom :** Un parcours de cônes pour s'exercer au braquage et à la maniabilité du fauteuil.
* **Basket-ball :** Saisie et lancer de ballons avec la mécanique de préhension VR pour marquer des paniers.
* **Tri des déchets :** Collecte et lancer de sacs poubelles directement dans un grand conteneur.

##  Mécaniques de Contrôle
Le jeu propose un système de locomotion original basé sur les mouvements réels des bras pour une immersion maximale.

### En Réalité Virtuelle (Casque VR)
* **Se déplacer :** Pointez les lasers bleus vers les grandes roues du fauteuil, maintenez le bouton **Grip**, et effectuez un mouvement circulaire avec vos bras.
* **Interagir avec l'UI :** Pointez avec le laser et appuyez sur la **Gâchette (Trigger)**.
* **Attraper un objet (Grab) :** Pointez le laser sur un objet interactif et maintenez le bouton **Grip**.

### Sur PC (XR Device Simulator)
*Si vous testez le build "Simulateur" sur ordinateur (clavier/souris) :*
* **Activer la main gauche / droite :** Maintenez Maj (Shift) gauche / Espace.
* **Bouger la tête / les mains :** Bougez la souris (avec le clic droit maintenu pour la tête).
* **Saisir (Grip) :** Touche `G`.
* **Cliquer (Trigger) :** Clic gauche de la souris.

>  **Note technique :** La manipulation du fauteuil au clavier/souris étant très complexe, il est conseillé de détacher temporairement le composant `XR Origin` du fauteuil dans la hiérarchie de la scène Unity pour explorer librement l'environnement et tester les interactions en mode simulateur.

##  Versions (Builds)
Deux exécutables sont fournis avec ce projet :
1.  **Build VR :** Conçu pour être joué avec un casque de réalité virtuelle (*XR Device Simulator* désactivé).
2.  **Build Simulateur :** Conçu pour être testé directement sur l'ordinateur de l'école sans casque.


