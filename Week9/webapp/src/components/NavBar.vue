<template>
<div class="home">

<img alt="Vue logo" src="../assets/logo.png" />
    <HelloWorld msg="Welcome to Your Vue.js App" />

    <!-- Check that the SDK client is not currently loading before accessing is methods -->
    <div v-if="!$auth.loading">
      <!-- show login when not authenticated -->
      <button v-if="!$auth.isAuthenticated" @click="login">Log in</button>
      <!-- show logout when authenticated -->
      <button v-if="$auth.isAuthenticated" @click="logout">Log out</button>
    </div>

    <div class="links">
        <span v-on:click='goToHome'>Home</span>
        <span v-on:click='goToStudents'>Students</span>
        <span v-on:click='goToInstructors'>Instructors</span>
        <!--<span v-on:click='goToLogin'>LogOut</span>-->
    </div>

</div>
</template>

<script>
export default {
name: 'NavBar',
methods: {
	goToLogin: function(){
		this.$router.push({ path: 'login'})
	},
	goToHome: function() {
		this.$router.push({ path: 'home' })
	},
	goToStudents: function() {
		this.$router.push({ path: 'students' })
	},
	goToInstructors: function() {
		this.$router.push({ path: 'instructors' })
	},
	login() {
		this.$auth.loginWithRedirect();
	},
	logout(){this.$auth.logout({returnTo:window.location.origin});}
	}
};

  
</script>

<style scoped>
  span {
      font-family: monospace;
      font-weight: bold;
      font-size: 14pt;
      cursor: pointer;
      padding-right: 20px;
      background-color: white;
      text-align: center;
  }
  .links {
      background-color: lightgray;
      margin-top: 20px;
      padding: 10px;
  }
</style>