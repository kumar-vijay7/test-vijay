import axios from 'axios';

const instance =axios.create({
        baseURL:'https://myburger-25367.firebaseio.com/'
});

export default instance;