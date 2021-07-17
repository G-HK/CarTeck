<template>

    <div class="bg-purple-200 w-80 text-center ">
        <h1 class="text-2xl">Filter</h1>
        <hr class="border-black">

        <form class="width text-center w-3/4 m-auto  p-1">

            <div class="block mt-2">
                 <span class="text-gray-700 text-xl">Brand</span>
                 <select class="form-select block w-full mt-1 rounded-lg h-8 text-lg">
                    <option class="All">All</option>
                    <option class="m-auto">BMW</option>
                    <option class="Mecredes-Benz">Mercedes</option>
                </select>  
            </div>

            <div class="block mt-2">
                 <span class="text-gray-700 text-xl">Model</span>
                 <select class="form-select block w-full mt-1 rounded-lg h-8 text-lg">
                     <option value="All">All</option>
                     <option value="M">M3</option>
                    <option value="GTR">AMG</option>
                </select>  
            </div>

            <div class="block mt-2">
                 <span class="text-gray-700 text-xl">Transmission</span>
                 <select class="form-select block w-full mt-1 rounded-lg h-8 text-lg">
                    <option value="Default">All</option>
                    <option value="Manual">Manual</option>
                    <option value="Automatica">Automatica</option>
                    <option value="Sequal">Sequal</option>
                </select>  
            </div>

            <div class="block mt-2">
                 <span class="text-gray-700 text-xl">BodyType</span>
                 <select class="form-select block w-full mt-1 rounded-lg h-8 text-lg">
                    <option value="All">All</option>
                    <option value="Coupé">Coupé</option>
                    <option>Berlin</option>
                    <option>Hatch</option>
                    <option>Van</option>
                </select>  
            </div>

            <div class="block mt-2">
                 <span class="text-gray-700 text-xl">DriveTrain</span>
                 <select class="form-select block w-full mt-1 rounded-lg h-8 text-lg">
                    <option value="All">All</option>
                    <option value="FWD">Front Wheel Drive</option>
                    <option value="RWD">Reer Wheel Drive</option>
                    <option value="AWD">All Wheel Drive</option>
                </select>  
            </div>

            <div class="block mt-2">
                <span class="text-gray-700 text-xl">Price</span>
                <div class="flex justify-center">
                    <input type="text" class="w-1/3 form-input text-center rounded-lg" placeholder="BeginPrice"> 
                    <span class="text-xl ml-1 mr-1"> until </span> 
                    <input type="text" class="w-1/3 form-input text-center rounded-lg" placeholder="EndPrice">
                </div>
            </div>
            
            <div class="block mt-2">
                <span class="text-gray-700 text-xl">KM</span> 
                <div class="flex justify-center">
                    <input type="text" class="w-1/3 form-input text-center rounded-lg" placeholder="from"> 
                    <span class="text-xl ml-1 mr-1"> until </span> 
                    <input type="text" class="w-1/3 form-input text-center rounded-lg" placeholder="to">
                 </div>
            </div>


           <div class="block mt-2">
                 <span class="text-gray-700 text-xl">FuelType</span>
                 <select class="form-select block w-3/5 mt-1  m-auto text-center rounded-lg h-8 text-lg">
                    <option value="Bezine">Benzine</option>
                <option value="Diesel">Diesel</option>
                <option value="Electric">Electric</option>
                </select>  
            </div>

            <div class="block mt-2">
                <span class="text-gray-700 text-xl">KW/PK</span> 
                <div class="flex justify-center">
                    <input type="text" class="w-1/3 form-input text-center rounded-lg" placeholder="from"> 
                    <span class="text-xl ml-1 mr-1"> until </span> 
                    <input type="text" class="w-1/3 form-input text-center rounded-lg" placeholder="to">
                 </div>
            </div>

            <div class="block mt-2">
                 <span class="text-gray-700 text-xl">Doors</span>
                 <select class="form-select block w-3/5 mt-1  m-auto text-center rounded-lg h-8 text-lg">
                    <option value="Null" aria-placeholder="All"></option>
                    <option value="2/3">2/3</option>
                    <option value="4/5">4/5</option>
                    <option value="6/7">6/7</option>
                </select>  
            </div>

            
            <div class="block mt-2">
                 <span class="text-gray-700 text-xl">Color</span>
                 <select class="form-select block w-3/5 mt-1  m-auto text-center rounded-lg h-8 text-lg">
                    <option value="All">All</option>
                    <option value="Red">Red</option>
                    <option value="Green">Green</option>
                    <option value="Black">Black</option>
                </select>  
            </div>


        </form>

        



        

    </div>
</template>

<script>
export default {
    name: 'FilterCar'
}
</script>
