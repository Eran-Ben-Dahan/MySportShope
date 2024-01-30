import React from "react";
import ReactDOM from "react-dom";
import styled, { createGlobalStyle } from "styled-components";
import Header from "./components/Header";
import Bio from "./components/Bio";
import Timeline from "./components/Timeline";
import Tecnologies from "./components/Tecnologies";


const GlobalStyles = createGlobalStyle`
  *,
  *:after,
  *:before {
    font-family: 'Roboto', sans-serif;
    margin: 0;
    padding: 0;
    box-sizing: border-box;
  }
`;

const Wrapper = styled.section`
  width: 100%;
  display: flex;
  flex-flow: row wrap;
  align-items: flex-start;
  justify-content: center;
  background-color: white;
`;

const Main = styled.main`
  width: 90%;
  max-width: 1240px;
  display: flex;
  flex-flow: row wrap;
  align-items: flex-start;
  justify-content: space-between;
  
`;

const exp = [
  {
    id: 1,
    title: "CRACK",
    subtitle: "Software Developer | 2019 - CURRENT",
    description:
      "Responsible for the front-end development team that works in the construction of platforms for insurance companies"
  },
  {
    id: 2,
    title: "DIGITAL DEX",
    subtitle: "Fullstack Developer | 2016 - 2017",
    description:
      "Develop web applications using Javascript (Angular, Backbone) on the front-end and NodeJS and PHP (Wordpress, Laravel and Codeigniter) on the back-end"
  },
  {
    id: 3,
    title: "AEROLITE",
    subtitle: "Fullstack Developer | 2014 - 2016",
    description:
      "Responsible for developing Web/Desktop applications using NodeJS and Javascript (React, Angular)"
  },
  {
    id: 4,
    title: "DEEN DIGITAL MARKETING",
    subtitle: "Front-end Developer | 2013 - 2014",
    description:
      "Responsible for developing web interfaces using HTML, CSS (SASS and Stylus) and Javascript (Angular, Backbone)"
  },
  {
    id: 5,
    title: "YOUR TECHNOLOGY",
    subtitle: "Front-end Developer | 2012 - 2013",
    description:
      "Responsible for developing web interfaces using HTML, CSS and Javascript (Jquery)"
  },
  {
    id: 6,
    title: "WEECOM COM. DIGITAL",
    subtitle: "AS3 Developer / Front-end Developer | 2008 - 2012",
    description:
      "Responsible for developing web interfaces using Flash (AS2 and AS3), HTML, CSS and Javascript (Jquery)"
  }
];

const courses = [
  {
    id: 0,
    title: "Testing Javascript",
    subtitle: "KENT C. DODDS | TESTINGJAVASCRIPT.COM",
    description: "Automated Testing Course with Javascript"
  },
  {
    id: 1,
    title: "Epic React",
    subtitle: "Kent C. Dodds | epicreact.dev",
    description: "Complete React Course from Basic to Advanced"
  },
  {
    id: 2,
    title: "PHP Developer",
    subtitle: "Flexxo | 2013",
    description:
      "PHP, Object Oriented and Relational Database Course"
  },
  {
    id: 3,
    title: "ActionScript 3",
    subtitle: "Alfamídia | 2011",
    description: "Actionscript 3 and OOP Course"
  },
  {
    id: 4,
    title: "Psicologia (trancado)",
    subtitle: "Universidade de Caxias do Sul",
    description: "Course locked in 2010"
  }
];

const About = () => {
  return (
    <Wrapper  >
      <GlobalStyles />
      <Header />
      <Bio  />
      <Main >
        <Timeline title="EXPERIENCES" data={exp} />
        <Timeline title="COURSES" data={courses} />
      </Main >
      <Tecnologies />
    </Wrapper>
  );
};

const rootElement = document.getElementById("root");
ReactDOM.render(<About />, rootElement);
export default About