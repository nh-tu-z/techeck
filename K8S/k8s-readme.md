## Kubernetes hands-on

1. Ssh to a pod 

```kubectl exec --stdin --tty asset-discovery-rorw2ouz-56fb65c8d6-ddqnj --namespace=cranium-collector -- /bin/bash```

2. Investigate the log of a pod

```kubectl logs asset-discovery-rorw2ouz-56fb65c8d6-ddqnj --namespace=cranium-collector```

Note: 2 above cmds, if you do not specify the namespace, it will run into an error not found

Log with tail

```kubectl logs asset-discovery-qrzjbiyt-c47bb8f56-4ccdq --namespace=cranium-collector --follow```

Log with pattern in powershell

```kubectl logs cranium-collector-d4f9c74-87v9v --namespace=cranium-collector --follow | Select-String "Collector WebSocket MessageTypeId:"```

--follow: Continuously stream the logs as they are generated.
--tail: Specify the number of lines of log output to display.
--since: Only show log output generated within a certain duration.
--timestamps: Add timestamps to the log output.

Continuously log into a file
```logs -f asset-discovery-azml76dfgton-8677dd759c-d6pkm --namespace=cranium-collector > .\Desktop\log-ad.txt```
or just log a snapshot
```kubectl logs asset-discovery-azml76dfgton-8677dd759c-d6pkm --namespace=cranium-collector > .\Desktop\log-ad.txt```

- TODO 
k8s_dotnet_request_total - Counter of request, broken down by HTTP Method
k8s_dotnet_response_code_total - Counter of responses, broken down by HTTP Method and response code
k8s_request_latency_seconds - Latency histograms broken down by method, api group, api version and resource kind


-- TODO - check 
kubectl drain

3. AWS EKS
- Access key: AKIASZ647C2Z7BSCGPA7
- Secret Access key: 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

- Install aws cli
- Should remove configuration in .aws config before using ```aws configure``` to prevent conflict

- ```aws eks update-kubeconfig --region us-east-1 --name aws-eks-craniumai-collector-dev``` to update cluster in k8s config

4. If we have multi cluster in local machine, we can check the current context using
```kubectl config current-context```

what is different between context and cluster?
https://stackoverflow.com/questions/56299440/kubectl-context-vs-cluster#:~:text=This%20cluster%20is%20the%20physical,a%20user%2C%20and%20a%20namespace.



4. Auto Scale Pod

5. Auto Scale Node

6. Default namespace of a k8s cluster
- There are 4 namespaces by default https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/
- Deployment autogen in ```kube-system``` namespace (coredns, coredns-autoscaler, konectivity-agent, metrics-server, ama-logs-rs, auzre-policy, azure-pilicy-webhook, microsoft-defender-collector-misc)
+ ```coredns```: Is a dns server plugin of k8s
  > References: https://kubernetes.io/docs/tasks/administer-cluster/coredns/

+ ```coredns-autoscaler```

+ ```konectivity-agent```: The Konnectivity service provides a TCP level proxy for the control plane to cluster communication
  > Reference: https://kubernetes.io/docs/tasks/extend-kubernetes/setup-konnectivity/

+ ```metrics-server```: mainly use for autoscaling
  > Reference: https://github.com/kubernetes-sigs/metrics-server

+ ```ama-logs-rs```: Looks like used for troubleshoot container
  > Reference: https://github.com/MicrosoftDocs/azure-docs/blob/main/articles/azure-monitor/containers/container-insights-troubleshoot.md

+ ```azure-policy```: 
  > Reference: https://learn.microsoft.com/en-us/azure/governance/policy/concepts/policy-for-kubernetes

+ ```azure-pilicy-webhook```

+ ```microsoft-defender-collector-misc```

- There is an namespace named ```gatekeeper-system```. what is it function?

7. Helm section


8. FAQ

- How to increase resources (cpu/ram) in AKS? I observe that it can be increase manually, on the fly mayby because the deployment does not need to delete, just restart the pod

9. Downgrade version of pod
a. Set image for container

10. Check rollout status of deployment
+ ```kubectl rollout status deployment/<deployment-name>```
