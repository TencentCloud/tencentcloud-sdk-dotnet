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

namespace TencentCloud.Hai.V20230812
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Hai.V20230812.Models;

   public class HaiClient : AbstractClient{

       private const string endpoint = "hai.tencentcloudapi.com";
       private const string version = "2023-08-12";
       private const string sdkVersion = "SDK_NET_3.0.1099";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public HaiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public HaiClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 查询应用
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public Task<DescribeApplicationsResponse> DescribeApplications(DescribeApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsResponse>(req, "DescribeApplications");
        }

        /// <summary>
        /// 查询应用
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public DescribeApplicationsResponse DescribeApplicationsSync(DescribeApplicationsRequest req)
        {
            return InternalRequestAsync<DescribeApplicationsResponse>(req, "DescribeApplications")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例的网络配置及消耗情况
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNetworkStatusRequest"/></param>
        /// <returns><see cref="DescribeInstanceNetworkStatusResponse"/></returns>
        public Task<DescribeInstanceNetworkStatusResponse> DescribeInstanceNetworkStatus(DescribeInstanceNetworkStatusRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNetworkStatusResponse>(req, "DescribeInstanceNetworkStatus");
        }

        /// <summary>
        /// 查询实例的网络配置及消耗情况
        /// </summary>
        /// <param name="req"><see cref="DescribeInstanceNetworkStatusRequest"/></param>
        /// <returns><see cref="DescribeInstanceNetworkStatusResponse"/></returns>
        public DescribeInstanceNetworkStatusResponse DescribeInstanceNetworkStatusSync(DescribeInstanceNetworkStatusRequest req)
        {
            return InternalRequestAsync<DescribeInstanceNetworkStatusResponse>(req, "DescribeInstanceNetworkStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询实例
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances");
        }

        /// <summary>
        /// 查询实例
        /// </summary>
        /// <param name="req"><see cref="DescribeInstancesRequest"/></param>
        /// <returns><see cref="DescribeInstancesResponse"/></returns>
        public DescribeInstancesResponse DescribeInstancesSync(DescribeInstancesRequest req)
        {
            return InternalRequestAsync<DescribeInstancesResponse>(req, "DescribeInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public Task<DescribeRegionsResponse> DescribeRegions(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions");
        }

        /// <summary>
        /// 查询地域列表
        /// </summary>
        /// <param name="req"><see cref="DescribeRegionsRequest"/></param>
        /// <returns><see cref="DescribeRegionsResponse"/></returns>
        public DescribeRegionsResponse DescribeRegionsSync(DescribeRegionsRequest req)
        {
            return InternalRequestAsync<DescribeRegionsResponse>(req, "DescribeRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询场景
        /// </summary>
        /// <param name="req"><see cref="DescribeScenesRequest"/></param>
        /// <returns><see cref="DescribeScenesResponse"/></returns>
        public Task<DescribeScenesResponse> DescribeScenes(DescribeScenesRequest req)
        {
            return InternalRequestAsync<DescribeScenesResponse>(req, "DescribeScenes");
        }

        /// <summary>
        /// 查询场景
        /// </summary>
        /// <param name="req"><see cref="DescribeScenesRequest"/></param>
        /// <returns><see cref="DescribeScenesResponse"/></returns>
        public DescribeScenesResponse DescribeScenesSync(DescribeScenesRequest req)
        {
            return InternalRequestAsync<DescribeScenesResponse>(req, "DescribeScenes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询服务登录配置
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceLoginSettingsRequest"/></param>
        /// <returns><see cref="DescribeServiceLoginSettingsResponse"/></returns>
        public Task<DescribeServiceLoginSettingsResponse> DescribeServiceLoginSettings(DescribeServiceLoginSettingsRequest req)
        {
            return InternalRequestAsync<DescribeServiceLoginSettingsResponse>(req, "DescribeServiceLoginSettings");
        }

        /// <summary>
        /// 查询服务登录配置
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceLoginSettingsRequest"/></param>
        /// <returns><see cref="DescribeServiceLoginSettingsResponse"/></returns>
        public DescribeServiceLoginSettingsResponse DescribeServiceLoginSettingsSync(DescribeServiceLoginSettingsRequest req)
        {
            return InternalRequestAsync<DescribeServiceLoginSettingsResponse>(req, "DescribeServiceLoginSettings")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (InquirePriceRunInstances) 用于实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRunInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRunInstancesResponse"/></returns>
        public Task<InquirePriceRunInstancesResponse> InquirePriceRunInstances(InquirePriceRunInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceRunInstancesResponse>(req, "InquirePriceRunInstances");
        }

        /// <summary>
        /// 本接口 (InquirePriceRunInstances) 用于实例询价。
        /// </summary>
        /// <param name="req"><see cref="InquirePriceRunInstancesRequest"/></param>
        /// <returns><see cref="InquirePriceRunInstancesResponse"/></returns>
        public InquirePriceRunInstancesResponse InquirePriceRunInstancesSync(InquirePriceRunInstancesRequest req)
        {
            return InternalRequestAsync<InquirePriceRunInstancesResponse>(req, "InquirePriceRunInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (RunInstances) 用于创建一个或多个指定配置的实例。
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public Task<RunInstancesResponse> RunInstances(RunInstancesRequest req)
        {
            return InternalRequestAsync<RunInstancesResponse>(req, "RunInstances");
        }

        /// <summary>
        /// 本接口 (RunInstances) 用于创建一个或多个指定配置的实例。
        /// </summary>
        /// <param name="req"><see cref="RunInstancesRequest"/></param>
        /// <returns><see cref="RunInstancesResponse"/></returns>
        public RunInstancesResponse RunInstancesSync(RunInstancesRequest req)
        {
            return InternalRequestAsync<RunInstancesResponse>(req, "RunInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (StartInstance) 用于主动启动实例。
        /// </summary>
        /// <param name="req"><see cref="StartInstanceRequest"/></param>
        /// <returns><see cref="StartInstanceResponse"/></returns>
        public Task<StartInstanceResponse> StartInstance(StartInstanceRequest req)
        {
            return InternalRequestAsync<StartInstanceResponse>(req, "StartInstance");
        }

        /// <summary>
        /// 本接口 (StartInstance) 用于主动启动实例。
        /// </summary>
        /// <param name="req"><see cref="StartInstanceRequest"/></param>
        /// <returns><see cref="StartInstanceResponse"/></returns>
        public StartInstanceResponse StartInstanceSync(StartInstanceRequest req)
        {
            return InternalRequestAsync<StartInstanceResponse>(req, "StartInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (StopInstance) 用于主动关闭实例。
        /// </summary>
        /// <param name="req"><see cref="StopInstanceRequest"/></param>
        /// <returns><see cref="StopInstanceResponse"/></returns>
        public Task<StopInstanceResponse> StopInstance(StopInstanceRequest req)
        {
            return InternalRequestAsync<StopInstanceResponse>(req, "StopInstance");
        }

        /// <summary>
        /// 本接口 (StopInstance) 用于主动关闭实例。
        /// </summary>
        /// <param name="req"><see cref="StopInstanceRequest"/></param>
        /// <returns><see cref="StopInstanceResponse"/></returns>
        public StopInstanceResponse StopInstanceSync(StopInstanceRequest req)
        {
            return InternalRequestAsync<StopInstanceResponse>(req, "StopInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (TerminateInstances) 用于主动退还实例。
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public Task<TerminateInstancesResponse> TerminateInstances(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances");
        }

        /// <summary>
        /// 本接口 (TerminateInstances) 用于主动退还实例。
        /// </summary>
        /// <param name="req"><see cref="TerminateInstancesRequest"/></param>
        /// <returns><see cref="TerminateInstancesResponse"/></returns>
        public TerminateInstancesResponse TerminateInstancesSync(TerminateInstancesRequest req)
        {
            return InternalRequestAsync<TerminateInstancesResponse>(req, "TerminateInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
