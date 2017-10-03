import React, { Component } from 'react';
import Projects from './Components/Projects';
import './App.css';

class App extends Component {
  constructor(){
    // This needs to be called when you create a constructor
    super();
    this.state = {
      projects: [
        {
          title: 'Business Website',
          category: 'Web Design'
        },
        {
          title: 'Social App',
          category: 'Mobile Development'
        },
        {
          title: 'Ecommerce Shopping Cart',
          category: 'Web Development'
        },
      ]
    }
  }

  render() {
    return (
      // Everything needs to be in ONE outer element. You CANNOT return 2 elements
      // Below takes everything in the Projects component and outputs it (simple as that
      <div className="App">
        My App
        <Projects projects={this.state.projects} />
      </div>
    );
  }
}

export default App;
