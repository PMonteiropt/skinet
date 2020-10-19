let data: number | string;

data = '42';

data = 10;

interface ICar {
  color: string;
  model: string;
  topSpeed?: number;
}

const car1: ICar = {
  color: 'blue',
  model: 'bmw',
};

const car2: ICar = {
  color: 'orange',
  model: 'mercedes',
  topSpeed: 100,
};




