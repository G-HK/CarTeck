<template>
    <div class="inline-flex p-3 m-auto w-full justify-center">
        <Filter />

        <div class="w-3/5 bg-gray-200 shadow-lg ml-3 text-center">
            <h1 class="text-xl">Cars</h1>
            <ViewCar v-for="car in cars" v-bind:car="car" :key="car" />
        </div>
    </div>
</template>
<script>
import Filter from './Filter.vue'
import ViewCar from './SelectCar.vue'

import cars from './car.json'

export default {
    name: 'Cars',
    data() {
        return {
            cars,
        }
    },
    components: {
        Filter,
        ViewCar,
    },

    methods: {
        bookType(bType) {
            cars = cars.Filter((test) => test.BodyType == 'Berline')
        },
    },
}
</script>
