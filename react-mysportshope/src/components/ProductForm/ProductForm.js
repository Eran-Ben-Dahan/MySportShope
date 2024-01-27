import React, { useEffect } from "react";
import { Button, Form } from "react-bootstrap";
import { useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import api from "../../utils/api";
import  "./ProductForm.css";

function ProductForm() {
  const { id } = useParams();
  const [name, setName] = useState("");
  const [manufacturer, setManufacturer] = useState("");
  const [description, setDescription] = useState("");
  const [orderItemList, setOrderItemList] = useState([]);
  const [orderItem, setOrderItem] = useState([]);
  //  const [colors, setColors] = useState("")
  const [image, setImage] = useState("");
  const navigate = useNavigate();

  useEffect(() => {
    api
      .get("OrderItem")
      .then((result) => setOrderItemList(result.data))
      .catch((ex) => console.error(ex));
  }, []);

  useEffect(() => {
    if (id) {
      api
        .get(`product/${id}`)

        .then((res) => {
          const item = res.data;

          setName(item.name);
          setManufacturer(item.manufacturer);
          setDescription(item.description);
          setOrderItem(item.orderItem || []);
          setImage(item.image);
        })
        .catch((ex) => console.error(ex));
    }
  }, [id]);

  const handleCancel = () => {
    navigate("../product");
  };
  const handleSubmit = (e) => {
    e.preventDefault();
    // 10.7.23 לחזור לשמירת מוצר חדש לסרטון בדקה 2:45

    const newItem = {
      id: id || 0,
      name:name,
      manufacturer:manufacturer,
      description:description,
      orderItem:orderItem,
      image:image,
    };
    const verb = id ? "put" : "post";

    console.log(newItem);
    api[verb]("product".newItem)
      .then((res) => {
        console.log(res.data);
        navigate("../product");
      })
      .catch((ex) => console.error(ex));
  };
  return (
    <>
     
      <Form onSubmit={handleSubmit} className="body">
        <Form.Group className="form-group ">
          <Form.Label>Name</Form.Label>
          <Form.Control
            type="text"
            value={name}
            required
            onChange={(e) => setName(e.target.value)}
          />
        </Form.Group >
        <Form.Group className="form-group ">
          <Form.Label>manufacturer</Form.Label>
          <Form.Control
            type="text"
            value={manufacturer}
            required
            onChange={(e) => setManufacturer(e.target.value)}
          />
        </Form.Group>
        <Form.Group className="form-group "> 
          <Form.Label>description</Form.Label>
          <Form.Control
            value={description}
            required
            onChange={(e) => setDescription(e.target.value)}
          />
        </Form.Group>
        <Form.Group className="form-group ">
          <Form.Label >price</Form.Label>
          <Form.Control
            as="select"
            value={orderItem}
            onChange={(e) =>
              setOrderItem(Array.from(e.target.selectedOptions, (o) => o.value))
            }
          >
            {orderItemList.map((price) => (
              <option key={price.id} value={price.id}>
                {price.price}
              </option>
            ))}
          </Form.Control>
        </Form.Group>
        <Form.Group className="form-group ">
          <Form.Label >image</Form.Label>
          <Form.Control
            type="text"
            value={image}
            required
            onChange={(e) => setImage(e.target.value)}
       
          />
        </Form.Group>
        <Button variant="primary" type="submit" className="button">
          Save
        </Button>
        <Button variant="secondary" onClick={handleCancel} className="button">
          Cancel
        </Button>
      </Form>
   
    </>
  );
}
export default ProductForm;
