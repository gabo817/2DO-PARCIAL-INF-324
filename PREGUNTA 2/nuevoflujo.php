<?php
session_start();
include "conexion.inc.php";
$sql="select * from flujo where proceso='P1' and cod_rol='".$_SESSION["rol"]."'";
echo $sql;
$resultado=mysqli_query($conn, $sql);
?>
<form action="controlflujo.php" method="GET">
	<select name="flujo_selecionado">
	<?php
	while ($fila=mysqli_fetch_array($resultado))
		echo "<option value=".$fila['flujo'].">".$fila['flujo']."</option>";
	?>
	</select>
	<input type="submit" name="Enviar" value="Enviar"/>
<form>