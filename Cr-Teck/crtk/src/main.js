import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";

import firebase from 'firebase';


// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
  apiKey: "AIzaSyDlhuDyRTqZROiZ1GXQ2cCIUMk2Znkajy4",
  authDomain: "crtk-demo.firebaseapp.com",
  databaseURL: "https://crtk-demo-default-rtdb.europe-west1.firebasedatabase.app",
  projectId: "crtk-demo",
  storageBucket: "crtk-demo.appspot.com",
  messagingSenderId: "785358660980",
  appId: "1:785358660980:web:d9e30befa374dd8167f821",
  measurementId: "G-N1ZEF6TSQD"
};

// Initialize Firebase
firebase.initializeApp(firebaseConfig);


createApp(App).use(router).use(firebase).mount("#app");
