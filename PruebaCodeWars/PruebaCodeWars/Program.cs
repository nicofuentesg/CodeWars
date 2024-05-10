// See https://aka.ms/new-console-template for more information

Sum("MCMLIV");

//kyu 6
int Solution(int value)
{
    if (value < 0)
    {
        return 0;
    }

    int comebackValue = value;
    int contenderSumValue = 0;
    for (int i = 0; i < value; i++)
    {
        if (comebackValue % 3 == 0 || comebackValue % 5 == 0)
        {
            contenderSumValue += comebackValue;
        }

        comebackValue -= 1;
    }

    return contenderSumValue;
}



//kyu 6
void Sum(string roman)
{
    
    //Creamos un diccionario con los valores MCMLIV
    Dictionary<char, int> romanValues = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    int result = 0;
    for (int i = 0; i < roman.Length ; i++)
    {
        var  value = romanValues[roman[i]];

        if (i + 1 < roman.Length && value < romanValues[roman[i + 1]] )
        {
            result -= value;
        }
        else
        {
            result += value;
        }
        

    }
    

}


