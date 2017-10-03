import React, { Component } from 'react';
import Projects from './Components/Projects';
import './App.css';

class App extends Component {
  render() {
    return (
      // Everything needs to be in ONE outer element. You CANNOT return 2 elements
      <div className="App">
        My App
        <Projects />
      </div>
    );
  }
}

export default App;
