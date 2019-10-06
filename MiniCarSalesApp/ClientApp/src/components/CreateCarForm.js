import React, { Component } from 'react';

export class CreateCarForm extends Component {
    static displayName = CreateCarForm.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <form>
                <h1>Create a new car</h1>
                <div class="form-row">
                    <input type="hidden" class="form-control" id="vehicleType" value="car"/>
                    <div class="form-group col-sm-4 col-md-5">
                        <label for="make">Make</label>
                        <input type="text" class="form-control" id="make" placeholder="Ford" />
                    </div>
                    <div class="form-group col-sm-4 col-md-5">
                        <label for="model">Model</label>
                        <input type="text" class="form-control" id="model" placeholder="Focus Trend" />
                    </div>
                    <div class="form-group col-sm-4 col-md-2">
                        <label for="inputState">Body Type</label>
                        <select id="inputState" class="form-control">
                            <option selected>Choose...</option>
                            <option>Bus</option>
                            <option>Cab Chassis</option>
                            <option>Convertible</option>
                            <option>Coupe</option>
                            <option>Hatch</option>
                            <option>Light Truck</option>
                            <option>People Mover</option>
                            <option>Sedan</option>
                            <option>SUV</option>
                            <option>Ute</option>
                            <option>Van</option>
                            <option>Wagon</option>
                        </select>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-sm-4 col-md-8">
                        <label for="engine">Engine</label>
                        <input type="text" class="form-control" id="engine" placeholder="1.5L turbo" />
                    </div>
                    <div class="form-group col-sm-4 col-md-2">
                        <label for="doors">Doors</label>
                        <input type="number" class="form-control" id="doors" placeholder="4" />
                    </div>
                    <div class="form-group col-sm-4 col-md-2">
                        <label for="wheels">Wheels</label>
                        <input type="number" class="form-control" id="wheels" placeholder="4" />
                    </div>
                </div>
                <button type="submit" class="btn btn-primary">Submit Car</button>
            </form>
        );
    }
}
