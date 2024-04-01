import pygame
import random
import tkinter.messagebox

pygame.init()

wix = 500
wiy = 500

win = pygame.display.set_mode((wix, wiy))
pygame.display.set_caption("Snake")

score = 0
snake_List = []
x = wix/2
y = wiy/2
width = 15
height = 15
vel = 5

ax = wix/2 + 200
ay = wiy/2
awidth = 15
aheight = 15

slis = []
t = 0
normalx = 0
normaly = 0

Length_of_snake = 1

def our_snake(snake_block, snake_list):
    for i in snake_list:
        pygame.draw.rect(win, (0, 255, 0), [i[0], i[1], 15, 15])

run = True
while run:
    
    pygame.time.delay(50)
    c = (score + 1)
    p = 15 * c
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            run = False
    keys = pygame.key.get_pressed()

    if keys[pygame.K_LEFT] and x > vel:
        normalx = -1 * vel
        normaly = 0
        width = p
        height = 15
    elif keys[pygame.K_RIGHT] and x < wix - width - vel:
        normalx = vel
        normaly = 0
        width = p
        height = 15
    elif keys[pygame.K_UP] and y > vel:
        normaly = -1 * vel
        normalx = 0
        width = 15
        height = p
    elif keys[pygame.K_DOWN] and y < wiy - height - vel:
        normaly = vel       
        normalx = 0
        width = 15
        height = p
        
  
    if x > vel and x < wix and y < wiy and y > vel:
        pass
    else:
        run = False
        
    win.fill((0, 0, 0))
    x = x + normalx
    y = y + normaly
    snake = pygame.draw.rect(win, (0, 255, 0), (x, y, width, height))
    
    snake_Head = []
    snake_Head.append(x)
    snake_Head.append(y)
    snake_List.append(snake_Head)
    if len(snake_List) > Length_of_snake:
        del snake_List[0]

    for i in snake_List[:-1]:
        if i == snake_Head:
            run = False
    our_snake(15, snake_List)
    
    apple = pygame.draw.rect(win, (255, 0, 0), (ax, ay, awidth, aheight))
    pygame.display.update()


    if snake.collidepoint((ax, ay)):
        score += 1
        Length_of_snake += 1
        ax = round(random.randrange(0, wiy - round(y)) / 10) * 10
        ay = round(random.randrange(0, wix - round(x)) / 10) * 10
        

    
pygame.quit()
tkinter.messagebox.showinfo(title = "Score", message = "Your score is " + str(score) + ".")
    
