import { Request } from './validate';
import { tokenRefresh } from './tokenRefresh';
import { addTransaction } from './transactions';
import Swal from 'sweetalert2';

export const getCredits = async () => {
    try {
        const restoken = await tokenRefresh();
        if (restoken) {
            const uri = '/api/v1/';
            const config = {
                method: 'GET',
                url: `${uri}credits/get`,
                headers: {
                    authorization: `Bearer ${restoken}`
                }
            }
            const response = await Request(config);
            return response.data;
        } else {
            window.location.href = '/';
        }
    } catch (error) {
        console.log(error);
    }
}

export const addCreditsToUser = async () => {
    const { value: number } = await Swal.fire({
        title: 'agregar créditos',
        input: 'text',
        inputLabel: 'Creditos',
        focusConfirm: false,
    });

    if (number) {
        try {
            const restoken = await tokenRefresh();
            if (restoken) {
                const amount = parseFloat(number);
                const uri = '/api/v1/';
                const config = {
                    method: 'POST',
                    url: `${uri}credits/add`,
                    headers: {
                        authorization: `Bearer ${restoken}`
                    },
                    data: {
                        credits: amount,
                    }
                }
                const response = await Request(config);
                if (response) {
                    const transaction = await addTransaction(amount, 'deposito');
                    if (transaction) {
                        return {
                            credits: response.data.credits,
                            transaction: transaction
                        };
                    }
                }
            } else {
                window.location.href = '/';
            }
        }
        catch (error) {
            console.log(error);
        }
    }
}

export const substractCreditsFromUser = async () => {
    const { value: number } = await Swal.fire({
        title: 'retirar créditos',
        input: 'text',
        inputLabel: 'Creditos',
        focusConfirm: false,
    });

    if (number) {
        const restoken = await tokenRefresh();
        if (restoken) {
            const amount = parseFloat(number);
            const uri = '/api/v1/';
            const config = {
                method: 'POST',
                url: `${uri}credits/substract`,
                headers: {
                    authorization: `Bearer ${restoken}`
                },
                data: {
                    credits: amount,
                }
            }
            const response = await Request(config);
            if (response) {
                const transaction = await addTransaction(amount, 'retiro');
                if (transaction) {
                    console.log(transaction);
                    return {
                        credits: response.data.credits,
                        transaction: transaction
                    };
                }
            }
        }
    }
}