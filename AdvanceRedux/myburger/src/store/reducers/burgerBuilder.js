import * as actionTypes from '../actions/actionTypes';
import {updateObject} from '../utility';

const initialState={
    ingredients:null,
        totalPrice:4,
        error:false
};
const INGREDIENT_PRICES={
    salad:0.5,
    cheese:0.4,
    meat:1.3,
    bacon:0.7
}; 

const addIngredients=(state,action)=>{
    const updatedIngredients={[action.ingredientName]:state.ingredients[action.ingredientName]+1}
                const updatedIngreidents=updateObject(state.ingredients,updatedIngredients);
                const updatedState={
                    ingredients:updatedIngreidents,
                    totalPrice:state.totalPrice + INGREDIENT_PRICES[action.ingredientName]
            }
                return updateObject(state,updatedState);
};

const removeIngredients=(state,action)=>{
    const updatedIng={[action.ingredientName]:state.ingredients[action.ingredientName]-1}
    const updatedIngs=updateObject(state.ingredients,updatedIng);
    const updatedSt={
        ingredients:updatedIngs ,
        totalPrice:state.totalPrice + INGREDIENT_PRICES[action.ingredientName]
}
    return updateObject(state,updatedSt);
};

const setIngredients=(state,action)=>{
    return updateObject(state,{
        ingredients:{
            salad: action.ingredients.salad,
            bacon: action.ingredients.bacon,
            cheese: action.ingredients.cheese,
            meat: action.ingredients.meat
        },
        totalPrice:4,
        error:false
    });
};

const fetchIngredientFail=(state,action)=>{
    return updateObject(state,{error:true});
};
const reducer=(state=initialState,action)=>{
        switch(action.type){
            case actionTypes.ADD_INGREDIENTS:return addIngredients(state,action);
            case actionTypes.REMOVE_INGREDIENTS:return removeIngredients(state,action);
            case actionTypes.SET_INGREDIENTS: return setIngredients(state,action); 
            case actionTypes.FETCH_INGREDIENTS_FAILED:return fetchIngredientFail(state,action);
            default:
                return state;
        }
};

export default reducer;