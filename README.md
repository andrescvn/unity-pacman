# unity-pacman
fuentes:http://answers.unity3d.com/questions/1222746/make-zombie-chase-player-within-a-set-range.html
El proyecto trata sobre crear un enemigo en el entorno de juego que persiga a nuestro personaje y que si llega a alcanzarlo el jugador se destruya
Para crear la persecucion se necesita crear una variable distancia la cual se iniciara con un Vextor3.distance el cual recibira los metodos target.position, transform.position siendo el target nuestro jugador que se iniciara en el metodo Start mediante un GameObject.FindGameObjectWithTag("Player").transform; dentro de este mismo metodo Start se necesita inicializar un NavMeshAgent que se enlazara con el navMeshAgent que el objeto enemigo tendra.
Una vez creada la variable distancia y el nav se puede decir al enemigo que persiga al jugador con un setDestination y jugar con la distancia para que el enemigo pueda hacer cosas como por ejemplo destruir al jguador cuando llegue a cierta distancia
