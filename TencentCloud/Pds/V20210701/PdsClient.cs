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

namespace TencentCloud.Pds.V20210701
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Pds.V20210701.Models;

   public class PdsClient : AbstractClient{

       private const string endpoint = "pds.tencentcloudapi.com";
       private const string version = "2021-07-01";
       private const string sdkVersion = "SDK_NET_3.0.1053";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public PdsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public PdsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 判断新用户信誉值
        /// </summary>
        /// <param name="req"><see cref="DescribeNewUserAcquisitionRequest"/></param>
        /// <returns><see cref="DescribeNewUserAcquisitionResponse"/></returns>
        public Task<DescribeNewUserAcquisitionResponse> DescribeNewUserAcquisition(DescribeNewUserAcquisitionRequest req)
        {
            return InternalRequestAsync<DescribeNewUserAcquisitionResponse>(req, "DescribeNewUserAcquisition");
        }

        /// <summary>
        /// 判断新用户信誉值
        /// </summary>
        /// <param name="req"><see cref="DescribeNewUserAcquisitionRequest"/></param>
        /// <returns><see cref="DescribeNewUserAcquisitionResponse"/></returns>
        public DescribeNewUserAcquisitionResponse DescribeNewUserAcquisitionSync(DescribeNewUserAcquisitionRequest req)
        {
            return InternalRequestAsync<DescribeNewUserAcquisitionResponse>(req, "DescribeNewUserAcquisition")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询存量判断服务
        /// </summary>
        /// <param name="req"><see cref="DescribeStockEstimationRequest"/></param>
        /// <returns><see cref="DescribeStockEstimationResponse"/></returns>
        public Task<DescribeStockEstimationResponse> DescribeStockEstimation(DescribeStockEstimationRequest req)
        {
            return InternalRequestAsync<DescribeStockEstimationResponse>(req, "DescribeStockEstimation");
        }

        /// <summary>
        /// 查询存量判断服务
        /// </summary>
        /// <param name="req"><see cref="DescribeStockEstimationRequest"/></param>
        /// <returns><see cref="DescribeStockEstimationResponse"/></returns>
        public DescribeStockEstimationResponse DescribeStockEstimationSync(DescribeStockEstimationRequest req)
        {
            return InternalRequestAsync<DescribeStockEstimationResponse>(req, "DescribeStockEstimation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
