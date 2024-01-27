import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";

const PersoneTypeURL = "https://localhost:7291/api/PersoneType";

export const fetchPersoneType= createAsyncThunk(
  "PersoneType/",
  async (_, { rejectWithValue }) => {
    try {
      const response = await axios.get(PersoneTypeURL);
      return response.data;
    } catch (error) {
      return rejectWithValue(error.response.data);
    }
  }
);

const PersoneTypeSlice = createSlice({
  name: "PersoneType",
  initialState: {
    data: [],
    status: "idle",
    error: null,
  },
  reducers: {},
  extraReducers: (builder) => {
    builder
      .addCase(fetchPersoneType.pending, (state) => {
        state.status = "loading";
      })
      .addCase(fetchPersoneType.fulfilled, (state, action) => {
        state.status = "succeeded";
        state.data = action.payload;
      })
      .addCase(fetchPersoneType.rejected, (state, action) => {
        state.status = "failed";
        state.error = action.payload;
      });
  },
});

export default PersoneTypeSlice.reducer;
