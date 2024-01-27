// import logo from "./logo.svg";
import "./App.css";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Protected from "./components/Protected/Protected";
import Login from "./components/Login/Login";
import BackOffice from "./components/BackOffice/BackOffice";
import ProductList from "./components/ProductList/ProductList";
import ProductForm from "./components/ProductForm/ProductForm";
// import { useSelector } from "react-redux";
import TopNav from "./components/nav/TopNav";


function App() {
  // const isDark = useSelector((state)=> state.theme.isDark)
    

  return (
    <div>
      <TopNav/>
    <BrowserRouter>
      <h1>welcome to my site</h1>
      <Routes>
        <Route path="/Login" element={<Login />} />
        <Route path="*" element={<div>Home</div>} />
        <Route
          path="/backoffice"
          element={
            <Protected>
              <BackOffice />
               </Protected>}>
          <Route path="product" element={<ProductList />} />
          <Route path="product/new" element={<ProductForm />} />
          <Route path="product/edit/:id" element={<ProductForm />} />
        </Route>
      </Routes>
    </BrowserRouter>
     </div>

  );
}

export default App;
