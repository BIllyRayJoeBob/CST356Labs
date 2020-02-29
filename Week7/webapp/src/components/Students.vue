<template>
  <div>
    <h1>Students</h1>
    <table>
        <thead>
            <th class="tableHeading">Student ID</th>
            <th class="tableHeading">Email Address</th>
        </thead>
        <tbody id="student-list">            
            <tr v-for="student in students" v-bind:key="student">
                <td>{{ student.ID }}</td>
                <td>{{ student.email }}</td>
            </tr>
        </tbody>
    </table>
  </div>
</template>

<script>
    export default {
        name: 'Students',
        mounted() {this.students = getStudents();},
        data(){ return{students:[]} }
    }
    function getStudents() {
            return JSON.parse(students);
        }
    var students = '[{"ID":"918000001","email":"billyray.bob@school.edu"},{"ID":"918000002","email":"phong.nguyen@school.edu"},{"ID":"918000003","email":"lucas.cordova@school.edu"},{"ID":"918000004","email":"gerald.aden@school.edu"},{"ID":"918000005","email":"pramod.govindan@school.edu"}]'
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

    table, tbody, tr, th, .student-list{
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
