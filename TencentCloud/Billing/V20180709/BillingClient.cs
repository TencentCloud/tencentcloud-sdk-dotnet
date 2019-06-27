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

namespace TencentCloud.Billing.V20180709
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Billing.V20180709.Models;

   public class BillingClient : AbstractClient{

       private const string endpoint = "billing.tencentcloudapi.com";
       private const string version = "2018-07-09";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public BillingClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public BillingClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 获取云账户余额信息。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeAccountBalanceRequest"/></param>
        /// <returns>参考<see cref="DescribeAccountBalanceResponse"/>实例</returns>
        public async Task<DescribeAccountBalanceResponse> DescribeAccountBalance(DescribeAccountBalanceRequest req)
        {
             JsonResponseModel<DescribeAccountBalanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账单明细数据
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBillDetailRequest"/></param>
        /// <returns>参考<see cref="DescribeBillDetailResponse"/>实例</returns>
        public async Task<DescribeBillDetailResponse> DescribeBillDetail(DescribeBillDetailRequest req)
        {
             JsonResponseModel<DescribeBillDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账单资源汇总数据 
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBillResourceSummaryRequest"/></param>
        /// <returns>参考<see cref="DescribeBillResourceSummaryResponse"/>实例</returns>
        public async Task<DescribeBillResourceSummaryResponse> DescribeBillResourceSummary(DescribeBillResourceSummaryRequest req)
        {
             JsonResponseModel<DescribeBillResourceSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillResourceSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillResourceSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按付费模式汇总费用分布
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBillSummaryByPayModeRequest"/></param>
        /// <returns>参考<see cref="DescribeBillSummaryByPayModeResponse"/>实例</returns>
        public async Task<DescribeBillSummaryByPayModeResponse> DescribeBillSummaryByPayMode(DescribeBillSummaryByPayModeRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByPayModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummaryByPayMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByPayModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取产品汇总费用分布
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBillSummaryByProductRequest"/></param>
        /// <returns>参考<see cref="DescribeBillSummaryByProductResponse"/>实例</returns>
        public async Task<DescribeBillSummaryByProductResponse> DescribeBillSummaryByProduct(DescribeBillSummaryByProductRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummaryByProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按项目汇总费用分布
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBillSummaryByProjectRequest"/></param>
        /// <returns>参考<see cref="DescribeBillSummaryByProjectResponse"/>实例</returns>
        public async Task<DescribeBillSummaryByProjectResponse> DescribeBillSummaryByProject(DescribeBillSummaryByProjectRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummaryByProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按地域汇总费用分布
        /// </summary>
        /// <param name="req">参考<see cref="DescribeBillSummaryByRegionRequest"/></param>
        /// <returns>参考<see cref="DescribeBillSummaryByRegionResponse"/>实例</returns>
        public async Task<DescribeBillSummaryByRegionResponse> DescribeBillSummaryByRegion(DescribeBillSummaryByRegionRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummaryByRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDealsByCondRequest"/></param>
        /// <returns>参考<see cref="DescribeDealsByCondResponse"/>实例</returns>
        public async Task<DescribeDealsByCondResponse> DescribeDealsByCond(DescribeDealsByCondRequest req)
        {
             JsonResponseModel<DescribeDealsByCondResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDealsByCond");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDealsByCondResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按日期获取产品用量明细
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDosageDetailByDateRequest"/></param>
        /// <returns>参考<see cref="DescribeDosageDetailByDateResponse"/>实例</returns>
        public async Task<DescribeDosageDetailByDateResponse> DescribeDosageDetailByDate(DescribeDosageDetailByDateRequest req)
        {
             JsonResponseModel<DescribeDosageDetailByDateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDosageDetailByDate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDosageDetailByDateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支付订单
        /// </summary>
        /// <param name="req">参考<see cref="PayDealsRequest"/></param>
        /// <returns>参考<see cref="PayDealsResponse"/>实例</returns>
        public async Task<PayDealsResponse> PayDeals(PayDealsRequest req)
        {
             JsonResponseModel<PayDealsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PayDeals");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PayDealsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
