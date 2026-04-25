# Trabajo práctico: Colección de datos

## Tipo
- Trabajo práctico obligatorio
- Entrega en la semana 7
- Devolución en semana 14

## Formato
> MUY IMPORTANTE RESPETAR EL NOMBRE DE LA ENTREGA PARA SU POSTERIOR ORGANIZACIÓN Y SEGUIMIENTO.
- `TP1_ComX_GrupoX_Apellido1_Apellido2_Apellido3_Apellido4_Apellido5.zip` o `.rar`. 
- Entrega un representante del equipo, respetando los que registraron oportunamente en la planilla (corregirla de ser necesario). Envío de todos los archivos correspondientes DENTRO de un archivo comprimido, indicando la comisión, el número del grupo y los apellidos de los integrantes del mismo.

## Descripción
- Usando el [ejemplo de la biblioteca](https://aulasvirtuales.bue.edu.ar/mod/book/view.php?id=408214&chapterid=66781) visto durante la semana en la explicación, nos piden como requerimiento que la misma tenga una colección de lectores registrados. De los lectores conocemos su `nombre` y `dni`.
- Cada lector puede tener hasta un máximo de 3 prestamos vigentes. 
- Cuando se realiza un préstamo, se extrae de la biblioteca el libro para entregárselo al lector (si es que puede retirarlo). Es decir, se debe retirar el libro de la lista de libros que posee la biblioteca para asignársela a la lista de libros que posee el lector en préstamo.

## Para hacer
- Ampliar el UML a los nuevos requerimientos.
- Desarrollar el método `altaLector` que pasándole los parámetros necesarios de el alta a un lector dentro de la lista de lectores si es que no se encontraba previamente registrado.
- Desarrollar el método prestarLibro de la clase Biblioteca la cual recibe por parámetro el título de un libro y el dni del lector que lo solicita y retorna un string con los posibles valores:
    - **PRESTAMO EXITOSO** (en este caso el libro se le pudo prestar al lector, se lo quitó de la lista de libros que dispone la biblioteca y se lo adjudicó al lector).
    - **LIBRO INEXISTENTE** (cuando el libro no se encuentra dentro de la colección de libros en la biblioteca)
    - **TOPE DE PRESTAMO ALCAZADO** (cuando el lector ya posee tres libros en préstamo).
    - **LECTOR INEXISTENTE** (cuando el lector no es se encuentra registrado dentro de la colección de lectores en la biblioteca).
- Generar un video grupal de 10 minutos máximo, con cámaras activas, donde cada integrante explique parte del desarrollo y funcionamiento del proyecto.

> Por cuestiones de espacio en la plataforma, pueden enviar un link al video, como recomendación pueden subirlo a Youtube, sino puede ser un enlace a Drive, pero cerciórense de asignar el permiso de visualización correspondiente y no deben borrarlo hasta tener aprobada la materia. No dejen para entregar a último momento porque la plataforma puede fallar, se aconseja enviarlo un día antes como mínimo.
