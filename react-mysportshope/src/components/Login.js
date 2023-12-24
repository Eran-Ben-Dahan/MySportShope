import React from "react";
import { useState } from "react";

const Login = () => {
    const [username, setusername] = useState('');
    const [password, setpassword] = useState('')

    const hendleSubmit=(e)=>{
        e.preventDefault();
    }
  return (
    <form onSubmit={hendleSubmit}>
      <label>
        Username:
        <input type="text" value={username} placeholder="enter your username" onChange={e=>setusername(e.target.value)}/>
      </label><br/>

      <label>password:
        <input type="text" value={password} placeholder="password" onChange={e=>setpassword(e.target.value)} />
      </label><br/>
      <button>Login</button>
    </form>
  );
};

export default Login;
