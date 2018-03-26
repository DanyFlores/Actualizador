# Actualizador

El presente proyecto consta de **2 subproyectos**: El proyecto actualizador y el proyecto hijo (o *auxiliar*).

Antes de ejecutarlo, es necesario **reemplazar las rutas** (indicadas directamente en el código) para asignar aquellas que sean necesarias para actualizar los archivos según sea necesario.

Una vez hecho esto y recompilando ambos programas, el proceso que debe ser inicialmente llamado es **UpdateProcess.exe**

## UpdateProcess

Se encarga de llamar a **MasterProcess.exe** (el cual simula ser el programa principal *o aquel que pretende ser actualizado*). Para llegar a esto, *UpdateProcess* valida si hay una nueva versión de los archivos disponible (consultando nuevos directorios en la ruta de actualización), y posteriormente pregunta si se desea actualizar o no. 

*En caso de aceptar: El programa actualiza los archivos a su versión más reciente disponible, y posteriormente reinicia el proceso principal (*MasterProcess*)

*En caso de rechazar: El programa simplemente lanza el proceso principal (*MasterProcess*).

## MasterProcess

Este programa es meramente un simulador (sus archivos no se actualizan, pues no depende de ningún archivo). Sin embargo, ofrece la lógica para también hacer un ***roll-back*** de los cambios realizados a una versión anterior de los archivos, enlistándolos en un *DataGridView* y permitiendo al usuario regresar a la versión de su elección. Esto se logra mediante el llamado nuevamente a **UpdateProcess**, sin embargo, esta vez el llamado es diferente. *UpdateProcess* no inicia comprobando actualizaciones, sino que es invocado con *CMD Flags* para iniciar en otra ventana dentro del mismo (en este caso, la bandera *rollback* es la necesaria para realizar dicho llamado), encargada de mostrar las versiones disponibles. Esto se logra llamando a la aplicación de la siguiente manera:

*En línea de comandos (CMD): 
  *```Batch UpdateProcess.exe rollback```

*En VB (VB.NET):
  *```VB .NET Process.Start("UpdateProcess.exe", "rollback")```
