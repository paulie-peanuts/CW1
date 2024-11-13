# Draw a square 
import turtle 
t = turtle.Turtle()
for v in range(60, 140, 8):
    t.circle(v)
    t.penup()
    t.right(90)
    t.forward(8)
    t.left(90)
    t.pendown()