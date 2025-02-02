import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";

import firebase from 'firebase';


// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
  apiKey: "",
  authDomain: "crtk-demo.firebaseapp.com",
  databaseURL: "",
  projectId: "crtk-demo",
  storageBucket: "crtk-demo.appspot.com",
  messagingSenderId: "",
  appId: "",
  measurementId: ""
};

// Initialize Firebase
firebase.initializeApp(firebaseConfig);


createApp(App).use(router).use(firebase).mount("#app");
