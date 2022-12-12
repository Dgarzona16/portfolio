import Swal from "sweetalert2";
import {tokenRefresh} from './tokenRefresh';
import {Request} from './validate';

export const GetUserInfo = async () => {
    try{
        const restoken = await tokenRefresh();

        if(restoken){
            const uri = '/api/v1/';
            const config = {
                method: 'get',
                url: `${uri}profile/info`,
                headers: {
                    authorization: `Bearer ${restoken}`
                }
            };
            const response = await Request(config);
            return response.data;
        }
    }catch(error){
        console.log(error);
    }
};

export const changePassword = async (event) => {
    const oldPassword = event.target['act-password'].value;
    const newPassword = event.target['new-password'].value;
    const confirmPassword = event.target['confirm-password'].value;

    if (newPassword !== confirmPassword) {
        Swal.fire({
            icon: 'error',
            title: 'Oops...',
            text: 'Las contraseñas no coinciden',
        });
        return;
    }

    const restoken = await tokenRefresh();

    if (restoken){
        const uri = '/api/v1/';
        const data = {
            password: oldPassword,
            newPassword: newPassword,
        };
        const config = {
            method: 'PUT',
            url: `${uri}profile/change-password`,
            headers: {
                authorization: `Bearer ${restoken}`,
            },
            data: data,
        }

        const response = await Request(config);

        if (response.status === 200) {
            const result = await Swal.fire({
                icon: 'success',
                title: 'Contraseña cambiada',
                text: 'Tu contraseña ha sido cambiada',
            });

            if (result.isConfirmed) {
                window.location.reload();
            }
        }
    }
};

export const updateUser = async (event) => {
    const username = event.target['data-name'].value;
    const email = event.target['data-email'].value;
    const address = event.target['data-direction'].value;
    const phone = event.target['data-phone'].value;

    const restoken = await tokenRefresh();

    if (restoken){
        const uri = '/api/v1/';
        const data = {
            username,
            email,
            address,
            phone,
        };

        const config = {
            method: 'PATCH',
            url: `${uri}profile/update`,
            headers: {
                authorization: `Bearer ${restoken}`,
            },
            data: data,
        }

        const response = await Request(config);

        if (response.status === 200) {
            const result = await Swal.fire({
                icon: 'success',
                title: 'Usuario actualizado',
                text: 'Tu usuario ha sido actualizado',
            });

            if (result.isConfirmed) {
                window.location.reload();
            }
        }
    }
};