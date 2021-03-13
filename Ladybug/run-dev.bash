#!/bin/bash
echo "Start"
cd ./Liquibase

dbUrl="jdbc:postgresql://postgres:5432/postgres"
dbUserName="postgres"
dbPassword=""

if [ $ASPNETCORE_ENVIRONMENT = "LocalRegression" ] ;\
then\
	dbUrl="jdbc:postgresql://pgsql_regression/keepbug"
	dbUserName="postgres"
fi;

cd /app/Liquibase/ && \

java -jar liquibase.jar \
	--driver=org.postgresql.Driver \
	--classpath=./postgresql-42.2.18.jar \
	--url=$dbUrl \
	--changeLogFile=./Changelog/changlog-initschema.xml \
	--username=$dbUserName\
	--password=$dbPassword\
	--defaultSchemaName=public\
	update;
java -jar liquibase.jar \
	--driver=org.postgresql.Driver \
	--classpath=./postgresql-42.2.18.jar \
	--url=$dbUrl \
	--changeLogFile=./Changelog/changelog-master.xml \
	--username=$dbUserName\
	--password=$dbPassword\
	--defaultSchemaName=keepbug\
	update && cd /app/out \
	&& dotnet Ladybug.dll
