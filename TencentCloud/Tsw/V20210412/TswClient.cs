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

namespace TencentCloud.Tsw.V20210412
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tsw.V20210412.Models;

   public class TswClient : AbstractClient{

       private const string endpoint = "tsw.tencentcloudapi.com";
       private const string version = "2021-04-12";
       private const string sdkVersion = "SDK_NET_3.0.1110";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TswClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TswClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 获取告警对象-组件告警
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentAlertObjectRequest"/></param>
        /// <returns><see cref="DescribeComponentAlertObjectResponse"/></returns>
        public Task<DescribeComponentAlertObjectResponse> DescribeComponentAlertObject(DescribeComponentAlertObjectRequest req)
        {
            return InternalRequestAsync<DescribeComponentAlertObjectResponse>(req, "DescribeComponentAlertObject");
        }

        /// <summary>
        /// 获取告警对象-组件告警
        /// </summary>
        /// <param name="req"><see cref="DescribeComponentAlertObjectRequest"/></param>
        /// <returns><see cref="DescribeComponentAlertObjectResponse"/></returns>
        public DescribeComponentAlertObjectResponse DescribeComponentAlertObjectSync(DescribeComponentAlertObjectRequest req)
        {
            return InternalRequestAsync<DescribeComponentAlertObjectResponse>(req, "DescribeComponentAlertObject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取告警对象-服务告警表
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceAlertObjectRequest"/></param>
        /// <returns><see cref="DescribeServiceAlertObjectResponse"/></returns>
        public Task<DescribeServiceAlertObjectResponse> DescribeServiceAlertObject(DescribeServiceAlertObjectRequest req)
        {
            return InternalRequestAsync<DescribeServiceAlertObjectResponse>(req, "DescribeServiceAlertObject");
        }

        /// <summary>
        /// 获取告警对象-服务告警表
        /// </summary>
        /// <param name="req"><see cref="DescribeServiceAlertObjectRequest"/></param>
        /// <returns><see cref="DescribeServiceAlertObjectResponse"/></returns>
        public DescribeServiceAlertObjectResponse DescribeServiceAlertObjectSync(DescribeServiceAlertObjectRequest req)
        {
            return InternalRequestAsync<DescribeServiceAlertObjectResponse>(req, "DescribeServiceAlertObject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询token
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenRequest"/></param>
        /// <returns><see cref="DescribeTokenResponse"/></returns>
        public Task<DescribeTokenResponse> DescribeToken(DescribeTokenRequest req)
        {
            return InternalRequestAsync<DescribeTokenResponse>(req, "DescribeToken");
        }

        /// <summary>
        /// 查询token
        /// </summary>
        /// <param name="req"><see cref="DescribeTokenRequest"/></param>
        /// <returns><see cref="DescribeTokenResponse"/></returns>
        public DescribeTokenResponse DescribeTokenSync(DescribeTokenRequest req)
        {
            return InternalRequestAsync<DescribeTokenResponse>(req, "DescribeToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
