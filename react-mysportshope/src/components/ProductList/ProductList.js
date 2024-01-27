import React from "react";
import { useState, useEffect } from "react";
import api from "../../utils/api";
import { Button, Table } from "react-bootstrap";
import { Link } from "react-router-dom";
// import ProductItem from "../productItem/ProductItem";

function ProductList() {
  const [items, setitems] = useState([]);

  const handleDelete = (id) => {
    if (!window.confirm("Are you sure?")) {
      return;
    }
    api
      .delete(`product/${id}`)
      .then(() => {
        setitems(items.filter((i) => i.id !== id));
      })
      .catch((ex) => console.error(ex));
  };

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
            <th>Manufacturer</th>
            <th>Description</th>
            <th>Price</th>
            <th>Images</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {items.map((p) => (
            <tr key={p.id}>
              <td>{p.id}</td>
              <td>{p.name}</td>
              <td>{p.manufacturer}</td>
              <td>{p.description}</td>
              <td>{p.orderItems.map((i) => i.price)}</td>
              <td>{p.image}</td>
              <td>
                <Button  as={Link} to={`edit/${p.id}`}>Edit
                </Button>
                <Button onClick={() => handleDelete(p.id)}>Delete</Button>
              </td>
            </tr>
          ))}
        </tbody>
      </Table>
    </>
  );
}
export default ProductList;
