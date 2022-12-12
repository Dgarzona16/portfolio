import axios from 'axios';


export const tokenRefresh = async () => {
    const uri = '/api/v1/';
    const config = {
        url: `${uri}auth/refresh`,	
        method: 'GET',
        Credential: 'include',
    }
    try {
        const response = await axios(config);
        return response.data.token;
    }
    catch (error) {
        return false;
    }
};