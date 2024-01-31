import React from "react";
import { useState, useEffect } from "react";
import api from "../../utils/api";
import { Button, Table } from "react-bootstrap";
import { Link } from "react-router-dom";
import { useSelector } from "react-redux";
  // import ProductItem from "../productItem/ProductItem";

function ProductList() {
  const [items, setitems] = useState([]);
  //  const data = useSelector((state) => state.data.searchResults);

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




// /** @jsxImportSource @emotion/react */
// import { useSelector } from "react-redux";
// import { containerStyles, cardGridStyles } from "./ProductListStyles";
// import ProductItem from "../ProtuctItem/ProductItem";
// import { useParams } from "react-router-dom";
// import { useMemo } from "react";
// import SortPriceComponent from "../sort/SortPriceComponent";


// const ProductList = () => {
//   const { gender, category, subcategory } = useParams();
//   const data = useSelector((state) => state.data.searchResults);
//   const status = useSelector((state) => state.data.status);
//   const error = useSelector((state) => state.data.error);
//   const departments = useSelector((state) => state.departments.data);

//   const items = useMemo(() => {
//     if (!departments || !gender || !category) return data;
//     try {
//       const itemsForGender = departments.find(
//         (d) => d.name === gender
//       )?.categories;
//       const itemsForCategory = itemsForGender?.find(
//         (cat) => cat.name === category
//       )?.subcategories;
//       const itemsInSubCategory = itemsForCategory?.find(
//         (subCat) => subCat.name === subcategory
//       )?.products;
//       return itemsInSubCategory || [];
//     } catch (e) {
//       console.error(e);
//       return [];
//     }
//   }, [departments, gender, category, subcategory, data]);

//   if (status === "loading") {
//     return <div>Loading...</div>;
//   }

//   if (status === "failed") {
//     return <div>Error: {error}</div>;
//   }

//   return (
//     <div css={containerStyles}>
   
//       <SortPriceComponent />
//       <div css={cardGridStyles}>
//         {items &&
//           items
//             .map((item) => <ProductItem key={item.id} data={item} />)}
//       </div>
//     </div>
//   );
// };

// export default ProductList;
