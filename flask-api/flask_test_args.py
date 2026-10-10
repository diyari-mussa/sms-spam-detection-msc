from flask import Flask, jsonify, request
app = Flask(__name__) # define app using flask

@app.route('/params')
def params():

    arg1 = request.args['arg1']
    if(arg1=="hello"):
        return 'Arg1 : hello -> ' +  arg1
    else:
        return 'Arg1 : ' +  arg1

if __name__ == '__main__':
    app.run(debug=True, port=8090)