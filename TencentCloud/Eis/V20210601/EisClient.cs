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

namespace TencentCloud.Eis.V20210601
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Eis.V20210601.Models;

   public class EisClient : AbstractClient{

       private const string endpoint = "eis.tencentcloudapi.com";
       private const string version = "2021-06-01";
       private const string sdkVersion = "SDK_NET_3.0.1168";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EisClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EisClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 获取运行时详情
        /// </summary>
        /// <param name="req"><see cref="GetRuntimeMCRequest"/></param>
        /// <returns><see cref="GetRuntimeMCResponse"/></returns>
        public Task<GetRuntimeMCResponse> GetRuntimeMC(GetRuntimeMCRequest req)
        {
            return InternalRequestAsync<GetRuntimeMCResponse>(req, "GetRuntimeMC");
        }

        /// <summary>
        /// 获取运行时详情
        /// </summary>
        /// <param name="req"><see cref="GetRuntimeMCRequest"/></param>
        /// <returns><see cref="GetRuntimeMCResponse"/></returns>
        public GetRuntimeMCResponse GetRuntimeMCSync(GetRuntimeMCRequest req)
        {
            return InternalRequestAsync<GetRuntimeMCResponse>(req, "GetRuntimeMC")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取运行时资源监控详情，cpu，memory，bandwidth
        /// </summary>
        /// <param name="req"><see cref="GetRuntimeResourceMonitorMetricMCRequest"/></param>
        /// <returns><see cref="GetRuntimeResourceMonitorMetricMCResponse"/></returns>
        public Task<GetRuntimeResourceMonitorMetricMCResponse> GetRuntimeResourceMonitorMetricMC(GetRuntimeResourceMonitorMetricMCRequest req)
        {
            return InternalRequestAsync<GetRuntimeResourceMonitorMetricMCResponse>(req, "GetRuntimeResourceMonitorMetricMC");
        }

        /// <summary>
        /// 获取运行时资源监控详情，cpu，memory，bandwidth
        /// </summary>
        /// <param name="req"><see cref="GetRuntimeResourceMonitorMetricMCRequest"/></param>
        /// <returns><see cref="GetRuntimeResourceMonitorMetricMCResponse"/></returns>
        public GetRuntimeResourceMonitorMetricMCResponse GetRuntimeResourceMonitorMetricMCSync(GetRuntimeResourceMonitorMetricMCRequest req)
        {
            return InternalRequestAsync<GetRuntimeResourceMonitorMetricMCResponse>(req, "GetRuntimeResourceMonitorMetricMC")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回用户可用的运行时列表，发布应用时返回的运行时环境，仅shared和private运行时，无sandbox运行时，并且只有running/scaling状态的
        /// </summary>
        /// <param name="req"><see cref="ListDeployableRuntimesMCRequest"/></param>
        /// <returns><see cref="ListDeployableRuntimesMCResponse"/></returns>
        public Task<ListDeployableRuntimesMCResponse> ListDeployableRuntimesMC(ListDeployableRuntimesMCRequest req)
        {
            return InternalRequestAsync<ListDeployableRuntimesMCResponse>(req, "ListDeployableRuntimesMC");
        }

        /// <summary>
        /// 返回用户可用的运行时列表，发布应用时返回的运行时环境，仅shared和private运行时，无sandbox运行时，并且只有running/scaling状态的
        /// </summary>
        /// <param name="req"><see cref="ListDeployableRuntimesMCRequest"/></param>
        /// <returns><see cref="ListDeployableRuntimesMCResponse"/></returns>
        public ListDeployableRuntimesMCResponse ListDeployableRuntimesMCSync(ListDeployableRuntimesMCRequest req)
        {
            return InternalRequestAsync<ListDeployableRuntimesMCResponse>(req, "ListDeployableRuntimesMC")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取运行时部署的应用实例列表
        /// </summary>
        /// <param name="req"><see cref="ListRuntimeDeployedInstancesMCRequest"/></param>
        /// <returns><see cref="ListRuntimeDeployedInstancesMCResponse"/></returns>
        public Task<ListRuntimeDeployedInstancesMCResponse> ListRuntimeDeployedInstancesMC(ListRuntimeDeployedInstancesMCRequest req)
        {
            return InternalRequestAsync<ListRuntimeDeployedInstancesMCResponse>(req, "ListRuntimeDeployedInstancesMC");
        }

        /// <summary>
        /// 获取运行时部署的应用实例列表
        /// </summary>
        /// <param name="req"><see cref="ListRuntimeDeployedInstancesMCRequest"/></param>
        /// <returns><see cref="ListRuntimeDeployedInstancesMCResponse"/></returns>
        public ListRuntimeDeployedInstancesMCResponse ListRuntimeDeployedInstancesMCSync(ListRuntimeDeployedInstancesMCRequest req)
        {
            return InternalRequestAsync<ListRuntimeDeployedInstancesMCResponse>(req, "ListRuntimeDeployedInstancesMC")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 返回用户的运行时列表，运行时管理主页使用，包含沙箱、共享运行时及独立运行时环境，不包含已经删除的运行时
        /// </summary>
        /// <param name="req"><see cref="ListRuntimesMCRequest"/></param>
        /// <returns><see cref="ListRuntimesMCResponse"/></returns>
        public Task<ListRuntimesMCResponse> ListRuntimesMC(ListRuntimesMCRequest req)
        {
            return InternalRequestAsync<ListRuntimesMCResponse>(req, "ListRuntimesMC");
        }

        /// <summary>
        /// 返回用户的运行时列表，运行时管理主页使用，包含沙箱、共享运行时及独立运行时环境，不包含已经删除的运行时
        /// </summary>
        /// <param name="req"><see cref="ListRuntimesMCRequest"/></param>
        /// <returns><see cref="ListRuntimesMCResponse"/></returns>
        public ListRuntimesMCResponse ListRuntimesMCSync(ListRuntimesMCRequest req)
        {
            return InternalRequestAsync<ListRuntimesMCResponse>(req, "ListRuntimesMC")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
