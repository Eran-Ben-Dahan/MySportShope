import { createSlice, createAsyncThunk } from "@reduxjs/toolkit";
import Swal from "sweetalert2";
export const movieUrl =
  `https://api.themoviedb.org/3/discover/movie` +
  `?api_key=b3b1492d3e91e9f9403a2989f3031b0c` +
  `&language=EN` +
  `&sort_by=popularity.desc` +
  `&include_adult=false` +
  `&include_video=false` +
  `&page=1` +
  `&with_watch_monetization_types=flatrate`;
const movieUrlWithGenres = (genre) => movieUrl + `&with_genres=${genre}`;
const movieUrlWithPage = (url,page) => url.replace(`&page=1`,`&page=${page}`)
export const imageUrl = (image_path) =>
  `https://image.tmdb.org/t/p/original${image_path}`;
const initialState = {
  movies: [],
  moviesFiltered:[  ],
  error: "",
  loading: false,
  
};
// REDUX works with reducers, async func can't change the state
//createAsyncThunk is a helper for writing async in the slice, then we use it in 'extra-redcuers'
export const fetchMovies = createAsyncThunk("movie/fetch", ({ genre,page=1 }) => {
  //return fetch url
  return fetch(genre ? movieUrlWithPage(movieUrlWithGenres(genre),page) : movieUrlWithPage(movieUrl,page))
    .then((response) => response.json())
    .then((json) => json.results)
    .then((movies) =>
      movies.map((m) => ({
        ...m,
        poster_path: imageUrl(m.poster_path),
        backdrop_path: imageUrl(m.backdrop_path),
        isFavorite: false,
      }))
    );
});
const moviesSlice = createSlice({
  name: "movie",
  initialState,
  reducers: {
    addMovies: (state, action) => {
      state.movies = action.payload;
    },
    filterMovies: (state, action) => {
      if(action.payload.length < 1) {
        state.moviesFiltered = state.movies
        return
      }
      state.moviesFiltered = action.payload;
    },
    //add / remove from favorites
    toggleFavorite: (state, { payload }) => {
      //find the index of the movie by id
      const index = state.movies.findIndex((m) => m.id === payload);
      if (index !== -1) {
        //found the index: change isFavorite = !isFavorite
        state.movies[index].isFavorite = !state.movies[index].isFavorite;
        state.moviesFiltered[index].isFavorite = !state.moviesFiltered[index].isFavorite;

      }
    },
  },
  extraReducers: (builder) => {
    builder.addCase(fetchMovies.pending, (state) => {
      state.loading = true;
      state.movies = [];
      state.moviesFiltered = [];
      state.error = "";
    });
    builder.addCase(fetchMovies.fulfilled, (state, action) => {
      state.loading = false;
      state.movies = action.payload;
      state.error = "";
      state.moviesFiltered = action.payload;

      Swal.fire({
        icon: "success",
        title: "Movies loaded!",
        showConfirmButton: false,
        timer: 1500,
      });
    });
    builder.addCase(fetchMovies.rejected, (state, action) => {
      state.loading = false;
      state.movies = [];
      state.moviesFiltered = []
      state.error = action.error ?? "Something went wrong";
    });
  },
});

export default moviesSlice.reducer;
export const { toggleFavorite, addMovies,filterMovies } = moviesSlice.actions;


// "https://api.themoviedb.org/3/discover/movie?api_key=b3b1492d3e91e9f9403a2989f3031b0c&language=he-il&sort_by=popularity.desc&include_adult=false&include_video=false&page=1&with_watch_monetization_types=flatrate";