<template>
    <nav id="nav" class="bg-gray-800">
        <div class="max-w-7xl mx-auto px-2 sm:px-6 lg:px-8">
            <div class="relative flex items-center justify-between h-20">
                <div class="absolute inset-y-0 left-0 flex items-center sm:hidden">
                    <!-- Mobile menu button-->
                    <button
                        type="button" v-on:click="navMobile = !navMobile"
                        class="inline-flex items-center justify-center p-2 rounded-md text-gray-400 hover:text-white hover:bg-gray-700 focus:outline-none focus:ring-2 focus:ring-inset hover:ring-white"
                        aria-controls="mobile-menu"
                        aria-expanded="false"
                    >
                        
                        <!--
            Icon when menu is closed.

            Heroicon name: outline/menu

            Menu open: "hidden", Menu closed: "block"
          -->
                        <svg
                            class="block h-6 w-6"
                            xmlns="http://www.w3.org/2000/svg"
                            fill="none"
                            viewBox="0 0 24 24"
                            stroke="currentColor"
                            aria-hidden="true"
                        >
                            <path
                                stroke-linecap="round"
                                stroke-linejoin="round"
                                stroke-width="2"
                                d="M4 6h16M4 12h16M4 18h16"
                            />
                        </svg>
                        <!--
            Icon when menu is open.

            Heroicon name: outline/x

            Menu open: "block", Menu closed: "hidden"
          -->
                        <svg
                            class="hidden h-6 w-6"
                            xmlns="http://www.w3.org/2000/svg"
                            fill="none"
                            viewBox="0 0 24 24"
                            stroke="currentColor"
                            aria-hidden="true"
                        >
                            <path
                                stroke-linecap="round"
                                stroke-linejoin="round"
                                stroke-width="2"
                                d="M6 18L18 6M6 6l12 12"
                            />
                        </svg>
                    </button>
                </div>

                <div
                    class="flex-1 flex items-center justify-center sm:items-stretch sm:justify-start"
                >
                    <div class="flex-shrink-0 flex items-center"  v-on:click="RedirectHome" >
                        <img
                            class="hidden lg:block h-16 w-auto"
                            src="../../assets/CarTeckLogo.png"
                            alt="Carteck" 
                             />
                    </div>

                    <div class="sm:hidden flex justify-center w-20 h-20">
                      <img src="../../assets/CarTeckLogo.png">
                    </div>
                    <div class="hidden sm:block  m-auto justify-center">
                        <div class="flex space-x-4 justify-center">
                            <!-- Current: "bg-gray-900 text-white", Default: "text-gray-300 hover:bg-gray-700 hover:text-white" -->
                            <!-- <a href="#" class="bg-gray-900 text-white px-3 py-2 rounded-md text-sm font-medium" aria-current="page">Dashboard</a> -->

                            <router-link
                                class="text-gray-300 trans  hover:bg-gray-700  px-3 py-2 rounded-md text-xl font-medium"
                                to="/"
                                >Home</router-link>

                            <router-link
                                to='/cars'
                                class="text-gray-300 trans  hover:bg-gray-700  px-3 py-2 rounded-md text-xl font-medium"
                                >Cars</router-link>

                            <a
                                href="#"
                                class="text-gray-300 trans  hover:bg-gray-700  px-3 py-2 rounded-md text-xl font-medium"
                                >Events</a>

                            <a
                                href="#"
                                class="text-gray-300 trans  hover:bg-gray-700  px-3 py-2 rounded-md text-xl font-medium"
                                >Forum</a>

                            <a
                                href="#"
                                class="text-gray-300 trans  hover:bg-gray-700  px-3 py-2 rounded-md text-xl font-medium"
                                >Q&amp;A</a>

                            <router-link
                                class="text-gray-300 trans  hover:bg-gray-700  px-3 py-2 rounded-md text-xl font-medium"
                                to="/about"
                                >About</router-link>
                        </div>
                    </div>
                </div>
                <div class="absolute inset-y-0 right-0 flex items-center pr-2 sm:static sm:inset-auto sm:ml-6 sm:pr-0">
                    <button
                        class="bg-gray-800 p-1 rounded-full text-gray-400 hover:text-white focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-offset-gray-800 focus:ring-white">
                        <span class="sr-only">View notifications</span>
                        <!-- Heroicon name: outline/bell -->
                        <svg
                            class="h-7 w-7"
                            xmlns="http://www.w3.org/2000/svg"
                            fill="none"
                            viewBox="0 0 24 24"
                            stroke="currentColor"
                            aria-hidden="true">
                            <path
                                stroke-linecap="round"
                                stroke-linejoin="round"
                                stroke-width="2"
                                d="M15 17h5l-1.405-1.405A2.032 2.032 0 0118 14.158V11a6.002 6.002 0 00-4-5.659V5a2 2 0 10-4 0v.341C7.67 6.165 6 8.388 6 11v3.159c0 .538-.214 1.055-.595 1.436L4 17h5m6 0v1a3 3 0 11-6 0v-1m6 0H9"
                            />
                        </svg>
                    </button>

                    <div class="py-1 flex flex-col justify-center">
                        <div class="flex items-center justify-center">
                            <div
                                class="relative inline-block text-left dropdown">
                                <span class="rounded-md shadow-sm">
                                    <button v-on:click="isActive = !isActive"
                                        class="inline-flex justify-center w-full px-4 py-2 text-sm font-medium leading-5 text-gray-700 transition duration-150 ease-in-out border-gray-300 rounded-md hover:text-gray-500 focus:outline-none focus:border-blue-300 focus:shadow-outline-blue active:bg-gray-50 active:text-gray-800"
                                        type="button"
                                        aria-haspopup="true"
                                        aria-expanded="true"
                                        aria-controls="headlessui-menu-items-117">
                                    
                                        <img
                                            class="h-10 w-10 rounded-full"
                                            src=""
                                            alt="profile Image"
                                            onerror="this.onerror=null; this.src='/src/assets/NoImage.png'"
                                        />
                                    </button>
                                </span>
                                <div  :style="{ visibility: isActive ? 'visible' : 'hidden' }"
                                 class="opacity-0 dropdown-menu transition-all duration-300 transform origin-top-right -translate-y-2 scale-95 ">
                                    <div
                                        class="absolute right-0 w-56 mt-2 origin-top-right bg-white border border-gray-200 divide-y divide-gray-100 rounded-md shadow-lg outline-none"
                                        aria-labelledby="headlessui-menu-button-1"
                                        id="headlessui-menu-items-117"
                                        role="menu">

                                        <div class="px-4 py-3" role="menuitem">
                                            <p class="text-sm leading-5">
                                                Signed in as
                                            </p>
                                            <p
                                                class="text-sm font-medium leading-5 text-gray-900 truncate">
                                                user@example.com
                                            </p>
                                        </div>
                                        <div class="py-1">

                                            <router-link to="/AccountSetting"  class="text-gray-700 flex justify-between w-full px-4 py-2 text-sm leading-5 text-left"
                                                role="menuitem"
                                                >Account settings
                                            </router-link>
                                            <a
                                                href="javascript:void(0)"
                                                class="text-gray-700 flex justify-between w-full px-4 py-2 text-sm leading-5 text-left"
                                                role="menuitem"
                                                >Support</a
                                            >
                                            <span
                                                role="menuitem"
                                                class="flex justify-between w-full px-4 py-2 text-sm leading-5 text-left text-gray-700 cursor-not-allowed opacity-50"
                                                aria-disabled="true"
                                                >New feature (soon)</span
                                            >
                                            <a
                                                href="javascript:void(0)"
                                                class="text-gray-700 flex justify-between w-full px-4 py-2 text-sm leading-5 text-left"
                                                role="menuitem"
                                                >License</a
                                            >
                                        </div>
                                        <div class="py-1">
                                            <a
                                                href="javascript:void(0)"
                                                class="text-gray-700 flex justify-between w-full px-4 py-2 text-sm leading-5 text-left"
                                                role="menuitem"
                                                >Sign out</a
                                            >
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Mobile menu, show/hide based on menu state. -->
        <div
            class="sm:hidden m-auto justify-center"
            :style="{ display: navMobile ? 'none' : 'flex'}"
            id="mobile-menu">
            <div class="px-2 pt-2 pb-3 space-y-1">
                <!-- Current: "bg-gray-900 text-white", Default: "text-gray-300 hover:bg-gray-700 hover:text-white" -->
                <!-- <a href="#" class="bg-gray-900 text-white block px-3 py-2 rounded-md text-base font-medium" aria-current="page">Dashboard</a> -->

                <router-link
                    class="text-gray-300 hover:bg-gray-700 hover:text-white block px-3 py-2 rounded-md text-base font-medium"
                    to=""
                    >Home</router-link
                >

                 <router-link
                                to='/cars'
                    class="text-gray-300 hover:bg-gray-700 hover:text-white block px-3 py-2 rounded-md text-base font-medium"
                    >Cars</router-link
                >

                <a
                    href="#"
                    class="text-gray-300 hover:bg-gray-700 hover:text-white block px-3 py-2 rounded-md text-base font-medium"
                    >Events</a
                >

                <a
                    href="#"
                    class="text-gray-300 hover:bg-gray-700 hover:text-white block px-3 py-2 rounded-md text-base font-medium"
                    >Forum</a
                >
                  <a
                    href="#"
                    class="text-gray-300 hover:bg-gray-700 hover:text-white block px-3 py-2 rounded-md text-base font-medium"
                    >Q&amp;A</a
                >

                <router-link
                    class="text-gray-300 hover:bg-gray-700 hover:text-white block px-3 py-2 rounded-md text-base font-medium"
                    to="/about"
                    >About</router-link
                >
                
            </div>
        </div>
    </nav>
</template>

<script>
export default {
    name: 'Header',

    data() {
      return{
        isActive: false, 
        navMobile: true
      }
    },
    methode: {
        RedirectHome:function(){
            this.$router.push({name:'Home'});
        },        
    },
}
</script>
<style>
.dropdown:focus-within .dropdown-menu {
    opacity: 1;
    transform: translate(0) scale(1);
    visibility: visible;
}
.trans:hover {
    text-shadow: 0px 3px 10px 5px rgb(233, 116, 7);
    background-position: -99.99% 1;
    text-decoration: underline;    
    color: rgb(233, 116, 7);
    transition: color 0.3s ease-in;


}
</style>
