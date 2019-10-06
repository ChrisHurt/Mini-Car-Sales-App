import React, { Component } from 'react';
import { Row, Col, Container } from 'reactstrap';
import { NavMenu } from './NavMenu';
//import 'bootstrap';

export class Layout extends Component {
    static displayName = Layout.name;

  render () {
    return (
      <div>
        <NavMenu />
        <Container>
            <Row>
                <Col>
                    {this.props.children}
                </Col>
            </Row>
        </Container>
      </div>
    );
  }
}
