from flask import Flask, render_template, request, redirect, session, flash

app = Flask(__name__)
app.secret_key = 'secret'

@app.route('/', methods = ['GET', 'POST'])
def index():
    if request.method == 'GET':
        return render_template('index.html')
    else:
        print(request.form.getlist('from'), request.form.getlist('to'), request.form['val'])
        try:
            if request.form.getlist('from')[0] == 'Denary':
                res = request.form['val']
            elif request.form.getlist('from')[0] == 'Binary':
                res = int(request.form['val'], 2)
            else:
                res = int(request.form['val'], 16)

            if request.form.getlist('to')[0] == 'denary':
                res = res
            elif request.form.getlist('to')[0] == 'binary':
                res = bin(res)
            else:
                res = hex(res)
            session['res'] = res
            return redirect('/result')
        except Exception as e:
            print(e)
            flash("Invalid Input")
            return redirect('/')

@app.route('/result')
def results():
    return render_template('result.html', res = session.get('res', 'No known conversions'))

if __name__ == '__main__':
    app.run(debug = True)
