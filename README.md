# GameOfLifeDojo
Un game of life en C# développé en équipe à l'aide de mob.sh

## Objectif
Développer un Conway's Game Of Life en équipe.

## Principe
On affiche à l'écran une grille constituée de cellules qui évoluent au cours du temps.

Une cellule a deux états possibles : vivante ou morte
Une cellule possède au maximum 8 voisins : toutes les cellules adjacentes horizontalement, verticalement ou diagonalement.

2 règles à suivre :
- Une cellule morte possédant exactement 3 voisins vivants devient vivante
- Une cellule vivante possédant 2 ou 3 voisins vivants reste vivante, sinon elle meurt

![VsDebugConsole_JFuYIOg2e8](https://user-images.githubusercontent.com/28712598/176712145-7ec7d37a-a951-4dc9-8285-3d4ccf929201.gif)


## Format du Dojo

On se base sur une expérience de Dojo de 1h.

| Durée | Objectif |
|---|---|
| 5 min | Présentation du Dojo et choix des règles |
| 5 min | Définition des règles, choix de dernière minute |
| 40 min | Code |
| 8 min | Rétrospective |
| 2 min | Planification prochain Dojo |

## Règles

> Règles non discutables

- On pratique le TDD
- Un test ```failed``` doit précéder l'écriture du code fonctionnel
- On fonctionne en baby step (on ne code que ce qui est nécessaire pour passer le test)
- On alertene chacun passera  ```co-pilote``` et ```pilote```
- Seul le ```co-pilote``` peut dicter au ```pilote``` ce qui doit être codé
- Seul le ```pilote``` code
- L'assistance peut intervenir pour exprimer son avis sur ce qui est en cours de réalisation, dans ce cas elle s'adresse au ```co-pilote```, le ```pilote``` n'intervient pas
- un maitre du Dojo le ```sensei``` veille à ce que les règles soient respectées, et globalement au bon déroullé du Dojo
- La bienveillance n'est pas optionnelle, aucun jugement sur les personnes, on ne se concentre que sur le code

> Règles optionnelles

Ces règles sont a définir en début de Dojo

- [ ] Pas de type générique
- [ ] DDD principles
- [ ] Réduction des conditionnelles (pas de else)
- [ ] Utilisation Object calisthenics (exemple <https://www.jimmyklein.fr/les-objets-calisthenics/>)
- [ ] TCR (test commit revert)

## Outils
- Github => https://github.com/
- Mob.sh => https://mob.sh/
