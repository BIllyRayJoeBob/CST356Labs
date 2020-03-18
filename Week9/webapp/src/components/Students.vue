<template>
  <div>
    <h1 class="Title">Students</h1>

    <div v-if='operation == "list"'>
      <table>
        <thead>
          <tr>
            <th class="tableHeading">Student ID</th>
            <th class="tableHeading">Email Address</th>
          </tr>
        </thead>
        <tbody id="student-list">            
          <tr v-for="student in students" v-bind:key="student">
            <td>{{ student.studentId }}</td>
            <td>{{ student.emailAddress }}</td>
          </tr>
        </tbody>
      </table>
    </div>
    
  </div>
</template>

<script>
    import Vue from 'vue';

    export default {
        studentId: 'Students',        
        
        data () {
            return {
                students: [],
                operation: 'list',
                studentId: undefined,
                emailAddress: undefined,
                studentUpdateId: undefined,
                apiServer: process.env.VUE_APP_API_SERVER
            }
        },

        methods: {
            getStudents: function() {
                let url = `http://${this.apiServer}/api/student`;
                Vue.axios.get(url).then(
                    (response) => {
                        this.students = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
            getStudent: function(studentId) {
                let url = `http://${this.apiServer}/api/student/${studentId}`;
                Vue.axios.get(url).then(
                    (response) => {
                        this.studentId = response.data.studentId;
                        this.emailAddress = response.data.emailAddress;
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
            displayAddStudent: function() {
                this.studentId = undefined;
                this.emailAddress = undefined;
                this.operation = 'add';
            },
            addStudent: function() {
                let url = `http://${this.apiServer}/api/student`;
                Vue.axios.post(url, {
                    studentId: this.studentId,
                    emailAddress: parseInt(this.emailAddress)
                }).then(
                    () => {
                        this.getStudents();
                        this.operation = 'list';
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
            displayStudentDetails: function(studentId) {
                this.getStudent(studentId);
                this.operation = 'detail';
            },
            displayUpdateStudent: function(studentId) {
                this.studentUpdateId = studentId;
                this.getStudent(studentId);
                this.operation = 'update';
            },
            updateStudent: function() {
                let url = `http://${this.apiServer}/api/student/${this.studentUpdateId}`;
                Vue.axios.put(url, {
                    studentId: this.studentId,
                    emailAddress: parseInt(this.emailAddress)
                }).then(
                    () => {
                        this.getStudents();
                        this.operation = 'list';
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
            deleteStudent: function(studentId) {
                let url = `http://${this.apiServer}/api/student/${studentId}`;
                Vue.axios.delete(url).then(
                    () => {
                        this.getStudents();
                        this.operation = 'list';
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            },
            cancel: function() {
                this.operation = 'list';
            }
        },


        mounted() {
            this.getStudents();
            this.operation = 'list';
        }
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
