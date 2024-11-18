secs=int(input())
hrs,mins,secs=secs//3600,(secs//60)%60,secs%60
print(hrs,mins,secs,sep=':')