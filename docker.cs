Comandos:
docker run hello-world /*(corro el contenedor hello-world)*/
docker ps /*(muestra los contenedores activos)*/
docker ps -a /*(muestra todos los contenedores)*/
docker inspect <containe ID> /*(muestra el detalle completo de un contenedor)*/
docker inspect <name> /*(igual que el anterior pero invocado con el nombre)*/
docker run –-name hello-platzi hello-world /*(le asigno un nombre custom “hello-platzi”)*/
docker rename hello-platzi hola-platzy /*(cambio el nombre de hello-platzi a hola-platzi)*/
docker rm <ID o nombre> /*(borro un contenedor)*/
docker container prune /*(borro todos lo contenedores que esten parados)*/

//bind mounts - Transferir datos de docker al administrador
$docker run  -d --name mongodb -v rutaAdministrador:rutacontenedor mongo /*(Todo lo que esté en esa ruta dentro del contenedor queda guardado en el administrador)*/

//Volumenes de docker, sin los signos mayor y menor
docker volume ls /*(listo los volumes)*/
docker volume create <nombrevolumen> /*((creo un volumen)*/
docker run -d --name db --mount src=<nombrevolumen>,dst=/data/db mongo /*(corro la BD y monto el volume)*/
docker inspect db /*(veo la información detallada del contenedor)*/


$ docker network ls (listo las redes)
$ docker network inspect docker_default (veo la definición de la red)
$ docker-compose logs (veo todos los logs)
$ docker-compose logs app (solo veo el log de “app”)
$ docker-compose logs -f app (hago un follow del log de app)
$ docker-compose exec app bash (entro al shell del contenedor app)
$ docker-compose ps (veo los contenedores generados por docker compose)
$ docker-compose down (borro todo lo generado por docker compose)	

$ docker-compose build (crea las imágenes)
$ docker-compose up -d (crea los servicios/contenedores)
