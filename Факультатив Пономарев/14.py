print("введите стороны параллелепипеда")
a,b,c=map(int,input().split())
print("введите стороны отверстия")
x,y=map(int,input().split())
iters=[a,b,c]
sides=[x,y]
if (a<=x and (b<=y or c<=y))or (a<=y and (b<=x or c<=x)) or (b<=x and (a<=y or c<=y))or (b<=y and (a<=x or c<=x)) or (c<=x and (b<=y or a<=y))or (c<=y and (b<=x or a<=x)):
    print("Влезет")
else:
    print("Не влезет")
