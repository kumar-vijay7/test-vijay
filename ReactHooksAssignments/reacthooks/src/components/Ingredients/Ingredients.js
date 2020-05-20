import React,{ useReducer,useEffect,useCallback,useMemo } from 'react';

import IngredientsList from './IngredientList';
import IngredientForm from './IngredientForm';
import ErrorModal from '../UI/ErrorModal';
import Search from './Search';
import useHttp from '../../hooks/http';

const ingredientReducer=(currentIngredients,action)=>{
  switch(action.type){
    case 'SET':
      return action.ingredients;
    case 'ADD':
      return [...currentIngredients,action.ingredient];
    case 'DELETE':
      return currentIngredients.filter(ing=>ing.id !== action.id);
      default :
       throw new Error('Should not get there !');
  }
};



const Ingredients=()=> {
  const [userIngredients,dispatch]=useReducer(ingredientReducer,[]);
  const {
    isLoading,
    error,
    data,
    sendRequest,
    reqExtra,
    reqIdentifier,
    clear
  } = useHttp();
  //const [userIngredients,setUserIngredients] =useState([]);
  // const [isLoading,setIsLoading]=useState(false);
  // const [error,setError] = useState();

//   useEffect(()=>{
//   fetch('https://react-hooks-update-60f5c.firebaseio.com/ingredients.json')
//   .then(response=>response.json()
//   ).then(responseData=>{
//      const loadingIngredients=[];
//      for(const key in responseData){
//        loadingIngredients.push({
//           id:key,
//           title:responseData[key].title,
//           amount: responseData[key].amount
//        }); 
//      }
//      setUserIngredients(loadingIngredients);
//   });
// },[]);

useEffect(()=>{
  if(!isLoading && !error &&  reqIdentifier=== 'REMOVE_INGREDIENT'){
    dispatch({type: 'DELETE',id: reqExtra});
  }else if(!isLoading && !error && reqIdentifier==='ADD_INGREDIENT'){
    dispatch({
          type: 'ADD',
          ingredient:{id:data.name,...reqExtra}
      });
  }
},[data,reqExtra,reqIdentifier, isLoading,error]);
  
const filteredIngredientsHandler = useCallback(filteredIngredients=>{
  //setUserIngredients(filteredIngredients);
  dispatch({type: 'SET',ingredients:filteredIngredients});
},[]);
  
  const addIngredientHandler=useCallback(ingredient=>{
    sendRequest('https://react-hooks-update-60f5c.firebaseio.com/ingredients.json',
    'POST',
    JSON.stringify(ingredient),
    ingredient,
    'ADD_INGREDIENT'
    );
    // dispatchHttp({type: 'SEND'});
    // // setIsLoading(true);
    // fetch('https://react-hooks-update-60f5c.firebaseio.com/ingredients.json',
    // {
    // method:'POST',
    // body: JSON.stringify(ingredient),
    // headers:{ 'content-type':'application/json' }
    // }).then(response=>{
    //   dispatchHttp({type: 'RESPONSE'})
    //   //setIsLoading (false);
    //   return response.json();
    
    // }).then(responseData=>{
    //   // setUserIngredients(prevIngredients=>[
    //   //   ...prevIngredients,
    //   //   {id:responseData.name,...ingredient}
    //   //  ]);
    //   dispatch({
    //     type: 'ADD',
    //     ingredient:{id:responseData.name,...ingredient}});
    // });
  },[sendRequest]);

  const removeIngredientHandler=useCallback(ingredientId=>{
    // dispatchHttp({type: 'SEND'});
    //setIsLoading(true);
       sendRequest(`https://react-hooks-update-60f5c.firebaseio.com/ingredients/${ingredientId}.json`,
       'DELETE',
       null,
       ingredientId,
       'REMOVE_INGREDIENT'
       ); 
  },[sendRequest]);
 
  // const clearError=useCallback(()=>{
  //   // dispatchHttp({type: 'CLEAR'});
  //   // //setError(null); 
  //   clear();
  // },[]);


const ingredientList = useMemo(()=>{
  return(
    <IngredientsList 
    ingredients={userIngredients}
     onRemoveItem={removeIngredientHandler}/>
  );
},[userIngredients,removeIngredientHandler]);

  return (
    <div className="App">
      {error && <ErrorModal onClose={clear}>{error}</ErrorModal>}
      <IngredientForm 
      onAddIngredient={addIngredientHandler} 
      loading={isLoading}/>

      <section>
        <Search  
        onLoadIngredients={filteredIngredientsHandler}/>
        {ingredientList}

      </section>
    </div>
  );
}

export default Ingredients;
