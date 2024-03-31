from flask import Flask, render_template, request
import sqlite3

con = sqlite3.connect("test.db", check_same_thread=False)
cur = con.cursor()

app = Flask(__name__)

def postev():
    titles = cur.execute("SELECT title FROM test").fetchall()
    descs = cur.execute("SELECT desc FROM test").fetchall()
    posts = []
    if len(titles) == len(descs):
        for i in titles:
            t = str(i)[2:-3]
            description = str(descs[titles.index(i)])[2:-3]
            posts.append([t, description])
    return render_template("index.html", posts = posts[::-1])

@app.route("/")
def index():
    try:
        return postev()
    except:
        return render_template("index.html")
       

@app.route("/", methods=["POST", "GET"])
def posting():
    if request.method == "POST":
        if len(request.form["title"]) != 0 and len(request.form["desc"]) != 0:
            title = request.form["title"]
            desc = request.form["desc"]
            command = "INSERT INTO test VALUES('"+title+"', '"+desc+"')"
            cur.execute(command)
            con.commit()
            return postev()
        else:
            return render_template("index.html")
    else:
        return postev()
        
if __name__ == "__main__":
    app.run(debug=True)