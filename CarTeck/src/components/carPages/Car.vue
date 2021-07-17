<template>
    <div class="inline-flex p-3 m-auto w-full justify-center">
    <Filter/>
    
    <div class="w-3/5 bg-gray-200 shadow-lg ml-3 text-center">
            <h1 class="text-xl">Cars</h1>
           <ViewCar v-for="carD in carData" v-bind:car="carD" />
    </div>

    </div>
</template>
<script>
import Filter from './Filter.vue'; 
import ViewCar from './SelectCar.vue';

import carData from './car.json';

export default {
    name: 'Cars',
    data() {
        return {
            carData
        }
    },
    components:{
        Filter,
        ViewCar
    }
}
</script>