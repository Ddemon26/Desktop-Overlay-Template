#!/bin/bash

# Create a new release on GitHub using Git and GitHub CLI
# Ensure GitHub CLI is installed and authenticated (https://cli.github.com/)

# Variables (customize these accordingly)
REPO="Ddemon26/Desktop-Overlay-Template"
TAG_NAME="v1.0.0"  # Replace with the desired version
RELEASE_NAME="Desktop Overlay Template v1.0.0"
RELEASE_BODY="Initial release of the Desktop Overlay Template with core functionalities including Overlay System, Particle Controller, and Effect Wizard."
TARGET_BRANCH="main"  # Branch to target for the release

# Create a new tag
git tag -a "$TAG_NAME" -m "Release $TAG_NAME"

# Push the tag to GitHub
git push origin "$TAG_NAME"

# Create a release on GitHub
gh release create "$TAG_NAME" \
  --repo "$REPO" \
  --title "$RELEASE_NAME" \
  --notes "$RELEASE_BODY" \
  --target "$TARGET_BRANCH"

# Output a message indicating success
echo "Release $TAG_NAME has been successfully created on GitHub."
