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

namespace TencentCloud.Cds.V20180420
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cds.V20180420.Models;

   public class CdsClient : AbstractClient{

       private const string endpoint = "cds.tencentcloudapi.com";
       private const string version = "2018-04-20";
       private const string sdkVersion = "SDK_NET_3.0.1132";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CdsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CdsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 本接口 (DescribeDbauditInstanceType) 用于查询可售卖的产品规格列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDbauditInstanceTypeRequest"/></param>
        /// <returns><see cref="DescribeDbauditInstanceTypeResponse"/></returns>
        public Task<DescribeDbauditInstanceTypeResponse> DescribeDbauditInstanceType(DescribeDbauditInstanceTypeRequest req)
        {
            return InternalRequestAsync<DescribeDbauditInstanceTypeResponse>(req, "DescribeDbauditInstanceType");
        }

        /// <summary>
        /// 本接口 (DescribeDbauditInstanceType) 用于查询可售卖的产品规格列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDbauditInstanceTypeRequest"/></param>
        /// <returns><see cref="DescribeDbauditInstanceTypeResponse"/></returns>
        public DescribeDbauditInstanceTypeResponse DescribeDbauditInstanceTypeSync(DescribeDbauditInstanceTypeRequest req)
        {
            return InternalRequestAsync<DescribeDbauditInstanceTypeResponse>(req, "DescribeDbauditInstanceType")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeDbauditInstances) 用于查询数据安全审计实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDbauditInstancesRequest"/></param>
        /// <returns><see cref="DescribeDbauditInstancesResponse"/></returns>
        public Task<DescribeDbauditInstancesResponse> DescribeDbauditInstances(DescribeDbauditInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDbauditInstancesResponse>(req, "DescribeDbauditInstances");
        }

        /// <summary>
        /// 本接口 (DescribeDbauditInstances) 用于查询数据安全审计实例列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDbauditInstancesRequest"/></param>
        /// <returns><see cref="DescribeDbauditInstancesResponse"/></returns>
        public DescribeDbauditInstancesResponse DescribeDbauditInstancesSync(DescribeDbauditInstancesRequest req)
        {
            return InternalRequestAsync<DescribeDbauditInstancesResponse>(req, "DescribeDbauditInstances")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (DescribeDbauditUsedRegions) 用于查询可售卖地域列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDbauditUsedRegionsRequest"/></param>
        /// <returns><see cref="DescribeDbauditUsedRegionsResponse"/></returns>
        public Task<DescribeDbauditUsedRegionsResponse> DescribeDbauditUsedRegions(DescribeDbauditUsedRegionsRequest req)
        {
            return InternalRequestAsync<DescribeDbauditUsedRegionsResponse>(req, "DescribeDbauditUsedRegions");
        }

        /// <summary>
        /// 本接口 (DescribeDbauditUsedRegions) 用于查询可售卖地域列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDbauditUsedRegionsRequest"/></param>
        /// <returns><see cref="DescribeDbauditUsedRegionsResponse"/></returns>
        public DescribeDbauditUsedRegionsResponse DescribeDbauditUsedRegionsSync(DescribeDbauditUsedRegionsRequest req)
        {
            return InternalRequestAsync<DescribeDbauditUsedRegionsResponse>(req, "DescribeDbauditUsedRegions")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 用于查询数据安全审计产品实例价格
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceDbauditInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceDbauditInstanceResponse"/></returns>
        public Task<InquiryPriceDbauditInstanceResponse> InquiryPriceDbauditInstance(InquiryPriceDbauditInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceDbauditInstanceResponse>(req, "InquiryPriceDbauditInstance");
        }

        /// <summary>
        /// 用于查询数据安全审计产品实例价格
        /// </summary>
        /// <param name="req"><see cref="InquiryPriceDbauditInstanceRequest"/></param>
        /// <returns><see cref="InquiryPriceDbauditInstanceResponse"/></returns>
        public InquiryPriceDbauditInstanceResponse InquiryPriceDbauditInstanceSync(InquiryPriceDbauditInstanceRequest req)
        {
            return InternalRequestAsync<InquiryPriceDbauditInstanceResponse>(req, "InquiryPriceDbauditInstance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 本接口 (ModifyDbauditInstancesRenewFlag) 用于修改数据安全审计产品实例续费标识
        /// </summary>
        /// <param name="req"><see cref="ModifyDbauditInstancesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDbauditInstancesRenewFlagResponse"/></returns>
        public Task<ModifyDbauditInstancesRenewFlagResponse> ModifyDbauditInstancesRenewFlag(ModifyDbauditInstancesRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyDbauditInstancesRenewFlagResponse>(req, "ModifyDbauditInstancesRenewFlag");
        }

        /// <summary>
        /// 本接口 (ModifyDbauditInstancesRenewFlag) 用于修改数据安全审计产品实例续费标识
        /// </summary>
        /// <param name="req"><see cref="ModifyDbauditInstancesRenewFlagRequest"/></param>
        /// <returns><see cref="ModifyDbauditInstancesRenewFlagResponse"/></returns>
        public ModifyDbauditInstancesRenewFlagResponse ModifyDbauditInstancesRenewFlagSync(ModifyDbauditInstancesRenewFlagRequest req)
        {
            return InternalRequestAsync<ModifyDbauditInstancesRenewFlagResponse>(req, "ModifyDbauditInstancesRenewFlag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
