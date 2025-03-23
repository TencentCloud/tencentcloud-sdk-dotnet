/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Thpc.V20211109
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Thpc.V20211109.Models;

   public class ThpcClient : AbstractClient{

       private const string endpoint = "thpc.tencentcloudapi.com";
       private const string version = "2021-11-09";
       private const string sdkVersion = "SDK_NET_3.0.1206";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public ThpcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public ThpcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口(BindAutoScalingGroup)用于为集群队列绑定弹性伸缩组
        /// </summary>
        /// <param name="req"><see cref="BindAutoScalingGroupRequest"/></param>
        /// <returns><see cref="BindAutoScalingGroupResponse"/></returns>
        public Task<BindAutoScalingGroupResponse> BindAutoScalingGroup(BindAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<BindAutoScalingGroupResponse>(req, "BindAutoScalingGroup");
        }

        /// <summary>
        /// 本接口(BindAutoScalingGroup)用于为集群队列绑定弹性伸缩组
        /// </summary>
        /// <param name="req"><see cref="BindAutoScalingGroupRequest"/></param>
        /// <returns><see cref="BindAutoScalingGroupResponse"/></returns>
        public BindAutoScalingGroupResponse BindAutoScalingGroupSync(BindAutoScalingGroupRequest req)
        {
            return InternalRequestAsync<BindAutoScalingGroupResponse>(req, "BindAutoScalingGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (CreateCluster) 用于创建并启动集群。
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public Task<CreateClusterResponse> CreateCluster(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster");
        }

        /// <summary>
        /// 本接口 (CreateCluster) 用于创建并启动集群。
        /// </summary>
        /// <param name="req"><see cref="CreateClusterRequest"/></param>
        /// <returns><see cref="CreateClusterResponse"/></returns>
        public CreateClusterResponse CreateClusterSync(CreateClusterRequest req)
        {
            return InternalRequestAsync<CreateClusterResponse>(req, "CreateCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DeleteCluster）用于删除一个指定的集群。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public Task<DeleteClusterResponse> DeleteCluster(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster");
        }

        /// <summary>
        /// 本接口（DeleteCluster）用于删除一个指定的集群。
        /// </summary>
        /// <param name="req"><see cref="DeleteClusterRequest"/></param>
        /// <returns><see cref="DeleteClusterResponse"/></returns>
        public DeleteClusterResponse DeleteClusterSync(DeleteClusterRequest req)
        {
            return InternalRequestAsync<DeleteClusterResponse>(req, "DeleteCluster")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口（DescribeClusters）用于查询集群列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public Task<DescribeClustersResponse> DescribeClusters(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters");
        }

        /// <summary>
        /// 本接口（DescribeClusters）用于查询集群列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeClustersRequest"/></param>
        /// <returns><see cref="DescribeClustersResponse"/></returns>
        public DescribeClustersResponse DescribeClustersSync(DescribeClustersRequest req)
        {
            return InternalRequestAsync<DescribeClustersResponse>(req, "DescribeClusters")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
