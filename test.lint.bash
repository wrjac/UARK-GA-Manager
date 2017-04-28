#!/bin/bash

shopt -s globstar

set -e

for x in **/*vb; do
	csharp -l "$x";
done