"use strict";

var HelloMessage = React.createClass({
    displayName: "HelloMessage",

    render: function render() {
        return React.createElement(
            "div",
            null,
            "Hello ",
            this.props.name
        );
    },
    list: Array()
});
var mountNode = document.getElementById("test1");
ReactDOM.render(React.createElement(HelloMessage, { name: "John" }), mountNode);

