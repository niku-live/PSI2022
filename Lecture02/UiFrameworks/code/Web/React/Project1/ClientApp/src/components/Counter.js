import React, { Component } from 'react';

export class Counter extends Component {
  static displayName = Counter.name;

  constructor(props) {
    super(props);
    this.state = { count: 0, counterBtnText: "Click me" };
    this.onCounterClicked = this.onCounterClicked.bind(this);
  }

  onCounterClicked() {

      var local_count = this.state.count + 1;
      var local_counterBtnText = "Click me";
      if (local_count === 1) {
          local_counterBtnText = `Clicked ${local_count} time`;
      } else {
          local_counterBtnText = `Clicked ${local_count} times`;
      }
    this.setState({
        count: local_count, counterBtnText: local_counterBtnText
    });
  }

  render() {
    return (
      <div>
        <img className="counter-image" alt="logo" src="dotnet_bot.png" />
        <h1 className="counter-big-text">Hello, World!</h1>
        <h2 className="counter-small-text">Welcome to React</h2>
        <button className="btn btn-primary" onClick={this.onCounterClicked}>{this.state.counterBtnText}</button>
      </div>
    );
  }
}
