import math
a,b,c=int(input()),int(input()),int(input())
P=a+b+c
p=P/2
S= math.sqrt(abs(p*(p-a)*(p-b)*(p-c)))
print("Периметр - ", P, "площадь - ", S)