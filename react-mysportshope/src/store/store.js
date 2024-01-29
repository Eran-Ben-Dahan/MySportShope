import personReducer from '../features/personType-slice';
import { configureStore } from '@reduxjs/toolkit';

const store = configureStore({
  reducer: {
   person: personReducer,
  },
  middleware: (getDefaultMiddleware) =>
  getDefaultMiddleware({
    serializableCheck: {
      // Ignore state and actions that are non-serializable
      ignoredActions: ['yourNonSerializableAction'],
      ignoredPaths: ['some.nested.nonSerializableField'],
      // Increase warning threshold
      warnAfter: 100, // Default is 32ms
    },
  }),
});


export default store;
