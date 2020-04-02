<?php
	include_once 'db.php';
	echo $DB->single("SELECT announcement FROM announcements");
?>