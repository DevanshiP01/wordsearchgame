from flask import Flask, render_template
from word_search_game import WordSearchGame

app = Flask(__name__)

@app.route('/')
def home():
    game = WordSearchGame(['WORD', 'SEARCH', 'GAME'])
    game.generate_grid()
    return render_template('index.html', game=game)

if __name__ == '__main__':
    app.run(debug=True)
