#!/usr/bin/env bash

source configure.sh
source version.sh

dotnet pack "swift-conductor-client/swift-conductor-client.csproj" \
    --output ./build \
    --include-symbols \
    --include-source \
    --configuration Release "/p:Version=${SDK_VERSION}"