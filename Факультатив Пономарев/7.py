a,b,c,d,e = map(int,input().split())
alles = [a,b,c,d,e]
#a = []
#a.append(input().split())
zeros,plss,minss=0,0,0
for i in range(5):
    if alles[i]==0:
        zeros+=1
    elif alles[i]>0:
        plss+=1
    else:
        minss+=1
print("Положительных чисел -",plss)
print("Отрицательных чисел -",minss)
print("Чисел, равных нулю -",zeros)