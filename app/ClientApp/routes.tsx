import * as React from 'react';
import { Route } from 'react-router-dom';
import { Home } from './components/Home';
import { Search } from './components/Search';

export const routes = <div>
    <Route exact path='/' component={ Home } />
    <Route path='/search' component={ Search } />
</div>;
