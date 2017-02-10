--- StructureMapExample ---

A quick example to serve as a reminder to myself on how to get StructureMap up
and running in a basic console application.

Default naming convention allows implicit registration between interfaces and
concrete classes following interface I[name] convention: shown in the
ICalculator and Calculator example.

If the convention is not followed, explicit registration is needed: shown in
the ILogger and ApplicationLogger example.

--------------------------------------------------------------------------------
--- WebStructureMapExample ---

A quick example of getting StructureMap running in a web application.

A very simple PersonRepository gets injected into the HomeController through
the default naming convention as IPersonRepository.

--------------------------------------------------------------------------------
--- CoreStructureMapExample ---

Another example using .NET Core.

ConfigureIoC in the Startup class registers anything using the default naming
convention, along with an explicit registration for the IMisnamedRepository and
StuffRepository.
