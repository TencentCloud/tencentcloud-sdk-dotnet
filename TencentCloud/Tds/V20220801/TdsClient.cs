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

namespace TencentCloud.Tds.V20220801
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tds.V20220801.Models;

   public class TdsClient : AbstractClient{

       private const string endpoint = "tds.tencentcloudapi.com";
       private const string version = "2022-08-01";
       private const string sdkVersion = "SDK_NET_3.0.984";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TdsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TdsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 查询设备风险
        /// </summary>
        /// <param name="req"><see cref="DescribeFraudBaseRequest"/></param>
        /// <returns><see cref="DescribeFraudBaseResponse"/></returns>
        public Task<DescribeFraudBaseResponse> DescribeFraudBase(DescribeFraudBaseRequest req)
        {
            return InternalRequestAsync<DescribeFraudBaseResponse>(req, "DescribeFraudBase");
        }

        /// <summary>
        /// 查询设备风险
        /// </summary>
        /// <param name="req"><see cref="DescribeFraudBaseRequest"/></param>
        /// <returns><see cref="DescribeFraudBaseResponse"/></returns>
        public DescribeFraudBaseResponse DescribeFraudBaseSync(DescribeFraudBaseRequest req)
        {
            return InternalRequestAsync<DescribeFraudBaseResponse>(req, "DescribeFraudBase")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备标识及风险
        /// </summary>
        /// <param name="req"><see cref="DescribeFraudPremiumRequest"/></param>
        /// <returns><see cref="DescribeFraudPremiumResponse"/></returns>
        public Task<DescribeFraudPremiumResponse> DescribeFraudPremium(DescribeFraudPremiumRequest req)
        {
            return InternalRequestAsync<DescribeFraudPremiumResponse>(req, "DescribeFraudPremium");
        }

        /// <summary>
        /// 查询设备标识及风险
        /// </summary>
        /// <param name="req"><see cref="DescribeFraudPremiumRequest"/></param>
        /// <returns><see cref="DescribeFraudPremiumResponse"/></returns>
        public DescribeFraudPremiumResponse DescribeFraudPremiumSync(DescribeFraudPremiumRequest req)
        {
            return InternalRequestAsync<DescribeFraudPremiumResponse>(req, "DescribeFraudPremium")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备标识及风险（旗舰版）
        /// </summary>
        /// <param name="req"><see cref="DescribeFraudUltimateRequest"/></param>
        /// <returns><see cref="DescribeFraudUltimateResponse"/></returns>
        public Task<DescribeFraudUltimateResponse> DescribeFraudUltimate(DescribeFraudUltimateRequest req)
        {
            return InternalRequestAsync<DescribeFraudUltimateResponse>(req, "DescribeFraudUltimate");
        }

        /// <summary>
        /// 查询设备标识及风险（旗舰版）
        /// </summary>
        /// <param name="req"><see cref="DescribeFraudUltimateRequest"/></param>
        /// <returns><see cref="DescribeFraudUltimateResponse"/></returns>
        public DescribeFraudUltimateResponse DescribeFraudUltimateSync(DescribeFraudUltimateRequest req)
        {
            return InternalRequestAsync<DescribeFraudUltimateResponse>(req, "DescribeFraudUltimate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询设备标识
        /// </summary>
        /// <param name="req"><see cref="DescribeTrustedIDRequest"/></param>
        /// <returns><see cref="DescribeTrustedIDResponse"/></returns>
        public Task<DescribeTrustedIDResponse> DescribeTrustedID(DescribeTrustedIDRequest req)
        {
            return InternalRequestAsync<DescribeTrustedIDResponse>(req, "DescribeTrustedID");
        }

        /// <summary>
        /// 查询设备标识
        /// </summary>
        /// <param name="req"><see cref="DescribeTrustedIDRequest"/></param>
        /// <returns><see cref="DescribeTrustedIDResponse"/></returns>
        public DescribeTrustedIDResponse DescribeTrustedIDSync(DescribeTrustedIDRequest req)
        {
            return InternalRequestAsync<DescribeTrustedIDResponse>(req, "DescribeTrustedID")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
