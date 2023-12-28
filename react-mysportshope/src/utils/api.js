import axios from "axios";

const api =axios.create({baseURL:"https://localhost:7291/api/",});

api.interceptors.request.use((o)=>{

    const token = localStorage.getItem("My_token");
    o.headers.Authorization=token ? `Bearer ${token}`:"";
    return o;
});
export default api;