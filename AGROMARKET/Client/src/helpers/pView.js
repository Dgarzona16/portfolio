import {Request} from './validate';
import {tokenRefresh} from './tokenRefresh';
import Swal from 'sweetalert2';

export const getProduct = async () => {
    const uri = '/api/v1/';
    const LastPath = window.location.pathname.split('/').pop();
    const config = {
        method: 'GET',
        url: `${uri}products/${LastPath}`,
    }
    const response = await Request(config);
    if (response) {
        return response.data;
    }
};

export const buyproduct = async (product) => {
    const restoken = await tokenRefresh();

    if (restoken){
        const uri = '/api/v1/';
        const config = {
            method: 'POST',
            url: `${uri}products/buy/${product._id}`,
            headers: {
                authorization: `Bearer ${restoken}`
            }
        }
        const response = await Request(config);

        if (response.status === 200){
            const modal = await Swal.fire({
                title: 'Compra exitosa',
                text: 'El producto se ha comprado correctamente',
                icon: 'success',
                confirmButtonText: 'Ok'
            });
        }
    }
};