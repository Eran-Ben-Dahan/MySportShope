// import axios from "axios";


// const api =axios.create({baseURL:"https://localhost:7291/api/",});

// api.interceptors.request.use((o)=>{

//     const token = localStorage.getItem("My_token");
//     o.headers.Authorization=token ? `Bearer ${token}`:"";
//     return o;
// });
// export default api;



// api.js
import axios from "axios";

const api = axios.create({
  baseURL: "https://localhost:7291/api/",
});

api.interceptors.request.use((o) => {
  const token = localStorage.getItem("My_token");
  o.headers.Authorization = token ? `Bearer ${token}` : "";
  return o;
});

export const cancelRequest = () => {
  // Implement logic to cancel the ongoing request if needed
};

export const fetchUser = async () => {
  return new Promise(async (resolve, reject) => {
    try {
      const response = await api.get("/login/GetUser", {
        headers: {
          Authorization: `Bearer ${localStorage.getItem("My_token")}`,
          "Content-Type": "application/json",
        },
      });
      const user = response.data;
      // dispatch the user into the redux
      // also do this in the App itself
      // if there is a token in the localStorage
      // do the action we did here and store the user object in redux
      resolve(user);
    } catch (e) {
      reject(e);
    }
  });
};

export default api;
