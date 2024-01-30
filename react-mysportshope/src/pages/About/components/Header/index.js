import React from "react";
import styled from "styled-components";

const Wrapper = styled.header`
  padding: 60px 0;
  display: flex;
  flex-flow: row wrap;
  align-items: center;
  justify-content: center;
  background: grey;
  width: 100%;
  background: url(https://images.unsplash.com/photo-1440688807730-73e4e2169fb8?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=2700&q=80)
    top center no-repeat fixed;
`;

const Main = styled.main`
  display: flex;
  flex-flow: row wrap;
  align-items: center;
  justify-content: space-between;
  max-width: 1240px;
  width: 90%;
`;

const Profile = styled.div``;
const Name = styled.h1`
  font-weight: 600;
  font-size: 60px;
  max-width: 400px;
  text-transform: uppercase;
  line-height: 55px;
`;
const Role = styled.h2`
  font-weight: 500;
  letter-spacing: 6px;
  text-transform: uppercase;
  font-size: 16px;
  margin-top: 20px;
`;

const Address = styled.ul`
  padding: 0;
  list-style: none;
  width: 400px;
  text-align: left;
  font-size: 15px;
  font-weight: 500;
  letter-spacing: 1px;
  font-family: "Open Sans";
  li {
    margin: 10px 0;
  }

  a {
    color: black;
    text-decoration: none;
    position: relative;
    z-index: 3;
    overflow: hidden;
    display: inline-block;
    padding: 5px;
    margin-top: -5px;
    margin-right: -5px;
    transition: all 200ms ease;

    :hover {
      color: white;

      :before {
        transform: translateY(0%);
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
  }
`;

const Header = () => (
  <Wrapper>
    <Main>
      <Profile>
        <Name>Eran<br/> Ben Dahan</Name>
        <Role>Full stack developer</Role>
      </Profile>

      <Address>
        <li>Netanya</li>
        
        <li>+972-548050910</li>
        <li>
          <a href="mailto:eran0099@gmail.com">
             Email:eran0099@gmail.com
          </a>
        </li>
      </Address>
    </Main>
  </Wrapper>
);

export default Header;
