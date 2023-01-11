﻿Install using;

```bash
helm upgrade --install anz abpzerotemplate-angular
```

Uninstall all charts

```bash
helm uninstall anz
```

## Create Images

### run in the aspnet-core folder
```bash
docker build -t abpzerotemplate-host -f src\I3T.CRM.Web.Host\Dockerfile .
docker build -t abpzerotemplate-migrator -f src\I3T.CRM.Migrator\Dockerfile .
```

### run in the angular folder
```bash
docker build -t abpzerotemplate-angular -f Dockerfile . 
```
