<template>
  <div>
    
    <h1 class="Title">HOME</h1>
    <img id="myPic" src="../assets/wife.jpg">
    <h2>About my Home Page</h2>
    <p>
        For the home page, I decided to use a photo of my wife 
        from a romantic dinner. I particularly like this photo of her. The video 
        below is of a project I was working on for a previous class. I was playing
        with the float parameters to get an idea of how to anchor the images to the
        page when the page display. 
    </p>
    <video v-on:click='PlayPause' id="myVid" autoplay>
        <source src="../assets/work.mp4" type="video/mp4">
    </video>
    <br>
    <br>
    <h2>About the Additional Pages</h2>
    <p>        
        The Instuctors html is a simple page with the OIT Hootie inset as the background. The Student page simply lists student IDs and emails in a tabular format. 
        It uses the same backround image as the Instructors page. 
    </p>
    <h2> Additional Elements </h2>
    <p>
        The image and video links in the page are current centered, I tried the stagger them 
        (float:right for the image and float:left for the video);  however,
        the image alignments also seemed to adversaly affect the sizes of the 
        video and it began overlapping the other text. I removed the separate button suggested
         by the w3schools.com tutorial and went with a clickable video instead. 
    </p>
  </div>
</template>

<script>
export default {
  name: 'Home',
  methods: { 
    PlayPause: function playPause(){
      if(myvideo.paused)
        myvideo.play();
      else
        myvideo.pause();
      }
  }
}
var myvideo = document.getElementById("myVid");
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

body{
    background-color: lightsteelblue;
    background-repeat: no-repeat;
    background-position-x: center;
    text-align: center;
    
    padding: 15px;
}

.generalBackground{
    background-image: url("../assets/OIT.jpg");
    background-blend-mode: lighten ;
}


a{
    text-decoration: none;   
    padding-left: 30px;
    padding-right: 30px;     
    font-family: cursive;
    background-color: darksalmon;
    border: ridge;
}

.Title {
    color: darkmagenta;
    font-family: cursive;
}

p {
    color: rgb(255, 199, 58);
    background-color: midnightblue;
    font-family: 'Courier New', Courier, monospace;
    font-weight: 200;
    text-align: justify;
    padding: 15px;
}

 #myPic {  
     float: left;
     width: 30%;
     padding-right: 15px;
 }

 #myVid {
     width: 30%;
     float: right;
    padding-left: 15px;
 }

.tableHeading{
    color: darkmagenta;
    font-family: 'Courier New', Courier, monospace;
    text-align: left;
}

h2{
    text-align: left;
    text-decoration: midnightblue;
}

table, tbody, tr, th {
    border: 3px solid darkgreen;
    text-align: center;
    border-collapse: collapse;
    margin-left: auto;
    margin-right: auto;
}

form{
    font-family: 'Courier New', Courier, monospace;
    color: aliceblue;
}

</style>
