import * as actionTypes from '../actions';

const initialState={
    counter:0
}

const reducer=(state=initialState,action)=>{
    switch(action.type){
        case actionTypes.INCREMENT:
            const newState=Object.assign({},state);
            newState.counter=state.counter + 1;
            return newState;
            // return{
            //     counter: state.counter+1
            // }
        case actionTypes.DECREMENT:
            return{
                ...state,
                counter: state.counter-1
            }
        case actionTypes.ADD:
            return{
                ...state,
                counter: state.counter+action.val
            }
        case actionTypes.SUB:
            return{
                ...state,
                counter: state.counter-action.val
            }
        
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