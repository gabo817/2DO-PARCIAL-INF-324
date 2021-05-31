<?php
include "conexion.inc.php";
session_start();
$nombre=$_POST["usuario"];
$pass= $_POST["contrasenia"];
$query=mysqli_query($conn, "SELECT * FROM USUARIO WHERE USUARIO='".$nombre."' AND CONTRASENA='".$pass."'");
$nr=mysqli_num_rows($query);
$fila = mysqli_fetch_array($query);
if ($nr==1){
    if ($fila['rol'] == 'U'){
        //echo "Bienvenido: ".$nombre."DOCENTE";
        //include "docente.php?ci=$fila[CI]";
		$_SESSION["IdUser"]=$fila['usuario'];
		$_SESSION["rol"]="U";
		header("Location: bandeja.php");
        //echo "<a href='docente.php?ci=$fila[ci]'>Bienvenido: ".$nombre."DOCENTE</a>";
    }
    else{
        //echo "Bienvenido: ".$nombre."ESTUDIANTE";
        //include "estudiante.php?ci=$fila[CI]";
		$_SESSION["IdUser"]=$fila['usuario'];
		$_SESSION["rol"]="K";
		header("Location: bandeja.php");
        //echo "<a href='estudiante.php?ci=$fila[ci]'>Bienvenido: ".$nombre."ESTUDIANTE</a>";
    }
}
else if($nr==0){
    echo "USUARIO INEXISTENTE O CONTRASENA INVALIDA";
}

/*if ($_POST["usuario"]=="moyo" && $_POST["contrasenia"]=="123456")
{	
	$_SESSION["IdUser"]=1;
	$_SESSION["rol"]="U";
	header("Location: bandeja.php");
}
if ($_POST["usuario"]=="meyo" && $_POST["contrasenia"]=="123456")
{
	$_SESSION["IdUser"]=10;
	$_SESSION["rol"]="U";
	header("Location: bandeja.php");
}
if ($_POST["usuario"]=="zulema" && $_POST["contrasenia"]=="123456")
{
	$_SESSION["IdUser"]=20;
	$_SESSION["rol"]="K";
	header("Location: bandeja.php");
}*/
?>