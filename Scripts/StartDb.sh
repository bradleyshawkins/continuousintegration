docker build -t continuousintegration-db ../Database
docker run -e MY_SQL_ROOT_PASSWORD=d3v3nv -p 127.0.0.1:3306:3306 continuousintegration-db