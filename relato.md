# Relato da implementação

## Experiência com F#

Para realizar esta atividade, escolhemos a linguagem F#. Como não tínhamos experiência com essa linguagem, foi necessário aprender alguns conceitos básicos antes de começar.

A atividade consistiu em criar versões em F# dos três códigos fornecidos originalmente em Python.

## Implementação

No primeiro programa, criamos uma thread que executa uma função. O programa principal espera a thread terminar utilizando `Join()`.

No segundo programa, utilizamos uma thread para executar uma função que recebe parâmetros.

No terceiro programa, criamos cinco threads que executam tarefas ao mesmo tempo. Também observamos o tempo de execução e percebemos que as threads conseguem realizar as tarefas de forma concorrente.

## Docker

Também utilizamos o Docker para executar os programas.

Foi necessário instalar e configurar o Docker Desktop e o WSL 2 no Windows. Para cada programa, criamos um `Dockerfile` e utilizamos o Docker para criar uma imagem e executar os programas dentro de containers.

## Dificuldades

A principal dificuldade foi aprender uma linguagem que não conhecíamos, já que não tínhamos experiência anterior com F#.

Também tivemos algumas dificuldades na instalação e configuração do Docker e do WSL 2. Depois de configurar o ambiente, conseguimos executar os três programas corretamente.

## Conclusão

A atividade permitiu conhecer melhor o funcionamento das threads e aprender conceitos básicos da linguagem F#.

Também foi possível aprender o básico sobre Docker e executar os programas dentro de containers.

No final, conseguimos implementar e executar os três exemplos com sucesso.
