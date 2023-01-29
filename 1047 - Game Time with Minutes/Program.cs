int firstHour, firstMinute, lasthour, lastMinute;
string [] var = Console.ReadLine().Split(' ');
firstHour = int.Parse(var[0]);
firstMinute = int.Parse(var[1]);
lasthour = int.Parse(var[2]);
lastMinute = int.Parse(var[3]);

int beginning = firstHour * 60 + firstMinute;
int end = lasthour * 60 + lastMinute;

int time;
if (beginning < end) 
{
    time = end - beginning;
}
else
{
    time = (24 * 60 - beginning) + end;
}

int timeHours = time / 60;
int timeMinutes = time % 60;

Console.WriteLine("O JOGO DUROU " + timeHours + " HORA(S) E " + timeMinutes + " MINUTO(S)");
        