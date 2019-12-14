Après un git pull ou un 
```
git clone
```

Il ne faut pas oublier de mettre à jour les migrations.

Pour ce faire, il faut accèder à l'outil de gestionnaire de packets:

Outils => Gestionnaire de package NuGet => Console du Gestionnaire de package.

Un terminal apparait en bas de votre Visual Code, dans ce dernier entrer les commandes suivante:

```
Drop-Database

Add-Migration InitialCreate

Update-Database
```

Vous pouvez maintenant lancer le projet.
