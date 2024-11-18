fc=input()
if len(fc)<8:
    print("Пароль слишком короткий") 
else:
    sc=input()
    if fc!=sc:
        print("Пароли не совпадают")
    else:
        print("Пароль успешно задан")
