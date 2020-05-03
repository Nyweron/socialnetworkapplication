import React, { Component } from "react";
import axios from "axios";
import { List, Header, Icon } from "semantic-ui-react";

class App extends Component {
  state = {
    values: [],
  };

  componentDidMount() {
    axios.get("http://localhost:5000/api/values").then((response) => {
      this.setState({
        values: response.data,
      });
    });
  }

  render() {
    return (
      <div className="App">
        <Header as='h2'>
          <Icon name='plug' />
          <Header.Content>Social Network App</Header.Content>
        </Header>
        <List>
          {this.state.values.map((value: any) => (
            <List.Item>{value.name}</List.Item>
          ))}
        </List>
      </div>
    );
  }
}

export default App;
