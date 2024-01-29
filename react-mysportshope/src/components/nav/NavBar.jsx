

import { useEffect } from "react";
import NavDropdown from "react-bootstrap/NavDropdown";
import { useDispatch, useSelector } from "react-redux";
import { fetchPersoneType } from "../../features/personType-slice";
import { useNavigate } from "react-router-dom";

const NavBar = () => {
  const personeTypes = useSelector((state) => state.person.data);
  
  const dispatch = useDispatch();
  const navigate = useNavigate();

  useEffect(() => {
    dispatch(fetchPersoneType());
  }, [dispatch]);

  return (
    <>
      {personeTypes.map((personeType) => (
        <NavDropdown title={personeType.name} key={personeType.id}>
          {personeType.categories.map((category) => (
            <NavDropdown title={category.name} key={category.id}>
              {category.subcategories.map((subcategory) => (
                <NavDropdown.Item key={subcategory.id} onClick={() =>  navigate(  `/products/${personeType.name}/${category.name}/${subcategory.name}` )  }   >
                  {subcategory.name}
                </NavDropdown.Item>
              ))}
            </NavDropdown>
          ))}
        </NavDropdown>
      ))}
    </>
  );
};

export default NavBar;
