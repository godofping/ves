<?php
	include_once 'db.php';

	$type = $DB->single("SELECT announcementtype FROM announcements");

	 if($type == 1)
	 {
		echo json_encode($DB->row("SELECT announcement, announcementtype FROM announcements"));
	 }
	 elseif ($type == 2) {
	 	echo json_encode($DB->row("SELECT announcementtextfullscreen, announcementtype FROM announcements"));
	 }
	 elseif ($type == 3) {
	 	echo json_encode($DB->row("SELECT announcementimage, announcementtype FROM announcements"));
	 }
	
?>