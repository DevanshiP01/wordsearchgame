import random
import string

class WordSearchGame:
    def __init__(self, words):
        self.words_to_find = words
        self.grid = [['' for _ in range(10)] for _ in range(10)]

    def generate_grid(self):
        # Fill the grid with random letters
        for i in range(10):
            for j in range(10):
                self.grid[i][j] = random.choice(string.ascii_uppercase)

    def check_word(self, word):
        # TODO: Check if the word is in the grid
        return False