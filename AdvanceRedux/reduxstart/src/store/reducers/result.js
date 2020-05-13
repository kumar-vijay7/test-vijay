import * as actionTypes from '../actions/actionTypes';
import  {updateObject} from '../utility';

const initialState={
    counter:0,
    results:[]
};

const deleteResult=(state,action)=>{
    const updatedArray=state.results.filter(result=>result.id !== action.resultElId);
    return updateObject(state,{results:updatedArray});
};

const reducer=(state=initialState,action)=>{
    switch(action.type){
        case actionTypes.STORE_RESULT:return updateObject(state,{results:state.results.concat({id:new Date(), value: action.result *2})});
        
        case actionTypes.DELETE_RESULT:return deleteResult(state,action);
            // const id = 2;
            // const newArray=[...state.results];
            // state.results.splice(id,1)
           
           

        default:
            return state;
    }
//     if(action.type==='INCREMENT'){
//         return{
//             counter: state.counter+1
//         }
//     }
//     if(action.type==='DECREMENT'){
//         return{
//             counter: state.counter-1
//         }
//     }
//     if(action.type==='ADD'){
//         return{
//             counter: state.counter+action.val
//         }
//     }
//     if(action.type==='SUB'){
//         return{
//             counter: state.counter-action.val
//         }
//     }
//   return state;
};

export default reducer;