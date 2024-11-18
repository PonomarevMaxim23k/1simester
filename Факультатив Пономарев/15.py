a,b,c=map(int,input("Введите три числа через пробел: ").split())
if a==b==c:
    print("Числа равны")
else:
    print("Наибольшее число -",max(a,b,c),"Наименьшее число -",min(a,b,c) , sep="  ")
