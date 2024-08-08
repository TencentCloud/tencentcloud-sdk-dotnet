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

namespace TencentCloud.Tke.V20220501
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tke.V20220501.Models;

   public class TkeClient : AbstractClient{

       private const string endpoint = "tke.tencentcloudapi.com";
       private const string version = "2022-05-01";
       private const string sdkVersion = "SDK_NET_3.0.1065";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TkeClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TkeClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建 TKE 节点池
        /// </summary>
        /// <param name="req"><see cref="CreateNodePoolRequest"/></param>
        /// <returns><see cref="CreateNodePoolResponse"/></returns>
        public Task<CreateNodePoolResponse> CreateNodePool(CreateNodePoolRequest req)
        {
            return InternalRequestAsync<CreateNodePoolResponse>(req, "CreateNodePool");
        }

        /// <summary>
        /// 创建 TKE 节点池
        /// </summary>
        /// <param name="req"><see cref="CreateNodePoolRequest"/></param>
        /// <returns><see cref="CreateNodePoolResponse"/></returns>
        public CreateNodePoolResponse CreateNodePoolSync(CreateNodePoolRequest req)
        {
            return InternalRequestAsync<CreateNodePoolResponse>(req, "CreateNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除 TKE 节点池
        /// </summary>
        /// <param name="req"><see cref="DeleteNodePoolRequest"/></param>
        /// <returns><see cref="DeleteNodePoolResponse"/></returns>
        public Task<DeleteNodePoolResponse> DeleteNodePool(DeleteNodePoolRequest req)
        {
            return InternalRequestAsync<DeleteNodePoolResponse>(req, "DeleteNodePool");
        }

        /// <summary>
        /// 删除 TKE 节点池
        /// </summary>
        /// <param name="req"><see cref="DeleteNodePoolRequest"/></param>
        /// <returns><see cref="DeleteNodePoolResponse"/></returns>
        public DeleteNodePoolResponse DeleteNodePoolSync(DeleteNodePoolRequest req)
        {
            return InternalRequestAsync<DeleteNodePoolResponse>(req, "DeleteNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询集群下节点实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public Task<DescribeClusterInstancesResponse> DescribeClusterInstances(DescribeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstancesResponse>(req, "DescribeClusterInstances");
        }

        /// <summary>
        /// 查询集群下节点实例信息
        /// </summary>
        /// <param name="req"><see cref="DescribeClusterInstancesRequest"/></param>
        /// <returns><see cref="DescribeClusterInstancesResponse"/></returns>
        public DescribeClusterInstancesResponse DescribeClusterInstancesSync(DescribeClusterInstancesRequest req)
        {
            return InternalRequestAsync<DescribeClusterInstancesResponse>(req, "DescribeClusterInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询 TKE 节点池列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeNodePoolsResponse"/></returns>
        public Task<DescribeNodePoolsResponse> DescribeNodePools(DescribeNodePoolsRequest req)
        {
            return InternalRequestAsync<DescribeNodePoolsResponse>(req, "DescribeNodePools");
        }

        /// <summary>
        /// 查询 TKE 节点池列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodePoolsRequest"/></param>
        /// <returns><see cref="DescribeNodePoolsResponse"/></returns>
        public DescribeNodePoolsResponse DescribeNodePoolsSync(DescribeNodePoolsRequest req)
        {
            return InternalRequestAsync<DescribeNodePoolsResponse>(req, "DescribeNodePools")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 更新 TKE 节点池
        /// </summary>
        /// <param name="req"><see cref="ModifyNodePoolRequest"/></param>
        /// <returns><see cref="ModifyNodePoolResponse"/></returns>
        public Task<ModifyNodePoolResponse> ModifyNodePool(ModifyNodePoolRequest req)
        {
            return InternalRequestAsync<ModifyNodePoolResponse>(req, "ModifyNodePool");
        }

        /// <summary>
        /// 更新 TKE 节点池
        /// </summary>
        /// <param name="req"><see cref="ModifyNodePoolRequest"/></param>
        /// <returns><see cref="ModifyNodePoolResponse"/></returns>
        public ModifyNodePoolResponse ModifyNodePoolSync(ModifyNodePoolRequest req)
        {
            return InternalRequestAsync<ModifyNodePoolResponse>(req, "ModifyNodePool")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
