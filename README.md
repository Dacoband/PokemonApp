## An attempt to fix [@dagoband](https://github.com/Dacoband) PokemonAPI hosting on Azure Server.
- So... after around an hour re-read the code and try to run it myself. I have come to the conclusion that the method of creating an SQLServer database directly during buildtime is one of the most baffled and impertinent I have witness.
- The problem with the last (the day before I pulished this respository) build is that the Database cannot be build on Azure Hosting Sevice, and somehow the git cannot create a stable connection to Azure remote git respo.
- What today (the day of this respository published) I did was fork that program and try to fix the code... And it sorta worked. I don't know how but my git connection work and able to push the program onto my own Azure server app. Maybe the hypothesis is that  my pal Azure Server is bugging out.
- Afterward, the app built successfully, swagger.io build-in UI ran. Even the API endpoint registered corretly. The only **BIG** problem I encountered is that SQLSERVER code.
- So... after a bit more hours trying to split the Database codes from the API code. I went for a cup of coffee and absolutely forgot about the atroscity that is this app.
- So I send you the full program *with the bugs* and hope someone will aid me. I will try further to re-code the whole things (mostly with the Context and the App Json) to use my remote MySQL server instead of creating **A WHOLE DATABASE WITH CODE**
- Good luck to anyone manage to fix this. Thanks!!! <3 <3 <3
