<?php include('db.php');include('header.php'); ?>

  <style type="text/css">
    .content-wrapper
    {
      background-color: #000 !important;
    }

  </style>
    
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <div class="container-fluid">
        <div class="row mb-2">
     
        </div>
      </div>
    </section>


    <section class="content" id="rb1">

      <div class="container-fluid text-center">
        
        <div class="row">

          <div class="col-sm-4">
            <div class="row">

              <div class="col-12" style="background-color: #c3b091;">
                
                <h2 id="teamaname" style="font-size: 4.5rem;"></h2>

              </div>

              <div class="col-12" style="background-color: #fff;">
                
                <h3 id="teamascore" style="font-size: 23rem; margin-top: -3.8rem; margin-bottom: -1.5rem;">2</h3>

              </div>

            </div>
          </div>

    

          <div class="col-sm-4">
            
            <div class="row">
              <div class="col-4"></div>
              <div class="col-4">

                <div class="row">

                  <div class="col-12">
                    <h3 style="font-size: 4.5rem; color: #fff;">SET</h3>
                  </div>
                
                  <div class="col-12" style="background-color: #FFFAF0;">
                      <h3 id="currentset" style="font-size: 7rem; margin-top: -1.7rem; margin-bottom: -0.8rem;">1</h3>
                  </div>

                </div>

              </div>
              <div class="col-4"></div>
            </div>

            <div class="row">
              <div class="col-4" style="padding-left: 2rem;">
                
                <h3 style="font-size: 2.3rem; color: #fff">WON SET</h3>
                  <div class="col-12" style="background-color: #FFFAF0;">
                  <h3 id="teamawonsets" style="font-size: 4.5rem;">0</h3>
                </div>

              </div>
              <div class="col-4"></div>
              <div class="col-4" style="padding-right: 2rem;">
                
                <h3 style="font-size: 2.3rem; color: #fff;">WON SET</h3>
                  <div class="col-12" style="background-color: #FFFAF0;">
                  <h3 id="teambwonsets" style="font-size: 4.5rem;">0</h3>
                </div>

              </div>
            </div>



          </div>

          <div class="col-sm-4">
            <div class="row">
              <div class="col-12" style="background-color: #00FF7F;">
                
                <h2 id="teambname" style="font-size: 4.5rem;">TEAM B</h2>

              </div>

              <div class="col-12" style="background-color: #fff;">
                
                <h3 id="teambscore" style="font-size: 23rem; margin-top: -3.8rem; margin-bottom: -1.5rem;">0</h3>

              </div>

            </div>
          </div>
      
        </div>

        <div class="row mt-3">

          <div class="col"></div>
          
          <div class="col">
            <h3 style="font-size: 2.5rem; color: #fff;">TIME OUT</h3>
            <div class="col-12" style="background-color: #FFFAF0;">
              <h3 id="teamatimeout" style="font-size: 4.5rem;">0</h3>
            </div>
          </div>

          <div class="col"></div>
          <div class="col"></div>
          <div class="col"></div>
          <div class="col"></div>
          <div class="col"></div>
          <div class="col"></div>


          <div class="col">
            <h3 style="font-size: 2.5rem; color: #fff;">TIME OUT</h3>
            <div class="col-12" style="background-color: #FFFAF0;">
              <h3 id="teambtimeout" style="font-size: 4.5rem;">0</h3>
            </div>
          </div>

          <div class="col"></div>
          
        </div>

        <div class="row mt-2">

          <div class="col">
            <div id="box1" style="background-color: #c3b091;">
              <h3 id="teamaset1" style="font-size: 5rem;">0</h3>
            </div>
          </div>

          <div class="col">
            <div id="box2" style="background-color: #c3b091;">
              <h3 id="teamaset2" style="font-size: 5rem;">0</h3>
            </div>
          </div>

          <div class="col">
            <div id="box3" style="background-color: #c3b091;">
              <h3 id="teamaset3" style="font-size: 5rem;">0</h3>
            </div>
          </div>

          <div class="col">
            <div id="box4" style="background-color: #c3b091;">
              <h3 id="teamaset4" style="font-size: 5rem;">0</h3>
            </div>
          </div>

          <div class="col">
            <div id="box5" style="background-color: #c3b091;">
              <h3 id="teamaset5" style="font-size: 5rem;">0</h3>
            </div>
          </div>

   
        </div>

        <div class="row">

          <div class="col">
            <div id="box6" style="background-color: #00ff7f;">
              <h3 id="teambset1" style="font-size: 5rem;">0</h3>
            </div>
          </div>

          <div class="col">
            <div id="box7" style="background-color: #00ff7f;">
              <h3 id="teambset2" style="font-size: 5rem;">0</h3>
            </div>
          </div>

          <div class="col">
            <div id="box8" style="background-color: #00ff7f;">
              <h3 id="teambset3" style="font-size: 5rem;">0</h3>
            </div>
          </div>

          <div class="col">
            <div id="box9" style="background-color: #00ff7f;">
              <h3 id="teambset4" style="font-size: 5rem;">0</h3>
            </div>
          </div>

          <div class="col">
            <div id="box10" style="background-color: #00ff7f;">
              <h3 id="teambset5" style="font-size: 5rem;">0</h3>
            </div>
          </div>

   
        </div>

        <div class="row">
         
            <marquee id="announcement" style="font-size: 5.9rem; padding: 10px; color: #fff;"></marquee>

        </div>


      </div>

    </section>

    <section class="content" id="rb2">
      <div class="container-fluid">
        <div class="row">
          <div class="col-12" style="height: 95vh;">

            <h1 class="text-center" style="color: white; font-size: 8.5vh; text-decoration: underline;">Announcement</h1>
            <h1 id="fullscreenh1" class="text-center" style="color: white; font-size: 7.5vh"></h1>

          </div>
        </div>
      </div>
    </section>

    <section class="content" id="rb3">
      <div class="container-fluid">
        <div class="row">
          <div class="col-12" style="height: 93vh; width: 100vw;">

            <h1 class="text-center" style="color: white; font-size: 8.5vh; text-decoration: underline;">Announcement</h1>
            <img id="fullscreenimage"  style="display: block;
  margin-left: auto;
  margin-right: auto;
  height:90%;">

          </div>
        </div>
      </div>
    </section>


<?php include('footer.php'); ?>