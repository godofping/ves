<?php include('db.php');



$s =  $DB->single("SELECT announcementimage FROM announcements");




echo '<img src="data:image/png;base64,' . $s . '" />';


 ?>

