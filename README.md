# dapr-pubsub

In this repo, you can find the implementation of pub-sub by using dapr. Please follow the intructions

1. After clone, first run the subscriber 
- cd sub
- dapr run -a sub -p 50000 -d ..\components\ -- dotnet run --urls http://*:50000

2. Then run the publisher 
- cd pub
- dapr run -a pub -H 3500 -d ..\components\ -- dotnet run

You will see that the publisher will send messages in a loop and subscriber will receive the message one by one and logging them.



Assuming that you already have Dapr at your local system
https://docs.dapr.io/getting-started/
