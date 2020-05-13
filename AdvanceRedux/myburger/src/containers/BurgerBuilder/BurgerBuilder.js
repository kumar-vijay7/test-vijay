import React, { Component } from 'react';
import {connect} from 'react-redux';
import Aux from '../../hoc/Auxx/Auxx';
import Burger from '../../components/Burger/Burger';
import BuildControls from '../../components/Burger/BuildControls/BuildControls'
import Modal from '../../components/UI/Modal/Modal';
import OrderSummary from '../../components/Burger/OrderSummary/OrderSummary';
import axios from '../../axios-orders';
import Spinner from '../../components/UI/Spinner/Spinner';
import withErrorHandler from '../../hoc/WithErrorHandler/withErrorHandler';
import * as actions from '../../store/actions/index';

class BurgerBuilder extends Component {
    state={
        purchasing:false
        
    }
    componentDidMount(){
       this.props.onInitIngredients();
    }
    updatePurchasedState=(ingredients)=>{
        // const ingredients={
        //     ...this.state.ingredients
        // };
        const sum=Object.keys(ingredients)
        .map(igkey=>{
        return ingredients[igkey];
        }).reduce((sum,el)=>{
            return sum+el;
        },0);
        return sum>0
    }
    // addIngredientHandler=(type)=>{
    //     const oldCount=this.state.ingredients[type];
    //     const updatedCount=oldCount+1;
    //     const updatedIngredients={
    //         ...this.state.ingredients
    //     };
    //     updatedIngredients[type]=updatedCount;
    //     const priceAddition=INGREDIENT_PRICES[type];
    //     const oldPrice=this.state.totalPrice;
    //     const newPrice=oldPrice+priceAddition;
    //     this.setState({
    //         totalPrice:newPrice,
    //         ingredients:updatedIngredients
    //     });     
    //     this.updatePurchasedState(updatedIngredients);   
    // }

    // removeIngredientHandler=(type)=>{
    //     const oldCount=this.state.ingredients[type];
    //     if(oldCount<=0){
    //         return;  
    //     }
    //     const updatedCount=oldCount-1;
    //     const updatedIngredients={
    //         ...this.state.ingredients
    //     };
    //     updatedIngredients[type]=updatedCount;
    //     const priceDeduction=INGREDIENT_PRICES[type];
    //     const oldPrice=this.state.totalPrice;
    //     const newPrice=oldPrice-priceDeduction;
    //     this.setState({
    //         totalPrice:newPrice,
    //         ingredients:updatedIngredients
    //     });     
    //     this.updatePurchasedState(updatedIngredients);
    // }

    purchaseHandler=()=>{
        this.setState({purchasing:true})
    }

    purchaseCancelHandler=()=>{
        this.setState({purchasing:false})
    }

    purchaseContinueHandler=()=>{
        this.props.onInitPurchase();
        this.props.history.push('/checkout');

    // const queryparams=[];
    // for(let i in this.state.ingredients){
    //     queryparams.push(encodeURIComponent (i)+ '=' + encodeURIComponent(this.state.ingredients[i]));
    // }
    // queryparams.push('price='+ this.state.totalPrice);
    //  const queryString=queryparams.join('&');
    // this.props.history.push({
    //     pathname:'/checkout',
    //     search: '?'+queryString
    // });
    }
    render() {
        const disabledInfo={
            ...this.props.ings
        };
        for(let key in disabledInfo){
            disabledInfo[key]=disabledInfo[key]<=0
        }

        let orderSummary=null;
        let burger=this.props.error?<p>Ingredients can`t be loaded!</p>:<Spinner/>
        if(this.props.ings){
            burger=(
                <Aux>
                <Burger ingredients={this.props.ings}/>
                <BuildControls 
                ingredientAdded={this.props.onIngredientAdded}
                ingredientRemoved={this.props.onIngredientRemoved}
                disabled={disabledInfo}
                purchasable={this.updatePurchasedState(this.props.ings)}
                ordered={this.purchaseHandler}
                price={this.props.price}/>
                </Aux>
                );
                orderSummary= <OrderSummary 
        ingredients={this.props.ings}
        price={this.props.price}
        purchaseCanceled={this.purchaseCancelHandler}
        purchaseContinue={this.purchaseContinueHandler}/>;
        }
    //     if(this.state.loading){

    //         orderSummary=<Spinner />;

    // }
        
        return (
            <Aux>
                <Modal show={this.state.purchasing}
                modalClosed={this.purchaseCancelHandler}>
                   {orderSummary}
                </Modal>
                {burger}
            </Aux>
        )
    };
}
const mapStateToProps=state=>{
    return{
            ings:state.burgerBuilder.ingredients,
            price:state.burgerBuilder.totalPrice,
            error: state.burgerBuilder.error
    };
};

const mapDispatchToProps=dispatch=>{
    return{
        onIngredientAdded:(ingName)=>dispatch(actions.addIngredient(ingName)),
        onIngredientRemoved:(ingName)=>dispatch(actions.removeIngredient(ingName)),
        onInitIngredients:()=>dispatch(actions.initIngredients()),
        onInitPurchase: () => dispatch( actions.purchaseInit())
    };
}

export default connect(mapStateToProps,mapDispatchToProps)(withErrorHandler(BurgerBuilder,axios));