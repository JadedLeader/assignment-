// total 9 pumps, new car every 1.5s, refuelling takes 8 seconds, ask for user input for the pumps, one type of fuel


//timer 
/*Timer myTimer = new Timer(carArriving, null, 0, 1500);


void carArriving(object o)
{
    Carstore();

}  */

Timer carupdater = new Timer(carUpdating, null, 0, 8000);


void carUpdating(object o)
{
    Console.WriteLine(" the car is leaving");
}



//setting up the user interface to show pumps, queue number


static void userInterface()
{
    

    Console.WriteLine("Queue: ");
    Console.WriteLine("     Cars: " );
    Carstore();
    Console.WriteLine("Pump 1: -----             Pump 2: -----       Pump 3: -----");
    Console.WriteLine("Pump 4: -----             Pump 5: -----       Pump 6: -----");
    Console.WriteLine("Pump 7: -----             Pump 8: -----       Pump 9: -----");

}

//going to create an array to store the cars that are generated every 1.5s 

// car storage array that every time the timer elapses it adds a "new car" element to the array -stops after one iteration
static void Carstore()
{
    string[] Carqueue = new string[1];

    for (int i = 0; i < 1; i++)
    {
        Carqueue[i] = "1";
        Console.WriteLine(Carqueue[0]);
    }
}


string[] pumpqueue = new string[9] {"available", "available", "available", "available", "available", "available", "available", "available", "available", }; 


int userinput;
int i = 0;

userInterface();

do
{
    Console.WriteLine("Please choose a pump # from 1 - 9");
    userinput = Convert.ToInt32(Console.ReadLine());

    switch(userinput)
    {
        case 1:

            if (pumpqueue[0] == "available")
            {
                Console.WriteLine("You've arrived at pump one");
                pumpqueue[0] = "Busy";

                // make the car leave after 8 seconds and reset the pump value to available 
                carUpdating(i);

            }
            else
            {
                Console.WriteLine("This pump is busy");
                
            }
            break;
       
        case 2:

            if (pumpqueue[1] == "available")
            {
                Console.WriteLine("You've arrived at pump two");
                pumpqueue[1] = "Busy";
                
            }
            else
            {
                Console.WriteLine("This pump is busy");

            }
            break;

        case 3:

            if (pumpqueue[2] == "available")
            {
                Console.WriteLine("You've arrived at pump three");
                pumpqueue[2] = "Busy";
                
            }
            else
            {
                Console.WriteLine("This pump is busy");

            }
            break;

        case 4:

            if (pumpqueue[3] == "available")
            {
                Console.WriteLine("You've arrived at pump four");
                pumpqueue[3] = "Busy";
                
            }
            else
            {
                Console.WriteLine("This pump is busy");

            }
            break;

        case 5:

            if (pumpqueue[4] == "available")
            {
                Console.WriteLine("You've arrived at pump five");
                pumpqueue[4] = "Busy";
                
            }
            else
            {
                Console.WriteLine("This pump is busy");

            }
            break;

        case 6:

            if (pumpqueue[5] == "available")
            {
                Console.WriteLine("You've arrived at pump six");
                pumpqueue[5] = "Busy";
                
            }
            else
            {
                Console.WriteLine("This pump is busy");

            }
            break;

        case 7:

            if (pumpqueue[6] == "available")
            {
                Console.WriteLine("You've arrived at pump seven");
                pumpqueue[6] = "Busy";
               
            }
            else
            {
                Console.WriteLine("This pump is busy");

            }
            break;

        case 8:

            if (pumpqueue[7] == "available")
            {
                Console.WriteLine("You've arrived at pump eight");
                pumpqueue[7] = "Busy";
               
            }
            else
            {
                Console.WriteLine("This pump is busy");

            }
            break;

        case 9:

            if (pumpqueue[8] == "available")
            {
                Console.WriteLine("You've arrived at pump nine");
                pumpqueue[8] = "Busy";
                
            }
            else
            {
                Console.WriteLine("This pump is busy");

            }
            break;

    }
}
while (i < 5);
































//timer 
/*Timer myTimer = new Timer(test, null, 0, 1000);

void test(object o)
{
    Console.WriteLine("based");

} */




Console.ReadKey();
