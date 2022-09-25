
string userName = "";
Console.WriteLine("Enter User Name:");
userName = Console.ReadLine();

if(userName.ToLower() == "анна"){
    Console.WriteLine("Привет Анютка!!!");
}else{
    Console.WriteLine("Здравствуйте " + userName);
}