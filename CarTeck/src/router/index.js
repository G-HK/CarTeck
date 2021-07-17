import { createRouter,  createWebHistory } from 'vue-router'

import Home from '/src/components/Home.vue';

import About from '/src/components/About.vue';


import Car from '/src/components/carPages/Car.vue';


import Details from '/src/components/carPages/DetailCar.vue';

import User from '/src/components/UserPages/UserInfo.vue';

import AccountSetting from '/src/components/UserPages/AccountSetting.vue';


import NotFound from '/src/components/404.vue';



import Search from '/src/components/Search.vue';

const routes = [
    {
    path: '/',
    name: 'Home',
    component: Home,
    },
    {
        path: '/about',
        name: 'About',
        component: About,
    },    
    {
        path: '/cars',
        name: 'Cars',
        component: Car,
    },
    {
        path: '/cars/:CarID',
        name: 'Details',
        component: Details
    },
    {
        path: '/user/:userID',
        name: 'User',
        component: User
    },
    {
        path: '/AccountSetting',
        name: 'AccountSetting',
        component: AccountSetting
    },
    {
        path: '/search',
        name: 'Search',
        component: Search,
        props: route => ({ query: route.query.q })
    },
    // {
    //     path: "*",
    //     name: '404',
    //     component: NotFound,
    // }
]

const router = createRouter({
    history: createWebHistory(),
    routes,
})

export default  router