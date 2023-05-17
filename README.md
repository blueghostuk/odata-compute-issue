= ISSUE

When using the odata endpoint, $expand works as expected, for example:
- http://localhost:5226/odata/Weathers
 - by default City is not expanded, as expected
 - properties are camelCase, as expected
- http://localhost:5226/odata/Weathers?$expand=City
 - City is expanded, as expected
 - properties are camelCase, as expected

When using ODataQueryOptions, $expand does not work as expected, for example:
- http://localhost:5226/weatherforecast
 - by default City is expanded, I would expect it not to be
 - properties are camelCase, as expected
- http://localhost:5226/weatherforecast?$expand=City
 - this expands City, but notice the properties are PascalCase, not camelCase as expected