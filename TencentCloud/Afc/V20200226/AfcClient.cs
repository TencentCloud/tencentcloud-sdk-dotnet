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

namespace TencentCloud.Afc.V20200226
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Afc.V20200226.Models;

   public class AfcClient : AbstractClient{

       private const string endpoint = "afc.tencentcloudapi.com";
       private const string version = "2020-02-26";
       private const string sdkVersion = "SDK_NET_3.0.962";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AfcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AfcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 反欺诈VIP评分接口
        /// </summary>
        /// <param name="req"><see cref="GetAntiFraudVipRequest"/></param>
        /// <returns><see cref="GetAntiFraudVipResponse"/></returns>
        public Task<GetAntiFraudVipResponse> GetAntiFraudVip(GetAntiFraudVipRequest req)
        {
            return InternalRequestAsync<GetAntiFraudVipResponse>(req, "GetAntiFraudVip");
        }

        /// <summary>
        /// 反欺诈VIP评分接口
        /// </summary>
        /// <param name="req"><see cref="GetAntiFraudVipRequest"/></param>
        /// <returns><see cref="GetAntiFraudVipResponse"/></returns>
        public GetAntiFraudVipResponse GetAntiFraudVipSync(GetAntiFraudVipRequest req)
        {
            return InternalRequestAsync<GetAntiFraudVipResponse>(req, "GetAntiFraudVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 天御反欺诈服务，主要应用于银行、证券、保险、P2P等金融行业客户，通过腾讯的大数据风控能力，
        /// 可以准确识别恶意用户信息，解决客户在支付、活动、理财，风控等业务环节遇到的欺诈威胁，降低企业
        /// 的损失。
        /// </summary>
        /// <param name="req"><see cref="QueryAntiFraudVipRequest"/></param>
        /// <returns><see cref="QueryAntiFraudVipResponse"/></returns>
        public Task<QueryAntiFraudVipResponse> QueryAntiFraudVip(QueryAntiFraudVipRequest req)
        {
            return InternalRequestAsync<QueryAntiFraudVipResponse>(req, "QueryAntiFraudVip");
        }

        /// <summary>
        /// 天御反欺诈服务，主要应用于银行、证券、保险、P2P等金融行业客户，通过腾讯的大数据风控能力，
        /// 可以准确识别恶意用户信息，解决客户在支付、活动、理财，风控等业务环节遇到的欺诈威胁，降低企业
        /// 的损失。
        /// </summary>
        /// <param name="req"><see cref="QueryAntiFraudVipRequest"/></param>
        /// <returns><see cref="QueryAntiFraudVipResponse"/></returns>
        public QueryAntiFraudVipResponse QueryAntiFraudVipSync(QueryAntiFraudVipRequest req)
        {
            return InternalRequestAsync<QueryAntiFraudVipResponse>(req, "QueryAntiFraudVip")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 天御信鸽取数平台接口
        /// </summary>
        /// <param name="req"><see cref="TransportGeneralInterfaceRequest"/></param>
        /// <returns><see cref="TransportGeneralInterfaceResponse"/></returns>
        public Task<TransportGeneralInterfaceResponse> TransportGeneralInterface(TransportGeneralInterfaceRequest req)
        {
            return InternalRequestAsync<TransportGeneralInterfaceResponse>(req, "TransportGeneralInterface");
        }

        /// <summary>
        /// 天御信鸽取数平台接口
        /// </summary>
        /// <param name="req"><see cref="TransportGeneralInterfaceRequest"/></param>
        /// <returns><see cref="TransportGeneralInterfaceResponse"/></returns>
        public TransportGeneralInterfaceResponse TransportGeneralInterfaceSync(TransportGeneralInterfaceRequest req)
        {
            return InternalRequestAsync<TransportGeneralInterfaceResponse>(req, "TransportGeneralInterface")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
