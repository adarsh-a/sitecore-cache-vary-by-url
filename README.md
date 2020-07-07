
A custom cache implementation for Sitecore.

## Usage
* This can be used by controller rendering that do not have any datasource.
  For example, you have a rendering making a call to an external API to fetch some data but you do not want the code to run for each request.
  This cache will add an entry to the Sitecore cache which is cleared automatically on publish.

## Steps
1. You need to add the attribute "vbpg=1" in the controller rendering.
2. And that's it.
