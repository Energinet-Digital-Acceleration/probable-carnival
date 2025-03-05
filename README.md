# probable-carnival

A small example project that shows how 2 Apps can share the same volume and read / write to it.

The sample can be run by:

```` bash
docker-compose up --build
````

* ConsoleApp1 will create a new file in the data folder.
* ConsoleApp2 will read existing file and write it.
