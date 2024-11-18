y = int(input())
a,b,c = y//100,(y//10)%10,y%10
if a+c>=10:
    new = b*100+a+c
elif a+c <=b:
    new = (a+c)*10+b
else:
    new = b*10+a+c
print(new)