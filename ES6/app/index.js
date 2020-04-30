import {areOfRectangle,areaOfCircle,areaOfCylinder} from './Area';
import {newArray} from './filteringArray';


//Ques:1 Given this array: `[3,62,234,7,23,74,23,76,92]`,
//Using arrow function, create an array of the numbers greater than `70`.
//Solution:
console.log('----------This is Ques1 Solution starts--------------');
const numbers=[3,62,234,7,23,74,23,76,92];
console.log(`This is main array: \n ${numbers}`);
const newNumbers=numbers.filter(num=>num>70)
{console.log('This is the newArray which contains the greaterthan 70 elements:\n'+newNumbers);}
console.log('----------This is Ques1 Solution ends--------------');
/*------------------------------------------------------*/

//Ques:2 <ul>
//   <li data-time="5:17">Flexbox Video</li>
//   <li data-time="8:22">Flexbox Video</li>
//   <li data-time="3:34">Redux Video</li>
//   <li data-time="5:23">Flexbox Video</li>
//   <li data-time="7:12">Flexbox Video</li>
//   <li data-time="7:24">Redux Video</li>
//   <li data-time="6:46">Flexbox Video</li>
//   <li data-time="4:45">Flexbox Video</li>
//   <li data-time="4:40">Flexbox Video</li>
//   <li data-time="7:58">Redux Video</li>
//   <li data-time="11:51">Flexbox Video</li>
//   <li data-time="9:13">Flexbox Video</li>
//   <li data-time="5:50">Flexbox Video</li>
//   <li data-time="5:52">Redux Video</li>
//   <li data-time="5:49">Flexbox Video</li>
//   <li data-time="8:57">Flexbox Video</li>
//   <li data-time="11:29">Flexbox Video</li>
//   <li data-time="3:07">Flexbox Video</li>
//   <li data-time="5:59">Redux Video</li>
//   <li data-time="3:31">Flexbox Video</li>
// </ul>

// a. Select all the list items on the page and convert to array.
// b. Filter for only the elements that contain the word 'flexbox'
// c. Map down to a list of time strings
// d. Map to an array of seconds
// e. Reduce to get total using .filter and .map

//Solution:
  // 2(a):

    const items=Array.from(document.querySelectorAll(`li`));
    console.log(items);
  //2(c):
    const filter=items.filter(item=>item.textContent.includes('Flexbox'));
    console.log(filter);
   //2(d,e)
    const listtime=filter.map(item => item.dataset.time).map(timecode => {
      const parts = timecode.split(':').map(part => parseFloat(part));
      return (parts[0] * 60) + parts[1];
    }).reduce((runningTotal, seconds) => runningTotal + seconds, 0)
    console.log(listtime);


/**
 * ----------------------------------------------------------------
 */
//Ques:3 Create a markup template using string literal

// const song = {
//  name: 'Dying to live',
//  artist: 'Tupac',
//  featuring: 'Biggie Smalls'
// };
// Result:
// "<div class="song">
//    <p>
//      Dying to live — Tupac
//      (Featuring Biggie Smalls)
//    </p>
//  </div>

//Solution:
const song={
  name:'Dying to live',
  artist:'Tupac',
  featuring:'Biggie Smalls'
};

let markupTemplate=`<div class=song>
<p>${song.name}--${song.artist}
<br/>
(Featuring ${song.featuring})
</p>
</div>`;

document.body.innerHTML=markupTemplate;

/*-----------------------------------------------*/
//Ques:4 Extract all keys inside address object from user object using destructuring ?
// const user = {
// firstName: ‘Sahil’,
// lastName: ‘Dua’,
// Address: {
// Line1: ‘address line 1’,
// Line2: ‘address line 2’,
// State: ‘Delhi’,
// Pin: 110085,
// Country: ‘India’,
// City: ‘New Delhi’,
// },
// phoneNo: 9999999999
// }
//Solution:


const user = {
        firstName: 'Sahil',
        lastName: 'Dua',
        Address: {
        Line1: 'address line 1',
        Line2: 'address line 2',
        State: 'Delhi',
        Pin: 110085,
        Country: 'India',
        City: 'New Delhi',
        },
        phoneNo: 9999999999
      }
console.log('----------This is Ques4 Solution starts--------------');
let {Line1,Line2,State,Pin,Country,City}=user.Address;
console.log(Line1);
console.log(Line2);
console.log(State);
console.log(Pin);
console.log(Country);
console.log(City);
console.log('----------This is Ques4 Solution Ends--------------');



//Ques:4(b) Filter unique array members using Set.
//Solution:
console.log('----------This is Ques4(b) Solution starts--------------');
const numArray=[1,2,2,3,4,5,66,66,5];
let set=new Set(numArray);
console.log(set);
console.log('----------This is Ques4(b) Solution Ends--------------');

//Ques:5 Find the possible combinations of a string and store them in a MAP? 
//Solution:
console.log('----------This is Ques5 Solution starts--------------');
const stringMap=new Map();

let printCombination=(inputString,finalsub)=> 
    { 
        if (inputString.length == 0) { 
            stringMap.set(finalsub+' ');
            console.log(stringMap);
            return stringMap;
        } 
  
        for (let i = 0; i < inputString.length; i++) { 
            let character = inputString.charAt(i); 
            let ros = inputString.substring(0, i) +  
                      inputString.substring(i + 1); 
  
            
            printCombination(ros, finalsub + character); 
        } 
    } 

    printCombination(`aap`,'');


    console.log('----------This is Ques5 Solution ends--------------');

//Ques:6 Write a program to implement inheritance upto 3 classes.The Class must
//  public variables and static functions.
//Solution:
console.log('----------This is Ques6 Solution starts--------------');
class Animal{
  constructor(animalType){
    this.animalType=animalType;
  }
  getAnimalType(){
    console.log(`Animal Type: ${this.animalType}`);
  }
}
class Dog extends Animal{
  constructor(animalType,breed,dogname){
    super(animalType);
    this.breed=breed;
    this.dogname=dogname;
  }
    getBreed(){
      console.log(`Dog Breed: ${this.breed}`);
      console.log(`Dog Name : ${this.dogname}`);
    }
  
}
class Owner extends Dog{
  constructor(nanimalType,breed,dogname,ownername){
      super(nanimalType,breed,dogname);
      this.ownername=ownername;
  }
  getOwnerInfo(){
    console.log(`OwnerName : ${this.ownername}`);
  }
  static welcome(){
    console.log('Welcome To Animal Information Center');
  }
}

let obj=new Owner('Dog','Labra','Belle','Vijay Kumar');
Owner.welcome();
obj.getOwnerInfo();
obj.getAnimalType();
obj.getBreed();
console.log('----------This is Ques6 Solution ends--------------');


//Ques:7 Write a program to implement a class having static functions
//Solution:
console.log('----------This is Ques7 Solution starts--------------');
class Home{

  static welcome(){
    console.log('Welcome to Home');
  }
}

Home.welcome();
console.log('----------This is Ques7 Solution ends--------------');


//Ques:8 Import a module containing the constants and 
//method for calculating area of circle, rectangle, cylinder.
//Solution:
console.log('----------This is Ques8 Solution starts--------------');
console.log(`Area of Circle : ${areaOfCircle(2)}`);
console.log(`Area of Rectangle : ${areOfRectangle(4,5)}`);
console.log(`Area of Cylinder : '${areaOfCylinder(5,2)}`);


console.log('----------This is Ques8 Solution ends--------------');

//Ques: 9 Import a module for filtering unique elements in an array.
//Solution:
console.log('----------This is Ques 9 Solution starts--------------');
 console.log(newArray);
 console.log('----------This is Ques 9 Solution ends--------------');


 //Ques: 10 Write a program to flatten a nested array to single level using arrow functions.
 //Solution: 

 console.log('----------This is Ques 10 Solution starts--------------');
const nestedArray=['a','b',['c','d',['e','f']]];
const flattenArray= (nestedArray)=>(nestedArray.flat(2));
console.log(flattenArray(nestedArray));

console.log('----------This is Ques 10 Solution ends--------------');

//Ques:11 Implement a singly linked list in es6 
//and implement addFirst() addLast(), length(), getFirst(), getLast(). (without using array)
//Solution:
console.log('----------This is Ques 11 Solution starts--------------');
class LinkedList{
  constructor(){
    this.head=null;
    this.tail=null;
    this.count=0;
  }
  //add at first position
  addFirst(data){
    const node={
      data:data,
      next:null
    }

    const temp=this.head;
    this.head=node;
    this.head.next=temp;

    this.count++;

    if(this.count===1){
      this.tail=this.head;
    }
  }

  //add at last position
  addLast(data){
    const node={
      data:data,
      next:null
    }

    if(this.count===0){
      this.head=node;
    }
    else{
      this.tail.next=node;
    }

    this.tail=node;
    this.count++;
  }
   length(){
     return this.count;
   }

   getFirst(){
     return this.head.data;
   }

   getLast(){
     return this.tail.data;
   }

   //This method is created for Ques 13
   removeFirst(data) {
    if(this.count > 0) {
      this.head = this.head.next;
      
      this.count--;
      
      if(this.count === 0) {
        this.tail = null;  
      } 
    }
  }

}

let linkedListObject=new LinkedList();
linkedListObject.addFirst(5);
linkedListObject.addLast(6);
linkedListObject.addLast(7);
console.log(`Length of the Linked List : ${linkedListObject.length()}`);
console.log(`First element of LinkedList : ${linkedListObject.getFirst()}`);
console.log(`Last Element of LinkedList : ${linkedListObject.getLast()}`);

console.log('----------This is Ques 11 Solution ends--------------');
//Ques: 12  Implement Map and Set using Es6
//Solution:
console.log('----------This is Ques 12 Solution starts--------------');

//This is Map implementtation
let info=new Map([
['Name','Vijay Kumar'],
['Company','To The New'],
['Skills','.Net']
]);

for(let item of info.entries())
console.log(`${item[0]}:${item[1]}`);

// Set Implementation starts here

const name=['Vijay','Abhishek','Vishesh','Vijay'];
let newNameArray=new Set(name);
console.log(newNameArray);
console.log('----------This is Ques 12 Solution ends--------------');



//Ques:13  Implementation of stack (using linked list)
//Solution:
console.log('----------This is Ques 13 Solution starts--------------');
   //using  Ques 11 Linkedlist
  class Stack{
    constructor(){
      this.list=new LinkedList();
    }
      push(data) {
        this.list.addFirst(data);
      }
      
      pop() {
        if(!this.list.length) {
          return;
        };
        
        let val = this.list.head.data;
        this.list.removeFirst();
        
        return val;
      }
      
      peek() {
        if(!this.list.head) { return; }
        return this.list.head.data;
      }
      
      getlength() {
        return this.list.length();
      } 
    }

    let stack=new Stack();
    stack.push(10);
    stack.push(11);
    stack.push(12);
    console.log(`Total Item in Stack : ${stack.getlength()}`);
    console.log(`Peek : ${stack.peek()}`);
    console.log(`Pop Operation : ${stack.pop()}`);
    console.log(`Total Item in Stack after pop: ${stack.getlength()}`);

  
console.log('----------This is Ques 13 Solution ends--------------');