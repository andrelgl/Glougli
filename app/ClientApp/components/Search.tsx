import * as React from 'react';
import { RouteComponentProps } from 'react-router';

interface SearchState {
    currentCount: number;
}

export class Search extends React.Component<RouteComponentProps<{}>, SearchState> {
    constructor() {
        super();
        this.state = { currentCount: 0 };
    }

    public render() {
        return <div>
            teste
        </div>;
    }

    incrementCounter() {
        this.setState({
            currentCount: this.state.currentCount + 1
        });
    }
}
