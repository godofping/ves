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
      </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class="content">

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
          
            <marquee>
              <h1 id = "announcement" style="font-size: 5rem; padding: 10px; color: #fff;"></h1>
            </marquee>

        </div>


      </div>

    </section>


<?php include('footer.php'); ?>