var HelloMessage = React.createClass({
    render: function() {
        return <div>Hello {this.props.name}</div>;
    },
    list: Array()
});
var mountNode = document.getElementById("test1");
ReactDOM.render(<HelloMessage name="John" />, mountNode);