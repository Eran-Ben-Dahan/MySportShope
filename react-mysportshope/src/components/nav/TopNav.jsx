import React from "react";
import { Navbar, Container, Nav } from "react-bootstrap";
import { NavLink } from "react-router-dom";
import { BiCameraMovie } from "react-icons/bi";
import TopNavLink from "./TopNavLink";
import NavDropdown from "react-bootstrap/NavDropdown";
import "./TopNav.css";
// import Login from "./Login";
// import Swal from "sweetalert2";
// import Login from './Login'
// import BtnDarkMode from './BtnDarkMode/BtnDarkMode'


const TopNav = () => {
  return (
    <Navbar  expand="lg" className="navbar">
        +
      <Container className="container">
        {/* BRAND: logo + app name */}
          <NavLink to="/" className="navbar-brand">
        {/* <span className="text-muted">Movie App</span> */}
        <BiCameraMovie className="logoIcon" color="#ecba25" />
        </NavLink>
        
        {/* BURGER */}
        <Navbar.Toggle aria-controls="basic-navbar-nav" className="color=FFDE00" />
        <Navbar.Collapse id="basic-navbar-nav" className="NavbarCollapse">
          <Nav className="me-auto">
            <TopNavLink to="*" label="Home" />
            <TopNavLink to="*" label="Movies"/>
              <NavDropdown to="*" label="Movies" title="Categories" id="basic-nav-dropdown">
              <NavDropdown.Item href="*">Romance</NavDropdown.Item>
              <NavDropdown.Item href="*">War</NavDropdown.Item>
              <NavDropdown.Item href="*">Music</NavDropdown.Item>
             </NavDropdown>
            <TopNavLink to="*" label="Favorites" />
            <TopNavLink to="*" label="Comments" />``
            <TopNavLink to="*" label="About" />
          </Nav>
        </Navbar.Collapse>
      </Container>
      {/* <Login /> */}
          {/* <BtnDarkMode className="BtnDarkMode"/> */}
    </Navbar>
  );
};
export default TopNav;






// // export default TopNav;
// import { useEffect } from "react";
// import NavDropdown from "react-bootstrap/NavDropdown";
// import { useDispatch, useSelector } from "react-redux";
// import { fetchPersoneType } from "../../features/PersoneType-slice";
// import { Dropdown } from "react-bootstrap";
// import { useNavigate } from "react-router-dom";





// const DropDown = () => {
 
//   const PersoneType = useSelector((state) => state.departments.data);
//   const  navigate  = useNavigate();

//   const dispatch = useDispatch();
//   useEffect(() => {
//     dispatch(fetchPersoneType());
//   }, []);
//   return (
//     <>
//       {PersoneType.map((d) => (
//         <NavDropdown title={d.name} key={d.id}>
//           {d.categories.map((c) => (
//             <NavDropdown key={c.id} title={c.name}>
//               {c.subcategories.map((s) => (
//                 <Dropdown.Item
//                   key={s.id}
//                   onClick={() => navigate(`/products/${d.name}/${c.name}/${s.name}`)}
//                 >
//                   <li>{s.name}</li>
//                 </Dropdown.Item>
//               ))}
//             </NavDropdown>
//           ))}
//         </NavDropdown>
//       ))}
//     </>
//   );
// };

// export default DropDown;

