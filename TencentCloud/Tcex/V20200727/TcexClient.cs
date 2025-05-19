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

namespace TencentCloud.Tcex.V20200727
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tcex.V20200727.Models;

   public class TcexClient : AbstractClient{

       private const string endpoint = "tcex.tencentcloudapi.com";
       private const string version = "2020-07-27";
       private const string sdkVersion = "SDK_NET_3.0.1243";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TcexClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TcexClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 产品控制台已经下线
        /// 
        /// 获取服务调用结果。和InvokeService接口配置合适，其InvokeId参数为InvokeService接口返回的RequestId。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationResultRequest"/></param>
        /// <returns><see cref="DescribeInvocationResultResponse"/></returns>
        public Task<DescribeInvocationResultResponse> DescribeInvocationResult(DescribeInvocationResultRequest req)
        {
            return InternalRequestAsync<DescribeInvocationResultResponse>(req, "DescribeInvocationResult");
        }

        /// <summary>
        /// 产品控制台已经下线
        /// 
        /// 获取服务调用结果。和InvokeService接口配置合适，其InvokeId参数为InvokeService接口返回的RequestId。
        /// </summary>
        /// <param name="req"><see cref="DescribeInvocationResultRequest"/></param>
        /// <returns><see cref="DescribeInvocationResultResponse"/></returns>
        public DescribeInvocationResultResponse DescribeInvocationResultSync(DescribeInvocationResultRequest req)
        {
            return InternalRequestAsync<DescribeInvocationResultResponse>(req, "DescribeInvocationResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 产品控制台已经下线
        /// 
        /// 通过传入文档url，测试服务算法。此接口需要和DescribeInvocationResult接口配置使用，该接口使用InvokeService返回的RequestId作为InvokeId参数，用于查询调用结果。
        /// </summary>
        /// <param name="req"><see cref="InvokeServiceRequest"/></param>
        /// <returns><see cref="InvokeServiceResponse"/></returns>
        public Task<InvokeServiceResponse> InvokeService(InvokeServiceRequest req)
        {
            return InternalRequestAsync<InvokeServiceResponse>(req, "InvokeService");
        }

        /// <summary>
        /// 产品控制台已经下线
        /// 
        /// 通过传入文档url，测试服务算法。此接口需要和DescribeInvocationResult接口配置使用，该接口使用InvokeService返回的RequestId作为InvokeId参数，用于查询调用结果。
        /// </summary>
        /// <param name="req"><see cref="InvokeServiceRequest"/></param>
        /// <returns><see cref="InvokeServiceResponse"/></returns>
        public InvokeServiceResponse InvokeServiceSync(InvokeServiceRequest req)
        {
            return InternalRequestAsync<InvokeServiceResponse>(req, "InvokeService")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
