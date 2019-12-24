formul = input('Prefix:')
formul = formul.split(' ')
formul = formul[::-1]

stack = list()

for i in formul:
    if i== '+' or i== '*' or i== '/' or i== '-':
        a=int(stack[len(stack)-1])
        b=int(stack[(len(stack)-2)])

        if i == '+':
            c=a+b
            pass
        elif i=='*':
            c=a*b
            pass
        elif i=='-':
            c=a-b
            pass
        else:
            c = a / b
            pass

        stack.pop()
        stack.pop()
        stack.append(c)
    else:
        stack.append(i)
        pass
    pass

print(stack)
