import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Route,Routes } from 'react-router-dom';
import Protected from './components/Protected';
import Login from './components/Login';


function App() {
  return (
   <BrowserRouter>
   <h1>welcome to my site</h1>
   <Routes>
   <Route path="/Login" element={<Login/>}/>
   <Route path="/backoffice" element={<Protected><div>Back office</div></Protected>}/>
   <Route path='*' element={<div>Home</div>}/>
    </Routes>
   </BrowserRouter>
  );
}

export default App;
