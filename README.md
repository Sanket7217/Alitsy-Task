# Alitsy-Task
This is C# MVC Web application containing model, view, and controller layer to perform the calculation of energy rate in dollars per kWh. Front-end is built using bootstrap 3.4.1, HTML, CSS, and JavaScript, Jquery, Ajax. Validation for the input fields is handled with bootstrap and JavaScript. JavaScript is mainly used for calculating energy rates when input is provided by the user, and if any of the input is missing then it will generate an error message.
### DB
sql scripts are avialble with code base at *AlitsyTask/AlitsyTask/Scripts*
* DDL Createdb_01.sql and Createtable_01.sql

db Schema Name: CMSSystem

### How to Run
* Import project to Visual studio
* Buid and run.
* launch application to browser using http://127.0.0.1:8080
* click link "Tariff 1"

### API
Please find below REST API for Persist the record:
```
POST /Home/save HTTP/1.1
Host: 127.0.0.1:8080
Content-Type: application/json
Cookie: ASP.NET_SessionId=B59E636DFC9AA6AA4408E97F

{"BillType_Name": "Block",
"EntryMethod_Name": "Fast",
"GST": "GST incl",
"OffPeakCharge": "5",
"OffPeakEnergyRate": "1.00000",
"OffPeakQuantity": "5",
"PeakCharge": "5",
"PeakEnergyRate": "1.00000",
"PeakQuantity": "5",
"ShoulderCharge": "5",
"ShoulderEnergyRate": "1.00000",
"ShoulderQuantity": "5"
}
```

