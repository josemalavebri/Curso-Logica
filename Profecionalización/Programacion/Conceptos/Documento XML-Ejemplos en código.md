
#### Estructura básica de un [[Documento XML]]
```xml
<?xml version="1.0" encoding="UTF-8"?>
<RootElement>
    <ChildElement attribute="value">Content</ChildElement>
    <AnotherChildElement>
        <SubChild>SubContent</SubChild>
    </AnotherChildElement>
</RootElement>

```
#### Archivo de configuración
``` xml
<?xml version="1.0" encoding="UTF-8"?>
<Configuration>
    <Database>
        <Server>localhost</Server>
        <Port>1433</Port>
        <Username>admin</Username>
        <Password>password</Password>
    </Database>
    <Logging level="debug">
        <FilePath>/var/logs/app.log</FilePath>
    </Logging>
</Configuration>

```
#### Archivo de datos
``` xml
<?xml version="1.0" encoding="UTF-8"?>
<Users>
    <User id="1">
        <Name>John Doe</Name>
        <Email>john.doe@example.com</Email>
        <Age>30</Age>
    </User>
    <User id="2">
        <Name>Jane Smith</Name>
        <Email>jane.smith@example.com</Email>
        <Age>25</Age>
    </User>
</Users>

```