import math
print("1. Квадратне рівняння\n2. Кубічне рівняння")
number = int(input(""))
if (number == 1):
    print("Квадратне рівняння")
    a = int(input("a = "))
    b = int(input("b = "))
    c = int(input("c = "))
    if (b > 0):
        if (c > 0):
            print(str(a) + "x^2+" + str(b) + "x+" + str(c))
        else:
            print(str(a) + "x^2+" + str(b) + "x" + str(c))
    if (b < 0):
        if (c > 0):
            print(str(a) + "x^2" + str(b) + "x+" + str(c))
        else:
            print(str(a) + "x^2" + str(b) + "x" + str(c))
    dis = (b**2) - (4 * a * c)
    print("Дискримінант: ", dis)
    if (dis > 0):
        x1 = (-(b) - math.sqrt(dis))/2*a
        print("x1 = " , int(x1))
        x2 = (-(b) + math.sqrt(dis))/2*a
        print("x2 = ", int(x2))
    elif (dis == 0):
        x = (-(b) + math.sqrt(dis))/2*a
    elif (dis < 0):
        print("Підберіть інші значення")

if (number == 2):
    print("Кубічне рівняння")
    a = int(input("a = "))
    b = int(input("b = "))
    c = int(input("c = "))
    d = int(input("d = "))
