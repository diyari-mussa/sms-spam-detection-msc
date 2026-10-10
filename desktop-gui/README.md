# Windows experiment GUI

Visual Studio 2017 WinForms application (.NET Framework 4.8) used to run the thesis experiments. The forms collect options and start Python. The classifiers live in the Python scripts, not in the C# code.

Open `SMSSpamFilterProject.sln`. The project file records one NuGet dependency, `LumenWorksCsvReader` 4.0.0, in `packages.config`. The `packages` folder itself is not in this archive.

## Forms

| Form | What it does |
| --- | --- |
| `FormStart` | Locates `python.exe` and the three scripts the later forms launch |
| `Form1` | Preprocessing and structural feature extraction through `Preprocessing.py` |
| `Form2` | Sequential feature selection through `FeatureSelection.py` |
| `Form3` | Classification and evaluation through `TestNewDataset.py` |

The start form looks for Python 3.7 inside `Needed_Resources\Requirements_venv\venvpy37`. That virtual environment is not included. The pinned package list is `Needed_Resources\Requirements_venv\dependencies.txt`, and the same list is copied to [ml-pipeline/requirements-py37.txt](../ml-pipeline/requirements-py37.txt). `Notes.txt` in the same folder is the original note on how that environment was created.

## Scripts shipped with the GUI

The copies under `SMSSpamFilterProject\Needed_Resources\Requirements_venv` are the files this program was pointed at:

- `Preprocessing.py`
- `FeatureSelection.py`
- `TestNewDataset.py`

`Preprocessing.py` and `FeatureSelection.py` differ from the research copies in [ml-pipeline](../ml-pipeline). The GUI copies add a feature-export argument and set `GradientBoostingClassifier(random_state=0)`. Both snapshots are kept unchanged.

The start form still contains the original absolute paths, including:

- `C:\Users\<the Windows user name>\source\repos\SMSSpamFilterProject\SMSSpamFilterProject\Needed_Resources\Requirements_venv\venvpy37\Scripts\python.exe`
- `C:\Users\MSI GP66\source\repos\SMSSpamFilterProject\SMSSpamFilterProject\Needed_Resources\Requirements_venv\Preprocessing.py`
- the same `MSI GP66` prefix for `FeatureSelection.py` and `TestNewDataset.py`

## Dataset copies

The original project folder also kept local CSV files beside the application. Those copies are omitted here. The experiments used SMS Spam Collection v.1 from the [UCI Machine Learning Repository](https://archive.ics.uci.edu/ml/datasets/sms+spam+collection).

## Assembly info

`Properties\AssemblyInfo.cs` still contains the Visual Studio template line `Copyright © HP Inc. 2019`. That line was left as it was. The degree work is by Diyari Jalal Mussa.
