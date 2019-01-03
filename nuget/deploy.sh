#!/bin/bash

HERE=$(cd "$(dirname "$0")";pwd)
cd ${HERE}

TAG=$1
NUGET_KEY=$2

# TODO: verify version
VERSION=`echo $TAG | cut -b 2-`

NUPKG="${HERE}/AElf.Types.${VERSION}.nupkg"

rm AElf.Types/*.cs
protoc --proto_path=../proto/ --csharp_out=AElf.Types/ ../proto/*

# build
dotnet build AElf.Types/AElf.Types.csproj --configuration Release -P:Version=${VERSION} -o ../

if [ ! -f "${NUPKG}" ]; then
    echo "nupk not exist."
    exit 1
fi

# publish
dotnet nuget push ${NUPKG} -k ${NUGET_KEY} -s https://api.nuget.org/v3/index.json
