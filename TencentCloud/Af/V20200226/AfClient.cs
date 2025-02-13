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

namespace TencentCloud.Af.V20200226
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Af.V20200226.Models;

   public class AfClient : AbstractClient{

       private const string endpoint = "af.tencentcloudapi.com";
       private const string version = "2020-02-26";
       private const string sdkVersion = "SDK_NET_3.0.1180";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public AfClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public AfClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 该接口未在使用，后端地址已无法访问，经查近60天日志无正常业务访问记录，申请预下线。
        /// 
        /// 天御反欺诈服务，主要应用于银行、证券、保险、消费金融等金融行业客户，通过腾讯的大数据风控能力，
        /// 可以准确识别恶意用户信息，解决客户在支付、活动、理财，风控等业务环节遇到的欺诈威胁，降低企业
        /// 的损失。
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiFraudRequest"/></param>
        /// <returns><see cref="DescribeAntiFraudResponse"/></returns>
        public Task<DescribeAntiFraudResponse> DescribeAntiFraud(DescribeAntiFraudRequest req)
        {
            return InternalRequestAsync<DescribeAntiFraudResponse>(req, "DescribeAntiFraud");
        }

        /// <summary>
        /// 该接口未在使用，后端地址已无法访问，经查近60天日志无正常业务访问记录，申请预下线。
        /// 
        /// 天御反欺诈服务，主要应用于银行、证券、保险、消费金融等金融行业客户，通过腾讯的大数据风控能力，
        /// 可以准确识别恶意用户信息，解决客户在支付、活动、理财，风控等业务环节遇到的欺诈威胁，降低企业
        /// 的损失。
        /// </summary>
        /// <param name="req"><see cref="DescribeAntiFraudRequest"/></param>
        /// <returns><see cref="DescribeAntiFraudResponse"/></returns>
        public DescribeAntiFraudResponse DescribeAntiFraudSync(DescribeAntiFraudRequest req)
        {
            return InternalRequestAsync<DescribeAntiFraudResponse>(req, "DescribeAntiFraud")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 反欺诈评分接口
        /// </summary>
        /// <param name="req"><see cref="GetAntiFraudRequest"/></param>
        /// <returns><see cref="GetAntiFraudResponse"/></returns>
        public Task<GetAntiFraudResponse> GetAntiFraud(GetAntiFraudRequest req)
        {
            return InternalRequestAsync<GetAntiFraudResponse>(req, "GetAntiFraud");
        }

        /// <summary>
        /// 反欺诈评分接口
        /// </summary>
        /// <param name="req"><see cref="GetAntiFraudRequest"/></param>
        /// <returns><see cref="GetAntiFraudResponse"/></returns>
        public GetAntiFraudResponse GetAntiFraudSync(GetAntiFraudRequest req)
        {
            return InternalRequestAsync<GetAntiFraudResponse>(req, "GetAntiFraud")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 天御反欺诈服务，主要应用于银行、证券、保险、消费金融等金融行业客户，通过腾讯的大数据风控能力，
        /// 可以准确识别恶意用户信息，解决客户在支付、活动、理财，风控等业务环节遇到的欺诈威胁，降低企业
        /// 的损失。
        /// </summary>
        /// <param name="req"><see cref="QueryAntiFraudRequest"/></param>
        /// <returns><see cref="QueryAntiFraudResponse"/></returns>
        public Task<QueryAntiFraudResponse> QueryAntiFraud(QueryAntiFraudRequest req)
        {
            return InternalRequestAsync<QueryAntiFraudResponse>(req, "QueryAntiFraud");
        }

        /// <summary>
        /// 天御反欺诈服务，主要应用于银行、证券、保险、消费金融等金融行业客户，通过腾讯的大数据风控能力，
        /// 可以准确识别恶意用户信息，解决客户在支付、活动、理财，风控等业务环节遇到的欺诈威胁，降低企业
        /// 的损失。
        /// </summary>
        /// <param name="req"><see cref="QueryAntiFraudRequest"/></param>
        /// <returns><see cref="QueryAntiFraudResponse"/></returns>
        public QueryAntiFraudResponse QueryAntiFraudSync(QueryAntiFraudRequest req)
        {
            return InternalRequestAsync<QueryAntiFraudResponse>(req, "QueryAntiFraud")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
