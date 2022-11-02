int sum = 0;
int startNumber = 1;
int endNumber = 15;

while (startNumber <= endNumber) 
{
    if (startNumber % 2 == 0) // % - делить
    {
        sum = sum + startNumber; // sum = sum + startnumber
    }
    startNumber = startNumber + 1;
}

Console.WriteLine(sum);

// 2+4+6+8+10+12+14=56

