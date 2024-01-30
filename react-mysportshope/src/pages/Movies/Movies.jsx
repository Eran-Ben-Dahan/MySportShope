
import { useSelector } from "react-redux";
import { useParams } from "react-router-dom";
import MovieItem from "../../components/MovieItem/MovieItem";
import NextPage from "../../components/NextPage/NextPage";
import genres from "../../features/movies/genres";
import useMovies from "../../hooks/useMovies";
import "./Movies.css";
import TopNav2 from '../../components/nav/TopNav2'





function isNumberGenre(genre) {
  return !genre || !isNaN(Number(genre));
}

function getGenreIdByName(genreName) {
  const foundGenre = genres.find(
    (genre) => genre.name.toLowerCase() === genreName.toLowerCase()
  );
  return foundGenre?.id;
}

function getGenreId(genre) {
  return { genre: isNumberGenre(genre) ? genre : getGenreIdByName(genre) };
}

const Movies = () => {
  const { genre } = useParams();
  useMovies(getGenreId(genre));
  const isDark = useSelector((state) => state.theme.isDark);
  const movies = useSelector((state) => state.movie.moviesFiltered);

  return (
    
    <div className={isDark ? "page_1_dark" : "page_1_light"}>
      
      <div
        className="movie_list_controle"
        style={{ direction: "rtl" }}
      >
          
        {movies.map((m) => (
          <MovieItem key={m.id} movie={m} />
        ))}
      </div>
      <TopNav2/>
      <NextPage genre={getGenreId(genre).genre} />
      
    </div>
  );
};

export default Movies;
