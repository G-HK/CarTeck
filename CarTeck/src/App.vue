<template>
  <Header class="z-10" />

  <div class="flex justify-center mt-3	">
      <router-view/>
  </div>
</template>

<script> 
import Header from './components/static/Header.vue';
import Footer from './components/static/Footer.vue';
import HelloWorld from './components/HelloWorld.vue'

// This starter template is using Vue 3 experimental <script setup> SFCs
// Check out https://github.com/vuejs/rfcs/blob/script-setup-2/active-rfcs/0000-script-setup.md
export default{
  name: 'app',
  components:{
    Header,
    Footer,
  },
  props: {

  },
  data(){
    return {

    };
  },
  methods:{

  },
}


</script>

<style src="./tailwind.css">
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
</style>