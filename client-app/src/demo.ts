export interface Icar  {
    color: any;
    model: any;
    topSpeed?: number
}

const car1: Icar = {
    color: 'red',
    model: 'Benz',
    topSpeed: 100
}

const car2: Icar= {
    color: 'black',
    model: 'Audi',
    topSpeed: 200
}


const multiply = (x: number , y: number) => {
     x*y;
}


export const cars = [car1,car2];