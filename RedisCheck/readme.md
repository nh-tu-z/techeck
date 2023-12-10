# Redis Feature Check

## How to run this project sample

1. Enable WSL (if Windows) - [reference](https://learn.microsoft.com/en-us/windows/wsl/install)

2. Install Redis through the guide of [this docs](https://redis.io/docs/getting-started/installation/install-redis-on-windows/)

## Docker set up

T.B.D

## Monitor metrics of Redis Server

T.B.D

## Feature check

### 1. Pub/Sub

- Simple hands-on in ```PubSubService.cs```

### 2. redis-cli

- Monitor redis - reference https://sematext.com/blog/redis-metrics/

- Monitor the memory utilization:
```
info memory
```

- Get server info:
```
info server
```

- Work with Azure Redis Cache (ARC)
  + `command help`: display some way to play around with ARC
  + `<command> help`: display how to use <command> correctly

Reference to read the command detail - https://redis.io/docs/reference/command-tips/

> [!NOTE]
> REFERENCES:
> 1. MITM attacks - T.B.D
> 2. Use the Redis command-line tool with Azure Cache for Redis - https://learn.microsoft.com/en-us/azure/azure-cache-for-redis/cache-how-to-redis-cli-tool

### 3. Diagnosing latency issues

Reference: https://redis.io/docs/management/optimization/latency/

### 4. Redis security

Reference 1: Redis security feature - https://redis.io/docs/management/security/

Reference 2: Section Connect to your production Redis with TLS in https://redis.io/docs/clients/dotnet/

### 5. Streams
There are 4 basic commands (https://redis.io/docs/data-types/streams/#basic-commands):
- XADD/XREAD/XRANGE/XLEN
- Advanced commands for Redis streams could be found in https://redis.io/commands/?group=stream 
- Important concept to know about stream: Entry IDs, Consumer Group
## REFERENCE

1. High level Redis architecture of famous company - https://redis.io/docs/about/users/
1. 

# Memcached
T.B.D
