<template>
  <div id="app">
    <NavBar/>
	
	<div id="nav">
      <router-link to="/">Home</router-link>|
      <router-link to="/about">About</router-link>|

      <!-- NEW - add a route to the profile page -->
      <router-link v-if="$auth.isAuthenticated" to="/profile">Profile</router-link>
    </div>
	
    <router-view/>
  </div>
</template>

<script>
import NavBar from './components/NavBar.vue'

export default {
  name: 'App',
  components: {
    NavBar
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
