import React, { useState } from "react";
import { useSelector } from "react-redux";
import { FaHeart, FaRegHeart } from "react-icons/fa";
import { useDispatch } from "react-redux";
import { toggleFavorite } from "../../features/movies/movies-slice";
import { toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import { Navigate, useNavigate, useParams } from "react-router-dom";
import ReactPlayer from "react-player";
import { useEffect } from "react";
import "./MovieDetails.css";
import { RiArrowGoBackLine } from "react-icons/ri";
import { BackgroundImage } from "@mantine/core";

function withMovie(Component) {
  return function MovieWrapper() {
    const { movieId } = useParams();
    const [trailer, setTrailer] = useState();

    useEffect(() => {
      (async () => {
        await fetch(
          `https://api.themoviedb.org/3/movie/${movieId}/videos?api_key=b3b1492d3e91e9f9403a2989f3031b0c&language=en-US`
        )
          .then((res) => res.json())
          .then(
            (data) => "https://www.youtube.com/watch?v=" + data.results[0].key
          )
          .then(setTrailer);
      })();
    }, [movieId]);

    //convert string to number:
    const mid = Number(movieId);
    const movie = useSelector((state) => state.movie.movies).find(
      (m) => m.id === mid
    );
    if (!movie) {
      return <Navigate to={"/"} />;
    }

    if (!trailer) return <div>Loading...</div>;

    return <Component trailer={trailer} movie={movie} />;
  };
}

const MovieDetails = ({ movie, trailer }) => {
  const navigate = useNavigate();
  const dispatch = useDispatch();
  const iconStyles = { color: "#FF008A", fontSize: "100px" };
  return (
    <div
      style={{ backgroundImage: `url(${movie.backdrop_path})` }}
      className="divBackdro"
    >
      <img className="backdro" src={movie.backdrop_path} alt="movie poster" />
      <div style={{ direction: "rtl" }} className="movieDetails">
        {/* button Back  */}
        <button
          className="btn btn-primary buttonBack"
          onClick={() => {
            navigate(-1);
          }}
        >
          <RiArrowGoBackLine />
        </button>
        <div className="topSide">
          <h2 className="titel">{movie.title}</h2>
          <ReactPlayer
            width="40%"
            height="40%"
            url={trailer}
            className="trailer"
            controls
            config={{
              youtube: {
                playerVars: { showinfo: 1 }}}}
          />
        </div>
        <div className="bottomSide">
          <p className="overview">
            <u>:Summary</u>
            <br></br> {movie.overview}
          </p>
        </div>
        {/* button Favorit  */}
        <button
          className="btn border-0 FavoriteBtn"
          onClick={(e) => {
            e.stopPropagation();
            if (!movie.isFavorite) {
              toast.success("Added", {
                style: { textAlign: "center" },
              });
            } else {
              toast.error("Removed", {
                style: { textAlign: "center" },
              });
            }
            dispatch(toggleFavorite(movie.id));
          }}
        >
          {movie.isFavorite && <FaHeart style={iconStyles} />}
          {!movie.isFavorite && <FaRegHeart style={iconStyles} />}
        </button>
        {/* <img
        className="w-50 shadow-lg p-3 mb-5 bg-white rounded card"
        src={movie.poster_path}
        alt="movie poster"
      /> */}
      </div>
    </div>
  );
};

export default withMovie(MovieDetails);
