
// personeTypeSlice.js
import { createAsyncThunk, createSlice } from '@reduxjs/toolkit';
import axios from 'axios';

const initialState = {
  data: [],
  status: 'idle', // 'idle' | 'loading' | 'succeeded' | 'failed'
  error: null,
};

export const fetchPersoneType = createAsyncThunk('personetype/fetchPersoneType', async () => {
  const response = await axios.get('https://localhost:7291/api/PersoneType');
  console.log(response.data);
  return response.data;
});

const personeTypeSlice = createSlice({
  name: 'personetype',
  initialState,
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(fetchPersoneType.pending, (state) => {
        state.status = 'loading';
      })
      .addCase(fetchPersoneType.fulfilled, (state, action) => {
        state.status = 'succeeded';
        state.data = action.payload;
      })
      .addCase(fetchPersoneType.rejected, (state, action) => {
        state.status = 'failed';
        state.error = action.error.message;
      });
  },
});

export default personeTypeSlice.reducer;