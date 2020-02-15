<template>
  <div>
    <h1>Students</h2>
    <table>
        <thead>
            <th class="tableHeading">Student ID</th>
            <th class="tableHeading">Email Address</th>
        </thead>
        <tbody id="student-list">
            <script>initializeStudentTable()</script>
        </tbody>
    </table>
  </div>
</template>

<script>
export default {
  name: 'Students',
}
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

#homeTitle {
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
