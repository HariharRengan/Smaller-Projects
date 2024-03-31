import pygame
import random

# Initialize the game
pygame.init()

# Set up the game window
window_width = 800
window_height = 600
window = pygame.display.set_mode((window_width, window_height))
pygame.display.set_caption("Snake Game")

# Set up the game clock
clock = pygame.time.Clock()

# Set up the colors
black = (0, 0, 0)
white = (255, 255, 255)
green = (0, 255, 0)
red = (255, 0, 0)

# Set up the snake and food
snake_block_size = 20
snake_speed = 15
snake_list = []
snake_length = 1
snake_head = [window_width / 2, window_height / 2]
food_position = [random.randrange(1, (window_width // snake_block_size)) * snake_block_size,
                 random.randrange(1, (window_height // snake_block_size)) * snake_block_size]


# Game loop
while True:
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            game_over = True

    # Move the snake
    keys = pygame.key.get_pressed()
    if keys[pygame.K_LEFT]:
        snake_head[0] -= snake_block_size
    if keys[pygame.K_RIGHT]:
        snake_head[0] += snake_block_size
    if keys[pygame.K_UP]:
        snake_head[1] -= snake_block_size
    if keys[pygame.K_DOWN]:
        snake_head[1] += snake_block_size

    # Check for collision with the food
    if snake_head[0] == food_position[0] and snake_head[1] == food_position[1]:
        food_position = [random.randrange(1, (window_width // snake_block_size)) * snake_block_size,
                         random.randrange(1, (window_height // snake_block_size)) * snake_block_size]
        snake_length += 1
    elif snake_head[0] < 0 or snake_head[0] >= window_width or snake_head[1] < 0 or snake_head[1] >= window_height:
        break

    # Update the snake list
    snake_list.append(list(snake_head))
    if len(snake_list) > snake_length:
        del snake_list[0]

    # Draw the snake and food
    window.fill(black)
    for segment in snake_list:
        pygame.draw.rect(window, green, [segment[0], segment[1], snake_block_size, snake_block_size])
    pygame.draw.rect(window, red, [food_position[0], food_position[1], snake_block_size, snake_block_size])

    # Update the game display
    pygame.display.update()

    # Set the game speed
    clock.tick(snake_speed)

# Quit the game
pygame.quit()
