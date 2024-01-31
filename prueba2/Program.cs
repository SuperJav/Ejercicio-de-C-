
//Juego de dado. 

//Instanciar la clase Ramdon en un objecto.
Random dice = new Random();

//Declarar las tres variables donde se almacenaran el resultado de los tres dados.
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

//Declaracion de la variable donde se almacenan la suma de los tres dados.
int total = roll1 + roll2 + roll3;

//Mostrar los resultados de los dados con la respectiva suma de las tres.
Console.WriteLine($" Dice roll: {roll1} + {roll2} + {roll3} = {total}");



//Condicion si los resultado de al menos dos de los tres dados son iguales 
if (roll1 == roll2 || roll3 == roll1 || roll2 == roll3)
{       
        //Condicion si el resultado de los tres dados son iguales.
        if (roll1 == roll2 && roll3 == roll1)
    {
        //Imprimir en consola su premio
        Console.WriteLine("You rolled triples! +6 bonus to total!");

        //Almacenar los puntos ganados.
        total += 6;

    //Si la condicion no se cumple
    }else{
    //Imprimir en consola.
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    //Alamcenar los puntos ganados.
    total +=2;
    }
}

//Condicion si el total de punto es mayor o igual a 16.
if (total >= 16)
{
    //Mostrar en pantalla.
    Console.WriteLine("You win a new car!");
}
//Si la condicion no se cumple, entonces si total es mayor o igual a 10.
else if (total >= 10)
{
    //Mostrar en pantalla.
    Console.WriteLine("You win a new laptop!");
}
//Si la condicon tanpoco se cumple. entonces si total es igual a 7.
else if (total == 7)
{
    //Mostrar en pantalla.
    Console.WriteLine("You win a trip for two!");
}
//Si no se cumple ninguna.
else
{   //Mostrar en pantalla.
    Console.WriteLine("You win a kitten!");
}