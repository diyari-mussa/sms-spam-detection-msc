# Flask API

Flask service used by the Android demo at the end of the degree. `flask_message_api.py` is the service. The other three files are small earlier trials and are kept with it.

## `flask_message_api.py`

`GET /messages` reads query parameters `id` and `msg`. The response is a one-item JSON list:

```json
[{"id": "<the id query>", "message": "spam"}]
```

`message` is `spam` when the LightGBM prediction is `1`, and `ham` otherwise.

On each request the function reads a tab-separated corpus, builds ten structural features, fits `LGBMClassifier`, and predicts the incoming text. The corpus path in the file is:

`C:\Users\OMEN\Machine Learning Kaggles\Data sets\SMSSpamCollectionfixed.csv`

That file is not in this archive. The development server at the bottom of the script listens on port **9090**.

The ten features extracted for this demo are:

| Column in the script | What it measures |
| --- | --- |
| `feature3` | Count of non-alphanumeric characters |
| `feature4` | Count of alphanumeric words |
| `feature6` | Count of uppercase letters |
| `feature8` | Mathematical symbols |
| `feature9` | URL |
| `feature15` | Phone number |
| `feature22` | Currency symbol |
| `feature23` | Service numbers (short digit strings) |
| `feature24` | Currency written as a word |
| `feature25` | Count of a fixed list of spam keywords |

This is the demo classifier shipped with the phone app. The thesis reports its best LightGBM result separately: 99.139% with nine features chosen by sequential backward selection. See Chapter 4 of the thesis.

The Python 3.7 scientific packages are listed in [ml-pipeline/requirements-py37.txt](../ml-pipeline/requirements-py37.txt). Flask itself was installed on the original machine and is not named in that list.

## Earlier trials

| File | What it contains |
| --- | --- |
| `flask_test_1.py` | A one-route greeting |
| `flask_test_2.py` | JSON trials, development server on port 8080 |
| `flask_test_args.py` | A query-parameter trial, development server on port 8090 |

The Android client was later pointed at port 8080 on the 2020 server, while this API file listens on port 9090. Those values are left as written. See [android-app](../android-app).
