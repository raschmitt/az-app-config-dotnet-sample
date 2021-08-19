# .Net - Azure App Config Sample

[![Azure DevOps builds (stage)](https://img.shields.io/azure-devops/build/raschmitt/7618d927-8467-43e2-b5e9-1aeddc1fbfdc/42?label=Continuous%20Integration&stage=CI&style=flat-square)](https://dev.azure.com/raschmitt/raschmitt/_build?definitionId=42)
[![Sonar Coverage](https://img.shields.io/sonar/coverage/raschmitt_unleash-dotnet-sample?label=Code%20coverage&server=https%3A%2F%2Fsonarcloud.io&style=flat-square)](https://sonarcloud.io/dashboard?id=raschmitt_unleash-dotnet-sample)
[![Mutation testing badge](https://img.shields.io/endpoint?style=flat-square&url=https%3A%2F%2Fbadge-api.stryker-mutator.io%2Fgithub.com%2Fraschmitt%2Funleash-dotnet-sample%2Fmain)](https://dashboard.stryker-mutator.io/reports/github.com/raschmitt/unleash-dotnet-sample/main)

Sample .Net Core API, using [Unleash](https://github.com/Unleash/unleash) as a feature flag manager. 

## Dependencies 

- [Docker](https://docs.docker.com/get-docker/)

## Running locally

1. After

2. Then go into the `src` directory and run `docker-compose up`.

2. Access [http://localhost:4242/](http://localhost:4242/) to create and manage feature flags.

      Use the following credentials to login:

      | Username | Password |
      | :---: | :---: |
      | admin | unleash4all |
 
3. Access [http://localhost:8080/swagger/](http://localhost:8080/swagger/) to query your feature flags using the .Net API.
  
      Keep in mind that the feature flags are case sensitive.

## Resources

- [Azure App Config - Getting Started](https://docs.microsoft.com/en-us/azure/azure-app-configuration/quickstart-feature-flag-aspnet-core?tabs=core5x)
- [Azure App Config - Pricing](https://azure.microsoft.com/en-us/pricing/details/app-configuration/)

## Contributions

  Contributions and feature requests are always welcome.
