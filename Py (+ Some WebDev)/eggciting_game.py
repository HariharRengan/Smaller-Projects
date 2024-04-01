import pygame
import random
import tkinter.messagebox

pygame.init()

wix = 500
wiy = 500

v = 5

timer = 60

win = pygame.display.set_mode((wix, wiy))
pygame.display.set_caption("Eggciting game")

font_style1 = pygame.font.SysFont("comicsansms", 20)
score_font = pygame.font.SysFont("comicsansms", 25)

x = wix / 2
ax = x

ay = 20

gtime = 0

score = 0

run = True
while run:
    pygame.time.delay(50)
    gtime += 1
    if timer == 0:
        run = False
    if gtime == 20:
        timer -= 1
        gtime = 0
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            run = False
    keys = pygame.key.get_pressed()

    if keys[pygame.K_LEFT] and x > 0:
        x -= 5
    elif keys[pygame.K_RIGHT] and x < wix - 15:
        x += 5
        
        
    if ay < wiy - 20:
        pass
    else:
        ay = 20
        ax = random.randint(0, wix-15)
        v -= 1
        
    win.fill((0, 0, 0))
    ay += v
    basket = pygame.draw.rect(win, (255, 0, 0), (x, wiy - 20, 60, 15))
    egg = pygame.draw.rect(win, (255, 255, 255), (ax, ay, 15, 15))
    value = score_font.render("Your Score: " + str(score), True, (0, 255, 0))
    win.blit(value, (0, 0))
    value1 = score_font.render(str(timer), True, (240, 0, 255))
    win.blit(value1, (400, 0))
        
    
    pygame.display.update()


    if basket.collidepoint((ax, ay)):
        score += 1
        ay = 20
        ax = random.randint(0, wix)
        aax = random.randint(0, wix)
        v += 1
        

    
pygame.quit()
tkinter.messagebox.showinfo(title = "Score", message = "Your score is " + str(score) + ".")
    
