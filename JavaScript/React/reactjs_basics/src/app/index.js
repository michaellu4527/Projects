import React from "react";
import {render} from "react-dom";

import React, { Home } from './components/Home';
import React, { Header } from './components/Header';

class App extends React.Component {
  render() {
    return (
      <div className="container">
        <div className="row">
          <div className="col-xs-10 col-xs-offset-1">
            <h1>Hello!</h1>
          </div>
        </div>
      </div>
    );
  }
}

// Renders component. Provide (Component name, place where you want element rendered)
render(<App/>, window.document.getElementById('app'));
