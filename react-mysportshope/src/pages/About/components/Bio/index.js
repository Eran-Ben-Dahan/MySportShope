import React from "react";
import styled from "styled-components";
import { SocialIcon } from "react-social-icons";

const Wrapper = styled.header`
  padding: 60px 0;
  display: flex;
  flex-flow: row wrap;
  align-items: center;
  justify-content: center;
  width: 100%;
    background-color: white;
`;

const Main = styled.main`
  display: flex;
  flex-flow: row wrap;
  align-items: center;
  justify-content: flex-start;
  max-width: 1240px;
  width: 90%;
  text-align: left;
  p {
    
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

const Links = styled.div`
  margin-left: auto;
  
  a {
    display: flex;
    flex-flow: row wrap;
    align-items: center;
    color: black;
    text-decoration: none;
    font-weight: 600;
    font-size: 15px;
    position: relative;
    z-index: 3;
    overflow: hidden;
    padding: 5px;
    margin-top: -5px;
    margin-right: -5px;
    transition: all 200ms ease;
    :hover {
      color: white;
      :before {
        transform: translateY(0%);
      }
      svg {
        path {
          fill: white;
        }
      }
    }
    :before {
      content: "";
      width: calc(100% + 10px);
      height: calc(100% + 10px);
      background: black;
      position: absolute;
      top: 0;
      left: -5px;
      bottom: 0;
      right: 0;
      margin: auto;
      z-index: -1;
      transition: all 200ms ease;
      transform: translateY(100%);
    }
    svg {
      margin-right: 10px;
      path {
        transition: all 400ms ease;
      }
    }
  }
`;

const Header = () => (
  <Wrapper>
    <Main>
      <Title>PRESENTATION</Title>
      <p>
        I am a mechanical engineering graduate and today a student in the full
        stuck developer course at HackerU College, with three years of
        experience as a validation and process engineer, with extensive
        professional knowledge, reliability and motivation to learn and
        contribute. I would like to offer my candidacy for the position of
        Fullstuck developer, CV summary. I would love to meet you, best regards,
        Eran Ben Dahan
      </p>

      <Links>
        <div className="social-media">
          <SocialIcon url="https://linkedin.com/in/eran-ben-dahan/" target="_blank" />
          <SocialIcon url="https://api.whatsapp.com/send/?phone=972548050910&text&type=phone_number&app_absent=0" target="_blank" />
          <SocialIcon url="https://github.com/Eran-Ben-Dahan" target="_blank" />
        </div>
      </Links>
    </Main>
  </Wrapper>
);

export default Header;
