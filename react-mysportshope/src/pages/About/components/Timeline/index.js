import React from "react";
import styled from "styled-components";



const Wrapper = styled.header`
  padding: 60px 0;
  display: flex;
  flex-flow: row wrap;
  align-items: center;
  justify-content: center;
  width: 50%;
`;

const Main = styled.main`
  display: flex;
  flex-flow: row wrap;
  align-items: center;
  justify-content: flex-start;
  width: 100%;
  text-align: left;
  p {
    width: calc(100% - 400px);
    line-height: 1.4;
  }
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
`;

const Time = styled.ul`
  list-style: none;
  padding: 30px 0;
  border-left: 2px solid rgba(0, 0, 0, 0.4);
`;

const Item = styled.li`
  margin-left: 20px;
  :not(:first-of-type) {
    margin-top: 60px;
  }
`;
const ItemTitle = styled.h1`
  font-size: 20px;
  font-weight: 700;
  text-transform: uppercase;
  position: relative;
  :after {
    content: "";
    width: 14px;
    height: 14px;
    background: grey;
    position: absolute;
    top: 0;
    bottom: 0;
    right: calc(100% + 14px);
    border: 2px solid white;
    margin: auto;
    border-radius: 50%;
  }
`;
const ItemSubtitle = styled.h2`
  font-size: 14px;
  font-weight: 700;
  text-transform: uppercase;
  color: grey;
  margin-bottom: 20px;
`;
const Description = styled.p`
  width: 80% !important;
  line-height: 1.5;
`;

const Timeline = ({ title, data }) => (
  <Wrapper>
    <Main>
      <Title>{title}</Title>

      <Time>
        {data.map(item => (
          <Item key={item.id}>
            <ItemTitle>{item.title}</ItemTitle>
            <ItemSubtitle>{item.subtitle}</ItemSubtitle>
            <Description>{item.description}</Description>
          </Item>
        ))}
      </Time>
    </Main>
  </Wrapper>
);

export default Timeline;
