from flask import Flask, render_template
import random
import string

app = Flask(__name__)

class WordSearchGame:
    def __init__(self, words):
        self.words_to_find = words
        self.grid = [['' for _ in range(10)] for _ in range(10)]

    def generate_grid(self):
        for i in range(10):
            for j in range(10):
                self.grid[i][j] = random.choice(string.ascii_uppercase)

@app.route('/')
def home():
    game = WordSearchGame(['WORD', 'SEARCH', 'GAME'])
    game.generate_grid()
    return render_template('index.html', game=game)

if __name__ == '__main__':
    app.run(debug=True)