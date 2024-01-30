import React from 'react'
import { useSelector } from 'react-redux';
import MovieItem from '../../components/MovieItem/MovieItem'
import './Favorites.css'

const Favorites = () => {
  
   const movies = useSelector((s) => s.movie.movies).filter(m=>m.isFavorite);
   const isDark = useSelector((state) => state.theme.isDark);

   return (
     <div className={isDark ?  'page_1_dark' : 'page_1_light'} >
     
       <div
         style={{ direction: "rtl" }}
         className="favoriets"
       >
         {movies.map((m) => (
           <MovieItem key={m.id} movie={m} />
         ))}
       </div>
     </div>
   );
}

export default Favorites