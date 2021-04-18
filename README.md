# InventoryManagement
The API Controller has functions that responds for GET, POST, PUT and DELETE requests which are useful for Listing, Adding, Modifying and Deleting inventory items in the database table.
 # ShopBridge Backend

"ShopBridge" needs a backend solution to build a website that helps track the different items they have for sale.

## Problem Statement

Create a backend solution for Product functionality to be used by Product
Admin, and perform below actions:
1. Add a new item to the inventory (The item should require a name, description, and price
as basic fileds, think of additional information that would be useful)
2. Modify an item in the inventory.
3. Delete an item from the inventory.
4. Lists the items in the inventory.
* Use a relational (SQL Server / MSSQL / Postgres) database and any ORM you feel
comfortable with for any persistent data storage needs. All of the functions of
the backend need to be served by an API call and the store’s inventory should be persisted
across restarts of the backend process.
* All API calls should be asynchronous.
* Include data validations as and when needed.
* Exception handling need to be present.

## DB Creation
* Set db connection string in appsettings.json
* Open Package Manager Console
* Set project to Entity.
* Set Startup project to WebApi.
* Run command:
```bash
update-database
```

## Example of POSTMAN call
### POST
Call URL https://localhost:44302/api/pay/ with POST with JSON:

```json
{
  "Name":"PC",
  "Description":"Desktop",
  "Price":40000,
  "QuantityAvailable":8
}
```
### PUT
Call URL https://localhost:44364/api/InventoryItems/6 with PUT with JSON:

```json
{
    "id": 6,
    "name": "PC",
    "description": "Desktop",
    "price": 40000,
    "itemCode": null,
    "quantityAvailable": 10,
    "catagory": null,
    "isActive": false,
    "brand": null,
    "manufacturer": null
}
```
### GET
Call URL https://localhost:44364/api/InventoryItems with GET  
This Should return list of Objects
```json
[
    {
        "id": 1,
        "name": "Mobile",
        "description": "Smart Phone",
        "price": 23000,
        "itemCode": null,
        "quantityAvailable": 0,
        "catagory": null,
        "isActive": false,
        "brand": "Apple",
        "manufacturer": null
    },
    {
        "id": 3,
        "name": "Camera",
        "description": "DSLR",
        "price": 60000,
        "itemCode": null,
        "quantityAvailable": 5,
        "catagory": null,
        "isActive": true,
        "brand": null,
        "manufacturer": null
    },
    {
        "id": 4,
        "name": "Laptop",
        "description": "Notebook",
        "price": 60000,
        "itemCode": null,
        "quantityAvailable": 8,
        "catagory": null,
        "isActive": true,
        "brand": "HP",
        "manufacturer": null
    },
    {
        "id": 6,
        "name": "PC",
        "description": "Desktop",
        "price": 40000,
        "itemCode": null,
        "quantityAvailable": 8,
        "catagory": null,
        "isActive": false,
        "brand": null,
        "manufacturer": null
    }
]
```
### GET
Call URL https://localhost:44364/api/InventoryItems/1 with GET  
This Should return Object with Id:1
```json
{
    "id": 1,
    "name": "Mobile",
    "description": "Smart Phone",
    "price": 23000,
    "itemCode": null,
    "quantityAvailable": 0,
    "catagory": null,
    "isActive": false,
    "brand": "Apple",
    "manufacturer": null
}
```
### DELETE
Call URL https://localhost:44364/api/InventoryItems/6 with DELETE  
This Should delete Object with Id:6

