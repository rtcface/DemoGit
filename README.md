#Comandos utiles in git

1. git init # Inicia Repositorio git
2. git add . # Toma una pre-snapshot
3. git reset . # Borra el pre-snapshot
4. git commit -m "comentario"  # Toma el snapshot
5. git checkout --. # Regresa todos los cambios al ultimo snapshot
6. git log # Muestra el hitorico de cambios en tu proyecto
7. git commit --amend # permite cambiar el ultimo comentario del commit
8. git checkout -b rama-desarrollo # Crea una rama
9. git branch # Muestra las ramas en el proyecto y muestra la rama actual
10. git checkout master # Permite el cambio de rama
11. git branch -d rama-desarrollo # Elimina la rama
12. git push # Sube los cambios al repositoro remoto 
13. git commit -am "comentario" # # Permite unir los comandos . add commit en una solo linea 
14. git push --set-upstream origin rama-desarrollo # sube la rama al repositorio remoto
15. git merge rama-desarrrollo # une la rama con el main
16. git update-ref -d HEAD Eliminará la referencia nombrada HEAD, por lo que restablecerá (suavemente, no perderá su trabajo) todas las confirmaciones de su rama actual.
17. git config --global alias.st "diff --stat" Cambia los alias

