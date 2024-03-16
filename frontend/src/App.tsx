import React from 'react';
import './App.css';
import Header from './Header';
import BowlerList from './BowlerList/BowlerList';

function App() {
  return (
    <div className="App">
      <Header title="No Lane, No Gain" />
      <BowlerList />
    </div>
  );
}

export default App;
