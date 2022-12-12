import { Request } from './validate';

export const getCategories = async () => {
    const uri = '/api/v1/';
    const config = {
        method: 'GET',
        url: `${uri}data/categories`,
    }
    const res = await Request(config);
    if (res.status === 200) {
        return res.data;
    }
}
