import math
n = float(input("Please enter the number of sides: "))
s = float(input("Please enter the length of each side: "))
area = (n * s**2) / (4 * math.tan(math.pi / n))
print("The area of the polygon is:" , area)