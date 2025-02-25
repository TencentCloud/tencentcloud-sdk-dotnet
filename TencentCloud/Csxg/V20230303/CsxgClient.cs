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

namespace TencentCloud.Csxg.V20230303
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Csxg.V20230303.Models;

   public class CsxgClient : AbstractClient{

       private const string endpoint = "csxg.tencentcloudapi.com";
       private const string version = "2023-03-03";
       private const string sdkVersion = "SDK_NET_3.0.1187";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CsxgClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CsxgClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 创建5G入云服务接口
        /// </summary>
        /// <param name="req"><see cref="Create5GInstanceRequest"/></param>
        /// <returns><see cref="Create5GInstanceResponse"/></returns>
        public Task<Create5GInstanceResponse> Create5GInstance(Create5GInstanceRequest req)
        {
            return InternalRequestAsync<Create5GInstanceResponse>(req, "Create5GInstance");
        }

        /// <summary>
        /// 创建5G入云服务接口
        /// </summary>
        /// <param name="req"><see cref="Create5GInstanceRequest"/></param>
        /// <returns><see cref="Create5GInstanceResponse"/></returns>
        public Create5GInstanceResponse Create5GInstanceSync(Create5GInstanceRequest req)
        {
            return InternalRequestAsync<Create5GInstanceResponse>(req, "Create5GInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 删除5G入云服务
        /// </summary>
        /// <param name="req"><see cref="Delete5GInstanceRequest"/></param>
        /// <returns><see cref="Delete5GInstanceResponse"/></returns>
        public Task<Delete5GInstanceResponse> Delete5GInstance(Delete5GInstanceRequest req)
        {
            return InternalRequestAsync<Delete5GInstanceResponse>(req, "Delete5GInstance");
        }

        /// <summary>
        /// 删除5G入云服务
        /// </summary>
        /// <param name="req"><see cref="Delete5GInstanceRequest"/></param>
        /// <returns><see cref="Delete5GInstanceResponse"/></returns>
        public Delete5GInstanceResponse Delete5GInstanceSync(Delete5GInstanceRequest req)
        {
            return InternalRequestAsync<Delete5GInstanceResponse>(req, "Delete5GInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询APN信息
        /// </summary>
        /// <param name="req"><see cref="Describe5GAPNsRequest"/></param>
        /// <returns><see cref="Describe5GAPNsResponse"/></returns>
        public Task<Describe5GAPNsResponse> Describe5GAPNs(Describe5GAPNsRequest req)
        {
            return InternalRequestAsync<Describe5GAPNsResponse>(req, "Describe5GAPNs");
        }

        /// <summary>
        /// 查询APN信息
        /// </summary>
        /// <param name="req"><see cref="Describe5GAPNsRequest"/></param>
        /// <returns><see cref="Describe5GAPNsResponse"/></returns>
        public Describe5GAPNsResponse Describe5GAPNsSync(Describe5GAPNsRequest req)
        {
            return InternalRequestAsync<Describe5GAPNsResponse>(req, "Describe5GAPNs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询5G入云服务
        /// </summary>
        /// <param name="req"><see cref="Describe5GInstancesRequest"/></param>
        /// <returns><see cref="Describe5GInstancesResponse"/></returns>
        public Task<Describe5GInstancesResponse> Describe5GInstances(Describe5GInstancesRequest req)
        {
            return InternalRequestAsync<Describe5GInstancesResponse>(req, "Describe5GInstances");
        }

        /// <summary>
        /// 查询5G入云服务
        /// </summary>
        /// <param name="req"><see cref="Describe5GInstancesRequest"/></param>
        /// <returns><see cref="Describe5GInstancesResponse"/></returns>
        public Describe5GInstancesResponse Describe5GInstancesSync(Describe5GInstancesRequest req)
        {
            return InternalRequestAsync<Describe5GInstancesResponse>(req, "Describe5GInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改5G入云服务
        /// </summary>
        /// <param name="req"><see cref="Modify5GInstanceAttributeRequest"/></param>
        /// <returns><see cref="Modify5GInstanceAttributeResponse"/></returns>
        public Task<Modify5GInstanceAttributeResponse> Modify5GInstanceAttribute(Modify5GInstanceAttributeRequest req)
        {
            return InternalRequestAsync<Modify5GInstanceAttributeResponse>(req, "Modify5GInstanceAttribute");
        }

        /// <summary>
        /// 修改5G入云服务
        /// </summary>
        /// <param name="req"><see cref="Modify5GInstanceAttributeRequest"/></param>
        /// <returns><see cref="Modify5GInstanceAttributeResponse"/></returns>
        public Modify5GInstanceAttributeResponse Modify5GInstanceAttributeSync(Modify5GInstanceAttributeRequest req)
        {
            return InternalRequestAsync<Modify5GInstanceAttributeResponse>(req, "Modify5GInstanceAttribute")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
