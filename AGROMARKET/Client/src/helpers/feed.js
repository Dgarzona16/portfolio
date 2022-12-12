import Swal from 'sweetalert2';
import { Request } from './validate';
import { tokenRefresh } from './tokenRefresh';

const path = (type, categoryID) => {
    console.log(type);
    const uri = '/api/v1/';
    //get path
    switch (type) {
        case 'home':
            return `${uri}products/all`;
        case 'user':
            return `${uri}products/user/ownproducts`;
        case 'category':
            return `${uri}products/category/${categoryID}`;

    }
}

export const getFeed = async (type, categoryID) => {

    try {
        const restoken = await tokenRefresh();

        if (restoken) {
            const config = {
                method: 'GET',
                url: `${path(type, categoryID)}`,
                headers: {
                    authorization: `Bearer ${restoken}`,
                },
            };
            const response = await Request(config);
            return response.data;
        }
        else {
            window.location.href = '/';
        }
    } catch (error) {
        console.log(error);
        const modalResult = await Swal.fire({
            title: 'Error',
            text: 'No se pudo obtener el feed',
            icon: 'error',
            confirmButtonText: 'Aceptar',
        });

        if (modalResult.isConfirmed) {
            return;
        }
    }
};