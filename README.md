## Database setup

In **appsettings.json** modify the connection string:

`"DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=BethanyDemo123;Trusted_Connection=True;MultipleActiveResultSets=true"`

Powershell (add a new migration):

```

$ add-migration migrationName
$ update-database

```

If necessary, remove the latest migration with:

`$ remove-migration`
