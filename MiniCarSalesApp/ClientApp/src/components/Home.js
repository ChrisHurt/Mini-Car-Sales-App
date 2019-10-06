import React, { Component } from 'react';
import 'bootstrap';
import { NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';


export class Home extends Component {
  static displayName = Home.name;

  render () {
      return (
        <main className="d-flex justify-content-center align-items-center p-12">
            <h1 className="mx-2">Add a new vehicle: </h1>
            <div className="dropdown mx-2">
                <button className="btn btn-secondary dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                    Choose a vehicle
                </button>
                <div className="dropdown-menu" aria-labelledby="dropdownMenuButton">
                      <NavLink tag={Link} className="dropdown-item" to="/cars/new">Create Car</NavLink>
                      <NavLink tag={Link} className="dropdown-item" to="/boats/new">Create Boat</NavLink>
                      <NavLink tag={Link} className="dropdown-item" to="/bikes/new">Create Bike</NavLink>
                </div>
            </div>
        </main>
    );
  }
}