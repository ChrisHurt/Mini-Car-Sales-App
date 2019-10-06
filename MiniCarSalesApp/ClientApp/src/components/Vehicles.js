import React, { Component } from 'react';

export class Vehicles extends Component {
    static displayName = Vehicles.name;

    constructor(props) {
        super(props);
        this.state = { currentCount: 0 };
    }

    renderCars = () => {
        return (<div> A list of cars will be here when the data is available</div>)
    }

    renderBoats = () => {
        return (<div> A list of boats will be here when the data is available</div>)
    }

    renderBikes = () => {
        return (<div> A list of bikes will be here when the data is available</div>)
    }


    render() {
        return (
            <div>
                {this.renderCars()}
                {this.renderBikes()}
                {this.renderBoats()}
            </div>
        );
    }
}
