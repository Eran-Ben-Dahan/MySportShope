// import logo from "./logo.svg";
import "./App.css";
import { Route,Routes} from "react-router-dom";
import Protected from "./components/Protected/Protected";
import Login from "./components/Login/Login";
import BackOffice from "./components/BackOffice/BackOffice";
import ProductList from "./components/ProductList/ProductList";
import ProductForm from "./components/ProductForm/ProductForm";
import React from "react";
import NavBar from "./components/nav/NavBar";
import About from "./pages/About/About";
import Footer from "./components/Footer/Footer.jsx";
import Home from "./pages/Home/Home.jsx";
// import { useSelector } from "react-redux";
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
    
    <div >
        <NavBar />
        <Routes>
          <Route path="/Login" element={<Login />} />
          <Route path="*" element={<Home/>} />
          <Route path="/backoffice" element={ <Protected> <BackOffice /></Protected> } >
            <Route path="product" element={<ProductList />} />
            <Route path="product/new" element={<ProductForm />} />
            <Route path="product/edit/:id" element={<ProductForm />} />
          </Route>
          <Route path="/products/:PpersonType/:category/:subcategory" element={<Home />} />
          <Route path="/about" element={<About/>} />
        </Routes>
      <Footer/>
    </div>
  );
}

export default App;

