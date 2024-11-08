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

namespace TencentCloud.Rkp.V20191209
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Rkp.V20191209.Models;

   public class RkpClient : AbstractClient{

       private const string endpoint = "rkp.tencentcloudapi.com";
       private const string version = "2019-12-09";
       private const string sdkVersion = "SDK_NET_3.0.1120";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public RkpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public RkpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 产品侧确认风险探针已停售，无收入，并且已经停服。目前服务使用自建redis，不符合规范需要整改下线。
        /// 
        /// 根据DevicceToken查询OpenID。
        /// </summary>
        /// <param name="req"><see cref="GetOpenIdRequest"/></param>
        /// <returns><see cref="GetOpenIdResponse"/></returns>
        public Task<GetOpenIdResponse> GetOpenId(GetOpenIdRequest req)
        {
            return InternalRequestAsync<GetOpenIdResponse>(req, "GetOpenId");
        }

        /// <summary>
        /// 产品侧确认风险探针已停售，无收入，并且已经停服。目前服务使用自建redis，不符合规范需要整改下线。
        /// 
        /// 根据DevicceToken查询OpenID。
        /// </summary>
        /// <param name="req"><see cref="GetOpenIdRequest"/></param>
        /// <returns><see cref="GetOpenIdResponse"/></returns>
        public GetOpenIdResponse GetOpenIdSync(GetOpenIdRequest req)
        {
            return InternalRequestAsync<GetOpenIdResponse>(req, "GetOpenId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 产品侧确认风险探针已停售，无收入，并且已经停服。目前服务使用自建redis，不符合规范需要整改下线。
        /// 
        /// 获取token接口。
        /// </summary>
        /// <param name="req"><see cref="GetTokenRequest"/></param>
        /// <returns><see cref="GetTokenResponse"/></returns>
        public Task<GetTokenResponse> GetToken(GetTokenRequest req)
        {
            return InternalRequestAsync<GetTokenResponse>(req, "GetToken");
        }

        /// <summary>
        /// 产品侧确认风险探针已停售，无收入，并且已经停服。目前服务使用自建redis，不符合规范需要整改下线。
        /// 
        /// 获取token接口。
        /// </summary>
        /// <param name="req"><see cref="GetTokenRequest"/></param>
        /// <returns><see cref="GetTokenResponse"/></returns>
        public GetTokenResponse GetTokenSync(GetTokenRequest req)
        {
            return InternalRequestAsync<GetTokenResponse>(req, "GetToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 产品侧确认风险探针已停售，无收入，并且已经停服。目前服务使用自建redis，不符合规范需要整改下线。
        /// 
        /// 腾讯天御设备风险查询接口，输入由客户应用自主采集的设备信息， 通过腾讯大数据风控能力，可以准确根据输入设备信息，还原设备库中的设备ID，并且识别设备的风险，解决客户业务过程中的设备风险，降低企业损失。
        /// </summary>
        /// <param name="req"><see cref="QueryDevAndRiskRequest"/></param>
        /// <returns><see cref="QueryDevAndRiskResponse"/></returns>
        public Task<QueryDevAndRiskResponse> QueryDevAndRisk(QueryDevAndRiskRequest req)
        {
            return InternalRequestAsync<QueryDevAndRiskResponse>(req, "QueryDevAndRisk");
        }

        /// <summary>
        /// 产品侧确认风险探针已停售，无收入，并且已经停服。目前服务使用自建redis，不符合规范需要整改下线。
        /// 
        /// 腾讯天御设备风险查询接口，输入由客户应用自主采集的设备信息， 通过腾讯大数据风控能力，可以准确根据输入设备信息，还原设备库中的设备ID，并且识别设备的风险，解决客户业务过程中的设备风险，降低企业损失。
        /// </summary>
        /// <param name="req"><see cref="QueryDevAndRiskRequest"/></param>
        /// <returns><see cref="QueryDevAndRiskResponse"/></returns>
        public QueryDevAndRiskResponse QueryDevAndRiskSync(QueryDevAndRiskRequest req)
        {
            return InternalRequestAsync<QueryDevAndRiskResponse>(req, "QueryDevAndRisk")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
