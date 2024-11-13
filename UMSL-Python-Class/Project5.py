import turtle

turtle.pensize(3)
turtle.penup()
turtle.goto(-50, -50)
turtle.pendown()
turtle.begin_fill()
turtle.color("red")
turtle.left(30)
turtle.circle(50, steps = 6)
turtle.end_fill()
turtle.color("white")
turtle.penup()
turtle.goto(-100, -15)
turtle.write("STOP",
	font = ("Times", 15, "bold"))
turtle.hideturtle()