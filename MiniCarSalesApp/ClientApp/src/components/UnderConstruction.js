import React, { Component } from 'react';

export class UnderConstruction extends Component {
    static displayName = UnderConstruction.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>This page is currently under construction or outside the project scope.</div>
        );
    }
}
