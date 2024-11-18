x,y=int(input()),int(input())
if  x > 0:
    if y > 0:
        print("Первая четверть")
    elif y <0:
        print("Четвёртая четверть")
elif x == 0:
    if y == 0:
        print("Точка находится в центре")
    else:
        print("Точка находится на оси x")
else:
    if y > 0:
        print("Вторая четверть")
    elif y <0:
        print("Третья четверть")
if y == 0:
    print("Точка находится на оси y")
