<?php
define('DBHost', 'localhost');
define('DBPort', 3306);
define('DBName', 'ves_db');
define('DBUser', 'root');
define('DBPassword', '');
require(__DIR__ . "/src/PDO.class.php");
$DB = new Db(DBHost, DBPort, DBName, DBUser, DBPassword);


?>