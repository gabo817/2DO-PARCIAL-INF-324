<?php
session_start();
include "conexion.inc.php";
include "cabecera.inc.php";
include "menu.inc.php";
$sql="select * from seguimiento where fecha_fin is null and usuario='".$_SESSION["IdUser"]."'";
$resultado=mysqli_query($conn, $sql);
?>
<table>
<tr>
	<td>Flujo</td>
	<td>Proceso</td>
	<td>Accion</td>
</tr>
<?php
while ($fila=mysqli_fetch_array($resultado))
{
echo "<tr>";
echo "<td>".$fila["flujo"]."</td>";
echo "<td>".$fila["proceso"]."</td>";
echo "<td><a href='motor.php?flujo=".$fila["flujo"]."&proceso=".$fila["proceso"]."'>Editar</a></td>";
echo "</tr>";
}

?>
</table>

<a href="nuevoflujo.php">Nuevo</a>
<?php
include "pie.inc.php";
?>
