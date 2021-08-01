# GitHub Actions

Collection of GitHub actions.

## Workflows



Set working directory if the solution file is not in root folder.

```
defaults:
  run:
    working-directory: src
```



Add `fetch-depth: 0` if using `GitVersion.MsBuild`  

```
    - uses: actions/checkout@v2
      with: 
        fetch-depth: 0    
```



## 



### NuGet push package

`nuget-push-package.yml` 



### NuGet push package with symbols

`nuget-push-package-with-symbols.yml`



### NuGet delete packages

`nuget-delete-packages.yml`

