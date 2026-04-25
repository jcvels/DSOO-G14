# Proyecto Integrador: Club Deportivo

> Este documento es un extracto de lo mencionado en el [DSOO - Proyecto Integrador (presentación y fase 1)](https://aulasvirtuales.bue.edu.ar/mod/book/view.php?id=874251)

## Faces del proyecto

1. Análisis preliminar
2. Análisis previo y funcional
3. Análisis orgánico
4. Conectar datos para programar
5. Programar
6. Prueba
7. Puesta a punto del sistema
8. Coloquio

## Presentación del sistema

La empresa administra un club deportivo que tiene distintos tipos de actividades destinadas a socios y no socios.
A continuación encontrarás algunas características de cómo se organiza el club:

`Socios` - `Cuota` - `Inscripción` - `Plantel`

- **Vencido el periodo de pago**, automáticamente el socio no puede realizar actividades, para retomar, debe pagar la cuota, y el plazo de pago comienza a correr a partir del día siguiente al vencimiento de la cuota.
- **Cada profesor** además de dictar su clase en los horarios asignados, **controla las actividades del salón general** (musculación y aparatos), **confeccionan las rutinas** para sus alumnos.
- Los profesores firman una planilla de asistencia a la llegada al club y el cobro de su sueldo es mensual, el último día hábil del mes.
- **Cuenta con un servicio adicional de Nutrición**. El mismo funciona una vez por semana, y la consulta es por turno asignado con anticipación. Se lleva la ficha médica de cada socio y se establece junto con el médico la carga de actividad física permitida según sea el tratamiento.

## Objetivo

Se desea realizar un sistema tal que permita administrar de manera eficiente el servicio prestado a fin de controlar:

- Registro de los socios y de los no socios.
- Entrega de carnet y cobro de cuota mensual o diaria.
- Listado diario de los socios que en la fecha les vence la cuota.
- > El enunciado muestra las actividades generales del club deportivo, sin embargo, lo que se solicita es parte de esas actividades.
- > Conocer el entorno en su totalidad nos permite entender las relaciones entre las actividades, y reconocer las salidas  de nuestros procesos.
- > Determinar el alcance de cada punto y acotar las acciones que deben ser codificadas agrega al desarrollo otro aprendizaje. Este aprendizaje esta relacionado a la definición del límite de cada proceso; para evitar agregar acciones que corresponden a otro proceso.
- > La función del límite además de lo mencionado en el párrafo anterior nos libera de que el cliente entusiasmado con el desarrollo solicite nuevos requerimientos.

## Fechas importantes

- Semana 4 a la 9: Tareas grupales semanales de la Fase 1 a la Fase 5
- Semana 9 (**17.05.2026**): Primer entregable del PI, con devolución del docente, sin nota numérica.
- Semana 10 a la 13: Tareas grupales semanales de la Fase 6 y la Fase 7
- Semana 14 (**21.06.2026**): Entrega completa del sistema (PI) y del video grupal del coloquio obligatorio.
