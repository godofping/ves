    <!-- /.content -->
  </div>
  <!-- /.content-wrapper -->


</div>
<!-- ./wrapper -->

<!-- jQuery -->
<script src="plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- AdminLTE App -->
<script src="dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="dist/js/demo.js"></script>
<script type="text/javascript">

getData();

function getData()
{
	$.get("announcement.php", function(data, status){
    	if(status == 'success')
    	{
    		$('#announcement').text(data);
    	}
 	});


 	$.get("matchdata.php", function(data, status){

 		if(status == 'success')
 		{
 			var info = JSON.parse(data);
 			$('#currentset').text(info.currentset);
 			$('#teamaname').text(info.teamaname);
 			$('#teambname').text(info.teambname);

 			$('#teamawonsets').text(info.teamawonsets);
 			$('#teambwonsets').text(info.teambwonsets);


 			$('#teamaset1').text(info.teamaset1);
 			$('#teamaset2').text(info.teamaset2);
 			$('#teamaset3').text(info.teamaset3);
 			$('#teamaset4').text(info.teamaset4);
 			$('#teamaset5').text(info.teamaset5);

 			$('#teambset1').text(info.teambset1);
 			$('#teambset2').text(info.teambset2);
 			$('#teambset3').text(info.teambset3);
 			$('#teambset4').text(info.teambset4);
 			$('#teambset5').text(info.teambset5);

 			

 			if(info.currentset == '1')
 			{
				$('#teamascore').text(info.teamaset1);
				$('#teambscore').text(info.teambset1);

				$('#teamatimeout').text(info.teamatimeout1);
				$('#teambtimeout').text(info.teambtimeout1);
 			}

 			if(info.currentset == '2')
 			{
				$('#teamascore').text(info.teamaset2);
				$('#teambscore').text(info.teambset2);

				$('#teamatimeout').text(info.teamatimeout2);
				$('#teambtimeout').text(info.teambtimeout2);
 			}

 			if(info.currentset == '3')
 			{
				$('#teamascore').text(info.teamaset3);
				$('#teambscore').text(info.teambset3);

				$('#teamatimeout').text(info.teamatimeout3);
				$('#teambtimeout').text(info.teambtimeout3);
 			}

 			if(info.currentset == '4')
 			{
				$('#teamascore').text(info.teamaset4);
				$('#teambscore').text(info.teambset4);

				$('#teamatimeout').text(info.teamatimeout4);
				$('#teambtimeout').text(info.teambtimeout4);
 			}

 			if(info.currentset == '5')
 			{
				$('#teamascore').text(info.teamaset5);
				$('#teambscore').text(info.teambset5);

				$('#teamatimeout').text(info.teamatimeout5);
				$('#teambtimeout').text(info.teambtimeout5);
 			}


 			
 		}

    	

 	});

}

setInterval(function(){
	getData(); 
},1000);



</script>

</body>
</html>
