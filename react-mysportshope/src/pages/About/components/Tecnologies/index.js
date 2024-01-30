import React from "react";
import styled from "styled-components";

const Wrapper = styled.header`
  display: flex;
  flex-flow: row wrap;
  align-items: center;
  justify-content: center;
  width: 100%;
`;

const Main = styled.main`
  display: flex;
  flex-flow: row wrap;
  align-items: center;
  justify-content: flex-start;
  max-width: 1240px;
  width: 90%;
  padding: 60px 0;
  border-top: 1px solid rgba(0, 0, 0, 0.1);
  text-align: left;
  p {
    width: 100%;
    line-height: 1.4;
`;

const Title = styled.h2`
  font-size: 20px;
  letter-spacing: 1px;
  font-weight: 800;
  color: black;
  font-family: "Open Sans";
  width: 100%;
  margin-bottom: 20px;
  text-transform: uppercase;
  small {
    font-size: 7px;
    font-weight: 400;
    text-decoration: line-through;
    line-height: 7px;
    display: block;
  }
`;

const Tecnologies = () => (
  <Wrapper>
    <Main>
      <Title>
        <small></small>Tecnologias
      </Title>
      <p>
        Javascript ,C ,C# ,Redux ,WordPress
      </p>
    </Main>
  </Wrapper>
);

export default Tecnologies;
