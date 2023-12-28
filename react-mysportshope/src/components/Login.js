import React from "react";
import { useState } from "react";
import api from "../utils/api"
import { useNavigate } from "react-router-dom";

const Login = () => {
    const [username, setusername] = useState('');
    const [password, setpassword] = useState('');
    const [error, setError] = useState("");
    const nav=useNavigate();

    const hendleSubmit=(e)=>{
        e.preventDefault();

        const loginData= {
        username,
        password,
    };

    api.post('Login',loginData).then
    ((result)=>{
      if(result.status===200){
        localStorage.setItem("My_token", result.data);
        console.log("Logged in-success");
        nav("/backoffice")
      } else{

        localStorage.setItem("My_token", "");
        console.log("Logged in- not success");
        setError(`could not login(${result.status})`);
      }

    })
    .catch((ex)=>{
      localStorage.setItem("My_token", "");
      setError(ex);
      console.error(ex);
    })
    };
  return (
    <>
    <form onSubmit={hendleSubmit}>
      <label>
        Username:
        <input type="text" value={username} placeholder="enter your username" onChange={e=>setusername(e.target.value)}/>
      </label><br/>

      <label>password:
        <input type="password" value={password} placeholder="password" onChange={e=>setpassword(e.target.value)} />
      </label><br/>
      <button type="submit">Login</button>
    </form>
    {error !== "" ?? <h3>Error during login</h3>}
    </>
  );
};

export default Login;
