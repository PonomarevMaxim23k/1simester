month=int(input())
if 1>month or month>12:
    print("Такого месяца не существует")
elif 1<=month<=2 or month==12:
    print("Сейчас зима")
elif 3<=month<=5:
    print("Сейчас весна")
elif 6<=month<=8:
    print("Сейчас лето")
else:
    print("Сейчас осень")