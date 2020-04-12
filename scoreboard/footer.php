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


var luma = 0;
var bago = 99;

function getData()
{

	$.get("announcement.php", function(data, status){
    	if(status == 'success')
    	{
    		var info = JSON.parse(data);


    		bago = info.announcementtype;

    		

    		if(info.announcementtype == 1)
    		{
    			$("#rb1").show();
    			$("#rb2").hide();
    			$("#rb3").hide();

    			$('#announcement').text(info.announcement);

    			if(bago != luma)
    			{
    				document.getElementById('announcement').start();
    				
    			}


    		}

    		if(info.announcementtype == 2)
    		{
    			$("#rb1").hide();
    			$("#rb2").show();
    			$("#rb3").hide();
    			$('#fullscreenh1').text(info.announcementtextfullscreen);
    		}

    		if(info.announcementtype == 3)
    		{
    			$("#rb1").hide();
    			$("#rb2").hide();
    			$("#rb3").show();

    			$("#fullscreenimage").attr("src","data:image/jpg;base64," + info.announcementimage);

    			
    		}
    		luma = bago;

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


 			if(info.bestof == '3')
 			{
 				$("#box1").hide();
 				$("#box5").hide();
 				$("#box6").hide();
 				$("#box10").hide();


	 			$('#teamaset2').text(info.teamaset1);
	 			$('#teamaset3').text(info.teamaset2);
	 			$('#teamaset4').text(info.teamaset3);
	 
	 			$('#teambset2').text(info.teambset1);
	 			$('#teambset3').text(info.teambset2);
	 			$('#teambset4').text(info.teambset3);

 			}

 			if(info.bestof == '5')
 			{
 				$("#box1").show();
 				$("#box5").show();
 				$("#box6").show();
 				$("#box10").show();


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
 			}


 			

 			

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
},300);





</script>

</body>
</html>
