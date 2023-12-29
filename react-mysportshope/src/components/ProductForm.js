import React from "react";
import { Button, Form } from "react-bootstrap";
import { useState } from "react";

function ProductForm() {
  const [name, setfirst] = useState("")
  const [description, setdescription] = useState("")
  const [manufacturer, setmanufacturer] = useState("")
  const [itemSizes, setitemSizes] = useState("")
  const [colors, setcolors] = useState("")
  const [image, setimage] = useState("")
  
  const handleSubmit = (e) => {
    e.preventDefault();
  };
  return (
    <>
      <h2>Product form add/edit</h2>
      <Form onSubmit={handleSubmit}>
        <Form.Group>
          <Form.Label>Name</Form.Label>
          <Form.Control type="text" value={name} required />
        </Form.Group>
        <Form.Group>
          <Form.Label>description</Form.Label>
          <Form.Control type="text" value={description} required />
        </Form.Group>
        <Form.Group>
          <Form.Label>manufacturer</Form.Label>
          <Form.Control type="text" value={manufacturer} required />
        </Form.Group>
        <Form.Group>
          <Form.Label>itemSizes</Form.Label>
          <Form.Control type="text" value={itemSizes} required />
        </Form.Group>
        <Form.Group>
          <Form.Label>colors</Form.Label>
          <Form.Control type="text" value={colors} required />
        </Form.Group>
        <Form.Group>
          <Form.Label>image</Form.Label>
          <Form.Control type="text" value={image} required />
        </Form.Group>
        <Button type="submit">Save</Button>
        <Button>Cancel</Button>
      </Form>
    </>
  );
}

export default ProductForm;
