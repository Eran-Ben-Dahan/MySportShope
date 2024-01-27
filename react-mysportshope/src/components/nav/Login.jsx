// import React from "react";
// import Swal from "sweetalert2";
// import "./Login.css";
// const Login = () => {
//   return (
//     <button
//       className="login"
//       onClick={async () => {
//         const { value: formValues } = await Swal.fire({
//           title: "Enter your Name",
//           html: '<input id="swal-input1" class="swal2-input">',
//           focusConfirm: false,
//           preConfirm: () => {
//             return [document.getElementById("swal-input1").value];
//           },
//         });

//         if (formValues) {
//           Swal.fire(`Entered name: ${formValues}`);
//         }

//         const { value: email } = await Swal.fire({
//           title: "Input email address",
//           input: "email",
//           inputLabel: "Your email address",
//           inputPlaceholder: "Enter your email address",
//         });

//         if (email) {
//           Swal.fire(`Entered email: ${email}`);
//         }
//         const { value: password } = await Swal.fire({
//           title: "Enter your password",
//           input: "password",
//           inputLabel: "Password",
//           inputPlaceholder: "Enter your password",
//           inputAttributes: {
//             maxlength: 10,
//             autocapitalize: "off",
//             autocorrect: "off",
//           },
//         });

//         if (password) {
//           Swal.fire(`you'r password is: ${password}`);

//         }
        
//       }}
//     >
//       <div>
//        Login
//       </div>
//     </button>
//   );
// };

// export default Login;
