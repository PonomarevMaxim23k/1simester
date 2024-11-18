curh, curm = map(int,input("Введите время в часах и минутах через :").split(':'))#map(int,input().split())
waitm=int(input("Введите время до будильника"))
waith=(curm+waitm)//60
print(curh+(curm+waitm)//60,":",(curm+waitm)%60)