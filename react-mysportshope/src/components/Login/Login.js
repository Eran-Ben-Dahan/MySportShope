

import React, { useState } from "react";
import api from "../../utils/api";
import { useNavigate } from "react-router-dom";
import "./Login.css"; // Import your custom CSS

const Login = () => {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");
  const navigate = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();

    const loginData = {
      username,
      password,
    };

    api
      .post("Login", loginData)
      .then((result) => {
        if (result.status === 200) {
          localStorage.setItem("My_token", result.data);
          navigate("/backoffice");
        } else {
          localStorage.setItem("My_token", "");
          setError(`Could not login (${result.status})`);
        }
      })
      .catch((ex) => {
        localStorage.setItem("My_token", "");
        setError("Error during login");
        console.error(ex);
      });
  };

  return (
    <div className="login-container">
      <form onSubmit={handleSubmit} className="login-form">
        <label>
          Username:
          <input
            type="text"
            value={username}
            placeholder="Enter your username"
            onChange={(e) => setUsername(e.target.value)}
          />
        </label>
        <br />

        <label>
          Password:
          <input
            type="password"
            value={password}
            placeholder="Password"
            onChange={(e) => setPassword(e.target.value)}
          />
        </label>
        <br />
        <button type="submit" className="login-button">
          Login
        </button>
      </form>
      {error && <h3 className="error-message">{error}</h3>}
    </div>
  );
};

export default Login;
