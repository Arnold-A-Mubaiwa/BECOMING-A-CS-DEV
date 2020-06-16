import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import './index.css';
// import App from './App';
import * as serviceWorker from './serviceWorker';

// a counter
// let counter = 0;

// function show() {
//   counter++;
//   const el = <p>{counter}</p>;
//   ReactDOM.render(
//     el, document.getElementById('root')
//   );
// }
// setInterval(show, 1000); 

// functional Component
// function Hello(){
//  return <p>Hello Arnold</p>;
// }

//class component 
// class Hello extends React.Component{
//   render(){
//    return <p>Hello There</p>
//   }
// }

// function props
function Hello(props){
  return <h2> Hello, {props.name}</h2>
}
function Item(props) {
  return <div className="item">
  <b>Name:</b> {props.name} <br />
  <b>Price:</b> {props.price}
  </div>;
}
function App(){
  return <div><div>
    <Hello name="Pre"/>
    <Hello name="Josh"/>
    <Hello name="Ano"/>
    <Hello name="Ola"/>
  </div>
  <div>
    <Item name="Cheese" price="4.99" />
<Item name="Bread" price="1.5" />
<Item name="Ice cream" price="24" />
  </div>
  </div>
}
class AllContain extends React.Component{
  render(){
    // const hi = <p>Hello {this.props.name="oks"} <p/>
    return <App />
  }
}
const el =<AllContain/>
ReactDOM.render(
  el, document.getElementById('root')
);
// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();
