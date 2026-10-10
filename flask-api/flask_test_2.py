from flask import Flask, jsonify, request
app = Flask(__name__) # define app using flask

languages = [{'name' : 'JavaScript'}, {'name' : 'python'}]

@app.route('/', methods=['GET'])
def test():
    return jsonify({'message ' : 'It Works!'})
    
@app.route('/lang', methods=['GET'])
def returnAll():
    return jsonify({'languages ' : languages})



if __name__ == '__main__':
    app.run(debug=True, port=8080)