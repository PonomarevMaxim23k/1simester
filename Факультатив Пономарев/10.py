a,b,c=int(input()),int(input()),int(input())
if a + b > c and b + c > a and a + c > b:
    if a==b or b==c or a==c:
        if a==b==c:
            print("Треугольник равносторонний")
        else:
            print("Треугольник равнобедренный")
    else:
        print("Треугольник разносторонний")
        
else:
    print("Нет такого треугольника")