def math():
    while True:
        num1 = int(input('Введите первое число: '))
        num2 = int(input('Введите второе число: '))
        action = input('Введите действие: ')

        if action == '+':
            print(num1, '+', num2, '=', num1 + num2)
        elif action == '-':
            print(num1, '-', num2, '=', num1 - num2)
        elif action == '*':
            print(num1, '*', num2, '=', num1 * num2)
        elif action == '/':
            print(num1, '/', num2, '=', num1 / num2)
        else:
            print('Ошибка. Такой операции не существует. Попробуйте ещё раз')
            math()


math()