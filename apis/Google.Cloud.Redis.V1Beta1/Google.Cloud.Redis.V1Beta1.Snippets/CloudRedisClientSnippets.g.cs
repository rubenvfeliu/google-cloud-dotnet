// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Redis.V1Beta1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Redis.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedCloudRedisClientSnippets
    {
        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesAsync()
        {
            // Snippet: ListInstancesAsync(string,string,int?,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response =
                cloudRedisClient.ListInstancesAsync(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstances()
        {
            // Snippet: ListInstances(string,string,int?,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response =
                cloudRedisClient.ListInstances(formattedParent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesAsync_RequestObject()
        {
            // Snippet: ListInstancesAsync(ListInstancesRequest,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response =
                cloudRedisClient.ListInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstances_RequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
            };
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response =
                cloudRedisClient.ListInstances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string,CallSettings)
            // Additional: GetInstanceAsync(string,CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]").ToString();
            // Make the request
            Instance response = await cloudRedisClient.GetInstanceAsync(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            string formattedName = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]").ToString();
            // Make the request
            Instance response = cloudRedisClient.GetInstance(formattedName);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync_RequestObject()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest,CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest,CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                Name = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]").ToString(),
            };
            // Make the request
            Instance response = await cloudRedisClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance_RequestObject()
        {
            // Snippet: GetInstance(GetInstanceRequest,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                Name = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]").ToString(),
            };
            // Make the request
            Instance response = cloudRedisClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceAsync()
        {
            // Snippet: CreateInstanceAsync(string,string,Instance,CallSettings)
            // Additional: CreateInstanceAsync(string,string,Instance,CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            string instanceId = "test_instance";
            Instance instance = new Instance
            {
                Tier = Instance.Types.Tier.Basic,
                MemorySizeGb = 1,
            };
            // Make the request
            Operation<Instance, Any> response =
                await cloudRedisClient.CreateInstanceAsync(formattedParent, instanceId, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, Any> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, Any> retrievedResponse =
                await cloudRedisClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstance()
        {
            // Snippet: CreateInstance(string,string,Instance,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            string formattedParent = new LocationName("[PROJECT]", "[LOCATION]").ToString();
            string instanceId = "test_instance";
            Instance instance = new Instance
            {
                Tier = Instance.Types.Tier.Basic,
                MemorySizeGb = 1,
            };
            // Make the request
            Operation<Instance, Any> response =
                cloudRedisClient.CreateInstance(formattedParent, instanceId, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, Any> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, Any> retrievedResponse =
                cloudRedisClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceAsync_RequestObject()
        {
            // Snippet: CreateInstanceAsync(CreateInstanceRequest,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                InstanceId = "test_instance",
                Instance = new Instance
                           {
                               Tier = Instance.Types.Tier.Basic,
                               MemorySizeGb = 1,
                           },
            };
            // Make the request
            Operation<Instance, Any> response =
                await cloudRedisClient.CreateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, Any> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, Any> retrievedResponse =
                await cloudRedisClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstance_RequestObject()
        {
            // Snippet: CreateInstance(CreateInstanceRequest,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                Parent = new LocationName("[PROJECT]", "[LOCATION]").ToString(),
                InstanceId = "test_instance",
                Instance = new Instance
                           {
                               Tier = Instance.Types.Tier.Basic,
                               MemorySizeGb = 1,
                           },
            };
            // Make the request
            Operation<Instance, Any> response =
                cloudRedisClient.CreateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, Any> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, Any> retrievedResponse =
                cloudRedisClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceAsync</summary>
        public async Task UpdateInstanceAsync()
        {
            // Snippet: UpdateInstanceAsync(FieldMask,Instance,CallSettings)
            // Additional: UpdateInstanceAsync(FieldMask,Instance,CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            FieldMask updateMask = new FieldMask
            {
                Paths = {
                            "display_name",
                            "memory_size_gb",
                        },
            };
            Instance instance = new Instance
            {
                DisplayName = "UpdatedDisplayName",
                MemorySizeGb = 4,
            };
            // Make the request
            Operation<Instance, Any> response =
                await cloudRedisClient.UpdateInstanceAsync(updateMask, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, Any> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, Any> retrievedResponse =
                await cloudRedisClient.PollOnceUpdateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstance</summary>
        public void UpdateInstance()
        {
            // Snippet: UpdateInstance(FieldMask,Instance,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            FieldMask updateMask = new FieldMask
            {
                Paths = {
                            "display_name",
                            "memory_size_gb",
                        },
            };
            Instance instance = new Instance
            {
                DisplayName = "UpdatedDisplayName",
                MemorySizeGb = 4,
            };
            // Make the request
            Operation<Instance, Any> response =
                cloudRedisClient.UpdateInstance(updateMask, instance);

            // Poll until the returned long-running operation is complete
            Operation<Instance, Any> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, Any> retrievedResponse =
                cloudRedisClient.PollOnceUpdateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceAsync</summary>
        public async Task UpdateInstanceAsync_RequestObject()
        {
            // Snippet: UpdateInstanceAsync(UpdateInstanceRequest,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                UpdateMask = new FieldMask
                             {
                                 Paths = {
                                             "display_name",
                                             "memory_size_gb",
                                         },
                             },
                Instance = new Instance
                           {
                               DisplayName = "UpdatedDisplayName",
                               MemorySizeGb = 4,
                           },
            };
            // Make the request
            Operation<Instance, Any> response =
                await cloudRedisClient.UpdateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, Any> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, Any> retrievedResponse =
                await cloudRedisClient.PollOnceUpdateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstance</summary>
        public void UpdateInstance_RequestObject()
        {
            // Snippet: UpdateInstance(UpdateInstanceRequest,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                UpdateMask = new FieldMask
                             {
                                 Paths = {
                                             "display_name",
                                             "memory_size_gb",
                                         },
                             },
                Instance = new Instance
                           {
                               DisplayName = "UpdatedDisplayName",
                               MemorySizeGb = 4,
                           },
            };
            // Make the request
            Operation<Instance, Any> response =
                cloudRedisClient.UpdateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, Any> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, Any> retrievedResponse =
                cloudRedisClient.PollOnceUpdateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceAsync()
        {
            // Snippet: DeleteInstanceAsync(string,CallSettings)
            // Additional: DeleteInstanceAsync(string,CancellationToken)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]").ToString();
            // Make the request
            Operation<Empty, Any> response =
                await cloudRedisClient.DeleteInstanceAsync(formattedName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Any> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Any> retrievedResponse =
                await cloudRedisClient.PollOnceDeleteInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstance()
        {
            // Snippet: DeleteInstance(string,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            string formattedName = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]").ToString();
            // Make the request
            Operation<Empty, Any> response =
                cloudRedisClient.DeleteInstance(formattedName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Any> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Any> retrievedResponse =
                cloudRedisClient.PollOnceDeleteInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceAsync_RequestObject()
        {
            // Snippet: DeleteInstanceAsync(DeleteInstanceRequest,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = await CloudRedisClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                Name = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]").ToString(),
            };
            // Make the request
            Operation<Empty, Any> response =
                await cloudRedisClient.DeleteInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Any> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Any> retrievedResponse =
                await cloudRedisClient.PollOnceDeleteInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstance_RequestObject()
        {
            // Snippet: DeleteInstance(DeleteInstanceRequest,CallSettings)
            // Create client
            CloudRedisClient cloudRedisClient = CloudRedisClient.Create();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                Name = new InstanceName("[PROJECT]", "[LOCATION]", "[INSTANCE]").ToString(),
            };
            // Make the request
            Operation<Empty, Any> response =
                cloudRedisClient.DeleteInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Any> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Any> retrievedResponse =
                cloudRedisClient.PollOnceDeleteInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

    }
}
