import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Route,Routes } from 'react-router-dom';
import Protected from './components/Protected';
import Login from './components/Login';
import BackOffice from './components/BackOffice'
import ProductList from './components/ProductList'


function App() {
  return (
   <BrowserRouter>
   <h1>welcome to my site</h1>
   <Routes>
   <Route path="/Login" element={<Login/>}/>
     <Route path='*' element={<div>Home</div>}/>
     
   <Route path="/backoffice" element={ <Protected><BackOffice/></Protected>}> 
   <Route path="product" element={<ProductList/>}/>
    </Route>
    </Routes>
   </BrowserRouter>
  );
}

export default App;
