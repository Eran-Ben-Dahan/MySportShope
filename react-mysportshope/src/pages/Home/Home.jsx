import React from "react";
import "./Home.css";
import reactLogo from "../../components/Media/Image/React logo.jpg";
import javascriptLogo from "../../components/Media/Image/Javascript Logo.jpg";
import htmlLogo from "../../components/Media/Image/HTML5_logo.jpg";
import cssLogo from "../../components/Media/Image/CSS3 Logo .jpg";
  import LoaderSpinner from "../../components/LoaderSpinner";

const Home = () => {
  return (
    <div className="container_home">
      <div className="top">
        <div>
          <h2>Welcome to the world's largest movie site</h2>
          <p>Here you can find movies of all time </p>
        </div>
      </div>
      <div className="main_1">
        <div>
          <h2>So what do we<br></br> have on the site?</h2>
          <p></p>
        </div>
        <div>
          <h3>
            <span>01.</span> HOME
          </h3>
          <p>- Here you can get a brief overview of the site.</p>
        </div>
        <div>
          <h3>
            <span>02. </span>MOVIES
          </h3>
          <p>
            - You can find an endless library of movies of all time.<br></br>-
            you can search for movies by name or by category.<br></br>- you can
            add movie to you'r favorit list by click on the heart .<br></br>-
            You can move between pages.<br></br>- If you click on the movie
            image you can go to the movie website
          </p>
        </div>
        <div>
          <h3>
            <span>03. </span>FAVORITES
          </h3>
          <p>
            - Here you can find all your saved movies. <br></br>- You can always
            add or delete favorite movies from your list.
          </p>
        </div>
        <div>
          <h3>
            <span>04. </span>COMMENTS
          </h3>
          <p>
            - Here you can see other people's comments.<br></br>- add comment.<br></br>- delete comment.
            <br></br>- edit your own comment.
          </p>
        </div>
        <div>
          <h3>
            <span>05. </span>ABOUT
          </h3>
          <p>- Here you can see the experience of the website builder.</p>
        </div>
        <div>
          <h3>
            <span>06. </span>MORE OPTIONS
          </h3>
          <p>- You can logein <br></br>- You can use in dark mode.</p>
        </div>
      </div>
      <div className="main_2">
        <div className="main_2_top">What technologies did we use?</div>
        <div className="main_2_bottom">
          <div>
            <img src={reactLogo} class="img-fluid rounded-top" alt="Logo" />
            <h3>React</h3>
            <p>
              -Hook<br></br>
              -React Toolkit <br></br>
              -Routes
            </p>
          </div>
          <div>
            <img
              src={javascriptLogo}
              class="img-fluid rounded-top"
              alt="Logo"
            />
            <h3>Javascript</h3>
            <p></p>
          </div>
          <div>
            <img src={htmlLogo} class="img-fluid rounded-top" alt="Logo" />
            <h3>HTML</h3>
            <p></p>
          </div>
          <div>
            <img src={cssLogo} class="img-fluid rounded-top" alt="Logo" />
            <h3>CSS</h3>
            <p></p>
          </div>
        </div>
      </div>
      <div className="main_3">
        <LoaderSpinner/>
      </div>
    </div>
  );
};

export default Home;
