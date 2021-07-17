<template>
    <div
        class="divide-y divide-gray-400 mx-2 my-4 bg-white"
        style="box-shadow: rgb(0 0 0 / 30%) 0px 20px 9px"
    >
        <div class="flex relative h-10">
            <span
                class="m-auto text-2xl absolute inset-y-0 left-3 p-1"
                style="font-family: Helvetica"
            >
                {{ car.Title }}
            </span>
            <span
                class="m-auto p-1 italic text-3xl font-sans absolute inset-y-0 right-3"
            >
              € {{ car.Price}} 
            </span>
        </div>

        <div
            @dblclick="detailsView(car.CarID)"
            :id="car.CarID"
            class="divide-black divide-x-2 grid grid-cols-3 grid-rows-1 h-48 cursor-pointer"
        >
            <div
                class="grid-cols-1 grid-rows-1 flex justify-center align-middle"
            >
                <img
                    class="object-none md:object-scale-down overscroll-contain object-center"
                    style="padding: auto"
                    :src="imageOne(car.Image[0])"
                    alt="ImageCar"
                />
            </div>

            <div
                class="black w-full text-left grid-cols-2 grid-rows-1 col-span-2"
            >
                <div
                    class="relative w-full grid grid-cols-3 grid-rows-1 max-h-full"
                >
                    <div class="m-1 mr-10 text-lg p-2 grid-cols-1 grid-rows-1">
                        <p>Brand: {{ car.Brand }}</p>
                        <p>Model: {{ car.Model }}</p>
                        <p>FuelType: {{ car.FuelType }}</p>
                        <p>Transmission: {{ car.Transmission }}</p>
                    </div>

                    <div class="m-1 text-lg p-2 grid-cols-2 grid-rows-1">
                        <p>DriveTrain : {{ car.DriveTrain }}</p>
                        <p>Torque: {{ car.Torque }}</p>
                        <p>Power: {{ car.Power }}</p>
                        <p>Kilometer: {{ car.Kilometer }}</p>
                    </div>

                    <div class="grid grid-cols-1 grid-rows-2 text-right">
                        <div
                            class="grid-cols-1 grid-rows-1 align-middle space-x-2 mr-1 mt-2"
                        >
                            <span class="text-lg">
                                {{ car.Saw }}
                                <i class="fas fa-eye text-xl"></i>
                            </span>

                            <button>
                                <i v-bind:class="favorite(false)"></i>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="grid grid-cols-3 grid-rows-1">
            <div class="m-auto flex ml-4 align-middle">
                <p>Country</p>
                <br />
                <p>state - city - street - streetNumber</p>
                <button class="ml-2" @click="">
                    <i class="fas fa-map-marker-alt"></i>
                </button>
            </div>

            <div class="m-0 flex">
                <router-link
                    :to="{ name: 'User', params: { userID: car.sellerID } }"
                    class="grid-cols-1 grid-rows-2 m-1 h-auto w-auto inline-flex align-middle"
                >
                    <img
                        src="/src/assets/NoImage.png"
                        class="w-10 h-10 m-auto"
                    />
                    <p class="m-auto pl-2">{{ car.SellerName }}</p>
                </router-link>
            </div>

            <div class="ml-auto mr-0 m-auto flex justify-end align-middle">
                <form>
                    <div class="rate text-2xl">
                        <input type="radio" id="star5" name="rate" value="5" />
                        <label for="star5" title="text">5 stars</label>
                        <input type="radio" id="star4" name="rate" value="4" />
                        <label for="star4" title="text">4 stars</label>
                        <input type="radio" id="star3" name="rate" value="3" />
                        <label for="star3" title="text">3 stars</label>
                        <input type="radio" id="star2" name="rate" value="2" />
                        <label for="star2" title="text">2 stars</label>
                        <input type="radio" id="star1" name="rate" value="1" />
                        <label for="star1" title="text">1 star</label>
                    </div>
                </form>
            </div>
        </div>
    </div>
</template>
<script>

export default {
    name: 'SelectCar',
    props: {
        car: Object,
        user: Object,
    },
    data() {
        return {
            imgPath: 'src/assets/', //weird
        }
    },
    methods: {
        detailsView(id) {
            this.$router.push({ name: 'Details', params: { CarID: id }  })
        },
        // viewSeller(sellerID){
        //     this.$router.push({ name: 'User', params:{userID: sellerID }})
        // },
        imageOne(portion) {
            //console.log(this.imgPath +portion ) // to see if the path is correct.
            return this.imgPath + portion
        },
        favorite(fav) {
            return fav == true
                ? 'fas fa-heart text-2xl'
                : 'far fa-heart text-2xl'
        },
        OpenMaps() {
            // opens google maps
        },
    },
    components: {
    },
}
</script>

<style>
.rate {
    /* float: left; */
    padding: 0 10px;
    align-content: center;
}
.rate:not(:checked) > input {
    position: absolute;
    top: -9999px;
}
.rate:not(:checked) > label {
    float: right;
    width: 1em;
    overflow: hidden;
    white-space: nowrap;
    cursor: pointer;
    font-size: 28px;
    color: #ccc;
}
.rate:not(:checked) > label:before {
    content: '★ ';
}
.rate > input:checked ~ label {
    color: #ffc700;
}
.rate:not(:checked) > label:hover,
.rate:not(:checked) > label:hover ~ label {
    color: #deb217;
}
.rate > input:checked + label:hover,
.rate > input:checked + label:hover ~ label,
.rate > input:checked ~ label:hover,
.rate > input:checked ~ label:hover ~ label,
.rate > label:hover ~ input:checked ~ label {
    color: #c59b08;
}
</style>
