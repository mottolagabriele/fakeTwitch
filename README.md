# FakeTwitch
## Info
Questa è la prima versione di FakeTwich. Il sistema è basato su un database Redis.
Per ora non è stata creata la parte di creazione dei dati, che dovranno essere creati manualmente
## Funzionalità
* Assegnamento dei punti in base al tempo di visualizzazione
* Assegnamento dei punti bonus random con la creazione del bottone
* Visualizzazione senza login
* Login con username e password
* Selezione del canale scelto
## Struttura
* Gli utenti sono definiti come utenti:_username_, è un hash con i campi password e nome
* I canali sono classifiche:_nome_, è una lista ordinata dove score è il punteggio e Value il nome utente
## Attenzione
* Non esiste un sistema di streaming vero, viene visualizzata un'immagine fissa

