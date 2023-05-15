= WHAT WORKS

http://localhost:5226/weatherforecast
http://localhost:5226/weatherforecast?$select=summary

= WHAT DOESNT WORK

http://localhost:5226/weatherforecast?$compute=length(Summary) as len&$select=summary,len

Could not find a property named 'len' on type 'ComputeExample.WeatherForecast'.
at Microsoft.OData.UriParser.SelectPathSegmentTokenBinder.ConvertNonTypeTokenToSegment(PathSegmentToken tokenIn, IEdmModel model, IEdmStructuredType edmType, ODataUriResolver resolver, BindingState state)
    at Microsoft.OData.UriParser.SelectExpandBinder.ProcessSelectTokenPath(PathSegmentToken tokenIn)
    at Microsoft.OData.UriParser.SelectExpandBinder.GenerateSelectItem(SelectTermToken tokenIn)
    at Microsoft.OData.UriParser.SelectExpandBinder.Bind(ExpandToken expandToken, SelectToken selectToken)
    at Microsoft.OData.UriParser.SelectExpandSemanticBinder.Bind(ODataPathInfo odataPathInfo, ExpandToken expandToken, SelectToken selectToken, ODataUriParserConfiguration configuration, BindingState state)
    at Microsoft.OData.UriParser.ODataQueryOptionParser.ParseSelectAndExpandImplementation(String select, String expand, ODataUriParserConfiguration configuration, ODataPathInfo odataPathInfo)
    at Microsoft.OData.UriParser.ODataQueryOptionParser.ParseSelectAndExpand()
    at Microsoft.AspNetCore.OData.Query.SelectExpandQueryOption.ProcessLevels()
    at Microsoft.AspNetCore.OData.Query.SelectExpandQueryOption.get_ProcessedSelectExpandClause()
    at Microsoft.AspNetCore.OData.Query.ODataQueryOptions.ApplySelectExpand[T](T entity, ODataQuerySettings querySettings)
    at Microsoft.AspNetCore.OData.Query.ODataQueryOptions.ApplyTo(IQueryable query, ODataQuerySettings querySettings)
    at ComputeExample.Controllers.WeatherForecastController.Get(ODataQueryOptions`1 options) in C:\git\ComputeExample\ComputeExample\Controllers\WeatherForecastController.cs:line 34
    at lambda_method1(Closure , Object , Object[] )
    at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.SyncActionResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
    at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeActionMethodAsync>g__Logged|12_1(ControllerActionInvoker invoker)
    at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeNextActionFilterAsync>g__Awaited|10_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
    at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
    at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
    at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.InvokeInnerFilterAsync()
--- End of stack trace from previous location ---
    at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeFilterPipelineAsync>g__Awaited|20_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
    at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Logged|17_1(ResourceInvoker invoker)
    at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Logged|17_1(ResourceInvoker invoker)
    at Microsoft.AspNetCore.Routing.EndpointMiddleware.<Invoke>g__AwaitRequestTask|6_0(Endpoint endpoint, Task requestTask, ILogger logger)
    at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
    at Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddleware.Invoke(HttpContext context)



http://localhost:5226/weatherforecast?$compute=length(Summary) as len&$select=summary,len&filter=summary ne null

An unhandled exception has occurred while executing the request.
  System.InvalidOperationException: Sequence contains no matching element
      at System.Linq.ThrowHelper.ThrowNoMatchException()
      at Microsoft.AspNetCore.OData.Query.Container.JsonPropertyNameMapper.MapProperty(String propertyName)
      at Microsoft.AspNetCore.OData.Query.Container.NamedProperty`1.ToDictionaryCore(Dictionary`2 dictionary, IPropertyMapper propertyMapper, Boolean includeAutoSelected)
      at Microsoft.AspNetCore.OData.Query.Container.PropertyContainer.NamedPropertyWithNext1`1.ToDictionaryCore(Dictionary`2 dictionary, IPropertyMapper propertyMapper, Boolean includeAutoSelected)
      at Microsoft.AspNetCore.OData.Query.Wrapper.SelectExpandWrapper.ToDictionary(Func`3 mapperProvider)
      at Microsoft.AspNetCore.OData.Query.Wrapper.SelectSomeConverter`1.Write(Utf8JsonWriter writer, SelectSome`1 value, JsonSerializerOptions options)
      at System.Text.Json.Serialization.JsonConverter`1.TryWrite(Utf8JsonWriter writer, T& value, JsonSerializerOptions options, WriteStack& state)
      at System.Text.Json.Serialization.Converters.IEnumerableDefaultConverter`2.OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, WriteStack& state)
      at System.Text.Json.Serialization.JsonCollectionConverter`2.OnTryWrite(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, WriteStack& state)
      at System.Text.Json.Serialization.JsonConverter`1.TryWrite(Utf8JsonWriter writer, T& value, JsonSerializerOptions options, WriteStack& state)
      at System.Text.Json.Serialization.JsonConverter`1.WriteCore(Utf8JsonWriter writer, T& value, JsonSerializerOptions options, WriteStack& state)
      at System.Text.Json.Serialization.JsonConverter`1.WriteCoreAsObject(Utf8JsonWriter writer, Object value, JsonSerializerOptions options, WriteStack& state)
      at System.Text.Json.JsonSerializer.WriteCore[TValue](JsonConverter jsonConverter, Utf8JsonWriter writer, TValue& value, JsonSerializerOptions options, WriteStack& state)
      at System.Text.Json.JsonSerializer.WriteStreamAsync[TValue](Stream utf8Json, TValue value, JsonTypeInfo jsonTypeInfo, CancellationToken cancellationToken)
      at System.Text.Json.JsonSerializer.WriteStreamAsync[TValue](Stream utf8Json, TValue value, JsonTypeInfo jsonTypeInfo, CancellationToken cancellationToken)
      at System.Text.Json.JsonSerializer.WriteStreamAsync[TValue](Stream utf8Json, TValue value, JsonTypeInfo jsonTypeInfo, CancellationToken cancellationToken)
      at Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonOutputFormatter.WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
      at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeResultAsync>g__Logged|22_0(ResourceInvoker invoker, IActionResult result)
      at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextResultFilterAsync>g__Awaited|30_0[TFilter,TFilterAsync](ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
      at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Rethrow(ResultExecutedContextSealed context)
      at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.ResultNext[TFilter,TFilterAsync](State& next, Scope& scope, Object& state, Boolean& isCompleted)
      at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.InvokeResultFilters()
  --- End of stack trace from previous location ---
      at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeFilterPipelineAsync>g__Awaited|20_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
      at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Logged|17_1(ResourceInvoker invoker)         at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Logged|17_1(ResourceInvoker invoker)         at Microsoft.AspNetCore.Routing.EndpointMiddleware.<Invoke>g__AwaitRequestTask|6_0(Endpoint endpoint, Task requestTask, ILogger logger)
      at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
      at Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddleware.Invoke(HttpContext context)