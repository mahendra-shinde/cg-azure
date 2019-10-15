## Container instances

Container is an application package that includes Runtime enviornment, framework, libraries and application code published on registries like docker hub (hub.docker.com).

Containers are easier to deploy and run. 

What can be packaged as container ?

1. A Microservice made with any language/framework.
2. A Web application.
3. A NoSQL Database.

Steps :
1. Create a resource group `mahendra-group`
2. Click `Create a resource` then search for `Container Instances` and click `create`
3.  Name of Container instance: myapp1
4.  Resource group : `mahendra-group`
5.  Image type: `Public`
6.  Image name: `microsoft/aci-helloworld`
7.  OS Type:    `Linux`
8.  Click Next then enter DNS Label `myapp1` (It might fail, then just replace 1 with any other number).
9.  Click Next -> Next -> Create
10. Once container instance is ready, copy DNS name in browser to access application.
