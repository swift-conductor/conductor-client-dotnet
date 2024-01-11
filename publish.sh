#!/usr/bin/env bash

source configure.sh
source version.sh

nuget push ./build/swift-conductor-client.${SDK_VERSION}.nupkg -Source https://api.nuget.org/v3/index.json