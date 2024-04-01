import pygame
import random
import tkinter.messagebox

pygame.init()

wix = 500
wiy = 500

v = 5
streak = 0
timer = 60
lstreak = 0

win = pygame.display.set_mode((wix, wiy))
pygame.display.set_caption("Eggciting game")

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
        if streak > lstreak:
            lstreak = streak
        streak = 0
        ax = random.randint(0, wix-15)
        if v != 1:
            v -= 1
    
    win.fill((100, 110, 255))
    ay += v
    bg_img = pygame.image.load('bg.jpg')
    bg_img = pygame.transform.scale(bg_img,(wix, wiy))
    player_image = pygame.image.load("basket.png").convert_alpha()
    basket = player_image.get_rect(center = (x, wiy-20))
    win.blit(player_image, basket)
    egg = pygame.draw.rect(win, (255, 255, 255), (ax, ay, 15, 15))
    ground = pygame.draw.rect(win, (0, 255, 0), (0, wiy-10, wix, 20))
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
        streak += 1
        

    

pygame.quit()
if streak > lstreak:
    lstreak = str(streak) + " and counting"
tkinter.messagebox.showinfo(title = "Stats", message = "Your score is " + str(score) + ".\nLongest streak: " + str(lstreak) + ".\n")
    
