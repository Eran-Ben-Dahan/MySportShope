import React from "react";
import { NavLink } from "react-router-dom";
import './TopNavLink.css'

const TopNavLink = ({ label, to }) => {
  return (
    <li className="nav-item">
      <NavLink className="nav-link"to={to}>
        {label}
      </NavLink>
    </li>
  );
};

export default TopNavLink;
