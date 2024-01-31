import React, { useEffect } from "react";
import NavDropdown from "react-bootstrap/NavDropdown";
import { useDispatch, useSelector } from "react-redux";
import { fetchPersoneType } from "../../features/personType-slice";
import { useNavigate } from "react-router-dom";
import "bootstrap/dist/css/bootstrap.min.css";
import "./NavBar.css";
import TopNavLink from "./TopNavLink";
import Logo from "../Logo/Logo";
import Login from "../Login/Login";

const NavBar = () => {
  const personeTypes = useSelector((state) => state.person.data);

  const dispatch = useDispatch();
  const navigate = useNavigate();

  useEffect(() => {
    dispatch(fetchPersoneType());
  }, [dispatch]);

  return (
    <nav className="navbar navbar-expand-lg navbar-light">
      {" "}
      <div className="container-fluid">
        <a className="navbar-brand text-white" href="/">
          {" "}
          <Logo />
        </a>

        <div className="collapse navbar-collapse" id="navbarNav">
          <ul className="navbar-nav">
            {personeTypes.map((personeType) => (
              <li className="nav-item" key={personeType.id}>
                <NavDropdown
                  title={personeType.name}
                  id={`nav-dropdown-${personeType.id}`}
                >
                  {personeType.categories.map((category) => (
                    <NavDropdown
                      title={category.name}
                      key={category.id}
                      id={`nav-dropdown-${category.id}`}
                    >
                      {category.subcategories.map((subcategory) => (
                        <NavDropdown.Item
                          key={subcategory.id}
                          onClick={() =>
                            navigate(
                              `/products/${personeType.name}/${category.name}/${subcategory.name}`
                            )
                          }
                        >
                          {subcategory.name}
                        </NavDropdown.Item>
                      ))}
                    </NavDropdown>
                  ))}
                </NavDropdown>
              </li>
            ))}
            <TopNavLink to="/about" label="About" />
            <button
              className="btn btn-outline-light"
              onClick={() => navigate("/Login")} >
              Login
            </button>
          </ul>
        </div>
      </div>
    </nav>
  );
};

export default NavBar;

// import { useEffect } from "react";
// import NavDropdown from "react-bootstrap/NavDropdown";
// import { useDispatch, useSelector } from "react-redux";
// import { fetchPersoneType } from "../../features/personType-slice";
// import { useNavigate } from "react-router-dom";
// import './NavBar.css';

// const NavBar = () => {
//   const personeTypes = useSelector((state) => state.person.data);

//   const dispatch = useDispatch();
//   const navigate = useNavigate();

//   useEffect(() => {
//     dispatch(fetchPersoneType());
//   }, [dispatch]);

//   return (
//     <div>
//       {personeTypes.map((personeType) => (
//         <NavDropdown title={personeType.name} key={personeType.id}>
//           {personeType.categories.map((category) => (
//             <NavDropdown title={category.name} key={category.id}>
//               {category.subcategories.map((subcategory) => (
//                 <NavDropdown.Item key={subcategory.id} onClick={() =>  navigate(  `/products/${personeType.name}/${category.name}/${subcategory.name}` )  }   >
//                   {subcategory.name}
//                 </NavDropdown.Item>
//               ))}
//             </NavDropdown>
//           ))}
//         </NavDropdown>
//       ))}
//     </div>
//   );
// };

// export default NavBar;

// NavBar.jsx

// NavBar.jsx
