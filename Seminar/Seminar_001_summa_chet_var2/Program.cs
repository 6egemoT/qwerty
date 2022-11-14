int sum = 0;
int startNumber = 2;
int endNumber = 15;

while (startNumber <= endNumber) 
{
    sum = sum + startNumber; // sum = sum + startnumber
    startNumber += 2;
}

Console.WriteLine(sum);

// 2+4+6+8+10+12+14=56