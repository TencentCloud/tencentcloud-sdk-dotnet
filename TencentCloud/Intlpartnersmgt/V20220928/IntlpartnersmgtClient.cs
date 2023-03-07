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

namespace TencentCloud.Intlpartnersmgt.V20220928
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Intlpartnersmgt.V20220928.Models;

   public class IntlpartnersmgtClient : AbstractClient{

       private const string endpoint = "intlpartnersmgt.tencentcloudapi.com";
       private const string version = "2022-09-28";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IntlpartnersmgtClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IntlpartnersmgtClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 合作伙伴可以为关联客户设置信用额度，包括调高额度、降低额度、设置额度为0
        /// 1、信用额度长期有效，不会定期清0；
        /// 2、可用信用额度为0，会触发客户停服，请谨慎操作；
        /// 3、如需限制客户新购，但不影响已购产品使用，可与渠道经理申请客户欠费不停服特权后，设置可用信用额度为0；
        /// 4、设置的额度，为当前可用信用额度的增量，最大不能超过合作伙伴可分配的剩余额度，设置负数代表回收额度，可用信用额度最低设置为0。
        /// </summary>
        /// <param name="req"><see cref="AllocateCustomerCreditRequest"/></param>
        /// <returns><see cref="AllocateCustomerCreditResponse"/></returns>
        public async Task<AllocateCustomerCreditResponse> AllocateCustomerCredit(AllocateCustomerCreditRequest req)
        {
             JsonResponseModel<AllocateCustomerCreditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AllocateCustomerCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateCustomerCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 合作伙伴可以为关联客户设置信用额度，包括调高额度、降低额度、设置额度为0
        /// 1、信用额度长期有效，不会定期清0；
        /// 2、可用信用额度为0，会触发客户停服，请谨慎操作；
        /// 3、如需限制客户新购，但不影响已购产品使用，可与渠道经理申请客户欠费不停服特权后，设置可用信用额度为0；
        /// 4、设置的额度，为当前可用信用额度的增量，最大不能超过合作伙伴可分配的剩余额度，设置负数代表回收额度，可用信用额度最低设置为0。
        /// </summary>
        /// <param name="req"><see cref="AllocateCustomerCreditRequest"/></param>
        /// <returns><see cref="AllocateCustomerCreditResponse"/></returns>
        public AllocateCustomerCreditResponse AllocateCustomerCreditSync(AllocateCustomerCreditRequest req)
        {
             JsonResponseModel<AllocateCustomerCreditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AllocateCustomerCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AllocateCustomerCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在合作伙伴平台，创建腾讯云账号，子客户注册完成后，自动与合作伙伴账号绑定。
        /// 
        /// 注意事项：<br>
        /// 1、创建腾讯云账号，输入的邮箱、手机号，需要合作伙伴做有效性验证。<br>
        /// 2、客户首次登录需要补充个人信息
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public async Task<CreateAccountResponse> CreateAccount(CreateAccountRequest req)
        {
             JsonResponseModel<CreateAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 在合作伙伴平台，创建腾讯云账号，子客户注册完成后，自动与合作伙伴账号绑定。
        /// 
        /// 注意事项：<br>
        /// 1、创建腾讯云账号，输入的邮箱、手机号，需要合作伙伴做有效性验证。<br>
        /// 2、客户首次登录需要补充个人信息
        /// </summary>
        /// <param name="req"><see cref="CreateAccountRequest"/></param>
        /// <returns><see cref="CreateAccountResponse"/></returns>
        public CreateAccountResponse CreateAccountSync(CreateAccountRequest req)
        {
             JsonResponseModel<CreateAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取国家和地区的代码
        /// </summary>
        /// <param name="req"><see cref="GetCountryCodesRequest"/></param>
        /// <returns><see cref="GetCountryCodesResponse"/></returns>
        public async Task<GetCountryCodesResponse> GetCountryCodes(GetCountryCodesRequest req)
        {
             JsonResponseModel<GetCountryCodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCountryCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCountryCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取国家和地区的代码
        /// </summary>
        /// <param name="req"><see cref="GetCountryCodesRequest"/></param>
        /// <returns><see cref="GetCountryCodesResponse"/></returns>
        public GetCountryCodesResponse GetCountryCodesSync(GetCountryCodesRequest req)
        {
             JsonResponseModel<GetCountryCodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCountryCodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCountryCodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个客户的全部历史分配记录
        /// </summary>
        /// <param name="req"><see cref="QueryCreditAllocationHistoryRequest"/></param>
        /// <returns><see cref="QueryCreditAllocationHistoryResponse"/></returns>
        public async Task<QueryCreditAllocationHistoryResponse> QueryCreditAllocationHistory(QueryCreditAllocationHistoryRequest req)
        {
             JsonResponseModel<QueryCreditAllocationHistoryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCreditAllocationHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCreditAllocationHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单个客户的全部历史分配记录
        /// </summary>
        /// <param name="req"><see cref="QueryCreditAllocationHistoryRequest"/></param>
        /// <returns><see cref="QueryCreditAllocationHistoryResponse"/></returns>
        public QueryCreditAllocationHistoryResponse QueryCreditAllocationHistorySync(QueryCreditAllocationHistoryRequest req)
        {
             JsonResponseModel<QueryCreditAllocationHistoryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCreditAllocationHistory");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCreditAllocationHistoryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户列表信用
        /// </summary>
        /// <param name="req"><see cref="QueryCreditByUinListRequest"/></param>
        /// <returns><see cref="QueryCreditByUinListResponse"/></returns>
        public async Task<QueryCreditByUinListResponse> QueryCreditByUinList(QueryCreditByUinListRequest req)
        {
             JsonResponseModel<QueryCreditByUinListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCreditByUinList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCreditByUinListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户列表信用
        /// </summary>
        /// <param name="req"><see cref="QueryCreditByUinListRequest"/></param>
        /// <returns><see cref="QueryCreditByUinListResponse"/></returns>
        public QueryCreditByUinListResponse QueryCreditByUinListSync(QueryCreditByUinListRequest req)
        {
             JsonResponseModel<QueryCreditByUinListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCreditByUinList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCreditByUinListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 合作伙伴可以查询关联客户的信用额度，以及客户的基础信息
        /// </summary>
        /// <param name="req"><see cref="QueryCustomersCreditRequest"/></param>
        /// <returns><see cref="QueryCustomersCreditResponse"/></returns>
        public async Task<QueryCustomersCreditResponse> QueryCustomersCredit(QueryCustomersCreditRequest req)
        {
             JsonResponseModel<QueryCustomersCreditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCustomersCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCustomersCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 合作伙伴可以查询关联客户的信用额度，以及客户的基础信息
        /// </summary>
        /// <param name="req"><see cref="QueryCustomersCreditRequest"/></param>
        /// <returns><see cref="QueryCustomersCreditResponse"/></returns>
        public QueryCustomersCreditResponse QueryCustomersCreditSync(QueryCustomersCreditRequest req)
        {
             JsonResponseModel<QueryCustomersCreditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCustomersCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCustomersCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询直接子客信用
        /// </summary>
        /// <param name="req"><see cref="QueryDirectCustomersCreditRequest"/></param>
        /// <returns><see cref="QueryDirectCustomersCreditResponse"/></returns>
        public async Task<QueryDirectCustomersCreditResponse> QueryDirectCustomersCredit(QueryDirectCustomersCreditRequest req)
        {
             JsonResponseModel<QueryDirectCustomersCreditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryDirectCustomersCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryDirectCustomersCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询直接子客信用
        /// </summary>
        /// <param name="req"><see cref="QueryDirectCustomersCreditRequest"/></param>
        /// <returns><see cref="QueryDirectCustomersCreditResponse"/></returns>
        public QueryDirectCustomersCreditResponse QueryDirectCustomersCreditSync(QueryDirectCustomersCreditRequest req)
        {
             JsonResponseModel<QueryDirectCustomersCreditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryDirectCustomersCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryDirectCustomersCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询合作伙伴自己的总信用额度、可用信用额度、已使用信用额度，单位为美元
        /// </summary>
        /// <param name="req"><see cref="QueryPartnerCreditRequest"/></param>
        /// <returns><see cref="QueryPartnerCreditResponse"/></returns>
        public async Task<QueryPartnerCreditResponse> QueryPartnerCredit(QueryPartnerCreditRequest req)
        {
             JsonResponseModel<QueryPartnerCreditResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryPartnerCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryPartnerCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询合作伙伴自己的总信用额度、可用信用额度、已使用信用额度，单位为美元
        /// </summary>
        /// <param name="req"><see cref="QueryPartnerCreditRequest"/></param>
        /// <returns><see cref="QueryPartnerCreditResponse"/></returns>
        public QueryPartnerCreditResponse QueryPartnerCreditSync(QueryPartnerCreditRequest req)
        {
             JsonResponseModel<QueryPartnerCreditResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryPartnerCredit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryPartnerCreditResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据客户uin查询代金券额度
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherAmountByUinRequest"/></param>
        /// <returns><see cref="QueryVoucherAmountByUinResponse"/></returns>
        public async Task<QueryVoucherAmountByUinResponse> QueryVoucherAmountByUin(QueryVoucherAmountByUinRequest req)
        {
             JsonResponseModel<QueryVoucherAmountByUinResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryVoucherAmountByUin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryVoucherAmountByUinResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据客户uin查询代金券额度
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherAmountByUinRequest"/></param>
        /// <returns><see cref="QueryVoucherAmountByUinResponse"/></returns>
        public QueryVoucherAmountByUinResponse QueryVoucherAmountByUinSync(QueryVoucherAmountByUinRequest req)
        {
             JsonResponseModel<QueryVoucherAmountByUinResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryVoucherAmountByUin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryVoucherAmountByUinResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据客户uin查询代金券列表
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherListByUinRequest"/></param>
        /// <returns><see cref="QueryVoucherListByUinResponse"/></returns>
        public async Task<QueryVoucherListByUinResponse> QueryVoucherListByUin(QueryVoucherListByUinRequest req)
        {
             JsonResponseModel<QueryVoucherListByUinResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryVoucherListByUin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryVoucherListByUinResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据客户uin查询代金券列表
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherListByUinRequest"/></param>
        /// <returns><see cref="QueryVoucherListByUinResponse"/></returns>
        public QueryVoucherListByUinResponse QueryVoucherListByUinSync(QueryVoucherListByUinRequest req)
        {
             JsonResponseModel<QueryVoucherListByUinResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryVoucherListByUin");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryVoucherListByUinResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询代金券额度池
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherPoolRequest"/></param>
        /// <returns><see cref="QueryVoucherPoolResponse"/></returns>
        public async Task<QueryVoucherPoolResponse> QueryVoucherPool(QueryVoucherPoolRequest req)
        {
             JsonResponseModel<QueryVoucherPoolResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryVoucherPool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryVoucherPoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询代金券额度池
        /// </summary>
        /// <param name="req"><see cref="QueryVoucherPoolRequest"/></param>
        /// <returns><see cref="QueryVoucherPoolResponse"/></returns>
        public QueryVoucherPoolResponse QueryVoucherPoolSync(QueryVoucherPoolRequest req)
        {
             JsonResponseModel<QueryVoucherPoolResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryVoucherPool");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryVoucherPoolResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
