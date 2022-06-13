import React from 'react';
import axios from 'axios';

export default class PersonList extends React.Component {
    state = {
        Id_user:'',
        Email:'',
        Password:'',
        Name: '',
        StatesPass:''
    }

    handleChange = event => {
        this.setState({ Id_user: event.target.value });
    }

    handleChange1 = event => {
        this.setState({ Email: event.target.value });
    }

    handleChange2 = event => {
        this.setState({ Password: event.target.value });
    }

    handleChange3 = event => {
        this.setState({ Name: event.target.value });
    }

    handleChange4 = event => {
        this.setState({ StatesPass: event.target.value });
    }

    handleSubmit = event => {
        event.preventDefault();

        const user = {
            Id_user:this.state.Id_user,
            Email:this.state.Email,
            Password:this.state.Password,
            Name: this.state.Name,
            StatesPass:this.state.StatesPass

        };

        axios.post(``, { user })
            .then(res => {
                console.log(res);
                console.log(res.data);
                alert("Всё сработало");
            })
    }

    render() {
        return (
            <div>
                <form onSubmit={this.handleSubmit}>
                    <label>
                        Person Name:
                        <input type="text" name="Id_user" onChange={this.handleChange} placeholder="Id_user"/>
                        <input type="text" name="Email" onChange={this.handleChange1} placeholder="Email"/>
                        <input type="text" name="Password" onChange={this.handleChange2} placeholder="Password"/>
                        <input type="text" name="Name" onChange={this.handleChange3} placeholder="Name"/>
                        <input type="text" name="StatesPass" onChange={this.handleChange4} placeholder="StatesPass"/>
                    </label>
                    <button type="submit">Add</button>
                </form>
            </div>
        )
    }
}