// import logo from "./logo.svg";
import "./App.css";
import { Route,Routes} from "react-router-dom";
import Protected from "./components/Protected/Protected";
import Login from "./components/Login/Login";
import BackOffice from "./components/BackOffice/BackOffice";
import ProductList from "./components/ProductList/ProductList";
import ProductForm from "./components/ProductForm/ProductForm";
// import { useSelector } from "react-redux";
import React from "react";
import NavBar from "./components/nav/NavBar";


function App() {
  // const isDark = useSelector((state)=> state.theme.isDark)
  // const Home = () => <div>Home Page</div>;
  // const Category = ({ match }) => <div>{match.params.category} Page</div>;
  // const SubCategory = ({ match }) => (
  //   <div>
  //     {" "}
  //     {match.params.category} , {match.params.subcategory} Page{" "}
  //   </div>
  // );

  return (
    <div>
        <NavBar />
        <h1>welcome to my site</h1>
        <Routes>
          <Route path="/Login" element={<Login />} />
          <Route path="*" element={<div>Home</div>} />
          <Route path="/backoffice" element={ <Protected> <BackOffice /></Protected> } >
            <Route path="product" element={<ProductList />} />
            <Route path="product/new" element={<ProductForm />} />
            <Route path="product/edit/:id" element={<ProductForm />} />
          </Route>
        </Routes>
      
    </div>
  );
}

export default App;

