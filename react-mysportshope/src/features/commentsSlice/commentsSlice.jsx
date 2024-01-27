import { createSlice } from "@reduxjs/toolkit"

const initialState = {
    comments: [
        {
            id:1,
            userName:'Yosi Moshe',
            comment :"The best movie is Need foe speed",
            date: '05-11-2020',
        },
        {
            id:2,
            userName:'Avi peretz',
            comment :"The best movie is Last man downd",
            date: '08-09-2021',
        },
        {
            id:3,
            userName:'Tom avni',
            comment :"The best movie is Mane on a ledge ",
            date: '08-01-2022',
        },
        {
            id:4,
            userName:'Roni yohananov',
            comment :"The best movie is Avengers",
            date: '08-05-2022',
        },
    ]
}
const commentsSlice = createSlice({
    name: "comment",
    initialState,
    reducers: {
        addComment: (state,{payload}) =>{
            state.comments.push(payload)
        },
        deleteComment:(state,{payload}) => {
            const idx = state.comments.findIndex(c => c.id === payload)
            if(idx >= 0)
                state.comments.splice(idx,1)  
        },
        editComment:(state,{payload}) => {
            const idx = state.comments.findIndex(c => c.id === payload.id)
            if(idx >=0)
             state.comments[idx] = payload
        }
    }
})

export default commentsSlice.reducer
export const {addComment,deleteComment,editComment} = commentsSlice.actions