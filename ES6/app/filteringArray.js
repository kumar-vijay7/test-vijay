const array=[1,2,33,4,5,44,33,2];

let newArray= array.filter((item,index)=>array.indexOf(item)===index);

export {newArray};