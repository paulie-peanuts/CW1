n = int(input("Enter an integer between 1 and 15: "))
for i in range(1, n + 1):
	print ('  ' * (n - i), end='')
	for j in range (i, 0, -1):
		print (f"{j} ", end='')
	for j in range (2, i + 1):
		print (f"{j} ", end='')
	print ()