# Project Title

Vehicle tracking system.
### Getting Start
* System has 2 roles 
1. Admin - view report and add car license. (username :Admin, password :12345)
2. Driver - Add location every 30 minutes. (username :Driver, password :12345)
* You can change the time from 30 minutes to be another in Driver.cshtml as code below

```
    <script type="text/javascript">
     $(document).ready(function () {
         callLocation();
         setTimeout(function () {
             getLocation();
         }, 1800000);
     });
```
     
### Installing

1. Create Database name as "Vehicle"
2. Run SQL script file(Vehicle.sql)
3. Change Database Server, username and password in web.config to be your configuration as below

```
 <connectionStrings>
    <add name="VehicleEntities" connectionString="metadata=res://*/DBContext.csdl|res://*/DBContext.ssdl|res://*/DBContext.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source={Server Name};initial catalog=Vehicle;persist security info=True;user id={UserId};password={password};MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
```
