import React from "react";
import {Box,Container,Row,Column,FooterLink,Heading,} from "./Footer";


const Footer = () => {
return (
	<Box>
	<Container>
		<Row>
		<Column>
			<Heading>About Us</Heading>
			<FooterLink href="#">Aim</FooterLink>
			<FooterLink href="#">Vision</FooterLink>
			<FooterLink href="#">Testimonials</FooterLink>
		</Column>
		<Column>
			<Heading>Services</Heading>
			<FooterLink href="#">Writing</FooterLink>
			<FooterLink href="#">Internships</FooterLink>
			<FooterLink href="#">Coding</FooterLink>
			<FooterLink href="#">Teaching</FooterLink>
		</Column>
		<Column>
			<Heading>Contact Us</Heading>
			<FooterLink href="#">Uttar Pradesh</FooterLink>
			<FooterLink href="#">Ahemdabad</FooterLink>
			<FooterLink href="#">Indore</FooterLink>
			<FooterLink href="#">Mumbai</FooterLink>
		</Column>
		<Column>
			<Heading>Social Media</Heading>
			<FooterLink href="https://linkedin.com/in/eran-ben-dahan/">
			<i className="fab fa-facebook-f">
				<span style={{ marginLeft: "10px" }}>
				Likedin
				</span>
			</i>
			</FooterLink>
			<FooterLink href="https://api.whatsapp.com/send/?phone=972548050910&text&type=phone_number&app_absent=0">
			<i className="fab fa-instagram">
				<span style={{ marginLeft: "10px" }}>
				Whatsapp
				</span>
			</i>
			</FooterLink>
			<FooterLink href="#">
			<i className="https://github.com/Eran-Ben-Dahan">
				<span style={{ marginLeft: "10px" }}>
				Github
				</span>
			</i>
			</FooterLink>
		
		</Column>
		</Row>
	</Container>
	</Box>
);
};
export default Footer;
