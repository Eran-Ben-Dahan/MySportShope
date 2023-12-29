import React from "react";
import { useState, useEffect } from "react";
import api from "../utils/api";
import { Button, Table } from "react-bootstrap";
import { Link } from "react-router-dom";

function ProductList() {
  const [items, setitems] = useState([]);

  useEffect(() => {
    api
      .get("Product")
      .then((result) => {
        console.log(result.data);
        setitems(result.data);
      })
      .catch((ex) => console.error(ex));
  }, []);
 
  return (
    <>
      <h3>product List</h3>
      <Button as={Link} to="new">
        Add New
      </Button>
      <Table striped bordered>
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            {/* <th>Description</th> */}
            <th>Manufacturer</th>
            {/* <th>ItemSizes</th> */}
            <th>Colors</th>
            {/* <th>SubCategory</th> */}
            <th>Images</th>
            <th>price</th>
            {/* <th>BoxSizes</th> */}
            {/* <th>PersoneType</th> */}
            {/* <th>OrderItems</th> */}
          </tr>
        </thead>
        <tbody>
          {items.map((p) => (
            <tr key={p.id}>
              <td>{p.id}</td>
              <td>{p.name}</td>
              <td>{p.manufacturer}</td>
              <td>{p.image}</td>
              <td>
                <Button as={Link} to={`edit/${items.id}`}>  Edit </Button>
                <Button>Delete</Button>
              </td>
            </tr>
          ))}


        </tbody>
      </Table>
    </>
  );
}

export default ProductList;
