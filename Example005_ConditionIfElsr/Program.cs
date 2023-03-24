// Условие. Если пользователя зовут Маша (в любом регистре).
// приветствуем его особенным образом. Если другое имя-выводим 
// "Привет, имя пользователя'

Сonsole.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
  Console.WriteLine("Ура, это же Маша!");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}