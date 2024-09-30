//var
string userChoice;

//main 
do{
    UserDisplay();
    userChoice= GetUserChoice();
    RoutEm(userChoice);
}while (userChoice != "4");
//end main
static void UserDisplay(){
    Console.Clear();
    System.Console.WriteLine("1. Plain pizza\n2. Cheese pizza\n3. Pepperoni pizza\n4. Exit");

}
static string GetUserChoice(){
    return Console.ReadLine();
}
void RoutEm(string userChoice){//rout menu
    switch(userChoice){
        case "1":
            PlainPizza();
            break;
        case "2":
            CheesePizza();
            break;
        case "3":
            PepperoniPizza();
            break;
        case "4":
            Exit();
            break;
        default:
            System.Console.WriteLine("Invalid menu choice please try again, Press any key to continue");
            Console.ReadKey();
            break;

    }
}

static int GetRandomNumber(){//random number method for pizza size
    Random rnd = new Random();
    int number = rnd.Next(8,13);
    return number;
}


string PlainPizza(){//plaim pizza generation
    for (int i = GetRandomNumber(); i >=1; i--){
        for (int j = 1; j<=i ;j++){
        System.Console.Write("*  ");
    }
    System.Console.WriteLine();
}
return GetUserChoice();}

string CheesePizza(){//cheese pizza generation
    for (int i = GetRandomNumber(); i >=1; i--){
        for (int j = 1; j<=i ;j++){
                if (j==1 || j ==i){
                System.Console.Write("*  ");}
                else {
                System.Console.Write("#  ");
            }
    }
    System.Console.WriteLine();
}
return GetUserChoice();}

string PepperoniPizza(){//pepproni pizza generation
    for (int i = GetRandomNumber(); i >=1; i--){
        Console.Write("*  ");
        for (int j = 2; j<=i ;j++){
                if (GetRandomPep()== 0){
                System.Console.Write("[]  ");}
                else {
                System.Console.Write("#  ");
            }
        }
        if(i>1){
           Console.Write("*");
            }
    System.Console.WriteLine();
}
return GetUserChoice();}

static int GetRandomPep(){//pepperoni placement decider
    Random rnd = new Random();
    int number = rnd.Next(0, 4);
    return number;
}

static void Exit(){
    System.Console.WriteLine("Goodbye!");

}