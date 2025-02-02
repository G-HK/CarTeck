<template>
    
    <!-- Slider for new features and news  -->
    <div class="text-center" >
        <img src="../assets/CarTeckLogo.png" class="w-96 h-96" />
        <h1>Welcome to CarTeck</h1>
    </div>

</template>

<script>
export default {
    name: 'Home',
    props: {
    },
    data(){
        return {
            newName: ""
        }
    },
    methods: {
       saveName() {
           store.dispatch('saveName', newName.value)
           newName.value = ''
           router.push('/about')
       }
    }



}
</script>