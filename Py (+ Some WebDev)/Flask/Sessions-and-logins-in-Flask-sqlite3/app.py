from flask import Flask, request, url_for, redirect, render_template, session
import sqlite3
import traceback

app = Flask(__name__)

con = sqlite3.connect("users.db", check_same_thread=False)
cur = con.cursor()

app.config['SECRET_KEY']='12345SECRET'

@app.route('/')
def sign():
    return render_template("signup.html")
    
@app.route('/', methods=["POST"])
def signup():
    try:
        if request.form['name'] != None and request.form['passw'] != None and request.form['name'] not in [i[0] for i in cur.execute("SELECT usr FROM user").fetchall()]:
            cur.execute("INSERT into user(usr, passw) VALUES(?, ?)", (request.form["name"], request.form["passw"]))
            con.commit()
            session["USERNAME"] = request.form["name"]
            cur.execute("CREATE table "+request.form["name"]+"(title CHAR(20), desc CHAR(200))")
            con.commit()
            return redirect("/main")
        else:
            return redirect("/")
    except Exception as ex:
        print(traceback.format_exc())
        return traceback.format_exc()
    
@app.route('/login')
def log():
    return render_template("login.html")
    
@app.route('/login', methods=["POST"])
def login():
    try:
        if request.form['lname'] != None and request.form['lpassw'] != None:
            cur.execute("SELECT * FROM user")

            rows = cur.fetchall()
            
            
            for i in rows:
                if request.form['lname'] == i[0] and request.form['lpassw'] == i[1]:
                    session['USERNAME'] = request.form['lname']
                    return redirect("/main")
            return redirect("/login")
        else:
            redirect("/login")
    except Exception as ex:
        print(traceback.format_exc())
        return render_template("login.html")
        
        
@app.route('/main')
def index():
    try:
        return render_template("main.html", us = session["USERNAME"], tasks=cur.execute("SELECT * FROM "+session["USERNAME"]).fetchall())
    except:
        return "An error has occured. Login or sign up, then try again later"
    
@app.route('/main', methods=["POST"])
def index2():
    try:
        if request.form["title"] != None and request.form["desc"] != None:
            cur.execute("INSERT into "+session["USERNAME"]+"(title, desc) VALUES(?, ?)", (request.form["title"], request.form["desc"]))
            con.commit()
            
    except:
        print(traceback.format_exc())
    
    return render_template("main.html", us = session["USERNAME"], tasks=cur.execute("SELECT * FROM "+session["USERNAME"]).fetchall())
    

@app.route('/<id>/delete/', methods=('POST',))
def delete(id):
    cur.execute('DELETE FROM '+session["USERNAME"]+' WHERE title = ?', (id,))
    con.commit()
    return redirect('/main')



if __name__ == "__main__":
    app.run(debug=True)