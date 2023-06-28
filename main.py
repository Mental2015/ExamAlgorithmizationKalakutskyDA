def check_password(password):
    if len(password) < 8 or len(password) > 20:
        return False
    if not any(char.isdigit() for char in password):
        return False
    if not any(char.islower()for char in password):
        return False
    if not any(char.isupper()for char in password):
        return False
    if not any(char in "@#$%^&*()"for char in password):
        return False
    return True
while True:
    password = input("Видите пароль: ")

    if check_password(password):
        print("Ваш пароль верен.")
        break
    else:
        print("Пароль не верен.")