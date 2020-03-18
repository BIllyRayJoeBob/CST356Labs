<template>
  <div>
    <h1 class="Title" >Instuctors</h1>
    <table>
        <thead>
            <th class="tableHeading">First Name</th>
            <th class="tableHeading">Middle Name</th>
            <th class="tableHeading">Last Name</th >
        </thead>
        <tbody id="teacher-list">           
            <tr v-for="instructor in instructors" v-bind:key="instructor">
                <td>{{ instructor.FirstName }}</td>
                <td>{{ instructor.MiddleName }}</td>
                <td>{{ instructor.LastName }}</td>
            </tr>
        </tbody>
    </table>
  </div>
</template>

<script>
    export default { 
        name: 'Intructors',
        mounted() {this.instructors = getinstructors();},
        data(){ return{instructors:[]} }
    }
    function getinstructors() {
            return JSON.parse(instructors);
        }
    var instructors = '[{"FirstName":"Billy Ray","MiddleName":"Joe", "LastName":"Bob"},{"FirstName":"Phong","MiddleName":"", "LastName":"Nguyen"},{"FirstName":"Lucas","MiddleName":"", "LastName":"Cordova"},{"FirstName":"Gerald","MiddleName":"", "LastName":"Aden"},{"FirstName":"Pramod","MiddleName":"", "LastName":"Govindan"}]'

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

table, tbody, tr, th, .teacher-list {
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
