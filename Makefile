PROJECT_HOME?=$(PWD)
UNITY_VERSION?=$(shell grep 'm_EditorVersion:' $(PROJECT_HOME)/ProjectSettings/ProjectVersion.txt | grep -o -E '\d{4}\.[1-4]\.\d+[abfp]\d+')
UNITY?=/Applications/Unity/HUB/Editor/$(UNITY_VERSION)/Unity.app/Contents/MacOS/Unity
BUILD_DIR?=$(PROJECT_HOME)/Build
LOG_DIR?=$(PROJECT_HOME)/Logs

# ReSharper command line tools
# download from https://www.jetbrains.com/resharper/download/index.html#section=commandline
RESHARPER_DIR?=$(HOME)/Tools/JetBrains.ReSharper.CommandLineTools.2021.1.1/
RESHARPER_TARGET?=$(shell find $(PROJECT_HOME) -name *.sln)

.PHONY: clean
clean:
	rm -rf $(BUILD_DIR)
	rm -rf $(LOG_DIR)

.PHONY: build
build:
	mkdir -p $(BUILD_DIR)
	mkdir -p $(LOG_DIR)
	$(UNITY) \
	  -projectPath $(PROJECT_HOME) \
	  -batchmode \
	  -buildOSXUniversalPlayer $(BUILD_DIR)/sample.app \
	  -quit \
	  -nographics \
	  -silent-crashes \
	  -stackTraceLogType Full \
	  -logFile $(LOG_DIR)/build.log

.PHONY: inspect
inspect:
	mkdir -p $(LOG_DIR)
	$(RESHARPER_DIR)/inspectcode.sh \
	  $(RESHARPER_TARGET) \
	  --output=$(LOG_DIR)/inspect.xml \
	  --format=xml
