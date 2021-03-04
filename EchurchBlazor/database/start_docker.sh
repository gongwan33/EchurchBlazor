EXISTING_CONTAINER=$(docker ps -a | grep "mssql-server"| wc -l | sed -e 's/^[[:space:]]*//')
SCRIPT_PATH="$( cd -- "$(dirname "$0")" >/dev/null 2>&1 ; pwd -P )"

if [ "$EXISTING_CONTAINER" -ge "1" ]; then

    echo "Removing existing container..."
    docker stop mssql-server
    docker rm mssql-server

fi

echo "Starting new container..."
docker run --name mssql-server -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=mssqlMaster@local' -e 'MSSQL_PID=Express' -v $SCRIPT_PATH/data:/var/opt/mssql/data -p 127.0.0.1:1433:1433 -d mcr.microsoft.com/mssql/server:2019-latest
