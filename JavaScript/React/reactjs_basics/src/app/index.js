import React from "react";
import {render} from "react-dom";

import { Home } from './components/Home';
import { Header } from './components/Header';

class App extends React.Component {
  render() {
    return (
      <div className="container">
        <div className="row">
          <div className="col-xs-10 col-xs-offset-1">
            {/* Calls the Header Component (as simple as it looks)*/}
            <Header />
          </div>
        </div>
        <div className="row">
          <div className="col-xs-10 col-xs-offset-1">
            <Home />
          </div>
        </div>
      </div>
    );
  }
}

// Renders component. Provide (Component name, place where you want element rendered)
render(<App/>, window.document.getElementById('app'));
