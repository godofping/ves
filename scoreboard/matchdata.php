<?php
	include_once 'db.php';
	echo json_encode($DB->row("SELECT * FROM matches where matchid = 1"));
?>