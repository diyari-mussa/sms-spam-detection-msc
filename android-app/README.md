# Android demo

Demo client from the end of the MSc project. The splash title is **Lighting SMS Filter**. The about screen states version 1.0, Sulaimani Polytechnic University, College of Informatics, created by Diyari Jalal Mussa and supervised by Dr. Noor Ghazi.

The app receives an SMS, sends the text to the Flask API, and stores the result in a local database. Spam and ham lists are separate screens. The about text describes the app as a demo of gradient boosting on features taken from the message text.

## Build files as preserved

| Setting | Value in the project |
| --- | --- |
| Application id | `com.example.smsspamdetection` |
| Version | 1.0 (`versionCode` 1) |
| compileSdkVersion | 28 |
| minSdkVersion | 16 |
| targetSdkVersion | 28 |
| Android Gradle plugin | 3.6.1 |
| Gradle wrapper | 5.6.4 |
| HTTP client | Retrofit 2.6.0 |

`build.gradle` still lists `jcenter()` as a repository. `local.properties`, the `.idea` directory, and build outputs are not included.

Permissions in `AndroidManifest.xml` are `RECEIVE_SMS` and `INTERNET`. The SMS receiver is `ReceiveSms`.

## Server address

`ReceiveSms.java` builds Retrofit with:

`http://212.24.103.188:8080`

That address is the server used in 2020. The same line comments an emulator alternative, `http://10.0.2.2:9090`. The request is `GET messages` with query parameters `msg` and `id`, matching [flask-api/flask_message_api.py](../flask-api/flask_message_api.py). The Flask script in this archive listens on port 9090.

The call uses cleartext HTTP, as written in 2020.
