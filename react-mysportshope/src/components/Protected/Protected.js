
import { Navigate } from "react-router-dom";
function Protected({children}){
const isAuthenticated=Boolean(localStorage.getItem("My_token"));

if(isAuthenticated){
    return children;
}
    return <Navigate to='/login'/>
}

export default Protected