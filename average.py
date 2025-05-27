def calcAverage():
    with open(filename, 'r') as file:

        filename = input("Enter filename: ")
        number = map(int, file.read().splitlines())
        numberList = list(number)

        calc = sum(numberList)
        count = len(numberList)

        average = calc / count
        print(f"The average is: {average}")


calcAverage()
