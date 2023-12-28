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
      <Button as={Link} to="new">Add New</Button>
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
          {/* <th>BoxSizes</th> */}
          {/* <th>PersoneType</th> */}
          {/* <th>OrderItems</th> */}
          </tr>
        </thead>
        <tbody>
          {items.map((items) => (
            <tr key={items.id}>
              <td>{items.id}</td>
              <td>{items.name}</td>
              <td>{items.manufacturer}</td>
              <td>{items.colors}</td>
              <td>{items.image}</td>
              <td>
                <Button as={Link} to={`edit/${items.id}`} >Edit</Button>
                <Button >Delete</Button>
                
                </td>

            </tr>
          ))}
        </tbody>
      </Table>
    </>
  );
}

export default ProductList;
