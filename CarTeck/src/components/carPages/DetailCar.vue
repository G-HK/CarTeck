<template>
    <div
        class="bg-gray-200 justify-center h-auto"
        style="margin: 0 15%"
    >

        <div
            class="col-span-2 border-black border-2 flex align-middle w-full text-3xl" style="height:13%"
        >
            <p class="m-auto ml-5 ">{{ Dcar.Title }}</p>

            <div class="text-2xl space-y-5 mr-3 mt-2 h-auto">
                <div class="space-x-3">
                     <button id="printBtn">
                    <i class="fas fa-print"></i>
                </button>

                <button>
                    <i v-bind:class="favorite(false)"></i>
                </button>

                <span id="EyeBtn">
                    <i class="fas fa-eye"></i>
                    {{ Dcar.Saw }}
                </span>
                </div>

                <div  class="space-x-2 m-auto align-middle bottom-1 ">
                     <i class="fas fa-history"></i> 
                    <span class="text-base">
                       since : {{Dcar.CreatedDate}}
                    </span>
                </div>
               
            </div>
        </div>

        <div class="w-full flex justify-evenly h-4/5">
            <div
                class="flex justify-center align-middle m-auto border-black border-2 w-1/2 h-full"
            >
                <img
                    class="object-none md:object-scale-down overscroll-contain object-center "
                    style="padding: auto"
                    src="/src/assets/NoImage.png"
                    alt="ImageCar"
                />

                <!-- <img v-for="c in Dcar.Image"  :src="imageOne(c)" :alt="Dcar.Title"> -->

            </div>

            <div class="border-black border-2 w-1/2 ">
                <p>{{ Dcar.Brand }}</p>
                <p>{{ Dcar.Model }}</p>
                <p>{{ Dcar.FuelType }}</p>
                <p>{{ Dcar.Transmission }}</p>
                <p>{{ Dcar.DriveTrain }}</p>

                <p>{{ Dcar.Kilometer }}</p>
                <p>{{ Dcar.Torque }}</p>
                <p>{{ Dcar.Power }}</p>
                <p>{{ Dcar.BuildYear }}</p>
                <p>{{ Dcar.Doors }}</p>
                <p>{{ Dcar.Color }}</p>

                <p>{{ Dcar.BodyType }}</p>
                <p>{{ Dcar.Price }}</p>
                <p>{{ Dcar.Brand }}</p>
                <p>{{ Dcar.Brand }}</p>
            </div>
        </div>

        <div class="border-black border-2 p-10 overscroll-auto">
            <p>{{ Dcar.Description }}</p>
        </div>

        <div>
            <p> Extra's </p>
        </div>

    </div>
</template>

<script>
export default {
    name: 'DetailCar',
    props: {
        cid: Number,
    },
    data() {
        return {
            Dcar: Object,
        }
    },
    methods: {
        GetCarInfo() {
            this.Dcar = this.axios
                .get('/src/components/carPages/car.json')
                .then((res) => res.data)
                .then((dat) =>
                    dat.forEach((element) => {
                        if (element.CarID == 1) {
                            this.Dcar = element // ??? this.DCar
                            return element
                        }
                    })
                )
                .catch(function (error) {
                    console.log(error)
                })
        },
        favorite(fav) {
            return fav == true ? 'fas fa-heart' : 'far fa-heart'
        },
        imageOne(portion) {
            // for pre-build
            return '/src/assets/' + portion
        },
    },
    mounted: function () {
        this.GetCarInfo()
    },
    created() {},
}
</script>
