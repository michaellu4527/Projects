import React, { Component } from 'react';

class Projects extends Component {
  render() {
    let projectItems;
    if (this.props.projects){
      projectItems = this.props.projects.map(project => {
        // console.log(project);
      })
    }
    return (
      // Everything needs to be in ONE outer element. You CANNOT return 2 elements
      <div className="Projects">
        My Projects
        {this.props.test}
      </div>
    );
  }
}

export default Projects;
