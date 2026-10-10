# Machine-learning pipeline

These are the research copies of the Python 3.7 scripts used for the February 2020 thesis and the December 2019 article. They are preserved as they were. They expect the long argument lists that the Windows bench in [desktop-gui](../desktop-gui) builds from its checkboxes.

| File | Role |
| --- | --- |
| `Preprocessing.py` | Load the tab-separated corpus, encode the ham/spam label, and extract structural features |
| `FeatureSelection.py` | Sequential forward or sequential backward selection with `mlxtend`, then score GBM, XGBoost, or LightGBM |
| `TestNewDataset.py` | Classify with the selected feature names and print evaluation for the three boosting models |
| `Prediction.py` | A parallel classification script kept beside the research copies |

`FeatureSelection.py` calls `mlxtend.feature_selection.SequentialFeatureSelector` with `cv=10`. The `forward` flag chooses sequential forward selection or sequential backward selection. Accuracy, and the other reported metrics, come from 10-fold `cross_val_score` / `cross_val_predict`.

## Which copy this is

`Preprocessing.py` and `FeatureSelection.py` in this folder are the research-folder snapshots. The Windows bench launches different copies, stored under [desktop-gui/.../Requirements_venv](../desktop-gui/SMSSpamFilterProject/Needed_Resources/Requirements_venv). Those GUI copies add a feature-export argument to preprocessing and construct GBM as `GradientBoostingClassifier(random_state=0)`. `TestNewDataset.py` is the same file in both places.

## Dependencies

`requirements-py37.txt` is the dependency list saved with the project:

```
numpy==1.16.2
pandas==0.24.2
xgboost==0.82
lightgbm==2.2.3
sklearn==0.21.0
mlxtend==0.16.0
```

That file records the 2019–2020 environment. `sklearn` was the PyPI name used then. The scripts read a dataset path from `sys.argv`. The SMS Spam Collection file is not in this repository; see the [root README](../README.md).
