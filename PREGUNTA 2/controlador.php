<?php
session_start();
include "conexion.inc.php";
$flujo=$_GET["flujo"];
$proceso=$_GET["proceso"];
$formulario=$_GET["formulario"];
include $formulario.".controlador.form.inc.php";
if (isset($_GET["Siguiente"]))
{
	
	$sql="select * from flujo where flujo='$flujo' and proceso='$proceso'";
	echo $sql;
	$resultado=mysqli_query($conn, $sql);
	$fila=mysqli_fetch_array($resultado);
	$procesosiguiente=$fila["proceso_sig"];
	
	header("Location: motor.php?flujo=$flujo&proceso=$procesosiguiente");
	
	
}
else
{
	$sql="select * from flujo where flujo='$flujo' and proceso_sig='$proceso'";
	$resultado=mysqli_query($conn, $sql);
	$fila=mysqli_fetch_array($resultado);
	$proceso=$fila["proceso"];
	header("Location: motor.php?flujo=$flujo&proceso=$proceso");
	
}

?>
