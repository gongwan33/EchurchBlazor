EXISTING_CONTAINTER=$(docker ps -a | grep "mssql-server"| lc -l)

echo $EXISTING_CONTAINER

exit


docker run -name mssql-server -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=mssqlMaster@local' -e 'MSSQL_PID=Express' -p 127.0.0.1:1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
