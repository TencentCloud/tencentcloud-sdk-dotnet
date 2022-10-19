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

namespace TencentCloud.Cpdp.V20190820
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cpdp.V20190820.Models;

   public class CpdpClient : AbstractClient{

       private const string endpoint = "cpdp.tencentcloudapi.com";
       private const string version = "2019-08-20";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CpdpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CpdpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 云支付-添加合同接口
        /// </summary>
        /// <param name="req"><see cref="AddContractRequest"/></param>
        /// <returns><see cref="AddContractResponse"/></returns>
        public async Task<AddContractResponse> AddContract(AddContractRequest req)
        {
             JsonResponseModel<AddContractResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-添加合同接口
        /// </summary>
        /// <param name="req"><see cref="AddContractRequest"/></param>
        /// <returns><see cref="AddContractResponse"/></returns>
        public AddContractResponse AddContractSync(AddContractRequest req)
        {
             JsonResponseModel<AddContractResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-补充证件信息
        /// </summary>
        /// <param name="req"><see cref="AddFlexIdInfoRequest"/></param>
        /// <returns><see cref="AddFlexIdInfoResponse"/></returns>
        public async Task<AddFlexIdInfoResponse> AddFlexIdInfo(AddFlexIdInfoRequest req)
        {
             JsonResponseModel<AddFlexIdInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddFlexIdInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddFlexIdInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-补充证件信息
        /// </summary>
        /// <param name="req"><see cref="AddFlexIdInfoRequest"/></param>
        /// <returns><see cref="AddFlexIdInfoResponse"/></returns>
        public AddFlexIdInfoResponse AddFlexIdInfoSync(AddFlexIdInfoRequest req)
        {
             JsonResponseModel<AddFlexIdInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddFlexIdInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddFlexIdInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-补充手机号信息
        /// </summary>
        /// <param name="req"><see cref="AddFlexPhoneNoRequest"/></param>
        /// <returns><see cref="AddFlexPhoneNoResponse"/></returns>
        public async Task<AddFlexPhoneNoResponse> AddFlexPhoneNo(AddFlexPhoneNoRequest req)
        {
             JsonResponseModel<AddFlexPhoneNoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddFlexPhoneNo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddFlexPhoneNoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-补充手机号信息
        /// </summary>
        /// <param name="req"><see cref="AddFlexPhoneNoRequest"/></param>
        /// <returns><see cref="AddFlexPhoneNoResponse"/></returns>
        public AddFlexPhoneNoResponse AddFlexPhoneNoSync(AddFlexPhoneNoRequest req)
        {
             JsonResponseModel<AddFlexPhoneNoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddFlexPhoneNo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddFlexPhoneNoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-添加商户接口
        /// </summary>
        /// <param name="req"><see cref="AddMerchantRequest"/></param>
        /// <returns><see cref="AddMerchantResponse"/></returns>
        public async Task<AddMerchantResponse> AddMerchant(AddMerchantRequest req)
        {
             JsonResponseModel<AddMerchantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-添加商户接口
        /// </summary>
        /// <param name="req"><see cref="AddMerchantRequest"/></param>
        /// <returns><see cref="AddMerchantResponse"/></returns>
        public AddMerchantResponse AddMerchantSync(AddMerchantRequest req)
        {
             JsonResponseModel<AddMerchantResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-添加门店接口
        /// </summary>
        /// <param name="req"><see cref="AddShopRequest"/></param>
        /// <returns><see cref="AddShopResponse"/></returns>
        public async Task<AddShopResponse> AddShop(AddShopRequest req)
        {
             JsonResponseModel<AddShopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddShop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddShopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-添加门店接口
        /// </summary>
        /// <param name="req"><see cref="AddShopRequest"/></param>
        /// <returns><see cref="AddShopResponse"/></returns>
        public AddShopResponse AddShopSync(AddShopRequest req)
        {
             JsonResponseModel<AddShopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddShop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddShopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-提交申报材料。申报材料的主体是付款人，需要提前调用【跨境-付款人申请】接口提交付款人信息且审核通过后调用。
        /// </summary>
        /// <param name="req"><see cref="ApplyApplicationMaterialRequest"/></param>
        /// <returns><see cref="ApplyApplicationMaterialResponse"/></returns>
        public async Task<ApplyApplicationMaterialResponse> ApplyApplicationMaterial(ApplyApplicationMaterialRequest req)
        {
             JsonResponseModel<ApplyApplicationMaterialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyApplicationMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyApplicationMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-提交申报材料。申报材料的主体是付款人，需要提前调用【跨境-付款人申请】接口提交付款人信息且审核通过后调用。
        /// </summary>
        /// <param name="req"><see cref="ApplyApplicationMaterialRequest"/></param>
        /// <returns><see cref="ApplyApplicationMaterialResponse"/></returns>
        public ApplyApplicationMaterialResponse ApplyApplicationMaterialSync(ApplyApplicationMaterialRequest req)
        {
             JsonResponseModel<ApplyApplicationMaterialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyApplicationMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyApplicationMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-付款
        /// </summary>
        /// <param name="req"><see cref="ApplyFlexPaymentRequest"/></param>
        /// <returns><see cref="ApplyFlexPaymentResponse"/></returns>
        public async Task<ApplyFlexPaymentResponse> ApplyFlexPayment(ApplyFlexPaymentRequest req)
        {
             JsonResponseModel<ApplyFlexPaymentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyFlexPayment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyFlexPaymentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-付款
        /// </summary>
        /// <param name="req"><see cref="ApplyFlexPaymentRequest"/></param>
        /// <returns><see cref="ApplyFlexPaymentResponse"/></returns>
        public ApplyFlexPaymentResponse ApplyFlexPaymentSync(ApplyFlexPaymentRequest req)
        {
             JsonResponseModel<ApplyFlexPaymentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyFlexPayment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyFlexPaymentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-结算
        /// </summary>
        /// <param name="req"><see cref="ApplyFlexSettlementRequest"/></param>
        /// <returns><see cref="ApplyFlexSettlementResponse"/></returns>
        public async Task<ApplyFlexSettlementResponse> ApplyFlexSettlement(ApplyFlexSettlementRequest req)
        {
             JsonResponseModel<ApplyFlexSettlementResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyFlexSettlement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyFlexSettlementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-结算
        /// </summary>
        /// <param name="req"><see cref="ApplyFlexSettlementRequest"/></param>
        /// <returns><see cref="ApplyFlexSettlementResponse"/></returns>
        public ApplyFlexSettlementResponse ApplyFlexSettlementSync(ApplyFlexSettlementRequest req)
        {
             JsonResponseModel<ApplyFlexSettlementResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyFlexSettlement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyFlexSettlementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-申请单笔交易回单
        /// </summary>
        /// <param name="req"><see cref="ApplyOpenBankOrderDetailReceiptRequest"/></param>
        /// <returns><see cref="ApplyOpenBankOrderDetailReceiptResponse"/></returns>
        public async Task<ApplyOpenBankOrderDetailReceiptResponse> ApplyOpenBankOrderDetailReceipt(ApplyOpenBankOrderDetailReceiptRequest req)
        {
             JsonResponseModel<ApplyOpenBankOrderDetailReceiptResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyOpenBankOrderDetailReceipt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyOpenBankOrderDetailReceiptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-申请单笔交易回单
        /// </summary>
        /// <param name="req"><see cref="ApplyOpenBankOrderDetailReceiptRequest"/></param>
        /// <returns><see cref="ApplyOpenBankOrderDetailReceiptResponse"/></returns>
        public ApplyOpenBankOrderDetailReceiptResponse ApplyOpenBankOrderDetailReceiptSync(ApplyOpenBankOrderDetailReceiptRequest req)
        {
             JsonResponseModel<ApplyOpenBankOrderDetailReceiptResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyOpenBankOrderDetailReceipt");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyOpenBankOrderDetailReceiptResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-结算申请接口
        /// </summary>
        /// <param name="req"><see cref="ApplyOpenBankSettleOrderRequest"/></param>
        /// <returns><see cref="ApplyOpenBankSettleOrderResponse"/></returns>
        public async Task<ApplyOpenBankSettleOrderResponse> ApplyOpenBankSettleOrder(ApplyOpenBankSettleOrderRequest req)
        {
             JsonResponseModel<ApplyOpenBankSettleOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyOpenBankSettleOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyOpenBankSettleOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-结算申请接口
        /// </summary>
        /// <param name="req"><see cref="ApplyOpenBankSettleOrderRequest"/></param>
        /// <returns><see cref="ApplyOpenBankSettleOrderResponse"/></returns>
        public ApplyOpenBankSettleOrderResponse ApplyOpenBankSettleOrderSync(ApplyOpenBankSettleOrderRequest req)
        {
             JsonResponseModel<ApplyOpenBankSettleOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyOpenBankSettleOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyOpenBankSettleOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 子商户在线签约
        /// </summary>
        /// <param name="req"><see cref="ApplyOpenBankSubMerchantSignOnlineRequest"/></param>
        /// <returns><see cref="ApplyOpenBankSubMerchantSignOnlineResponse"/></returns>
        public async Task<ApplyOpenBankSubMerchantSignOnlineResponse> ApplyOpenBankSubMerchantSignOnline(ApplyOpenBankSubMerchantSignOnlineRequest req)
        {
             JsonResponseModel<ApplyOpenBankSubMerchantSignOnlineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyOpenBankSubMerchantSignOnline");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyOpenBankSubMerchantSignOnlineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 子商户在线签约
        /// </summary>
        /// <param name="req"><see cref="ApplyOpenBankSubMerchantSignOnlineRequest"/></param>
        /// <returns><see cref="ApplyOpenBankSubMerchantSignOnlineResponse"/></returns>
        public ApplyOpenBankSubMerchantSignOnlineResponse ApplyOpenBankSubMerchantSignOnlineSync(ApplyOpenBankSubMerchantSignOnlineRequest req)
        {
             JsonResponseModel<ApplyOpenBankSubMerchantSignOnlineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyOpenBankSubMerchantSignOnline");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyOpenBankSubMerchantSignOnlineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-汇出指令申请。通过该接口可将对接方账户中的人民币余额汇兑成外币，再汇出至指定银行账户。
        /// </summary>
        /// <param name="req"><see cref="ApplyOutwardOrderRequest"/></param>
        /// <returns><see cref="ApplyOutwardOrderResponse"/></returns>
        public async Task<ApplyOutwardOrderResponse> ApplyOutwardOrder(ApplyOutwardOrderRequest req)
        {
             JsonResponseModel<ApplyOutwardOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyOutwardOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyOutwardOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-汇出指令申请。通过该接口可将对接方账户中的人民币余额汇兑成外币，再汇出至指定银行账户。
        /// </summary>
        /// <param name="req"><see cref="ApplyOutwardOrderRequest"/></param>
        /// <returns><see cref="ApplyOutwardOrderResponse"/></returns>
        public ApplyOutwardOrderResponse ApplyOutwardOrderSync(ApplyOutwardOrderRequest req)
        {
             JsonResponseModel<ApplyOutwardOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyOutwardOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyOutwardOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-付款人申请。通过该接口提交付款人信息并进行 kyc 审核。
        /// </summary>
        /// <param name="req"><see cref="ApplyPayerInfoRequest"/></param>
        /// <returns><see cref="ApplyPayerInfoResponse"/></returns>
        public async Task<ApplyPayerInfoResponse> ApplyPayerInfo(ApplyPayerInfoRequest req)
        {
             JsonResponseModel<ApplyPayerInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyPayerInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyPayerInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-付款人申请。通过该接口提交付款人信息并进行 kyc 审核。
        /// </summary>
        /// <param name="req"><see cref="ApplyPayerInfoRequest"/></param>
        /// <returns><see cref="ApplyPayerInfoResponse"/></returns>
        public ApplyPayerInfoResponse ApplyPayerInfoSync(ApplyPayerInfoRequest req)
        {
             JsonResponseModel<ApplyPayerInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyPayerInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyPayerInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 正常结算提现失败情况下，发起重新提现的请求接口
        /// </summary>
        /// <param name="req"><see cref="ApplyReWithdrawalRequest"/></param>
        /// <returns><see cref="ApplyReWithdrawalResponse"/></returns>
        public async Task<ApplyReWithdrawalResponse> ApplyReWithdrawal(ApplyReWithdrawalRequest req)
        {
             JsonResponseModel<ApplyReWithdrawalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyReWithdrawal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyReWithdrawalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 正常结算提现失败情况下，发起重新提现的请求接口
        /// </summary>
        /// <param name="req"><see cref="ApplyReWithdrawalRequest"/></param>
        /// <returns><see cref="ApplyReWithdrawalResponse"/></returns>
        public ApplyReWithdrawalResponse ApplyReWithdrawalSync(ApplyReWithdrawalRequest req)
        {
             JsonResponseModel<ApplyReWithdrawalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyReWithdrawal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyReWithdrawalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 聚鑫-申请对账文件
        /// </summary>
        /// <param name="req"><see cref="ApplyReconciliationFileRequest"/></param>
        /// <returns><see cref="ApplyReconciliationFileResponse"/></returns>
        public async Task<ApplyReconciliationFileResponse> ApplyReconciliationFile(ApplyReconciliationFileRequest req)
        {
             JsonResponseModel<ApplyReconciliationFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyReconciliationFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyReconciliationFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 聚鑫-申请对账文件
        /// </summary>
        /// <param name="req"><see cref="ApplyReconciliationFileRequest"/></param>
        /// <returns><see cref="ApplyReconciliationFileResponse"/></returns>
        public ApplyReconciliationFileResponse ApplyReconciliationFileSync(ApplyReconciliationFileRequest req)
        {
             JsonResponseModel<ApplyReconciliationFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyReconciliationFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyReconciliationFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-提交贸易材料。通过提交贸易材料接口可为对接方累计贸易额度，在额度范围内可发起汇兑汇出交易。
        /// </summary>
        /// <param name="req"><see cref="ApplyTradeRequest"/></param>
        /// <returns><see cref="ApplyTradeResponse"/></returns>
        public async Task<ApplyTradeResponse> ApplyTrade(ApplyTradeRequest req)
        {
             JsonResponseModel<ApplyTradeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyTrade");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyTradeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-提交贸易材料。通过提交贸易材料接口可为对接方累计贸易额度，在额度范围内可发起汇兑汇出交易。
        /// </summary>
        /// <param name="req"><see cref="ApplyTradeRequest"/></param>
        /// <returns><see cref="ApplyTradeResponse"/></returns>
        public ApplyTradeResponse ApplyTradeSync(ApplyTradeRequest req)
        {
             JsonResponseModel<ApplyTradeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyTrade");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyTradeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户提现
        /// </summary>
        /// <param name="req"><see cref="ApplyWithdrawalRequest"/></param>
        /// <returns><see cref="ApplyWithdrawalResponse"/></returns>
        public async Task<ApplyWithdrawalResponse> ApplyWithdrawal(ApplyWithdrawalRequest req)
        {
             JsonResponseModel<ApplyWithdrawalResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyWithdrawal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyWithdrawalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户提现
        /// </summary>
        /// <param name="req"><see cref="ApplyWithdrawalRequest"/></param>
        /// <returns><see cref="ApplyWithdrawalResponse"/></returns>
        public ApplyWithdrawalResponse ApplyWithdrawalSync(ApplyWithdrawalRequest req)
        {
             JsonResponseModel<ApplyWithdrawalResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyWithdrawal");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyWithdrawalResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-绑定账号
        /// </summary>
        /// <param name="req"><see cref="BindAccountRequest"/></param>
        /// <returns><see cref="BindAccountResponse"/></returns>
        public async Task<BindAccountResponse> BindAccount(BindAccountRequest req)
        {
             JsonResponseModel<BindAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-绑定账号
        /// </summary>
        /// <param name="req"><see cref="BindAccountRequest"/></param>
        /// <returns><see cref="BindAccountResponse"/></returns>
        public BindAccountResponse BindAccountSync(BindAccountRequest req)
        {
             JsonResponseModel<BindAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户绑定提现银行卡，每个商户只能绑定一张提现银行卡
        /// </summary>
        /// <param name="req"><see cref="BindAcctRequest"/></param>
        /// <returns><see cref="BindAcctResponse"/></returns>
        public async Task<BindAcctResponse> BindAcct(BindAcctRequest req)
        {
             JsonResponseModel<BindAcctResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindAcct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindAcctResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户绑定提现银行卡，每个商户只能绑定一张提现银行卡
        /// </summary>
        /// <param name="req"><see cref="BindAcctRequest"/></param>
        /// <returns><see cref="BindAcctResponse"/></returns>
        public BindAcctResponse BindAcctSync(BindAcctRequest req)
        {
             JsonResponseModel<BindAcctResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindAcct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindAcctResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户银行卡绑定
        /// </summary>
        /// <param name="req"><see cref="BindOpenBankExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="BindOpenBankExternalSubMerchantBankAccountResponse"/></returns>
        public async Task<BindOpenBankExternalSubMerchantBankAccountResponse> BindOpenBankExternalSubMerchantBankAccount(BindOpenBankExternalSubMerchantBankAccountRequest req)
        {
             JsonResponseModel<BindOpenBankExternalSubMerchantBankAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindOpenBankExternalSubMerchantBankAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindOpenBankExternalSubMerchantBankAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户银行卡绑定
        /// </summary>
        /// <param name="req"><see cref="BindOpenBankExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="BindOpenBankExternalSubMerchantBankAccountResponse"/></returns>
        public BindOpenBankExternalSubMerchantBankAccountResponse BindOpenBankExternalSubMerchantBankAccountSync(BindOpenBankExternalSubMerchantBankAccountRequest req)
        {
             JsonResponseModel<BindOpenBankExternalSubMerchantBankAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindOpenBankExternalSubMerchantBankAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindOpenBankExternalSubMerchantBankAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员绑定提现账户-回填银联鉴权短信码。用于会员填写动态验证码后，发往银行进行验证，验证成功则完成绑定。
        /// </summary>
        /// <param name="req"><see cref="BindRelateAccReUnionPayRequest"/></param>
        /// <returns><see cref="BindRelateAccReUnionPayResponse"/></returns>
        public async Task<BindRelateAccReUnionPayResponse> BindRelateAccReUnionPay(BindRelateAccReUnionPayRequest req)
        {
             JsonResponseModel<BindRelateAccReUnionPayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindRelateAccReUnionPay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindRelateAccReUnionPayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员绑定提现账户-回填银联鉴权短信码。用于会员填写动态验证码后，发往银行进行验证，验证成功则完成绑定。
        /// </summary>
        /// <param name="req"><see cref="BindRelateAccReUnionPayRequest"/></param>
        /// <returns><see cref="BindRelateAccReUnionPayResponse"/></returns>
        public BindRelateAccReUnionPayResponse BindRelateAccReUnionPaySync(BindRelateAccReUnionPayRequest req)
        {
             JsonResponseModel<BindRelateAccReUnionPayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindRelateAccReUnionPay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindRelateAccReUnionPayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员绑定提现账户-小额鉴权。会员申请绑定提现账户，绑定后从会员子账户中提现到绑定账户。
        /// 转账鉴权有两种形式：往账鉴权和来账鉴权。
        /// 往账鉴权：该接口发起成功后，银行会向提现账户转入小于等于0.5元的随机金额，并短信通知客户查看，客户查看后，需将收到的金额大小，在电商平台页面上回填，并通知银行。银行验证通过后，完成提现账户绑定。
        /// 来账鉴权：该接口发起成功后，银行以短信通知客户查看，客户查看后，需通过待绑定的账户往市场的监管账户转入短信上指定的金额。银行检索到该笔指定金额的来账是源自待绑定账户，则绑定成功。平安银行的账户，即BankType送1时，大小额行号和超级网银号都不用送。
        /// </summary>
        /// <param name="req"><see cref="BindRelateAcctSmallAmountRequest"/></param>
        /// <returns><see cref="BindRelateAcctSmallAmountResponse"/></returns>
        public async Task<BindRelateAcctSmallAmountResponse> BindRelateAcctSmallAmount(BindRelateAcctSmallAmountRequest req)
        {
             JsonResponseModel<BindRelateAcctSmallAmountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindRelateAcctSmallAmount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindRelateAcctSmallAmountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员绑定提现账户-小额鉴权。会员申请绑定提现账户，绑定后从会员子账户中提现到绑定账户。
        /// 转账鉴权有两种形式：往账鉴权和来账鉴权。
        /// 往账鉴权：该接口发起成功后，银行会向提现账户转入小于等于0.5元的随机金额，并短信通知客户查看，客户查看后，需将收到的金额大小，在电商平台页面上回填，并通知银行。银行验证通过后，完成提现账户绑定。
        /// 来账鉴权：该接口发起成功后，银行以短信通知客户查看，客户查看后，需通过待绑定的账户往市场的监管账户转入短信上指定的金额。银行检索到该笔指定金额的来账是源自待绑定账户，则绑定成功。平安银行的账户，即BankType送1时，大小额行号和超级网银号都不用送。
        /// </summary>
        /// <param name="req"><see cref="BindRelateAcctSmallAmountRequest"/></param>
        /// <returns><see cref="BindRelateAcctSmallAmountResponse"/></returns>
        public BindRelateAcctSmallAmountResponse BindRelateAcctSmallAmountSync(BindRelateAcctSmallAmountRequest req)
        {
             JsonResponseModel<BindRelateAcctSmallAmountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindRelateAcctSmallAmount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindRelateAcctSmallAmountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员绑定提现账户-银联鉴权。用于会员申请绑定提现账户，申请后银行前往银联验证卡信息：姓名、证件、卡号、银行预留手机是否相符，相符则发送给会员手机动态验证码并返回成功，不相符则返回失败。
        /// 平台接收到银行返回成功后，进入输入动态验证码的页面，有效期120秒，若120秒未输入，客户可点击重新发送动态验证码，这个步骤重新调用该接口即可。
        /// 平安银行的账户，大小额行号和超级网银号都不用送。
        /// 超级网银号：单笔转账金额不超过5万，不限制笔数，只用选XX银行，不用具体到支行，可实时知道对方是否收款成功。
        /// 大小额联行号：单笔转账可超过5万，需具体到支行，不能实时知道对方是否收款成功。金额超过5万的，在工作日的8点30-17点间才会成功。
        /// </summary>
        /// <param name="req"><see cref="BindRelateAcctUnionPayRequest"/></param>
        /// <returns><see cref="BindRelateAcctUnionPayResponse"/></returns>
        public async Task<BindRelateAcctUnionPayResponse> BindRelateAcctUnionPay(BindRelateAcctUnionPayRequest req)
        {
             JsonResponseModel<BindRelateAcctUnionPayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindRelateAcctUnionPay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindRelateAcctUnionPayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员绑定提现账户-银联鉴权。用于会员申请绑定提现账户，申请后银行前往银联验证卡信息：姓名、证件、卡号、银行预留手机是否相符，相符则发送给会员手机动态验证码并返回成功，不相符则返回失败。
        /// 平台接收到银行返回成功后，进入输入动态验证码的页面，有效期120秒，若120秒未输入，客户可点击重新发送动态验证码，这个步骤重新调用该接口即可。
        /// 平安银行的账户，大小额行号和超级网银号都不用送。
        /// 超级网银号：单笔转账金额不超过5万，不限制笔数，只用选XX银行，不用具体到支行，可实时知道对方是否收款成功。
        /// 大小额联行号：单笔转账可超过5万，需具体到支行，不能实时知道对方是否收款成功。金额超过5万的，在工作日的8点30-17点间才会成功。
        /// </summary>
        /// <param name="req"><see cref="BindRelateAcctUnionPayRequest"/></param>
        /// <returns><see cref="BindRelateAcctUnionPayResponse"/></returns>
        public BindRelateAcctUnionPayResponse BindRelateAcctUnionPaySync(BindRelateAcctUnionPayRequest req)
        {
             JsonResponseModel<BindRelateAcctUnionPayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindRelateAcctUnionPay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindRelateAcctUnionPayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户绑定提现银行卡的验证接口
        /// </summary>
        /// <param name="req"><see cref="CheckAcctRequest"/></param>
        /// <returns><see cref="CheckAcctResponse"/></returns>
        public async Task<CheckAcctResponse> CheckAcct(CheckAcctRequest req)
        {
             JsonResponseModel<CheckAcctResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckAcct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckAcctResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户绑定提现银行卡的验证接口
        /// </summary>
        /// <param name="req"><see cref="CheckAcctRequest"/></param>
        /// <returns><see cref="CheckAcctResponse"/></returns>
        public CheckAcctResponse CheckAcctSync(CheckAcctRequest req)
        {
             JsonResponseModel<CheckAcctResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckAcct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckAcctResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证鉴权金额。此接口可受理BindRelateAcctSmallAmount接口发起的转账金额（往账鉴权方式）的验证处理。若所回填的验证金额验证通过，则会绑定原申请中的银行账户作为提现账户。通过此接口也可以查得BindRelateAcctSmallAmount接口发起的来账鉴权方式的申请的当前状态。
        /// </summary>
        /// <param name="req"><see cref="CheckAmountRequest"/></param>
        /// <returns><see cref="CheckAmountResponse"/></returns>
        public async Task<CheckAmountResponse> CheckAmount(CheckAmountRequest req)
        {
             JsonResponseModel<CheckAmountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckAmount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckAmountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 验证鉴权金额。此接口可受理BindRelateAcctSmallAmount接口发起的转账金额（往账鉴权方式）的验证处理。若所回填的验证金额验证通过，则会绑定原申请中的银行账户作为提现账户。通过此接口也可以查得BindRelateAcctSmallAmount接口发起的来账鉴权方式的申请的当前状态。
        /// </summary>
        /// <param name="req"><see cref="CheckAmountRequest"/></param>
        /// <returns><see cref="CheckAmountResponse"/></returns>
        public CheckAmountResponse CheckAmountSync(CheckAmountRequest req)
        {
             JsonResponseModel<CheckAmountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckAmount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckAmountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口关闭此前已创建的订单。关闭后，用户将无法继续付款，仅能关闭创建后未支付的订单。
        /// </summary>
        /// <param name="req"><see cref="CloseCloudOrderRequest"/></param>
        /// <returns><see cref="CloseCloudOrderResponse"/></returns>
        public async Task<CloseCloudOrderResponse> CloseCloudOrder(CloseCloudOrderRequest req)
        {
             JsonResponseModel<CloseCloudOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseCloudOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseCloudOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口关闭此前已创建的订单。关闭后，用户将无法继续付款，仅能关闭创建后未支付的订单。
        /// </summary>
        /// <param name="req"><see cref="CloseCloudOrderRequest"/></param>
        /// <returns><see cref="CloseCloudOrderResponse"/></returns>
        public CloseCloudOrderResponse CloseCloudOrderSync(CloseCloudOrderRequest req)
        {
             JsonResponseModel<CloseCloudOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseCloudOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseCloudOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-关闭订单
        /// </summary>
        /// <param name="req"><see cref="CloseOpenBankPaymentOrderRequest"/></param>
        /// <returns><see cref="CloseOpenBankPaymentOrderResponse"/></returns>
        public async Task<CloseOpenBankPaymentOrderResponse> CloseOpenBankPaymentOrder(CloseOpenBankPaymentOrderRequest req)
        {
             JsonResponseModel<CloseOpenBankPaymentOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseOpenBankPaymentOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseOpenBankPaymentOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-关闭订单
        /// </summary>
        /// <param name="req"><see cref="CloseOpenBankPaymentOrderRequest"/></param>
        /// <returns><see cref="CloseOpenBankPaymentOrderResponse"/></returns>
        public CloseOpenBankPaymentOrderResponse CloseOpenBankPaymentOrderSync(CloseOpenBankPaymentOrderRequest req)
        {
             JsonResponseModel<CloseOpenBankPaymentOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseOpenBankPaymentOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseOpenBankPaymentOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口关闭此前已创建的订单，关闭后，用户将无法继续付款。仅能关闭创建后未支付的订单
        /// </summary>
        /// <param name="req"><see cref="CloseOrderRequest"/></param>
        /// <returns><see cref="CloseOrderResponse"/></returns>
        public async Task<CloseOrderResponse> CloseOrder(CloseOrderRequest req)
        {
             JsonResponseModel<CloseOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CloseOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口关闭此前已创建的订单，关闭后，用户将无法继续付款。仅能关闭创建后未支付的订单
        /// </summary>
        /// <param name="req"><see cref="CloseOrderRequest"/></param>
        /// <returns><see cref="CloseOrderResponse"/></returns>
        public CloseOrderResponse CloseOrderSync(CloseOrderRequest req)
        {
             JsonResponseModel<CloseOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CloseOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CloseOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云鉴-消费订单确认接口
        /// </summary>
        /// <param name="req"><see cref="ConfirmOrderRequest"/></param>
        /// <returns><see cref="ConfirmOrderResponse"/></returns>
        public async Task<ConfirmOrderResponse> ConfirmOrder(ConfirmOrderRequest req)
        {
             JsonResponseModel<ConfirmOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ConfirmOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ConfirmOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云鉴-消费订单确认接口
        /// </summary>
        /// <param name="req"><see cref="ConfirmOrderRequest"/></param>
        /// <returns><see cref="ConfirmOrderResponse"/></returns>
        public ConfirmOrderResponse ConfirmOrderSync(ConfirmOrderRequest req)
        {
             JsonResponseModel<ConfirmOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ConfirmOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ConfirmOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 应用需要先带上签约信息调用本接口生成支付订单号，并将应答的PayInfo透传给聚鑫SDK，拉起客户端（包括微信公众号/微信小程序/客户端App）支付。
        /// </summary>
        /// <param name="req"><see cref="ContractOrderRequest"/></param>
        /// <returns><see cref="ContractOrderResponse"/></returns>
        public async Task<ContractOrderResponse> ContractOrder(ContractOrderRequest req)
        {
             JsonResponseModel<ContractOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ContractOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ContractOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 应用需要先带上签约信息调用本接口生成支付订单号，并将应答的PayInfo透传给聚鑫SDK，拉起客户端（包括微信公众号/微信小程序/客户端App）支付。
        /// </summary>
        /// <param name="req"><see cref="ContractOrderRequest"/></param>
        /// <returns><see cref="ContractOrderResponse"/></returns>
        public ContractOrderResponse ContractOrderSync(ContractOrderRequest req)
        {
             JsonResponseModel<ContractOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ContractOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ContractOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 子商户入驻聚鑫平台
        /// </summary>
        /// <param name="req"><see cref="CreateAcctRequest"/></param>
        /// <returns><see cref="CreateAcctResponse"/></returns>
        public async Task<CreateAcctResponse> CreateAcct(CreateAcctRequest req)
        {
             JsonResponseModel<CreateAcctResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAcct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAcctResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 子商户入驻聚鑫平台
        /// </summary>
        /// <param name="req"><see cref="CreateAcctRequest"/></param>
        /// <returns><see cref="CreateAcctResponse"/></returns>
        public CreateAcctResponse CreateAcctSync(CreateAcctRequest req)
        {
             JsonResponseModel<CreateAcctResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAcct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAcctResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-代理商完税信息录入
        /// </summary>
        /// <param name="req"><see cref="CreateAgentTaxPaymentInfosRequest"/></param>
        /// <returns><see cref="CreateAgentTaxPaymentInfosResponse"/></returns>
        public async Task<CreateAgentTaxPaymentInfosResponse> CreateAgentTaxPaymentInfos(CreateAgentTaxPaymentInfosRequest req)
        {
             JsonResponseModel<CreateAgentTaxPaymentInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAgentTaxPaymentInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAgentTaxPaymentInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-代理商完税信息录入
        /// </summary>
        /// <param name="req"><see cref="CreateAgentTaxPaymentInfosRequest"/></param>
        /// <returns><see cref="CreateAgentTaxPaymentInfosResponse"/></returns>
        public CreateAgentTaxPaymentInfosResponse CreateAgentTaxPaymentInfosSync(CreateAgentTaxPaymentInfosRequest req)
        {
             JsonResponseModel<CreateAgentTaxPaymentInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAgentTaxPaymentInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAgentTaxPaymentInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-主播入驻
        /// </summary>
        /// <param name="req"><see cref="CreateAnchorRequest"/></param>
        /// <returns><see cref="CreateAnchorResponse"/></returns>
        public async Task<CreateAnchorResponse> CreateAnchor(CreateAnchorRequest req)
        {
             JsonResponseModel<CreateAnchorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAnchor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAnchorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-主播入驻
        /// </summary>
        /// <param name="req"><see cref="CreateAnchorRequest"/></param>
        /// <returns><see cref="CreateAnchorResponse"/></returns>
        public CreateAnchorResponse CreateAnchorSync(CreateAnchorRequest req)
        {
             JsonResponseModel<CreateAnchorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAnchor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAnchorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-批量主播转账接口
        /// </summary>
        /// <param name="req"><see cref="CreateBatchPaymentRequest"/></param>
        /// <returns><see cref="CreateBatchPaymentResponse"/></returns>
        public async Task<CreateBatchPaymentResponse> CreateBatchPayment(CreateBatchPaymentRequest req)
        {
             JsonResponseModel<CreateBatchPaymentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBatchPayment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBatchPaymentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-批量主播转账接口
        /// </summary>
        /// <param name="req"><see cref="CreateBatchPaymentRequest"/></param>
        /// <returns><see cref="CreateBatchPaymentResponse"/></returns>
        public CreateBatchPaymentResponse CreateBatchPaymentSync(CreateBatchPaymentRequest req)
        {
             JsonResponseModel<CreateBatchPaymentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBatchPayment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBatchPaymentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建子商户
        /// </summary>
        /// <param name="req"><see cref="CreateCloudSubMerchantRequest"/></param>
        /// <returns><see cref="CreateCloudSubMerchantResponse"/></returns>
        public async Task<CreateCloudSubMerchantResponse> CreateCloudSubMerchant(CreateCloudSubMerchantRequest req)
        {
             JsonResponseModel<CreateCloudSubMerchantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCloudSubMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudSubMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建子商户
        /// </summary>
        /// <param name="req"><see cref="CreateCloudSubMerchantRequest"/></param>
        /// <returns><see cref="CreateCloudSubMerchantResponse"/></returns>
        public CreateCloudSubMerchantResponse CreateCloudSubMerchantSync(CreateCloudSubMerchantRequest req)
        {
             JsonResponseModel<CreateCloudSubMerchantResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCloudSubMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCloudSubMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员子账户开立。会员在银行注册，并开立会员子账户，交易网会员代码即会员在平台端系统的会员编号。
        /// 平台需保存银行返回的子账户账号，后续交易接口都会用到。会员属性字段为预留扩展字段，当前必须送默认值。
        /// </summary>
        /// <param name="req"><see cref="CreateCustAcctIdRequest"/></param>
        /// <returns><see cref="CreateCustAcctIdResponse"/></returns>
        public async Task<CreateCustAcctIdResponse> CreateCustAcctId(CreateCustAcctIdRequest req)
        {
             JsonResponseModel<CreateCustAcctIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCustAcctId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustAcctIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员子账户开立。会员在银行注册，并开立会员子账户，交易网会员代码即会员在平台端系统的会员编号。
        /// 平台需保存银行返回的子账户账号，后续交易接口都会用到。会员属性字段为预留扩展字段，当前必须送默认值。
        /// </summary>
        /// <param name="req"><see cref="CreateCustAcctIdRequest"/></param>
        /// <returns><see cref="CreateCustAcctIdResponse"/></returns>
        public CreateCustAcctIdResponse CreateCustAcctIdSync(CreateCustAcctIdRequest req)
        {
             JsonResponseModel<CreateCustAcctIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCustAcctId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCustAcctIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-主播入驻
        /// </summary>
        /// <param name="req"><see cref="CreateExternalAnchorRequest"/></param>
        /// <returns><see cref="CreateExternalAnchorResponse"/></returns>
        public async Task<CreateExternalAnchorResponse> CreateExternalAnchor(CreateExternalAnchorRequest req)
        {
             JsonResponseModel<CreateExternalAnchorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateExternalAnchor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateExternalAnchorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-主播入驻
        /// </summary>
        /// <param name="req"><see cref="CreateExternalAnchorRequest"/></param>
        /// <returns><see cref="CreateExternalAnchorResponse"/></returns>
        public CreateExternalAnchorResponse CreateExternalAnchorSync(CreateExternalAnchorRequest req)
        {
             JsonResponseModel<CreateExternalAnchorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateExternalAnchor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateExternalAnchorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-收款用户开立
        /// </summary>
        /// <param name="req"><see cref="CreateFlexPayeeRequest"/></param>
        /// <returns><see cref="CreateFlexPayeeResponse"/></returns>
        public async Task<CreateFlexPayeeResponse> CreateFlexPayee(CreateFlexPayeeRequest req)
        {
             JsonResponseModel<CreateFlexPayeeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlexPayee");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlexPayeeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-收款用户开立
        /// </summary>
        /// <param name="req"><see cref="CreateFlexPayeeRequest"/></param>
        /// <returns><see cref="CreateFlexPayeeResponse"/></returns>
        public CreateFlexPayeeResponse CreateFlexPayeeSync(CreateFlexPayeeRequest req)
        {
             JsonResponseModel<CreateFlexPayeeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlexPayee");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlexPayeeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-发票开具
        /// </summary>
        /// <param name="req"><see cref="CreateInvoiceRequest"/></param>
        /// <returns><see cref="CreateInvoiceResponse"/></returns>
        public async Task<CreateInvoiceResponse> CreateInvoice(CreateInvoiceRequest req)
        {
             JsonResponseModel<CreateInvoiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInvoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInvoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-发票开具
        /// </summary>
        /// <param name="req"><see cref="CreateInvoiceRequest"/></param>
        /// <returns><see cref="CreateInvoiceResponse"/></returns>
        public CreateInvoiceResponse CreateInvoiceSync(CreateInvoiceRequest req)
        {
             JsonResponseModel<CreateInvoiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInvoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInvoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-发票开具V2
        /// </summary>
        /// <param name="req"><see cref="CreateInvoiceV2Request"/></param>
        /// <returns><see cref="CreateInvoiceV2Response"/></returns>
        public async Task<CreateInvoiceV2Response> CreateInvoiceV2(CreateInvoiceV2Request req)
        {
             JsonResponseModel<CreateInvoiceV2Response> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateInvoiceV2");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInvoiceV2Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-发票开具V2
        /// </summary>
        /// <param name="req"><see cref="CreateInvoiceV2Request"/></param>
        /// <returns><see cref="CreateInvoiceV2Response"/></returns>
        public CreateInvoiceV2Response CreateInvoiceV2Sync(CreateInvoiceV2Request req)
        {
             JsonResponseModel<CreateInvoiceV2Response> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateInvoiceV2");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateInvoiceV2Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-商户注册
        /// </summary>
        /// <param name="req"><see cref="CreateMerchantRequest"/></param>
        /// <returns><see cref="CreateMerchantResponse"/></returns>
        public async Task<CreateMerchantResponse> CreateMerchant(CreateMerchantRequest req)
        {
             JsonResponseModel<CreateMerchantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-商户注册
        /// </summary>
        /// <param name="req"><see cref="CreateMerchantRequest"/></param>
        /// <returns><see cref="CreateMerchantResponse"/></returns>
        public CreateMerchantResponse CreateMerchantSync(CreateMerchantRequest req)
        {
             JsonResponseModel<CreateMerchantResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户进件V2
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankAggregatedSubMerchantRegistrationRequest"/></param>
        /// <returns><see cref="CreateOpenBankAggregatedSubMerchantRegistrationResponse"/></returns>
        public async Task<CreateOpenBankAggregatedSubMerchantRegistrationResponse> CreateOpenBankAggregatedSubMerchantRegistration(CreateOpenBankAggregatedSubMerchantRegistrationRequest req)
        {
             JsonResponseModel<CreateOpenBankAggregatedSubMerchantRegistrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOpenBankAggregatedSubMerchantRegistration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankAggregatedSubMerchantRegistrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户进件V2
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankAggregatedSubMerchantRegistrationRequest"/></param>
        /// <returns><see cref="CreateOpenBankAggregatedSubMerchantRegistrationResponse"/></returns>
        public CreateOpenBankAggregatedSubMerchantRegistrationResponse CreateOpenBankAggregatedSubMerchantRegistrationSync(CreateOpenBankAggregatedSubMerchantRegistrationRequest req)
        {
             JsonResponseModel<CreateOpenBankAggregatedSubMerchantRegistrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOpenBankAggregatedSubMerchantRegistration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankAggregatedSubMerchantRegistrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 第三方子商户电子记账本创建接口
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankExternalSubMerchantAccountBookRequest"/></param>
        /// <returns><see cref="CreateOpenBankExternalSubMerchantAccountBookResponse"/></returns>
        public async Task<CreateOpenBankExternalSubMerchantAccountBookResponse> CreateOpenBankExternalSubMerchantAccountBook(CreateOpenBankExternalSubMerchantAccountBookRequest req)
        {
             JsonResponseModel<CreateOpenBankExternalSubMerchantAccountBookResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOpenBankExternalSubMerchantAccountBook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankExternalSubMerchantAccountBookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 第三方子商户电子记账本创建接口
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankExternalSubMerchantAccountBookRequest"/></param>
        /// <returns><see cref="CreateOpenBankExternalSubMerchantAccountBookResponse"/></returns>
        public CreateOpenBankExternalSubMerchantAccountBookResponse CreateOpenBankExternalSubMerchantAccountBookSync(CreateOpenBankExternalSubMerchantAccountBookRequest req)
        {
             JsonResponseModel<CreateOpenBankExternalSubMerchantAccountBookResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOpenBankExternalSubMerchantAccountBook");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankExternalSubMerchantAccountBookResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户进件
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankExternalSubMerchantRegistrationRequest"/></param>
        /// <returns><see cref="CreateOpenBankExternalSubMerchantRegistrationResponse"/></returns>
        public async Task<CreateOpenBankExternalSubMerchantRegistrationResponse> CreateOpenBankExternalSubMerchantRegistration(CreateOpenBankExternalSubMerchantRegistrationRequest req)
        {
             JsonResponseModel<CreateOpenBankExternalSubMerchantRegistrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOpenBankExternalSubMerchantRegistration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankExternalSubMerchantRegistrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户进件
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankExternalSubMerchantRegistrationRequest"/></param>
        /// <returns><see cref="CreateOpenBankExternalSubMerchantRegistrationResponse"/></returns>
        public CreateOpenBankExternalSubMerchantRegistrationResponse CreateOpenBankExternalSubMerchantRegistrationSync(CreateOpenBankExternalSubMerchantRegistrationRequest req)
        {
             JsonResponseModel<CreateOpenBankExternalSubMerchantRegistrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOpenBankExternalSubMerchantRegistration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankExternalSubMerchantRegistrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-跨境支付下单
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankGlobalPaymentOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankGlobalPaymentOrderResponse"/></returns>
        public async Task<CreateOpenBankGlobalPaymentOrderResponse> CreateOpenBankGlobalPaymentOrder(CreateOpenBankGlobalPaymentOrderRequest req)
        {
             JsonResponseModel<CreateOpenBankGlobalPaymentOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOpenBankGlobalPaymentOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankGlobalPaymentOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-跨境支付下单
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankGlobalPaymentOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankGlobalPaymentOrderResponse"/></returns>
        public CreateOpenBankGlobalPaymentOrderResponse CreateOpenBankGlobalPaymentOrderSync(CreateOpenBankGlobalPaymentOrderRequest req)
        {
             JsonResponseModel<CreateOpenBankGlobalPaymentOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOpenBankGlobalPaymentOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankGlobalPaymentOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-创建商户
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankMerchantRequest"/></param>
        /// <returns><see cref="CreateOpenBankMerchantResponse"/></returns>
        public async Task<CreateOpenBankMerchantResponse> CreateOpenBankMerchant(CreateOpenBankMerchantRequest req)
        {
             JsonResponseModel<CreateOpenBankMerchantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOpenBankMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-创建商户
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankMerchantRequest"/></param>
        /// <returns><see cref="CreateOpenBankMerchantResponse"/></returns>
        public CreateOpenBankMerchantResponse CreateOpenBankMerchantSync(CreateOpenBankMerchantRequest req)
        {
             JsonResponseModel<CreateOpenBankMerchantResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOpenBankMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-创建支付订单。支持B2B网关支付，B2C转账下单。
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankPaymentOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankPaymentOrderResponse"/></returns>
        public async Task<CreateOpenBankPaymentOrderResponse> CreateOpenBankPaymentOrder(CreateOpenBankPaymentOrderRequest req)
        {
             JsonResponseModel<CreateOpenBankPaymentOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOpenBankPaymentOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankPaymentOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-创建支付订单。支持B2B网关支付，B2C转账下单。
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankPaymentOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankPaymentOrderResponse"/></returns>
        public CreateOpenBankPaymentOrderResponse CreateOpenBankPaymentOrderSync(CreateOpenBankPaymentOrderRequest req)
        {
             JsonResponseModel<CreateOpenBankPaymentOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOpenBankPaymentOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankPaymentOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-创建充值订单
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankRechargeOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankRechargeOrderResponse"/></returns>
        public async Task<CreateOpenBankRechargeOrderResponse> CreateOpenBankRechargeOrder(CreateOpenBankRechargeOrderRequest req)
        {
             JsonResponseModel<CreateOpenBankRechargeOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOpenBankRechargeOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankRechargeOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-创建充值订单
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankRechargeOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankRechargeOrderResponse"/></returns>
        public CreateOpenBankRechargeOrderResponse CreateOpenBankRechargeOrderSync(CreateOpenBankRechargeOrderRequest req)
        {
             JsonResponseModel<CreateOpenBankRechargeOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOpenBankRechargeOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankRechargeOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户费率配置
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankSubMerchantRateConfigureRequest"/></param>
        /// <returns><see cref="CreateOpenBankSubMerchantRateConfigureResponse"/></returns>
        public async Task<CreateOpenBankSubMerchantRateConfigureResponse> CreateOpenBankSubMerchantRateConfigure(CreateOpenBankSubMerchantRateConfigureRequest req)
        {
             JsonResponseModel<CreateOpenBankSubMerchantRateConfigureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOpenBankSubMerchantRateConfigure");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankSubMerchantRateConfigureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户费率配置
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankSubMerchantRateConfigureRequest"/></param>
        /// <returns><see cref="CreateOpenBankSubMerchantRateConfigureResponse"/></returns>
        public CreateOpenBankSubMerchantRateConfigureResponse CreateOpenBankSubMerchantRateConfigureSync(CreateOpenBankSubMerchantRateConfigureRequest req)
        {
             JsonResponseModel<CreateOpenBankSubMerchantRateConfigureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOpenBankSubMerchantRateConfigure");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankSubMerchantRateConfigureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-聚合下单
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankUnifiedOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankUnifiedOrderResponse"/></returns>
        public async Task<CreateOpenBankUnifiedOrderResponse> CreateOpenBankUnifiedOrder(CreateOpenBankUnifiedOrderRequest req)
        {
             JsonResponseModel<CreateOpenBankUnifiedOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOpenBankUnifiedOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankUnifiedOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-聚合下单
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankUnifiedOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankUnifiedOrderResponse"/></returns>
        public CreateOpenBankUnifiedOrderResponse CreateOpenBankUnifiedOrderSync(CreateOpenBankUnifiedOrderRequest req)
        {
             JsonResponseModel<CreateOpenBankUnifiedOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOpenBankUnifiedOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankUnifiedOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-创建核销申请，适用于针对支付订单维度的确认收货，解冻等业务场景。目前支持的渠道有TENPAY下的EBANK_PAYMENT付款方式创建支付订单时，选择担保支付下单的订单进行解冻。
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankVerificationOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankVerificationOrderResponse"/></returns>
        public async Task<CreateOpenBankVerificationOrderResponse> CreateOpenBankVerificationOrder(CreateOpenBankVerificationOrderRequest req)
        {
             JsonResponseModel<CreateOpenBankVerificationOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOpenBankVerificationOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankVerificationOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-创建核销申请，适用于针对支付订单维度的确认收货，解冻等业务场景。目前支持的渠道有TENPAY下的EBANK_PAYMENT付款方式创建支付订单时，选择担保支付下单的订单进行解冻。
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankVerificationOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankVerificationOrderResponse"/></returns>
        public CreateOpenBankVerificationOrderResponse CreateOpenBankVerificationOrderSync(CreateOpenBankVerificationOrderRequest req)
        {
             JsonResponseModel<CreateOpenBankVerificationOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOpenBankVerificationOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOpenBankVerificationOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云鉴-消费订单发起的接口
        /// </summary>
        /// <param name="req"><see cref="CreateOrderRequest"/></param>
        /// <returns><see cref="CreateOrderResponse"/></returns>
        public async Task<CreateOrderResponse> CreateOrder(CreateOrderRequest req)
        {
             JsonResponseModel<CreateOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云鉴-消费订单发起的接口
        /// </summary>
        /// <param name="req"><see cref="CreateOrderRequest"/></param>
        /// <returns><see cref="CreateOrderResponse"/></returns>
        public CreateOrderResponse CreateOrderSync(CreateOrderRequest req)
        {
             JsonResponseModel<CreateOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户新增的接口
        /// </summary>
        /// <param name="req"><see cref="CreatePayMerchantRequest"/></param>
        /// <returns><see cref="CreatePayMerchantResponse"/></returns>
        public async Task<CreatePayMerchantResponse> CreatePayMerchant(CreatePayMerchantRequest req)
        {
             JsonResponseModel<CreatePayMerchantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePayMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePayMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户新增的接口
        /// </summary>
        /// <param name="req"><see cref="CreatePayMerchantRequest"/></param>
        /// <returns><see cref="CreatePayMerchantResponse"/></returns>
        public CreatePayMerchantResponse CreatePayMerchantSync(CreatePayMerchantRequest req)
        {
             JsonResponseModel<CreatePayMerchantResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePayMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePayMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 务工卡-核身预下单
        /// </summary>
        /// <param name="req"><see cref="CreatePayRollPreOrderRequest"/></param>
        /// <returns><see cref="CreatePayRollPreOrderResponse"/></returns>
        public async Task<CreatePayRollPreOrderResponse> CreatePayRollPreOrder(CreatePayRollPreOrderRequest req)
        {
             JsonResponseModel<CreatePayRollPreOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePayRollPreOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePayRollPreOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 务工卡-核身预下单
        /// </summary>
        /// <param name="req"><see cref="CreatePayRollPreOrderRequest"/></param>
        /// <returns><see cref="CreatePayRollPreOrderResponse"/></returns>
        public CreatePayRollPreOrderResponse CreatePayRollPreOrderSync(CreatePayRollPreOrderRequest req)
        {
             JsonResponseModel<CreatePayRollPreOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePayRollPreOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePayRollPreOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 务工卡-核身预下单带授权
        /// </summary>
        /// <param name="req"><see cref="CreatePayRollPreOrderWithAuthRequest"/></param>
        /// <returns><see cref="CreatePayRollPreOrderWithAuthResponse"/></returns>
        public async Task<CreatePayRollPreOrderWithAuthResponse> CreatePayRollPreOrderWithAuth(CreatePayRollPreOrderWithAuthRequest req)
        {
             JsonResponseModel<CreatePayRollPreOrderWithAuthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePayRollPreOrderWithAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePayRollPreOrderWithAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 务工卡-核身预下单带授权
        /// </summary>
        /// <param name="req"><see cref="CreatePayRollPreOrderWithAuthRequest"/></param>
        /// <returns><see cref="CreatePayRollPreOrderWithAuthResponse"/></returns>
        public CreatePayRollPreOrderWithAuthResponse CreatePayRollPreOrderWithAuthSync(CreatePayRollPreOrderWithAuthRequest req)
        {
             JsonResponseModel<CreatePayRollPreOrderWithAuthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePayRollPreOrderWithAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePayRollPreOrderWithAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 务工卡-生成授权令牌
        /// </summary>
        /// <param name="req"><see cref="CreatePayRollTokenRequest"/></param>
        /// <returns><see cref="CreatePayRollTokenResponse"/></returns>
        public async Task<CreatePayRollTokenResponse> CreatePayRollToken(CreatePayRollTokenRequest req)
        {
             JsonResponseModel<CreatePayRollTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePayRollToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePayRollTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 务工卡-生成授权令牌
        /// </summary>
        /// <param name="req"><see cref="CreatePayRollTokenRequest"/></param>
        /// <returns><see cref="CreatePayRollTokenResponse"/></returns>
        public CreatePayRollTokenResponse CreatePayRollTokenSync(CreatePayRollTokenRequest req)
        {
             JsonResponseModel<CreatePayRollTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePayRollToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePayRollTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-发票红冲
        /// </summary>
        /// <param name="req"><see cref="CreateRedInvoiceRequest"/></param>
        /// <returns><see cref="CreateRedInvoiceResponse"/></returns>
        public async Task<CreateRedInvoiceResponse> CreateRedInvoice(CreateRedInvoiceRequest req)
        {
             JsonResponseModel<CreateRedInvoiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRedInvoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRedInvoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-发票红冲
        /// </summary>
        /// <param name="req"><see cref="CreateRedInvoiceRequest"/></param>
        /// <returns><see cref="CreateRedInvoiceResponse"/></returns>
        public CreateRedInvoiceResponse CreateRedInvoiceSync(CreateRedInvoiceRequest req)
        {
             JsonResponseModel<CreateRedInvoiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRedInvoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRedInvoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-发票红冲V2
        /// </summary>
        /// <param name="req"><see cref="CreateRedInvoiceV2Request"/></param>
        /// <returns><see cref="CreateRedInvoiceV2Response"/></returns>
        public async Task<CreateRedInvoiceV2Response> CreateRedInvoiceV2(CreateRedInvoiceV2Request req)
        {
             JsonResponseModel<CreateRedInvoiceV2Response> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRedInvoiceV2");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRedInvoiceV2Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-发票红冲V2
        /// </summary>
        /// <param name="req"><see cref="CreateRedInvoiceV2Request"/></param>
        /// <returns><see cref="CreateRedInvoiceV2Response"/></returns>
        public CreateRedInvoiceV2Response CreateRedInvoiceV2Sync(CreateRedInvoiceV2Request req)
        {
             JsonResponseModel<CreateRedInvoiceV2Response> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRedInvoiceV2");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRedInvoiceV2Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-单笔主播转账接口
        /// </summary>
        /// <param name="req"><see cref="CreateSinglePaymentRequest"/></param>
        /// <returns><see cref="CreateSinglePaymentResponse"/></returns>
        public async Task<CreateSinglePaymentResponse> CreateSinglePayment(CreateSinglePaymentRequest req)
        {
             JsonResponseModel<CreateSinglePaymentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSinglePayment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSinglePaymentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-单笔主播转账接口
        /// </summary>
        /// <param name="req"><see cref="CreateSinglePaymentRequest"/></param>
        /// <returns><see cref="CreateSinglePaymentResponse"/></returns>
        public CreateSinglePaymentResponse CreateSinglePaymentSync(CreateSinglePaymentRequest req)
        {
             JsonResponseModel<CreateSinglePaymentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSinglePayment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSinglePaymentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 微信商户发起批量转账
        /// </summary>
        /// <param name="req"><see cref="CreateTransferBatchRequest"/></param>
        /// <returns><see cref="CreateTransferBatchResponse"/></returns>
        public async Task<CreateTransferBatchResponse> CreateTransferBatch(CreateTransferBatchRequest req)
        {
             JsonResponseModel<CreateTransferBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTransferBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTransferBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 微信商户发起批量转账
        /// </summary>
        /// <param name="req"><see cref="CreateTransferBatchRequest"/></param>
        /// <returns><see cref="CreateTransferBatchResponse"/></returns>
        public CreateTransferBatchResponse CreateTransferBatchSync(CreateTransferBatchRequest req)
        {
             JsonResponseModel<CreateTransferBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTransferBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTransferBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-扣减额度
        /// </summary>
        /// <param name="req"><see cref="DeduceQuotaRequest"/></param>
        /// <returns><see cref="DeduceQuotaResponse"/></returns>
        public async Task<DeduceQuotaResponse> DeduceQuota(DeduceQuotaRequest req)
        {
             JsonResponseModel<DeduceQuotaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeduceQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeduceQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-扣减额度
        /// </summary>
        /// <param name="req"><see cref="DeduceQuotaRequest"/></param>
        /// <returns><see cref="DeduceQuotaResponse"/></returns>
        public DeduceQuotaResponse DeduceQuotaSync(DeduceQuotaRequest req)
        {
             JsonResponseModel<DeduceQuotaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeduceQuota");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeduceQuotaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-删除代理商完税信息
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentTaxPaymentInfoRequest"/></param>
        /// <returns><see cref="DeleteAgentTaxPaymentInfoResponse"/></returns>
        public async Task<DeleteAgentTaxPaymentInfoResponse> DeleteAgentTaxPaymentInfo(DeleteAgentTaxPaymentInfoRequest req)
        {
             JsonResponseModel<DeleteAgentTaxPaymentInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAgentTaxPaymentInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAgentTaxPaymentInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-删除代理商完税信息
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentTaxPaymentInfoRequest"/></param>
        /// <returns><see cref="DeleteAgentTaxPaymentInfoResponse"/></returns>
        public DeleteAgentTaxPaymentInfoResponse DeleteAgentTaxPaymentInfoSync(DeleteAgentTaxPaymentInfoRequest req)
        {
             JsonResponseModel<DeleteAgentTaxPaymentInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAgentTaxPaymentInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAgentTaxPaymentInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-删除代理商完税信息
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentTaxPaymentInfosRequest"/></param>
        /// <returns><see cref="DeleteAgentTaxPaymentInfosResponse"/></returns>
        public async Task<DeleteAgentTaxPaymentInfosResponse> DeleteAgentTaxPaymentInfos(DeleteAgentTaxPaymentInfosRequest req)
        {
             JsonResponseModel<DeleteAgentTaxPaymentInfosResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAgentTaxPaymentInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAgentTaxPaymentInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-删除代理商完税信息
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentTaxPaymentInfosRequest"/></param>
        /// <returns><see cref="DeleteAgentTaxPaymentInfosResponse"/></returns>
        public DeleteAgentTaxPaymentInfosResponse DeleteAgentTaxPaymentInfosSync(DeleteAgentTaxPaymentInfosRequest req)
        {
             JsonResponseModel<DeleteAgentTaxPaymentInfosResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAgentTaxPaymentInfos");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAgentTaxPaymentInfosResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询充值明细接口
        /// </summary>
        /// <param name="req"><see cref="DescribeChargeDetailRequest"/></param>
        /// <returns><see cref="DescribeChargeDetailResponse"/></returns>
        public async Task<DescribeChargeDetailResponse> DescribeChargeDetail(DescribeChargeDetailRequest req)
        {
             JsonResponseModel<DescribeChargeDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeChargeDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChargeDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询充值明细接口
        /// </summary>
        /// <param name="req"><see cref="DescribeChargeDetailRequest"/></param>
        /// <returns><see cref="DescribeChargeDetailResponse"/></returns>
        public DescribeChargeDetailResponse DescribeChargeDetailSync(DescribeChargeDetailRequest req)
        {
             JsonResponseModel<DescribeChargeDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeChargeDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeChargeDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单笔订单交易状态
        /// </summary>
        /// <param name="req"><see cref="DescribeOrderStatusRequest"/></param>
        /// <returns><see cref="DescribeOrderStatusResponse"/></returns>
        public async Task<DescribeOrderStatusResponse> DescribeOrderStatus(DescribeOrderStatusRequest req)
        {
             JsonResponseModel<DescribeOrderStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeOrderStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrderStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询单笔订单交易状态
        /// </summary>
        /// <param name="req"><see cref="DescribeOrderStatusRequest"/></param>
        /// <returns><see cref="DescribeOrderStatusResponse"/></returns>
        public DescribeOrderStatusResponse DescribeOrderStatusSync(DescribeOrderStatusRequest req)
        {
             JsonResponseModel<DescribeOrderStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeOrderStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeOrderStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-分账授权申请查询接口
        /// </summary>
        /// <param name="req"><see cref="DistributeAccreditQueryRequest"/></param>
        /// <returns><see cref="DistributeAccreditQueryResponse"/></returns>
        public async Task<DistributeAccreditQueryResponse> DistributeAccreditQuery(DistributeAccreditQueryRequest req)
        {
             JsonResponseModel<DistributeAccreditQueryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DistributeAccreditQuery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeAccreditQueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-分账授权申请查询接口
        /// </summary>
        /// <param name="req"><see cref="DistributeAccreditQueryRequest"/></param>
        /// <returns><see cref="DistributeAccreditQueryResponse"/></returns>
        public DistributeAccreditQueryResponse DistributeAccreditQuerySync(DistributeAccreditQueryRequest req)
        {
             JsonResponseModel<DistributeAccreditQueryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DistributeAccreditQuery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeAccreditQueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-分账授权申请接口
        /// </summary>
        /// <param name="req"><see cref="DistributeAccreditTlinxRequest"/></param>
        /// <returns><see cref="DistributeAccreditTlinxResponse"/></returns>
        public async Task<DistributeAccreditTlinxResponse> DistributeAccreditTlinx(DistributeAccreditTlinxRequest req)
        {
             JsonResponseModel<DistributeAccreditTlinxResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DistributeAccreditTlinx");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeAccreditTlinxResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-分账授权申请接口
        /// </summary>
        /// <param name="req"><see cref="DistributeAccreditTlinxRequest"/></param>
        /// <returns><see cref="DistributeAccreditTlinxResponse"/></returns>
        public DistributeAccreditTlinxResponse DistributeAccreditTlinxSync(DistributeAccreditTlinxRequest req)
        {
             JsonResponseModel<DistributeAccreditTlinxResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DistributeAccreditTlinx");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeAccreditTlinxResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-分账添加分账接收方接口
        /// </summary>
        /// <param name="req"><see cref="DistributeAddReceiverRequest"/></param>
        /// <returns><see cref="DistributeAddReceiverResponse"/></returns>
        public async Task<DistributeAddReceiverResponse> DistributeAddReceiver(DistributeAddReceiverRequest req)
        {
             JsonResponseModel<DistributeAddReceiverResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DistributeAddReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeAddReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-分账添加分账接收方接口
        /// </summary>
        /// <param name="req"><see cref="DistributeAddReceiverRequest"/></param>
        /// <returns><see cref="DistributeAddReceiverResponse"/></returns>
        public DistributeAddReceiverResponse DistributeAddReceiverSync(DistributeAddReceiverRequest req)
        {
             JsonResponseModel<DistributeAddReceiverResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DistributeAddReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeAddReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-分账请求接口
        /// </summary>
        /// <param name="req"><see cref="DistributeApplyRequest"/></param>
        /// <returns><see cref="DistributeApplyResponse"/></returns>
        public async Task<DistributeApplyResponse> DistributeApply(DistributeApplyRequest req)
        {
             JsonResponseModel<DistributeApplyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DistributeApply");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeApplyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-分账请求接口
        /// </summary>
        /// <param name="req"><see cref="DistributeApplyRequest"/></param>
        /// <returns><see cref="DistributeApplyResponse"/></returns>
        public DistributeApplyResponse DistributeApplySync(DistributeApplyRequest req)
        {
             JsonResponseModel<DistributeApplyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DistributeApply");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeApplyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-分账撤销接口
        /// </summary>
        /// <param name="req"><see cref="DistributeCancelRequest"/></param>
        /// <returns><see cref="DistributeCancelResponse"/></returns>
        public async Task<DistributeCancelResponse> DistributeCancel(DistributeCancelRequest req)
        {
             JsonResponseModel<DistributeCancelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DistributeCancel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeCancelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-分账撤销接口
        /// </summary>
        /// <param name="req"><see cref="DistributeCancelRequest"/></param>
        /// <returns><see cref="DistributeCancelResponse"/></returns>
        public DistributeCancelResponse DistributeCancelSync(DistributeCancelRequest req)
        {
             JsonResponseModel<DistributeCancelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DistributeCancel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeCancelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-分账结果查询接口
        /// </summary>
        /// <param name="req"><see cref="DistributeQueryRequest"/></param>
        /// <returns><see cref="DistributeQueryResponse"/></returns>
        public async Task<DistributeQueryResponse> DistributeQuery(DistributeQueryRequest req)
        {
             JsonResponseModel<DistributeQueryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DistributeQuery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeQueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-分账结果查询接口
        /// </summary>
        /// <param name="req"><see cref="DistributeQueryRequest"/></param>
        /// <returns><see cref="DistributeQueryResponse"/></returns>
        public DistributeQueryResponse DistributeQuerySync(DistributeQueryRequest req)
        {
             JsonResponseModel<DistributeQueryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DistributeQuery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeQueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询已添加分账接收方接口
        /// </summary>
        /// <param name="req"><see cref="DistributeQueryReceiverRequest"/></param>
        /// <returns><see cref="DistributeQueryReceiverResponse"/></returns>
        public async Task<DistributeQueryReceiverResponse> DistributeQueryReceiver(DistributeQueryReceiverRequest req)
        {
             JsonResponseModel<DistributeQueryReceiverResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DistributeQueryReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeQueryReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询已添加分账接收方接口
        /// </summary>
        /// <param name="req"><see cref="DistributeQueryReceiverRequest"/></param>
        /// <returns><see cref="DistributeQueryReceiverResponse"/></returns>
        public DistributeQueryReceiverResponse DistributeQueryReceiverSync(DistributeQueryReceiverRequest req)
        {
             JsonResponseModel<DistributeQueryReceiverResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DistributeQueryReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeQueryReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-分账解除分账接收方接口
        /// </summary>
        /// <param name="req"><see cref="DistributeRemoveReceiverRequest"/></param>
        /// <returns><see cref="DistributeRemoveReceiverResponse"/></returns>
        public async Task<DistributeRemoveReceiverResponse> DistributeRemoveReceiver(DistributeRemoveReceiverRequest req)
        {
             JsonResponseModel<DistributeRemoveReceiverResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DistributeRemoveReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeRemoveReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-分账解除分账接收方接口
        /// </summary>
        /// <param name="req"><see cref="DistributeRemoveReceiverRequest"/></param>
        /// <returns><see cref="DistributeRemoveReceiverResponse"/></returns>
        public DistributeRemoveReceiverResponse DistributeRemoveReceiverSync(DistributeRemoveReceiverRequest req)
        {
             JsonResponseModel<DistributeRemoveReceiverResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DistributeRemoveReceiver");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DistributeRemoveReceiverResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 账单下载接口，根据本接口返回的URL地址，在D+1日下载对账单。注意，本接口返回的URL地址有时效，请尽快下载。URL超时时效后，请重新调用本接口再次获取。
        /// </summary>
        /// <param name="req"><see cref="DownloadBillRequest"/></param>
        /// <returns><see cref="DownloadBillResponse"/></returns>
        public async Task<DownloadBillResponse> DownloadBill(DownloadBillRequest req)
        {
             JsonResponseModel<DownloadBillResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadBill");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadBillResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 账单下载接口，根据本接口返回的URL地址，在D+1日下载对账单。注意，本接口返回的URL地址有时效，请尽快下载。URL超时时效后，请重新调用本接口再次获取。
        /// </summary>
        /// <param name="req"><see cref="DownloadBillRequest"/></param>
        /// <returns><see cref="DownloadBillResponse"/></returns>
        public DownloadBillResponse DownloadBillSync(DownloadBillRequest req)
        {
             JsonResponseModel<DownloadBillResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadBill");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadBillResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-下载机构文件接口
        /// </summary>
        /// <param name="req"><see cref="DownloadOrgFileRequest"/></param>
        /// <returns><see cref="DownloadOrgFileResponse"/></returns>
        public async Task<DownloadOrgFileResponse> DownloadOrgFile(DownloadOrgFileRequest req)
        {
             JsonResponseModel<DownloadOrgFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadOrgFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadOrgFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-下载机构文件接口
        /// </summary>
        /// <param name="req"><see cref="DownloadOrgFileRequest"/></param>
        /// <returns><see cref="DownloadOrgFileResponse"/></returns>
        public DownloadOrgFileResponse DownloadOrgFileSync(DownloadOrgFileRequest req)
        {
             JsonResponseModel<DownloadOrgFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadOrgFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadOrgFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取对账中心账单下载地址的接口
        /// </summary>
        /// <param name="req"><see cref="DownloadReconciliationUrlRequest"/></param>
        /// <returns><see cref="DownloadReconciliationUrlResponse"/></returns>
        public async Task<DownloadReconciliationUrlResponse> DownloadReconciliationUrl(DownloadReconciliationUrlRequest req)
        {
             JsonResponseModel<DownloadReconciliationUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DownloadReconciliationUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadReconciliationUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取对账中心账单下载地址的接口
        /// </summary>
        /// <param name="req"><see cref="DownloadReconciliationUrlRequest"/></param>
        /// <returns><see cref="DownloadReconciliationUrlResponse"/></returns>
        public DownloadReconciliationUrlResponse DownloadReconciliationUrlSync(DownloadReconciliationUrlRequest req)
        {
             JsonResponseModel<DownloadReconciliationUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DownloadReconciliationUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DownloadReconciliationUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员间交易接口
        /// </summary>
        /// <param name="req"><see cref="ExecuteMemberTransactionRequest"/></param>
        /// <returns><see cref="ExecuteMemberTransactionResponse"/></returns>
        public async Task<ExecuteMemberTransactionResponse> ExecuteMemberTransaction(ExecuteMemberTransactionRequest req)
        {
             JsonResponseModel<ExecuteMemberTransactionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExecuteMemberTransaction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteMemberTransactionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员间交易接口
        /// </summary>
        /// <param name="req"><see cref="ExecuteMemberTransactionRequest"/></param>
        /// <returns><see cref="ExecuteMemberTransactionResponse"/></returns>
        public ExecuteMemberTransactionResponse ExecuteMemberTransactionSync(ExecuteMemberTransactionRequest req)
        {
             JsonResponseModel<ExecuteMemberTransactionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExecuteMemberTransaction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteMemberTransactionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-冻结余额
        /// </summary>
        /// <param name="req"><see cref="FreezeFlexBalanceRequest"/></param>
        /// <returns><see cref="FreezeFlexBalanceResponse"/></returns>
        public async Task<FreezeFlexBalanceResponse> FreezeFlexBalance(FreezeFlexBalanceRequest req)
        {
             JsonResponseModel<FreezeFlexBalanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "FreezeFlexBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FreezeFlexBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-冻结余额
        /// </summary>
        /// <param name="req"><see cref="FreezeFlexBalanceRequest"/></param>
        /// <returns><see cref="FreezeFlexBalanceResponse"/></returns>
        public FreezeFlexBalanceResponse FreezeFlexBalanceSync(FreezeFlexBalanceRequest req)
        {
             JsonResponseModel<FreezeFlexBalanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "FreezeFlexBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<FreezeFlexBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用该接口返回对账单下载地址，对账单下载URL通过GET方式访问，返回zip包，解压后为csv格式文件。文件首行如下：
        /// 订单号,订单归属日期,机构编号,订单描述,交易类型,订单状态,支付场景,原始金额,折扣金额,实际交易金额,支付渠道优惠金额,抹零金额,币种,下单时间,付款成功时间,商户编号,门店编号,付款方式编号,付款方式名称,商户手续费T1,商户扣率,是否信用卡交易,原始订单号,用户账号,外部订单号,订单备注
        /// </summary>
        /// <param name="req"><see cref="GetBillDownloadUrlRequest"/></param>
        /// <returns><see cref="GetBillDownloadUrlResponse"/></returns>
        public async Task<GetBillDownloadUrlResponse> GetBillDownloadUrl(GetBillDownloadUrlRequest req)
        {
             JsonResponseModel<GetBillDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetBillDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBillDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用该接口返回对账单下载地址，对账单下载URL通过GET方式访问，返回zip包，解压后为csv格式文件。文件首行如下：
        /// 订单号,订单归属日期,机构编号,订单描述,交易类型,订单状态,支付场景,原始金额,折扣金额,实际交易金额,支付渠道优惠金额,抹零金额,币种,下单时间,付款成功时间,商户编号,门店编号,付款方式编号,付款方式名称,商户手续费T1,商户扣率,是否信用卡交易,原始订单号,用户账号,外部订单号,订单备注
        /// </summary>
        /// <param name="req"><see cref="GetBillDownloadUrlRequest"/></param>
        /// <returns><see cref="GetBillDownloadUrlResponse"/></returns>
        public GetBillDownloadUrlResponse GetBillDownloadUrlSync(GetBillDownloadUrlRequest req)
        {
             JsonResponseModel<GetBillDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetBillDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetBillDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用该接口返回对账单下载地址，对账单下载URL通过GET方式访问，返回zip包，解压后为csv格式文件。文件首行如下：
        /// 商户号,订单号,支付订单号,分账订单总金额,分账详情（通过|分割每笔明细：商户号1#分账金额1|商户号2#分账金额2）,交易手续费承担方商户号,交易手续费,发起时间,分账状态,结算日期,非交易主体分账金额,商户退款订单号,商户分账单号
        /// </summary>
        /// <param name="req"><see cref="GetDistributeBillDownloadUrlRequest"/></param>
        /// <returns><see cref="GetDistributeBillDownloadUrlResponse"/></returns>
        public async Task<GetDistributeBillDownloadUrlResponse> GetDistributeBillDownloadUrl(GetDistributeBillDownloadUrlRequest req)
        {
             JsonResponseModel<GetDistributeBillDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDistributeBillDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDistributeBillDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 调用该接口返回对账单下载地址，对账单下载URL通过GET方式访问，返回zip包，解压后为csv格式文件。文件首行如下：
        /// 商户号,订单号,支付订单号,分账订单总金额,分账详情（通过|分割每笔明细：商户号1#分账金额1|商户号2#分账金额2）,交易手续费承担方商户号,交易手续费,发起时间,分账状态,结算日期,非交易主体分账金额,商户退款订单号,商户分账单号
        /// </summary>
        /// <param name="req"><see cref="GetDistributeBillDownloadUrlRequest"/></param>
        /// <returns><see cref="GetDistributeBillDownloadUrlResponse"/></returns>
        public GetDistributeBillDownloadUrlResponse GetDistributeBillDownloadUrlSync(GetDistributeBillDownloadUrlRequest req)
        {
             JsonResponseModel<GetDistributeBillDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDistributeBillDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDistributeBillDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 务工卡-查询授权关系
        /// </summary>
        /// <param name="req"><see cref="GetPayRollAuthRequest"/></param>
        /// <returns><see cref="GetPayRollAuthResponse"/></returns>
        public async Task<GetPayRollAuthResponse> GetPayRollAuth(GetPayRollAuthRequest req)
        {
             JsonResponseModel<GetPayRollAuthResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPayRollAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPayRollAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 务工卡-查询授权关系
        /// </summary>
        /// <param name="req"><see cref="GetPayRollAuthRequest"/></param>
        /// <returns><see cref="GetPayRollAuthResponse"/></returns>
        public GetPayRollAuthResponse GetPayRollAuthSync(GetPayRollAuthRequest req)
        {
             JsonResponseModel<GetPayRollAuthResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPayRollAuth");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPayRollAuthResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 务工卡-查询核身记录
        /// </summary>
        /// <param name="req"><see cref="GetPayRollAuthListRequest"/></param>
        /// <returns><see cref="GetPayRollAuthListResponse"/></returns>
        public async Task<GetPayRollAuthListResponse> GetPayRollAuthList(GetPayRollAuthListRequest req)
        {
             JsonResponseModel<GetPayRollAuthListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPayRollAuthList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPayRollAuthListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 务工卡-查询核身记录
        /// </summary>
        /// <param name="req"><see cref="GetPayRollAuthListRequest"/></param>
        /// <returns><see cref="GetPayRollAuthListResponse"/></returns>
        public GetPayRollAuthListResponse GetPayRollAuthListSync(GetPayRollAuthListRequest req)
        {
             JsonResponseModel<GetPayRollAuthListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPayRollAuthList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPayRollAuthListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 务工卡-获取核身结果
        /// </summary>
        /// <param name="req"><see cref="GetPayRollAuthResultRequest"/></param>
        /// <returns><see cref="GetPayRollAuthResultResponse"/></returns>
        public async Task<GetPayRollAuthResultResponse> GetPayRollAuthResult(GetPayRollAuthResultRequest req)
        {
             JsonResponseModel<GetPayRollAuthResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPayRollAuthResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPayRollAuthResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 务工卡-获取核身结果
        /// </summary>
        /// <param name="req"><see cref="GetPayRollAuthResultRequest"/></param>
        /// <returns><see cref="GetPayRollAuthResultResponse"/></returns>
        public GetPayRollAuthResultResponse GetPayRollAuthResultSync(GetPayRollAuthResultRequest req)
        {
             JsonResponseModel<GetPayRollAuthResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPayRollAuthResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPayRollAuthResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 山姆聚合支付项目-存量订单退款接口。可以通过本接口将支付款全部或部分退还给付款方，在收到用户退款请求并且验证成功之后，按照退款规则将支付款按原路退回到支付帐号。
        /// </summary>
        /// <param name="req"><see cref="MigrateOrderRefundRequest"/></param>
        /// <returns><see cref="MigrateOrderRefundResponse"/></returns>
        public async Task<MigrateOrderRefundResponse> MigrateOrderRefund(MigrateOrderRefundRequest req)
        {
             JsonResponseModel<MigrateOrderRefundResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MigrateOrderRefund");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigrateOrderRefundResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 山姆聚合支付项目-存量订单退款接口。可以通过本接口将支付款全部或部分退还给付款方，在收到用户退款请求并且验证成功之后，按照退款规则将支付款按原路退回到支付帐号。
        /// </summary>
        /// <param name="req"><see cref="MigrateOrderRefundRequest"/></param>
        /// <returns><see cref="MigrateOrderRefundResponse"/></returns>
        public MigrateOrderRefundResponse MigrateOrderRefundSync(MigrateOrderRefundRequest req)
        {
             JsonResponseModel<MigrateOrderRefundResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MigrateOrderRefund");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigrateOrderRefundResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交退款申请后，通过调用该接口查询退款状态。退款可能有一定延时。
        /// </summary>
        /// <param name="req"><see cref="MigrateOrderRefundQueryRequest"/></param>
        /// <returns><see cref="MigrateOrderRefundQueryResponse"/></returns>
        public async Task<MigrateOrderRefundQueryResponse> MigrateOrderRefundQuery(MigrateOrderRefundQueryRequest req)
        {
             JsonResponseModel<MigrateOrderRefundQueryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "MigrateOrderRefundQuery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigrateOrderRefundQueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交退款申请后，通过调用该接口查询退款状态。退款可能有一定延时。
        /// </summary>
        /// <param name="req"><see cref="MigrateOrderRefundQueryRequest"/></param>
        /// <returns><see cref="MigrateOrderRefundQueryResponse"/></returns>
        public MigrateOrderRefundQueryResponse MigrateOrderRefundQuerySync(MigrateOrderRefundQueryRequest req)
        {
             JsonResponseModel<MigrateOrderRefundQueryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "MigrateOrderRefundQuery");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<MigrateOrderRefundQueryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-修改代理商完税信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentTaxPaymentInfoRequest"/></param>
        /// <returns><see cref="ModifyAgentTaxPaymentInfoResponse"/></returns>
        public async Task<ModifyAgentTaxPaymentInfoResponse> ModifyAgentTaxPaymentInfo(ModifyAgentTaxPaymentInfoRequest req)
        {
             JsonResponseModel<ModifyAgentTaxPaymentInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAgentTaxPaymentInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAgentTaxPaymentInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-修改代理商完税信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentTaxPaymentInfoRequest"/></param>
        /// <returns><see cref="ModifyAgentTaxPaymentInfoResponse"/></returns>
        public ModifyAgentTaxPaymentInfoResponse ModifyAgentTaxPaymentInfoSync(ModifyAgentTaxPaymentInfoRequest req)
        {
             JsonResponseModel<ModifyAgentTaxPaymentInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAgentTaxPaymentInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAgentTaxPaymentInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-重新绑定账号
        /// </summary>
        /// <param name="req"><see cref="ModifyBindedAccountRequest"/></param>
        /// <returns><see cref="ModifyBindedAccountResponse"/></returns>
        public async Task<ModifyBindedAccountResponse> ModifyBindedAccount(ModifyBindedAccountRequest req)
        {
             JsonResponseModel<ModifyBindedAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyBindedAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBindedAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-重新绑定账号
        /// </summary>
        /// <param name="req"><see cref="ModifyBindedAccountRequest"/></param>
        /// <returns><see cref="ModifyBindedAccountResponse"/></returns>
        public ModifyBindedAccountResponse ModifyBindedAccountSync(ModifyBindedAccountRequest req)
        {
             JsonResponseModel<ModifyBindedAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyBindedAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyBindedAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-收款用户账户权益状态修改
        /// </summary>
        /// <param name="req"><see cref="ModifyFlexPayeeAccountRightStatusRequest"/></param>
        /// <returns><see cref="ModifyFlexPayeeAccountRightStatusResponse"/></returns>
        public async Task<ModifyFlexPayeeAccountRightStatusResponse> ModifyFlexPayeeAccountRightStatus(ModifyFlexPayeeAccountRightStatusRequest req)
        {
             JsonResponseModel<ModifyFlexPayeeAccountRightStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyFlexPayeeAccountRightStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFlexPayeeAccountRightStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-收款用户账户权益状态修改
        /// </summary>
        /// <param name="req"><see cref="ModifyFlexPayeeAccountRightStatusRequest"/></param>
        /// <returns><see cref="ModifyFlexPayeeAccountRightStatusResponse"/></returns>
        public ModifyFlexPayeeAccountRightStatusResponse ModifyFlexPayeeAccountRightStatusSync(ModifyFlexPayeeAccountRightStatusRequest req)
        {
             JsonResponseModel<ModifyFlexPayeeAccountRightStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyFlexPayeeAccountRightStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyFlexPayeeAccountRightStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云鉴-商户信息修改的接口
        /// </summary>
        /// <param name="req"><see cref="ModifyMerchantRequest"/></param>
        /// <returns><see cref="ModifyMerchantResponse"/></returns>
        public async Task<ModifyMerchantResponse> ModifyMerchant(ModifyMerchantRequest req)
        {
             JsonResponseModel<ModifyMerchantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云鉴-商户信息修改的接口
        /// </summary>
        /// <param name="req"><see cref="ModifyMerchantRequest"/></param>
        /// <returns><see cref="ModifyMerchantResponse"/></returns>
        public ModifyMerchantResponse ModifyMerchantSync(ModifyMerchantRequest req)
        {
             JsonResponseModel<ModifyMerchantResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 维护会员绑定提现账户联行号。此接口可以支持市场修改会员的提现账户的开户行信息，具体包括开户行行名、开户行的银行联行号（大小额联行号）和超级网银行号。
        /// </summary>
        /// <param name="req"><see cref="ModifyMntMbrBindRelateAcctBankCodeRequest"/></param>
        /// <returns><see cref="ModifyMntMbrBindRelateAcctBankCodeResponse"/></returns>
        public async Task<ModifyMntMbrBindRelateAcctBankCodeResponse> ModifyMntMbrBindRelateAcctBankCode(ModifyMntMbrBindRelateAcctBankCodeRequest req)
        {
             JsonResponseModel<ModifyMntMbrBindRelateAcctBankCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMntMbrBindRelateAcctBankCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMntMbrBindRelateAcctBankCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 维护会员绑定提现账户联行号。此接口可以支持市场修改会员的提现账户的开户行信息，具体包括开户行行名、开户行的银行联行号（大小额联行号）和超级网银行号。
        /// </summary>
        /// <param name="req"><see cref="ModifyMntMbrBindRelateAcctBankCodeRequest"/></param>
        /// <returns><see cref="ModifyMntMbrBindRelateAcctBankCodeResponse"/></returns>
        public ModifyMntMbrBindRelateAcctBankCodeResponse ModifyMntMbrBindRelateAcctBankCodeSync(ModifyMntMbrBindRelateAcctBankCodeRequest req)
        {
             JsonResponseModel<ModifyMntMbrBindRelateAcctBankCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMntMbrBindRelateAcctBankCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMntMbrBindRelateAcctBankCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 聚鑫-查询子账户绑定银行卡
        /// </summary>
        /// <param name="req"><see cref="QueryAcctBindingRequest"/></param>
        /// <returns><see cref="QueryAcctBindingResponse"/></returns>
        public async Task<QueryAcctBindingResponse> QueryAcctBinding(QueryAcctBindingRequest req)
        {
             JsonResponseModel<QueryAcctBindingResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryAcctBinding");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAcctBindingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 聚鑫-查询子账户绑定银行卡
        /// </summary>
        /// <param name="req"><see cref="QueryAcctBindingRequest"/></param>
        /// <returns><see cref="QueryAcctBindingResponse"/></returns>
        public QueryAcctBindingResponse QueryAcctBindingSync(QueryAcctBindingRequest req)
        {
             JsonResponseModel<QueryAcctBindingResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryAcctBinding");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAcctBindingResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 聚鑫-开户信息查询
        /// </summary>
        /// <param name="req"><see cref="QueryAcctInfoRequest"/></param>
        /// <returns><see cref="QueryAcctInfoResponse"/></returns>
        public async Task<QueryAcctInfoResponse> QueryAcctInfo(QueryAcctInfoRequest req)
        {
             JsonResponseModel<QueryAcctInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryAcctInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAcctInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 聚鑫-开户信息查询
        /// </summary>
        /// <param name="req"><see cref="QueryAcctInfoRequest"/></param>
        /// <returns><see cref="QueryAcctInfoResponse"/></returns>
        public QueryAcctInfoResponse QueryAcctInfoSync(QueryAcctInfoRequest req)
        {
             JsonResponseModel<QueryAcctInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryAcctInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAcctInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 聚鑫-开户信息列表查询, 查询某一段时间的开户信息
        /// </summary>
        /// <param name="req"><see cref="QueryAcctInfoListRequest"/></param>
        /// <returns><see cref="QueryAcctInfoListResponse"/></returns>
        public async Task<QueryAcctInfoListResponse> QueryAcctInfoList(QueryAcctInfoListRequest req)
        {
             JsonResponseModel<QueryAcctInfoListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryAcctInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAcctInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 聚鑫-开户信息列表查询, 查询某一段时间的开户信息
        /// </summary>
        /// <param name="req"><see cref="QueryAcctInfoListRequest"/></param>
        /// <returns><see cref="QueryAcctInfoListResponse"/></returns>
        public QueryAcctInfoListResponse QueryAcctInfoListSync(QueryAcctInfoListRequest req)
        {
             JsonResponseModel<QueryAcctInfoListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryAcctInfoList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAcctInfoListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-查询代理商结算单链接
        /// </summary>
        /// <param name="req"><see cref="QueryAgentStatementsRequest"/></param>
        /// <returns><see cref="QueryAgentStatementsResponse"/></returns>
        public async Task<QueryAgentStatementsResponse> QueryAgentStatements(QueryAgentStatementsRequest req)
        {
             JsonResponseModel<QueryAgentStatementsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryAgentStatements");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAgentStatementsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-查询代理商结算单链接
        /// </summary>
        /// <param name="req"><see cref="QueryAgentStatementsRequest"/></param>
        /// <returns><see cref="QueryAgentStatementsResponse"/></returns>
        public QueryAgentStatementsResponse QueryAgentStatementsSync(QueryAgentStatementsRequest req)
        {
             JsonResponseModel<QueryAgentStatementsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryAgentStatements");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAgentStatementsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-查询批次信息
        /// </summary>
        /// <param name="req"><see cref="QueryAgentTaxPaymentBatchRequest"/></param>
        /// <returns><see cref="QueryAgentTaxPaymentBatchResponse"/></returns>
        public async Task<QueryAgentTaxPaymentBatchResponse> QueryAgentTaxPaymentBatch(QueryAgentTaxPaymentBatchRequest req)
        {
             JsonResponseModel<QueryAgentTaxPaymentBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryAgentTaxPaymentBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAgentTaxPaymentBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-查询批次信息
        /// </summary>
        /// <param name="req"><see cref="QueryAgentTaxPaymentBatchRequest"/></param>
        /// <returns><see cref="QueryAgentTaxPaymentBatchResponse"/></returns>
        public QueryAgentTaxPaymentBatchResponse QueryAgentTaxPaymentBatchSync(QueryAgentTaxPaymentBatchRequest req)
        {
             JsonResponseModel<QueryAgentTaxPaymentBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryAgentTaxPaymentBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAgentTaxPaymentBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-查询主播签约信息
        /// </summary>
        /// <param name="req"><see cref="QueryAnchorContractInfoRequest"/></param>
        /// <returns><see cref="QueryAnchorContractInfoResponse"/></returns>
        public async Task<QueryAnchorContractInfoResponse> QueryAnchorContractInfo(QueryAnchorContractInfoRequest req)
        {
             JsonResponseModel<QueryAnchorContractInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryAnchorContractInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAnchorContractInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-查询主播签约信息
        /// </summary>
        /// <param name="req"><see cref="QueryAnchorContractInfoRequest"/></param>
        /// <returns><see cref="QueryAnchorContractInfoResponse"/></returns>
        public QueryAnchorContractInfoResponse QueryAnchorContractInfoSync(QueryAnchorContractInfoRequest req)
        {
             JsonResponseModel<QueryAnchorContractInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryAnchorContractInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAnchorContractInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-成功申报材料查询。查询成功入库的申报材料。
        /// </summary>
        /// <param name="req"><see cref="QueryApplicationMaterialRequest"/></param>
        /// <returns><see cref="QueryApplicationMaterialResponse"/></returns>
        public async Task<QueryApplicationMaterialResponse> QueryApplicationMaterial(QueryApplicationMaterialRequest req)
        {
             JsonResponseModel<QueryApplicationMaterialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryApplicationMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryApplicationMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-成功申报材料查询。查询成功入库的申报材料。
        /// </summary>
        /// <param name="req"><see cref="QueryApplicationMaterialRequest"/></param>
        /// <returns><see cref="QueryApplicationMaterialResponse"/></returns>
        public QueryApplicationMaterialResponse QueryApplicationMaterialSync(QueryApplicationMaterialRequest req)
        {
             JsonResponseModel<QueryApplicationMaterialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryApplicationMaterial");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryApplicationMaterialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-查询分配关系
        /// </summary>
        /// <param name="req"><see cref="QueryAssignmentRequest"/></param>
        /// <returns><see cref="QueryAssignmentResponse"/></returns>
        public async Task<QueryAssignmentResponse> QueryAssignment(QueryAssignmentRequest req)
        {
             JsonResponseModel<QueryAssignmentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryAssignment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAssignmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-查询分配关系
        /// </summary>
        /// <param name="req"><see cref="QueryAssignmentRequest"/></param>
        /// <returns><see cref="QueryAssignmentResponse"/></returns>
        public QueryAssignmentResponse QueryAssignmentSync(QueryAssignmentRequest req)
        {
             JsonResponseModel<QueryAssignmentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryAssignment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryAssignmentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 子商户余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryBalanceRequest"/></param>
        /// <returns><see cref="QueryBalanceResponse"/></returns>
        public async Task<QueryBalanceResponse> QueryBalance(QueryBalanceRequest req)
        {
             JsonResponseModel<QueryBalanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 子商户余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryBalanceRequest"/></param>
        /// <returns><see cref="QueryBalanceResponse"/></returns>
        public QueryBalanceResponse QueryBalanceSync(QueryBalanceRequest req)
        {
             JsonResponseModel<QueryBalanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询银行在途清算结果。查询时间段内交易网的在途清算结果。
        /// </summary>
        /// <param name="req"><see cref="QueryBankClearRequest"/></param>
        /// <returns><see cref="QueryBankClearResponse"/></returns>
        public async Task<QueryBankClearResponse> QueryBankClear(QueryBankClearRequest req)
        {
             JsonResponseModel<QueryBankClearResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryBankClear");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBankClearResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询银行在途清算结果。查询时间段内交易网的在途清算结果。
        /// </summary>
        /// <param name="req"><see cref="QueryBankClearRequest"/></param>
        /// <returns><see cref="QueryBankClearResponse"/></returns>
        public QueryBankClearResponse QueryBankClearSync(QueryBankClearRequest req)
        {
             JsonResponseModel<QueryBankClearResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryBankClear");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBankClearResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询银行时间段内交易明细。查询时间段的会员成功交易。
        /// </summary>
        /// <param name="req"><see cref="QueryBankTransactionDetailsRequest"/></param>
        /// <returns><see cref="QueryBankTransactionDetailsResponse"/></returns>
        public async Task<QueryBankTransactionDetailsResponse> QueryBankTransactionDetails(QueryBankTransactionDetailsRequest req)
        {
             JsonResponseModel<QueryBankTransactionDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryBankTransactionDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBankTransactionDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询银行时间段内交易明细。查询时间段的会员成功交易。
        /// </summary>
        /// <param name="req"><see cref="QueryBankTransactionDetailsRequest"/></param>
        /// <returns><see cref="QueryBankTransactionDetailsResponse"/></returns>
        public QueryBankTransactionDetailsResponse QueryBankTransactionDetailsSync(QueryBankTransactionDetailsRequest req)
        {
             JsonResponseModel<QueryBankTransactionDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryBankTransactionDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBankTransactionDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询银行时间段内清分提现明细。查询银行时间段内清分提现明细接口：若为“见证+收单退款”“见证+收单充值”记录时备注Note为“见证+收单充值,订单号”“见证+收单退款,订单号”，此接口可以查到T0/T1的充值明细和退款记录。查询标志：充值记录仍用3清分选项查询，退款记录同提现用2选项查询。
        /// </summary>
        /// <param name="req"><see cref="QueryBankWithdrawCashDetailsRequest"/></param>
        /// <returns><see cref="QueryBankWithdrawCashDetailsResponse"/></returns>
        public async Task<QueryBankWithdrawCashDetailsResponse> QueryBankWithdrawCashDetails(QueryBankWithdrawCashDetailsRequest req)
        {
             JsonResponseModel<QueryBankWithdrawCashDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryBankWithdrawCashDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBankWithdrawCashDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询银行时间段内清分提现明细。查询银行时间段内清分提现明细接口：若为“见证+收单退款”“见证+收单充值”记录时备注Note为“见证+收单充值,订单号”“见证+收单退款,订单号”，此接口可以查到T0/T1的充值明细和退款记录。查询标志：充值记录仍用3清分选项查询，退款记录同提现用2选项查询。
        /// </summary>
        /// <param name="req"><see cref="QueryBankWithdrawCashDetailsRequest"/></param>
        /// <returns><see cref="QueryBankWithdrawCashDetailsResponse"/></returns>
        public QueryBankWithdrawCashDetailsResponse QueryBankWithdrawCashDetailsSync(QueryBankWithdrawCashDetailsRequest req)
        {
             JsonResponseModel<QueryBankWithdrawCashDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryBankWithdrawCashDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBankWithdrawCashDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-批量转账结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryBatchPaymentResultRequest"/></param>
        /// <returns><see cref="QueryBatchPaymentResultResponse"/></returns>
        public async Task<QueryBatchPaymentResultResponse> QueryBatchPaymentResult(QueryBatchPaymentResultRequest req)
        {
             JsonResponseModel<QueryBatchPaymentResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryBatchPaymentResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBatchPaymentResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-批量转账结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryBatchPaymentResultRequest"/></param>
        /// <returns><see cref="QueryBatchPaymentResultResponse"/></returns>
        public QueryBatchPaymentResultResponse QueryBatchPaymentResultSync(QueryBatchPaymentResultRequest req)
        {
             JsonResponseModel<QueryBatchPaymentResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryBatchPaymentResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBatchPaymentResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单笔代发转账对账单下载URL
        /// </summary>
        /// <param name="req"><see cref="QueryBillDownloadURLRequest"/></param>
        /// <returns><see cref="QueryBillDownloadURLResponse"/></returns>
        public async Task<QueryBillDownloadURLResponse> QueryBillDownloadURL(QueryBillDownloadURLRequest req)
        {
             JsonResponseModel<QueryBillDownloadURLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryBillDownloadURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBillDownloadURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单笔代发转账对账单下载URL
        /// </summary>
        /// <param name="req"><see cref="QueryBillDownloadURLRequest"/></param>
        /// <returns><see cref="QueryBillDownloadURLResponse"/></returns>
        public QueryBillDownloadURLResponse QueryBillDownloadURLSync(QueryBillDownloadURLRequest req)
        {
             JsonResponseModel<QueryBillDownloadURLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryBillDownloadURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryBillDownloadURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询城市编码接口
        /// </summary>
        /// <param name="req"><see cref="QueryCityCodeRequest"/></param>
        /// <returns><see cref="QueryCityCodeResponse"/></returns>
        public async Task<QueryCityCodeResponse> QueryCityCode(QueryCityCodeRequest req)
        {
             JsonResponseModel<QueryCityCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCityCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCityCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询城市编码接口
        /// </summary>
        /// <param name="req"><see cref="QueryCityCodeRequest"/></param>
        /// <returns><see cref="QueryCityCodeResponse"/></returns>
        public QueryCityCodeResponse QueryCityCodeSync(QueryCityCodeRequest req)
        {
             JsonResponseModel<QueryCityCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCityCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCityCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发起支付等渠道操作后，可以调用该接口查询渠道的数据。
        /// </summary>
        /// <param name="req"><see cref="QueryCloudChannelDataRequest"/></param>
        /// <returns><see cref="QueryCloudChannelDataResponse"/></returns>
        public async Task<QueryCloudChannelDataResponse> QueryCloudChannelData(QueryCloudChannelDataRequest req)
        {
             JsonResponseModel<QueryCloudChannelDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCloudChannelData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCloudChannelDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发起支付等渠道操作后，可以调用该接口查询渠道的数据。
        /// </summary>
        /// <param name="req"><see cref="QueryCloudChannelDataRequest"/></param>
        /// <returns><see cref="QueryCloudChannelDataResponse"/></returns>
        public QueryCloudChannelDataResponse QueryCloudChannelDataSync(QueryCloudChannelDataRequest req)
        {
             JsonResponseModel<QueryCloudChannelDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCloudChannelData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCloudChannelDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据订单号或用户ID，查询支付订单状态。
        /// </summary>
        /// <param name="req"><see cref="QueryCloudOrderRequest"/></param>
        /// <returns><see cref="QueryCloudOrderResponse"/></returns>
        public async Task<QueryCloudOrderResponse> QueryCloudOrder(QueryCloudOrderRequest req)
        {
             JsonResponseModel<QueryCloudOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCloudOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCloudOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据订单号或用户ID，查询支付订单状态。
        /// </summary>
        /// <param name="req"><see cref="QueryCloudOrderRequest"/></param>
        /// <returns><see cref="QueryCloudOrderResponse"/></returns>
        public QueryCloudOrderResponse QueryCloudOrderSync(QueryCloudOrderRequest req)
        {
             JsonResponseModel<QueryCloudOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCloudOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCloudOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交退款申请后，通过调用该接口查询退款状态。退款可能有一定延时，用微信零钱支付的退款约20分钟内到账，银行卡支付的退款约3个工作日后到账。
        /// </summary>
        /// <param name="req"><see cref="QueryCloudRefundOrderRequest"/></param>
        /// <returns><see cref="QueryCloudRefundOrderResponse"/></returns>
        public async Task<QueryCloudRefundOrderResponse> QueryCloudRefundOrder(QueryCloudRefundOrderRequest req)
        {
             JsonResponseModel<QueryCloudRefundOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCloudRefundOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCloudRefundOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交退款申请后，通过调用该接口查询退款状态。退款可能有一定延时，用微信零钱支付的退款约20分钟内到账，银行卡支付的退款约3个工作日后到账。
        /// </summary>
        /// <param name="req"><see cref="QueryCloudRefundOrderRequest"/></param>
        /// <returns><see cref="QueryCloudRefundOrderResponse"/></returns>
        public QueryCloudRefundOrderResponse QueryCloudRefundOrderSync(QueryCloudRefundOrderRequest req)
        {
             JsonResponseModel<QueryCloudRefundOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCloudRefundOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCloudRefundOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询普通转账充值明细。接口用于查询会员主动转账进资金汇总账户的明细情况。若会员使用绑定账号转入，则直接入账到会员子账户。若未使用绑定账号转入，则系统无法自动清分到对应子账户，则转入挂账子账户由平台自行清分。若是 “见证+收单充值”T0充值记录时备注Note为“见证+收单充值,订单号” 此接口可以查到T0到账的“见证+收单充值”充值记录。
        /// </summary>
        /// <param name="req"><see cref="QueryCommonTransferRechargeRequest"/></param>
        /// <returns><see cref="QueryCommonTransferRechargeResponse"/></returns>
        public async Task<QueryCommonTransferRechargeResponse> QueryCommonTransferRecharge(QueryCommonTransferRechargeRequest req)
        {
             JsonResponseModel<QueryCommonTransferRechargeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCommonTransferRecharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCommonTransferRechargeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询普通转账充值明细。接口用于查询会员主动转账进资金汇总账户的明细情况。若会员使用绑定账号转入，则直接入账到会员子账户。若未使用绑定账号转入，则系统无法自动清分到对应子账户，则转入挂账子账户由平台自行清分。若是 “见证+收单充值”T0充值记录时备注Note为“见证+收单充值,订单号” 此接口可以查到T0到账的“见证+收单充值”充值记录。
        /// </summary>
        /// <param name="req"><see cref="QueryCommonTransferRechargeRequest"/></param>
        /// <returns><see cref="QueryCommonTransferRechargeResponse"/></returns>
        public QueryCommonTransferRechargeResponse QueryCommonTransferRechargeSync(QueryCommonTransferRechargeRequest req)
        {
             JsonResponseModel<QueryCommonTransferRechargeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCommonTransferRecharge");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCommonTransferRechargeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-查询公司抬头
        /// </summary>
        /// <param name="req"><see cref="QueryCompanyTitleRequest"/></param>
        /// <returns><see cref="QueryCompanyTitleResponse"/></returns>
        public async Task<QueryCompanyTitleResponse> QueryCompanyTitle(QueryCompanyTitleRequest req)
        {
             JsonResponseModel<QueryCompanyTitleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCompanyTitle");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCompanyTitleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-查询公司抬头
        /// </summary>
        /// <param name="req"><see cref="QueryCompanyTitleRequest"/></param>
        /// <returns><see cref="QueryCompanyTitleResponse"/></returns>
        public QueryCompanyTitleResponse QueryCompanyTitleSync(QueryCompanyTitleRequest req)
        {
             JsonResponseModel<QueryCompanyTitleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCompanyTitle");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCompanyTitleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口查询签约数据
        /// </summary>
        /// <param name="req"><see cref="QueryContractRequest"/></param>
        /// <returns><see cref="QueryContractResponse"/></returns>
        public async Task<QueryContractResponse> QueryContract(QueryContractRequest req)
        {
             JsonResponseModel<QueryContractResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口查询签约数据
        /// </summary>
        /// <param name="req"><see cref="QueryContractRequest"/></param>
        /// <returns><see cref="QueryContractResponse"/></returns>
        public QueryContractResponse QueryContractSync(QueryContractRequest req)
        {
             JsonResponseModel<QueryContractResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询支付方式费率及自定义表单项接口
        /// </summary>
        /// <param name="req"><see cref="QueryContractPayFeeRequest"/></param>
        /// <returns><see cref="QueryContractPayFeeResponse"/></returns>
        public async Task<QueryContractPayFeeResponse> QueryContractPayFee(QueryContractPayFeeRequest req)
        {
             JsonResponseModel<QueryContractPayFeeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryContractPayFee");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryContractPayFeeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询支付方式费率及自定义表单项接口
        /// </summary>
        /// <param name="req"><see cref="QueryContractPayFeeRequest"/></param>
        /// <returns><see cref="QueryContractPayFeeResponse"/></returns>
        public QueryContractPayFeeResponse QueryContractPayFeeSync(QueryContractPayFeeRequest req)
        {
             JsonResponseModel<QueryContractPayFeeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryContractPayFee");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryContractPayFeeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询合同支付方式列表接口
        /// </summary>
        /// <param name="req"><see cref="QueryContractPayWayListRequest"/></param>
        /// <returns><see cref="QueryContractPayWayListResponse"/></returns>
        public async Task<QueryContractPayWayListResponse> QueryContractPayWayList(QueryContractPayWayListRequest req)
        {
             JsonResponseModel<QueryContractPayWayListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryContractPayWayList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryContractPayWayListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询合同支付方式列表接口
        /// </summary>
        /// <param name="req"><see cref="QueryContractPayWayListRequest"/></param>
        /// <returns><see cref="QueryContractPayWayListResponse"/></returns>
        public QueryContractPayWayListResponse QueryContractPayWayListSync(QueryContractPayWayListRequest req)
        {
             JsonResponseModel<QueryContractPayWayListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryContractPayWayList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryContractPayWayListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询合同可关联门店接口
        /// </summary>
        /// <param name="req"><see cref="QueryContractRelateShopRequest"/></param>
        /// <returns><see cref="QueryContractRelateShopResponse"/></returns>
        public async Task<QueryContractRelateShopResponse> QueryContractRelateShop(QueryContractRelateShopRequest req)
        {
             JsonResponseModel<QueryContractRelateShopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryContractRelateShop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryContractRelateShopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询合同可关联门店接口
        /// </summary>
        /// <param name="req"><see cref="QueryContractRelateShopRequest"/></param>
        /// <returns><see cref="QueryContractRelateShopResponse"/></returns>
        public QueryContractRelateShopResponse QueryContractRelateShopSync(QueryContractRelateShopRequest req)
        {
             JsonResponseModel<QueryContractRelateShopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryContractRelateShop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryContractRelateShopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询银行子账户余额。查询会员子账户以及平台的功能子账户的余额。
        /// </summary>
        /// <param name="req"><see cref="QueryCustAcctIdBalanceRequest"/></param>
        /// <returns><see cref="QueryCustAcctIdBalanceResponse"/></returns>
        public async Task<QueryCustAcctIdBalanceResponse> QueryCustAcctIdBalance(QueryCustAcctIdBalanceRequest req)
        {
             JsonResponseModel<QueryCustAcctIdBalanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryCustAcctIdBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCustAcctIdBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询银行子账户余额。查询会员子账户以及平台的功能子账户的余额。
        /// </summary>
        /// <param name="req"><see cref="QueryCustAcctIdBalanceRequest"/></param>
        /// <returns><see cref="QueryCustAcctIdBalanceResponse"/></returns>
        public QueryCustAcctIdBalanceResponse QueryCustAcctIdBalanceSync(QueryCustAcctIdBalanceRequest req)
        {
             JsonResponseModel<QueryCustAcctIdBalanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryCustAcctIdBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryCustAcctIdBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云鉴-查询对账单下载地址的接口
        /// </summary>
        /// <param name="req"><see cref="QueryDownloadBillURLRequest"/></param>
        /// <returns><see cref="QueryDownloadBillURLResponse"/></returns>
        public async Task<QueryDownloadBillURLResponse> QueryDownloadBillURL(QueryDownloadBillURLRequest req)
        {
             JsonResponseModel<QueryDownloadBillURLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryDownloadBillURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryDownloadBillURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云鉴-查询对账单下载地址的接口
        /// </summary>
        /// <param name="req"><see cref="QueryDownloadBillURLRequest"/></param>
        /// <returns><see cref="QueryDownloadBillURLResponse"/></returns>
        public QueryDownloadBillURLResponse QueryDownloadBillURLSync(QueryDownloadBillURLRequest req)
        {
             JsonResponseModel<QueryDownloadBillURLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryDownloadBillURL");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryDownloadBillURLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-查询超额信息
        /// </summary>
        /// <param name="req"><see cref="QueryExceedingInfoRequest"/></param>
        /// <returns><see cref="QueryExceedingInfoResponse"/></returns>
        public async Task<QueryExceedingInfoResponse> QueryExceedingInfo(QueryExceedingInfoRequest req)
        {
             JsonResponseModel<QueryExceedingInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryExceedingInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryExceedingInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-查询超额信息
        /// </summary>
        /// <param name="req"><see cref="QueryExceedingInfoRequest"/></param>
        /// <returns><see cref="QueryExceedingInfoResponse"/></returns>
        public QueryExceedingInfoResponse QueryExceedingInfoSync(QueryExceedingInfoRequest req)
        {
             JsonResponseModel<QueryExceedingInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryExceedingInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryExceedingInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-查询汇率
        /// </summary>
        /// <param name="req"><see cref="QueryExchangeRateRequest"/></param>
        /// <returns><see cref="QueryExchangeRateResponse"/></returns>
        public async Task<QueryExchangeRateResponse> QueryExchangeRate(QueryExchangeRateRequest req)
        {
             JsonResponseModel<QueryExchangeRateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryExchangeRate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryExchangeRateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-查询汇率
        /// </summary>
        /// <param name="req"><see cref="QueryExchangeRateRequest"/></param>
        /// <returns><see cref="QueryExchangeRateResponse"/></returns>
        public QueryExchangeRateResponse QueryExchangeRateSync(QueryExchangeRateRequest req)
        {
             JsonResponseModel<QueryExchangeRateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryExchangeRate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryExchangeRateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 财税-查询金融数据文件下载链接
        /// </summary>
        /// <param name="req"><see cref="QueryFinancialDataUrlRequest"/></param>
        /// <returns><see cref="QueryFinancialDataUrlResponse"/></returns>
        public async Task<QueryFinancialDataUrlResponse> QueryFinancialDataUrl(QueryFinancialDataUrlRequest req)
        {
             JsonResponseModel<QueryFinancialDataUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryFinancialDataUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFinancialDataUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 财税-查询金融数据文件下载链接
        /// </summary>
        /// <param name="req"><see cref="QueryFinancialDataUrlRequest"/></param>
        /// <returns><see cref="QueryFinancialDataUrlResponse"/></returns>
        public QueryFinancialDataUrlResponse QueryFinancialDataUrlSync(QueryFinancialDataUrlRequest req)
        {
             JsonResponseModel<QueryFinancialDataUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryFinancialDataUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFinancialDataUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-查询税前金额
        /// </summary>
        /// <param name="req"><see cref="QueryFlexAmountBeforeTaxRequest"/></param>
        /// <returns><see cref="QueryFlexAmountBeforeTaxResponse"/></returns>
        public async Task<QueryFlexAmountBeforeTaxResponse> QueryFlexAmountBeforeTax(QueryFlexAmountBeforeTaxRequest req)
        {
             JsonResponseModel<QueryFlexAmountBeforeTaxResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryFlexAmountBeforeTax");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexAmountBeforeTaxResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-查询税前金额
        /// </summary>
        /// <param name="req"><see cref="QueryFlexAmountBeforeTaxRequest"/></param>
        /// <returns><see cref="QueryFlexAmountBeforeTaxResponse"/></returns>
        public QueryFlexAmountBeforeTaxResponse QueryFlexAmountBeforeTaxSync(QueryFlexAmountBeforeTaxRequest req)
        {
             JsonResponseModel<QueryFlexAmountBeforeTaxResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryFlexAmountBeforeTax");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexAmountBeforeTaxResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-查询对账单文件下载链接
        /// </summary>
        /// <param name="req"><see cref="QueryFlexBillDownloadUrlRequest"/></param>
        /// <returns><see cref="QueryFlexBillDownloadUrlResponse"/></returns>
        public async Task<QueryFlexBillDownloadUrlResponse> QueryFlexBillDownloadUrl(QueryFlexBillDownloadUrlRequest req)
        {
             JsonResponseModel<QueryFlexBillDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryFlexBillDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexBillDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-查询对账单文件下载链接
        /// </summary>
        /// <param name="req"><see cref="QueryFlexBillDownloadUrlRequest"/></param>
        /// <returns><see cref="QueryFlexBillDownloadUrlResponse"/></returns>
        public QueryFlexBillDownloadUrlResponse QueryFlexBillDownloadUrlSync(QueryFlexBillDownloadUrlRequest req)
        {
             JsonResponseModel<QueryFlexBillDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryFlexBillDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexBillDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-查询冻结订单列表
        /// </summary>
        /// <param name="req"><see cref="QueryFlexFreezeOrderListRequest"/></param>
        /// <returns><see cref="QueryFlexFreezeOrderListResponse"/></returns>
        public async Task<QueryFlexFreezeOrderListResponse> QueryFlexFreezeOrderList(QueryFlexFreezeOrderListRequest req)
        {
             JsonResponseModel<QueryFlexFreezeOrderListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryFlexFreezeOrderList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexFreezeOrderListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-查询冻结订单列表
        /// </summary>
        /// <param name="req"><see cref="QueryFlexFreezeOrderListRequest"/></param>
        /// <returns><see cref="QueryFlexFreezeOrderListResponse"/></returns>
        public QueryFlexFreezeOrderListResponse QueryFlexFreezeOrderListSync(QueryFlexFreezeOrderListRequest req)
        {
             JsonResponseModel<QueryFlexFreezeOrderListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryFlexFreezeOrderList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexFreezeOrderListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-订单汇总列表查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexOrderSummaryListRequest"/></param>
        /// <returns><see cref="QueryFlexOrderSummaryListResponse"/></returns>
        public async Task<QueryFlexOrderSummaryListResponse> QueryFlexOrderSummaryList(QueryFlexOrderSummaryListRequest req)
        {
             JsonResponseModel<QueryFlexOrderSummaryListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryFlexOrderSummaryList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexOrderSummaryListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-订单汇总列表查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexOrderSummaryListRequest"/></param>
        /// <returns><see cref="QueryFlexOrderSummaryListResponse"/></returns>
        public QueryFlexOrderSummaryListResponse QueryFlexOrderSummaryListSync(QueryFlexOrderSummaryListRequest req)
        {
             JsonResponseModel<QueryFlexOrderSummaryListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryFlexOrderSummaryList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexOrderSummaryListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-收款用户账户余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeAccountBalanceRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeAccountBalanceResponse"/></returns>
        public async Task<QueryFlexPayeeAccountBalanceResponse> QueryFlexPayeeAccountBalance(QueryFlexPayeeAccountBalanceRequest req)
        {
             JsonResponseModel<QueryFlexPayeeAccountBalanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryFlexPayeeAccountBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexPayeeAccountBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-收款用户账户余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeAccountBalanceRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeAccountBalanceResponse"/></returns>
        public QueryFlexPayeeAccountBalanceResponse QueryFlexPayeeAccountBalanceSync(QueryFlexPayeeAccountBalanceRequest req)
        {
             JsonResponseModel<QueryFlexPayeeAccountBalanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryFlexPayeeAccountBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexPayeeAccountBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-收款用户账户信息查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeAccountInfoRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeAccountInfoResponse"/></returns>
        public async Task<QueryFlexPayeeAccountInfoResponse> QueryFlexPayeeAccountInfo(QueryFlexPayeeAccountInfoRequest req)
        {
             JsonResponseModel<QueryFlexPayeeAccountInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryFlexPayeeAccountInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexPayeeAccountInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-收款用户账户信息查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeAccountInfoRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeAccountInfoResponse"/></returns>
        public QueryFlexPayeeAccountInfoResponse QueryFlexPayeeAccountInfoSync(QueryFlexPayeeAccountInfoRequest req)
        {
             JsonResponseModel<QueryFlexPayeeAccountInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryFlexPayeeAccountInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexPayeeAccountInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-收款用户账户列表查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeAccountListRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeAccountListResponse"/></returns>
        public async Task<QueryFlexPayeeAccountListResponse> QueryFlexPayeeAccountList(QueryFlexPayeeAccountListRequest req)
        {
             JsonResponseModel<QueryFlexPayeeAccountListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryFlexPayeeAccountList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexPayeeAccountListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-收款用户账户列表查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeAccountListRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeAccountListResponse"/></returns>
        public QueryFlexPayeeAccountListResponse QueryFlexPayeeAccountListSync(QueryFlexPayeeAccountListRequest req)
        {
             JsonResponseModel<QueryFlexPayeeAccountListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryFlexPayeeAccountList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexPayeeAccountListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-收款用户信息查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeInfoRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeInfoResponse"/></returns>
        public async Task<QueryFlexPayeeInfoResponse> QueryFlexPayeeInfo(QueryFlexPayeeInfoRequest req)
        {
             JsonResponseModel<QueryFlexPayeeInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryFlexPayeeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexPayeeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-收款用户信息查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeInfoRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeInfoResponse"/></returns>
        public QueryFlexPayeeInfoResponse QueryFlexPayeeInfoSync(QueryFlexPayeeInfoRequest req)
        {
             JsonResponseModel<QueryFlexPayeeInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryFlexPayeeInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexPayeeInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-查询付款订单列表
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPaymentOrderListRequest"/></param>
        /// <returns><see cref="QueryFlexPaymentOrderListResponse"/></returns>
        public async Task<QueryFlexPaymentOrderListResponse> QueryFlexPaymentOrderList(QueryFlexPaymentOrderListRequest req)
        {
             JsonResponseModel<QueryFlexPaymentOrderListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryFlexPaymentOrderList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexPaymentOrderListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-查询付款订单列表
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPaymentOrderListRequest"/></param>
        /// <returns><see cref="QueryFlexPaymentOrderListResponse"/></returns>
        public QueryFlexPaymentOrderListResponse QueryFlexPaymentOrderListSync(QueryFlexPaymentOrderListRequest req)
        {
             JsonResponseModel<QueryFlexPaymentOrderListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryFlexPaymentOrderList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexPaymentOrderListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-查询付款订单状态
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPaymentOrderStatusRequest"/></param>
        /// <returns><see cref="QueryFlexPaymentOrderStatusResponse"/></returns>
        public async Task<QueryFlexPaymentOrderStatusResponse> QueryFlexPaymentOrderStatus(QueryFlexPaymentOrderStatusRequest req)
        {
             JsonResponseModel<QueryFlexPaymentOrderStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryFlexPaymentOrderStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexPaymentOrderStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-查询付款订单状态
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPaymentOrderStatusRequest"/></param>
        /// <returns><see cref="QueryFlexPaymentOrderStatusResponse"/></returns>
        public QueryFlexPaymentOrderStatusResponse QueryFlexPaymentOrderStatusSync(QueryFlexPaymentOrderStatusRequest req)
        {
             JsonResponseModel<QueryFlexPaymentOrderStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryFlexPaymentOrderStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexPaymentOrderStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-查询结算订单列表
        /// </summary>
        /// <param name="req"><see cref="QueryFlexSettlementOrderListRequest"/></param>
        /// <returns><see cref="QueryFlexSettlementOrderListResponse"/></returns>
        public async Task<QueryFlexSettlementOrderListResponse> QueryFlexSettlementOrderList(QueryFlexSettlementOrderListRequest req)
        {
             JsonResponseModel<QueryFlexSettlementOrderListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryFlexSettlementOrderList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexSettlementOrderListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云V2-查询结算订单列表
        /// </summary>
        /// <param name="req"><see cref="QueryFlexSettlementOrderListRequest"/></param>
        /// <returns><see cref="QueryFlexSettlementOrderListResponse"/></returns>
        public QueryFlexSettlementOrderListResponse QueryFlexSettlementOrderListSync(QueryFlexSettlementOrderListRequest req)
        {
             JsonResponseModel<QueryFlexSettlementOrderListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryFlexSettlementOrderList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFlexSettlementOrderListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 聚鑫-查询会员资金交易信息列表
        /// </summary>
        /// <param name="req"><see cref="QueryFundsTransactionDetailsRequest"/></param>
        /// <returns><see cref="QueryFundsTransactionDetailsResponse"/></returns>
        public async Task<QueryFundsTransactionDetailsResponse> QueryFundsTransactionDetails(QueryFundsTransactionDetailsRequest req)
        {
             JsonResponseModel<QueryFundsTransactionDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryFundsTransactionDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFundsTransactionDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 聚鑫-查询会员资金交易信息列表
        /// </summary>
        /// <param name="req"><see cref="QueryFundsTransactionDetailsRequest"/></param>
        /// <returns><see cref="QueryFundsTransactionDetailsResponse"/></returns>
        public QueryFundsTransactionDetailsResponse QueryFundsTransactionDetailsSync(QueryFundsTransactionDetailsRequest req)
        {
             JsonResponseModel<QueryFundsTransactionDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryFundsTransactionDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryFundsTransactionDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-发票查询
        /// </summary>
        /// <param name="req"><see cref="QueryInvoiceRequest"/></param>
        /// <returns><see cref="QueryInvoiceResponse"/></returns>
        public async Task<QueryInvoiceResponse> QueryInvoice(QueryInvoiceRequest req)
        {
             JsonResponseModel<QueryInvoiceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryInvoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryInvoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-发票查询
        /// </summary>
        /// <param name="req"><see cref="QueryInvoiceRequest"/></param>
        /// <returns><see cref="QueryInvoiceResponse"/></returns>
        public QueryInvoiceResponse QueryInvoiceSync(QueryInvoiceRequest req)
        {
             JsonResponseModel<QueryInvoiceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryInvoice");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryInvoiceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-发票查询V2
        /// </summary>
        /// <param name="req"><see cref="QueryInvoiceV2Request"/></param>
        /// <returns><see cref="QueryInvoiceV2Response"/></returns>
        public async Task<QueryInvoiceV2Response> QueryInvoiceV2(QueryInvoiceV2Request req)
        {
             JsonResponseModel<QueryInvoiceV2Response> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryInvoiceV2");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryInvoiceV2Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-发票查询V2
        /// </summary>
        /// <param name="req"><see cref="QueryInvoiceV2Request"/></param>
        /// <returns><see cref="QueryInvoiceV2Response"/></returns>
        public QueryInvoiceV2Response QueryInvoiceV2Sync(QueryInvoiceV2Request req)
        {
             JsonResponseModel<QueryInvoiceV2Response> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryInvoiceV2");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryInvoiceV2Response>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户恶意注册接口
        /// </summary>
        /// <param name="req"><see cref="QueryMaliciousRegistrationRequest"/></param>
        /// <returns><see cref="QueryMaliciousRegistrationResponse"/></returns>
        public async Task<QueryMaliciousRegistrationResponse> QueryMaliciousRegistration(QueryMaliciousRegistrationRequest req)
        {
             JsonResponseModel<QueryMaliciousRegistrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryMaliciousRegistration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMaliciousRegistrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户恶意注册接口
        /// </summary>
        /// <param name="req"><see cref="QueryMaliciousRegistrationRequest"/></param>
        /// <returns><see cref="QueryMaliciousRegistrationResponse"/></returns>
        public QueryMaliciousRegistrationResponse QueryMaliciousRegistrationSync(QueryMaliciousRegistrationRequest req)
        {
             JsonResponseModel<QueryMaliciousRegistrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryMaliciousRegistration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMaliciousRegistrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员绑定信息查询。查询标志为“单个会员”的情况下，返回该会员的有效的绑定账户信息。
        /// 查询标志为“全部会员”的情况下，返回市场下的全部的有效的绑定账户信息。查询标志为“单个会员的证件信息”的情况下，返回市场下的指定的会员的留存在电商见证宝系统的证件信息。
        /// </summary>
        /// <param name="req"><see cref="QueryMemberBindRequest"/></param>
        /// <returns><see cref="QueryMemberBindResponse"/></returns>
        public async Task<QueryMemberBindResponse> QueryMemberBind(QueryMemberBindRequest req)
        {
             JsonResponseModel<QueryMemberBindResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryMemberBind");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMemberBindResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员绑定信息查询。查询标志为“单个会员”的情况下，返回该会员的有效的绑定账户信息。
        /// 查询标志为“全部会员”的情况下，返回市场下的全部的有效的绑定账户信息。查询标志为“单个会员的证件信息”的情况下，返回市场下的指定的会员的留存在电商见证宝系统的证件信息。
        /// </summary>
        /// <param name="req"><see cref="QueryMemberBindRequest"/></param>
        /// <returns><see cref="QueryMemberBindResponse"/></returns>
        public QueryMemberBindResponse QueryMemberBindSync(QueryMemberBindRequest req)
        {
             JsonResponseModel<QueryMemberBindResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryMemberBind");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMemberBindResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员间交易-不验证。此接口可以实现会员间的余额的交易，实现资金在会员之间流动。
        /// </summary>
        /// <param name="req"><see cref="QueryMemberTransactionRequest"/></param>
        /// <returns><see cref="QueryMemberTransactionResponse"/></returns>
        public async Task<QueryMemberTransactionResponse> QueryMemberTransaction(QueryMemberTransactionRequest req)
        {
             JsonResponseModel<QueryMemberTransactionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryMemberTransaction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMemberTransactionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员间交易-不验证。此接口可以实现会员间的余额的交易，实现资金在会员之间流动。
        /// </summary>
        /// <param name="req"><see cref="QueryMemberTransactionRequest"/></param>
        /// <returns><see cref="QueryMemberTransactionResponse"/></returns>
        public QueryMemberTransactionResponse QueryMemberTransactionSync(QueryMemberTransactionRequest req)
        {
             JsonResponseModel<QueryMemberTransactionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryMemberTransaction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMemberTransactionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 聚鑫-查询会员间交易信息列表
        /// </summary>
        /// <param name="req"><see cref="QueryMemberTransactionDetailsRequest"/></param>
        /// <returns><see cref="QueryMemberTransactionDetailsResponse"/></returns>
        public async Task<QueryMemberTransactionDetailsResponse> QueryMemberTransactionDetails(QueryMemberTransactionDetailsRequest req)
        {
             JsonResponseModel<QueryMemberTransactionDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryMemberTransactionDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMemberTransactionDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 聚鑫-查询会员间交易信息列表
        /// </summary>
        /// <param name="req"><see cref="QueryMemberTransactionDetailsRequest"/></param>
        /// <returns><see cref="QueryMemberTransactionDetailsResponse"/></returns>
        public QueryMemberTransactionDetailsResponse QueryMemberTransactionDetailsSync(QueryMemberTransactionDetailsRequest req)
        {
             JsonResponseModel<QueryMemberTransactionDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryMemberTransactionDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMemberTransactionDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云鉴-商户信息查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantRequest"/></param>
        /// <returns><see cref="QueryMerchantResponse"/></returns>
        public async Task<QueryMerchantResponse> QueryMerchant(QueryMerchantRequest req)
        {
             JsonResponseModel<QueryMerchantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云鉴-商户信息查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantRequest"/></param>
        /// <returns><see cref="QueryMerchantResponse"/></returns>
        public QueryMerchantResponse QueryMerchantSync(QueryMerchantRequest req)
        {
             JsonResponseModel<QueryMerchantResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-对接方账户余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantBalanceRequest"/></param>
        /// <returns><see cref="QueryMerchantBalanceResponse"/></returns>
        public async Task<QueryMerchantBalanceResponse> QueryMerchantBalance(QueryMerchantBalanceRequest req)
        {
             JsonResponseModel<QueryMerchantBalanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryMerchantBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMerchantBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-对接方账户余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantBalanceRequest"/></param>
        /// <returns><see cref="QueryMerchantBalanceResponse"/></returns>
        public QueryMerchantBalanceResponse QueryMerchantBalanceSync(QueryMerchantBalanceRequest req)
        {
             JsonResponseModel<QueryMerchantBalanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryMerchantBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMerchantBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询商户分类接口
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantClassificationRequest"/></param>
        /// <returns><see cref="QueryMerchantClassificationResponse"/></returns>
        public async Task<QueryMerchantClassificationResponse> QueryMerchantClassification(QueryMerchantClassificationRequest req)
        {
             JsonResponseModel<QueryMerchantClassificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryMerchantClassification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMerchantClassificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询商户分类接口
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantClassificationRequest"/></param>
        /// <returns><see cref="QueryMerchantClassificationResponse"/></returns>
        public QueryMerchantClassificationResponse QueryMerchantClassificationSync(QueryMerchantClassificationRequest req)
        {
             JsonResponseModel<QueryMerchantClassificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryMerchantClassification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMerchantClassificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-查询管理端商户
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantInfoForManagementRequest"/></param>
        /// <returns><see cref="QueryMerchantInfoForManagementResponse"/></returns>
        public async Task<QueryMerchantInfoForManagementResponse> QueryMerchantInfoForManagement(QueryMerchantInfoForManagementRequest req)
        {
             JsonResponseModel<QueryMerchantInfoForManagementResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryMerchantInfoForManagement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMerchantInfoForManagementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智慧零售-查询管理端商户
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantInfoForManagementRequest"/></param>
        /// <returns><see cref="QueryMerchantInfoForManagementResponse"/></returns>
        public QueryMerchantInfoForManagementResponse QueryMerchantInfoForManagementSync(QueryMerchantInfoForManagementRequest req)
        {
             JsonResponseModel<QueryMerchantInfoForManagementResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryMerchantInfoForManagement");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMerchantInfoForManagementResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云鉴-消费订单查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantOrderRequest"/></param>
        /// <returns><see cref="QueryMerchantOrderResponse"/></returns>
        public async Task<QueryMerchantOrderResponse> QueryMerchantOrder(QueryMerchantOrderRequest req)
        {
             JsonResponseModel<QueryMerchantOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryMerchantOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMerchantOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云鉴-消费订单查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantOrderRequest"/></param>
        /// <returns><see cref="QueryMerchantOrderResponse"/></returns>
        public QueryMerchantOrderResponse QueryMerchantOrderSync(QueryMerchantOrderRequest req)
        {
             JsonResponseModel<QueryMerchantOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryMerchantOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMerchantOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户查询已开通的支付方式列表
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantPayWayListRequest"/></param>
        /// <returns><see cref="QueryMerchantPayWayListResponse"/></returns>
        public async Task<QueryMerchantPayWayListResponse> QueryMerchantPayWayList(QueryMerchantPayWayListRequest req)
        {
             JsonResponseModel<QueryMerchantPayWayListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryMerchantPayWayList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMerchantPayWayListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户查询已开通的支付方式列表
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantPayWayListRequest"/></param>
        /// <returns><see cref="QueryMerchantPayWayListResponse"/></returns>
        public QueryMerchantPayWayListResponse QueryMerchantPayWayListSync(QueryMerchantPayWayListRequest req)
        {
             JsonResponseModel<QueryMerchantPayWayListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryMerchantPayWayList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryMerchantPayWayListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户银行卡余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBankAccountBalanceRequest"/></param>
        /// <returns><see cref="QueryOpenBankBankAccountBalanceResponse"/></returns>
        public async Task<QueryOpenBankBankAccountBalanceResponse> QueryOpenBankBankAccountBalance(QueryOpenBankBankAccountBalanceRequest req)
        {
             JsonResponseModel<QueryOpenBankBankAccountBalanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankBankAccountBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankBankAccountBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户银行卡余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBankAccountBalanceRequest"/></param>
        /// <returns><see cref="QueryOpenBankBankAccountBalanceResponse"/></returns>
        public QueryOpenBankBankAccountBalanceResponse QueryOpenBankBankAccountBalanceSync(QueryOpenBankBankAccountBalanceRequest req)
        {
             JsonResponseModel<QueryOpenBankBankAccountBalanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankBankAccountBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankBankAccountBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-查询联行号
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBankBranchListRequest"/></param>
        /// <returns><see cref="QueryOpenBankBankBranchListResponse"/></returns>
        public async Task<QueryOpenBankBankBranchListResponse> QueryOpenBankBankBranchList(QueryOpenBankBankBranchListRequest req)
        {
             JsonResponseModel<QueryOpenBankBankBranchListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankBankBranchList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankBankBranchListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-查询联行号
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBankBranchListRequest"/></param>
        /// <returns><see cref="QueryOpenBankBankBranchListResponse"/></returns>
        public QueryOpenBankBankBranchListResponse QueryOpenBankBankBranchListSync(QueryOpenBankBankBranchListRequest req)
        {
             JsonResponseModel<QueryOpenBankBankBranchListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankBankBranchList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankBankBranchListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-分页查询对账单数据
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBillDataPageRequest"/></param>
        /// <returns><see cref="QueryOpenBankBillDataPageResponse"/></returns>
        public async Task<QueryOpenBankBillDataPageResponse> QueryOpenBankBillDataPage(QueryOpenBankBillDataPageRequest req)
        {
             JsonResponseModel<QueryOpenBankBillDataPageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankBillDataPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankBillDataPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-分页查询对账单数据
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBillDataPageRequest"/></param>
        /// <returns><see cref="QueryOpenBankBillDataPageResponse"/></returns>
        public QueryOpenBankBillDataPageResponse QueryOpenBankBillDataPageSync(QueryOpenBankBillDataPageRequest req)
        {
             JsonResponseModel<QueryOpenBankBillDataPageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankBillDataPage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankBillDataPageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户银行卡绑定结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBindExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="QueryOpenBankBindExternalSubMerchantBankAccountResponse"/></returns>
        public async Task<QueryOpenBankBindExternalSubMerchantBankAccountResponse> QueryOpenBankBindExternalSubMerchantBankAccount(QueryOpenBankBindExternalSubMerchantBankAccountRequest req)
        {
             JsonResponseModel<QueryOpenBankBindExternalSubMerchantBankAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankBindExternalSubMerchantBankAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankBindExternalSubMerchantBankAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户银行卡绑定结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBindExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="QueryOpenBankBindExternalSubMerchantBankAccountResponse"/></returns>
        public QueryOpenBankBindExternalSubMerchantBankAccountResponse QueryOpenBankBindExternalSubMerchantBankAccountSync(QueryOpenBankBindExternalSubMerchantBankAccountRequest req)
        {
             JsonResponseModel<QueryOpenBankBindExternalSubMerchantBankAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankBindExternalSubMerchantBankAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankBindExternalSubMerchantBankAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-按日期批量查询回单下载地址
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankDailyReceiptDownloadUrlRequest"/></param>
        /// <returns><see cref="QueryOpenBankDailyReceiptDownloadUrlResponse"/></returns>
        public async Task<QueryOpenBankDailyReceiptDownloadUrlResponse> QueryOpenBankDailyReceiptDownloadUrl(QueryOpenBankDailyReceiptDownloadUrlRequest req)
        {
             JsonResponseModel<QueryOpenBankDailyReceiptDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankDailyReceiptDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankDailyReceiptDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-按日期批量查询回单下载地址
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankDailyReceiptDownloadUrlRequest"/></param>
        /// <returns><see cref="QueryOpenBankDailyReceiptDownloadUrlResponse"/></returns>
        public QueryOpenBankDailyReceiptDownloadUrlResponse QueryOpenBankDailyReceiptDownloadUrlSync(QueryOpenBankDailyReceiptDownloadUrlRequest req)
        {
             JsonResponseModel<QueryOpenBankDailyReceiptDownloadUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankDailyReceiptDownloadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankDailyReceiptDownloadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-查询对账单下载地址
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankDownLoadUrlRequest"/></param>
        /// <returns><see cref="QueryOpenBankDownLoadUrlResponse"/></returns>
        public async Task<QueryOpenBankDownLoadUrlResponse> QueryOpenBankDownLoadUrl(QueryOpenBankDownLoadUrlRequest req)
        {
             JsonResponseModel<QueryOpenBankDownLoadUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankDownLoadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankDownLoadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-查询对账单下载地址
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankDownLoadUrlRequest"/></param>
        /// <returns><see cref="QueryOpenBankDownLoadUrlResponse"/></returns>
        public QueryOpenBankDownLoadUrlResponse QueryOpenBankDownLoadUrlSync(QueryOpenBankDownLoadUrlRequest req)
        {
             JsonResponseModel<QueryOpenBankDownLoadUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankDownLoadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankDownLoadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 第三方子商户电子记账本余额查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankExternalSubAccountBookBalanceRequest"/></param>
        /// <returns><see cref="QueryOpenBankExternalSubAccountBookBalanceResponse"/></returns>
        public async Task<QueryOpenBankExternalSubAccountBookBalanceResponse> QueryOpenBankExternalSubAccountBookBalance(QueryOpenBankExternalSubAccountBookBalanceRequest req)
        {
             JsonResponseModel<QueryOpenBankExternalSubAccountBookBalanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankExternalSubAccountBookBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankExternalSubAccountBookBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 第三方子商户电子记账本余额查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankExternalSubAccountBookBalanceRequest"/></param>
        /// <returns><see cref="QueryOpenBankExternalSubAccountBookBalanceResponse"/></returns>
        public QueryOpenBankExternalSubAccountBookBalanceResponse QueryOpenBankExternalSubAccountBookBalanceSync(QueryOpenBankExternalSubAccountBookBalanceRequest req)
        {
             JsonResponseModel<QueryOpenBankExternalSubAccountBookBalanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankExternalSubAccountBookBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankExternalSubAccountBookBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户银行卡列表查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="QueryOpenBankExternalSubMerchantBankAccountResponse"/></returns>
        public async Task<QueryOpenBankExternalSubMerchantBankAccountResponse> QueryOpenBankExternalSubMerchantBankAccount(QueryOpenBankExternalSubMerchantBankAccountRequest req)
        {
             JsonResponseModel<QueryOpenBankExternalSubMerchantBankAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankExternalSubMerchantBankAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankExternalSubMerchantBankAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户银行卡列表查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="QueryOpenBankExternalSubMerchantBankAccountResponse"/></returns>
        public QueryOpenBankExternalSubMerchantBankAccountResponse QueryOpenBankExternalSubMerchantBankAccountSync(QueryOpenBankExternalSubMerchantBankAccountRequest req)
        {
             JsonResponseModel<QueryOpenBankExternalSubMerchantBankAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankExternalSubMerchantBankAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankExternalSubMerchantBankAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户进件结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankExternalSubMerchantRegistrationRequest"/></param>
        /// <returns><see cref="QueryOpenBankExternalSubMerchantRegistrationResponse"/></returns>
        public async Task<QueryOpenBankExternalSubMerchantRegistrationResponse> QueryOpenBankExternalSubMerchantRegistration(QueryOpenBankExternalSubMerchantRegistrationRequest req)
        {
             JsonResponseModel<QueryOpenBankExternalSubMerchantRegistrationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankExternalSubMerchantRegistration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankExternalSubMerchantRegistrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户进件结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankExternalSubMerchantRegistrationRequest"/></param>
        /// <returns><see cref="QueryOpenBankExternalSubMerchantRegistrationResponse"/></returns>
        public QueryOpenBankExternalSubMerchantRegistrationResponse QueryOpenBankExternalSubMerchantRegistrationSync(QueryOpenBankExternalSubMerchantRegistrationRequest req)
        {
             JsonResponseModel<QueryOpenBankExternalSubMerchantRegistrationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankExternalSubMerchantRegistration");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankExternalSubMerchantRegistrationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-单笔交易回单申请结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankOrderDetailReceiptInfoRequest"/></param>
        /// <returns><see cref="QueryOpenBankOrderDetailReceiptInfoResponse"/></returns>
        public async Task<QueryOpenBankOrderDetailReceiptInfoResponse> QueryOpenBankOrderDetailReceiptInfo(QueryOpenBankOrderDetailReceiptInfoRequest req)
        {
             JsonResponseModel<QueryOpenBankOrderDetailReceiptInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankOrderDetailReceiptInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankOrderDetailReceiptInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-单笔交易回单申请结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankOrderDetailReceiptInfoRequest"/></param>
        /// <returns><see cref="QueryOpenBankOrderDetailReceiptInfoResponse"/></returns>
        public QueryOpenBankOrderDetailReceiptInfoResponse QueryOpenBankOrderDetailReceiptInfoSync(QueryOpenBankOrderDetailReceiptInfoRequest req)
        {
             JsonResponseModel<QueryOpenBankOrderDetailReceiptInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankOrderDetailReceiptInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankOrderDetailReceiptInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-查询订单支付结果
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankPaymentOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankPaymentOrderResponse"/></returns>
        public async Task<QueryOpenBankPaymentOrderResponse> QueryOpenBankPaymentOrder(QueryOpenBankPaymentOrderRequest req)
        {
             JsonResponseModel<QueryOpenBankPaymentOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankPaymentOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankPaymentOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-查询订单支付结果
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankPaymentOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankPaymentOrderResponse"/></returns>
        public QueryOpenBankPaymentOrderResponse QueryOpenBankPaymentOrderSync(QueryOpenBankPaymentOrderRequest req)
        {
             JsonResponseModel<QueryOpenBankPaymentOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankPaymentOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankPaymentOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-退款结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankRefundOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankRefundOrderResponse"/></returns>
        public async Task<QueryOpenBankRefundOrderResponse> QueryOpenBankRefundOrder(QueryOpenBankRefundOrderRequest req)
        {
             JsonResponseModel<QueryOpenBankRefundOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankRefundOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankRefundOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-退款结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankRefundOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankRefundOrderResponse"/></returns>
        public QueryOpenBankRefundOrderResponse QueryOpenBankRefundOrderSync(QueryOpenBankRefundOrderRequest req)
        {
             JsonResponseModel<QueryOpenBankRefundOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankRefundOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankRefundOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-结算单查询结果
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSettleOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankSettleOrderResponse"/></returns>
        public async Task<QueryOpenBankSettleOrderResponse> QueryOpenBankSettleOrder(QueryOpenBankSettleOrderRequest req)
        {
             JsonResponseModel<QueryOpenBankSettleOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankSettleOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankSettleOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-结算单查询结果
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSettleOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankSettleOrderResponse"/></returns>
        public QueryOpenBankSettleOrderResponse QueryOpenBankSettleOrderSync(QueryOpenBankSettleOrderRequest req)
        {
             JsonResponseModel<QueryOpenBankSettleOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankSettleOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankSettleOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户资质文件查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSubMerchantCredentialRequest"/></param>
        /// <returns><see cref="QueryOpenBankSubMerchantCredentialResponse"/></returns>
        public async Task<QueryOpenBankSubMerchantCredentialResponse> QueryOpenBankSubMerchantCredential(QueryOpenBankSubMerchantCredentialRequest req)
        {
             JsonResponseModel<QueryOpenBankSubMerchantCredentialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankSubMerchantCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankSubMerchantCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户资质文件查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSubMerchantCredentialRequest"/></param>
        /// <returns><see cref="QueryOpenBankSubMerchantCredentialResponse"/></returns>
        public QueryOpenBankSubMerchantCredentialResponse QueryOpenBankSubMerchantCredentialSync(QueryOpenBankSubMerchantCredentialRequest req)
        {
             JsonResponseModel<QueryOpenBankSubMerchantCredentialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankSubMerchantCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankSubMerchantCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户费率配置结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSubMerchantRateConfigureRequest"/></param>
        /// <returns><see cref="QueryOpenBankSubMerchantRateConfigureResponse"/></returns>
        public async Task<QueryOpenBankSubMerchantRateConfigureResponse> QueryOpenBankSubMerchantRateConfigure(QueryOpenBankSubMerchantRateConfigureRequest req)
        {
             JsonResponseModel<QueryOpenBankSubMerchantRateConfigureResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankSubMerchantRateConfigure");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankSubMerchantRateConfigureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户费率配置结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSubMerchantRateConfigureRequest"/></param>
        /// <returns><see cref="QueryOpenBankSubMerchantRateConfigureResponse"/></returns>
        public QueryOpenBankSubMerchantRateConfigureResponse QueryOpenBankSubMerchantRateConfigureSync(QueryOpenBankSubMerchantRateConfigureRequest req)
        {
             JsonResponseModel<QueryOpenBankSubMerchantRateConfigureResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankSubMerchantRateConfigure");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankSubMerchantRateConfigureResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 子商户在线签约查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSubMerchantSignOnlineRequest"/></param>
        /// <returns><see cref="QueryOpenBankSubMerchantSignOnlineResponse"/></returns>
        public async Task<QueryOpenBankSubMerchantSignOnlineResponse> QueryOpenBankSubMerchantSignOnline(QueryOpenBankSubMerchantSignOnlineRequest req)
        {
             JsonResponseModel<QueryOpenBankSubMerchantSignOnlineResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankSubMerchantSignOnline");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankSubMerchantSignOnlineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 子商户在线签约查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSubMerchantSignOnlineRequest"/></param>
        /// <returns><see cref="QueryOpenBankSubMerchantSignOnlineResponse"/></returns>
        public QueryOpenBankSubMerchantSignOnlineResponse QueryOpenBankSubMerchantSignOnlineSync(QueryOpenBankSubMerchantSignOnlineRequest req)
        {
             JsonResponseModel<QueryOpenBankSubMerchantSignOnlineResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankSubMerchantSignOnline");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankSubMerchantSignOnlineResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-查询支持银行列表
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSupportBankListRequest"/></param>
        /// <returns><see cref="QueryOpenBankSupportBankListResponse"/></returns>
        public async Task<QueryOpenBankSupportBankListResponse> QueryOpenBankSupportBankList(QueryOpenBankSupportBankListRequest req)
        {
             JsonResponseModel<QueryOpenBankSupportBankListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankSupportBankList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankSupportBankListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-查询支持银行列表
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSupportBankListRequest"/></param>
        /// <returns><see cref="QueryOpenBankSupportBankListResponse"/></returns>
        public QueryOpenBankSupportBankListResponse QueryOpenBankSupportBankListSync(QueryOpenBankSupportBankListRequest req)
        {
             JsonResponseModel<QueryOpenBankSupportBankListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankSupportBankList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankSupportBankListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户银行卡解绑结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankUnbindExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="QueryOpenBankUnbindExternalSubMerchantBankAccountResponse"/></returns>
        public async Task<QueryOpenBankUnbindExternalSubMerchantBankAccountResponse> QueryOpenBankUnbindExternalSubMerchantBankAccount(QueryOpenBankUnbindExternalSubMerchantBankAccountRequest req)
        {
             JsonResponseModel<QueryOpenBankUnbindExternalSubMerchantBankAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankUnbindExternalSubMerchantBankAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankUnbindExternalSubMerchantBankAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户银行卡解绑结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankUnbindExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="QueryOpenBankUnbindExternalSubMerchantBankAccountResponse"/></returns>
        public QueryOpenBankUnbindExternalSubMerchantBankAccountResponse QueryOpenBankUnbindExternalSubMerchantBankAccountSync(QueryOpenBankUnbindExternalSubMerchantBankAccountRequest req)
        {
             JsonResponseModel<QueryOpenBankUnbindExternalSubMerchantBankAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankUnbindExternalSubMerchantBankAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankUnbindExternalSubMerchantBankAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-查询核销订单状态，客户可以使用该接口来查询核销申请的订单状态。目前仅支持TENPAY渠道EBANK_PAYMENT付款方式的担保支付订单查询。
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankVerificationOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankVerificationOrderResponse"/></returns>
        public async Task<QueryOpenBankVerificationOrderResponse> QueryOpenBankVerificationOrder(QueryOpenBankVerificationOrderRequest req)
        {
             JsonResponseModel<QueryOpenBankVerificationOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOpenBankVerificationOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankVerificationOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-查询核销订单状态，客户可以使用该接口来查询核销申请的订单状态。目前仅支持TENPAY渠道EBANK_PAYMENT付款方式的担保支付订单查询。
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankVerificationOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankVerificationOrderResponse"/></returns>
        public QueryOpenBankVerificationOrderResponse QueryOpenBankVerificationOrderSync(QueryOpenBankVerificationOrderRequest req)
        {
             JsonResponseModel<QueryOpenBankVerificationOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOpenBankVerificationOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOpenBankVerificationOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据订单号，或者用户Id，查询支付订单状态 
        /// </summary>
        /// <param name="req"><see cref="QueryOrderRequest"/></param>
        /// <returns><see cref="QueryOrderResponse"/></returns>
        public async Task<QueryOrderResponse> QueryOrder(QueryOrderRequest req)
        {
             JsonResponseModel<QueryOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据订单号，或者用户Id，查询支付订单状态 
        /// </summary>
        /// <param name="req"><see cref="QueryOrderRequest"/></param>
        /// <returns><see cref="QueryOrderResponse"/></returns>
        public QueryOrderResponse QueryOrderSync(QueryOrderRequest req)
        {
             JsonResponseModel<QueryOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询订单付款状态
        /// </summary>
        /// <param name="req"><see cref="QueryOrderStatusRequest"/></param>
        /// <returns><see cref="QueryOrderStatusResponse"/></returns>
        public async Task<QueryOrderStatusResponse> QueryOrderStatus(QueryOrderStatusRequest req)
        {
             JsonResponseModel<QueryOrderStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOrderStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOrderStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询订单付款状态
        /// </summary>
        /// <param name="req"><see cref="QueryOrderStatusRequest"/></param>
        /// <returns><see cref="QueryOrderStatusResponse"/></returns>
        public QueryOrderStatusResponse QueryOrderStatusSync(QueryOrderStatusRequest req)
        {
             JsonResponseModel<QueryOrderStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOrderStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOrderStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-查询汇出结果
        /// </summary>
        /// <param name="req"><see cref="QueryOutwardOrderRequest"/></param>
        /// <returns><see cref="QueryOutwardOrderResponse"/></returns>
        public async Task<QueryOutwardOrderResponse> QueryOutwardOrder(QueryOutwardOrderRequest req)
        {
             JsonResponseModel<QueryOutwardOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryOutwardOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOutwardOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-查询汇出结果
        /// </summary>
        /// <param name="req"><see cref="QueryOutwardOrderRequest"/></param>
        /// <returns><see cref="QueryOutwardOrderResponse"/></returns>
        public QueryOutwardOrderResponse QueryOutwardOrderSync(QueryOutwardOrderRequest req)
        {
             JsonResponseModel<QueryOutwardOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryOutwardOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryOutwardOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-付款人查询
        /// </summary>
        /// <param name="req"><see cref="QueryPayerInfoRequest"/></param>
        /// <returns><see cref="QueryPayerInfoResponse"/></returns>
        public async Task<QueryPayerInfoResponse> QueryPayerInfo(QueryPayerInfoRequest req)
        {
             JsonResponseModel<QueryPayerInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryPayerInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryPayerInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-付款人查询
        /// </summary>
        /// <param name="req"><see cref="QueryPayerInfoRequest"/></param>
        /// <returns><see cref="QueryPayerInfoResponse"/></returns>
        public QueryPayerInfoResponse QueryPayerInfoSync(QueryPayerInfoRequest req)
        {
             JsonResponseModel<QueryPayerInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryPayerInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryPayerInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询对账文件信息。平台调用该接口获取需下载对账文件的文件名称以及密钥。 平台获取到信息后， 可以再调用OPENAPI的文件下载功能。
        /// </summary>
        /// <param name="req"><see cref="QueryReconciliationDocumentRequest"/></param>
        /// <returns><see cref="QueryReconciliationDocumentResponse"/></returns>
        public async Task<QueryReconciliationDocumentResponse> QueryReconciliationDocument(QueryReconciliationDocumentRequest req)
        {
             JsonResponseModel<QueryReconciliationDocumentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryReconciliationDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryReconciliationDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询对账文件信息。平台调用该接口获取需下载对账文件的文件名称以及密钥。 平台获取到信息后， 可以再调用OPENAPI的文件下载功能。
        /// </summary>
        /// <param name="req"><see cref="QueryReconciliationDocumentRequest"/></param>
        /// <returns><see cref="QueryReconciliationDocumentResponse"/></returns>
        public QueryReconciliationDocumentResponse QueryReconciliationDocumentSync(QueryReconciliationDocumentRequest req)
        {
             JsonResponseModel<QueryReconciliationDocumentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryReconciliationDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryReconciliationDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 聚鑫-查询对账文件申请结果
        /// </summary>
        /// <param name="req"><see cref="QueryReconciliationFileApplyInfoRequest"/></param>
        /// <returns><see cref="QueryReconciliationFileApplyInfoResponse"/></returns>
        public async Task<QueryReconciliationFileApplyInfoResponse> QueryReconciliationFileApplyInfo(QueryReconciliationFileApplyInfoRequest req)
        {
             JsonResponseModel<QueryReconciliationFileApplyInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryReconciliationFileApplyInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryReconciliationFileApplyInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 聚鑫-查询对账文件申请结果
        /// </summary>
        /// <param name="req"><see cref="QueryReconciliationFileApplyInfoRequest"/></param>
        /// <returns><see cref="QueryReconciliationFileApplyInfoResponse"/></returns>
        public QueryReconciliationFileApplyInfoResponse QueryReconciliationFileApplyInfoSync(QueryReconciliationFileApplyInfoRequest req)
        {
             JsonResponseModel<QueryReconciliationFileApplyInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryReconciliationFileApplyInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryReconciliationFileApplyInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交退款申请后，通过调用该接口查询退款状态。退款可能有一定延时，用微信零钱支付的退款约20分钟内到账，银行卡支付的退款约3个工作日后到账。
        /// </summary>
        /// <param name="req"><see cref="QueryRefundRequest"/></param>
        /// <returns><see cref="QueryRefundResponse"/></returns>
        public async Task<QueryRefundResponse> QueryRefund(QueryRefundRequest req)
        {
             JsonResponseModel<QueryRefundResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryRefund");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryRefundResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交退款申请后，通过调用该接口查询退款状态。退款可能有一定延时，用微信零钱支付的退款约20分钟内到账，银行卡支付的退款约3个工作日后到账。
        /// </summary>
        /// <param name="req"><see cref="QueryRefundRequest"/></param>
        /// <returns><see cref="QueryRefundResponse"/></returns>
        public QueryRefundResponse QueryRefundSync(QueryRefundRequest req)
        {
             JsonResponseModel<QueryRefundResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryRefund");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryRefundResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-获取门店OpenId接口
        /// </summary>
        /// <param name="req"><see cref="QueryShopOpenIdRequest"/></param>
        /// <returns><see cref="QueryShopOpenIdResponse"/></returns>
        public async Task<QueryShopOpenIdResponse> QueryShopOpenId(QueryShopOpenIdRequest req)
        {
             JsonResponseModel<QueryShopOpenIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryShopOpenId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryShopOpenIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-获取门店OpenId接口
        /// </summary>
        /// <param name="req"><see cref="QueryShopOpenIdRequest"/></param>
        /// <returns><see cref="QueryShopOpenIdResponse"/></returns>
        public QueryShopOpenIdResponse QueryShopOpenIdSync(QueryShopOpenIdRequest req)
        {
             JsonResponseModel<QueryShopOpenIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryShopOpenId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryShopOpenIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-单笔转账结果查询
        /// </summary>
        /// <param name="req"><see cref="QuerySinglePaymentResultRequest"/></param>
        /// <returns><see cref="QuerySinglePaymentResultResponse"/></returns>
        public async Task<QuerySinglePaymentResultResponse> QuerySinglePaymentResult(QuerySinglePaymentResultRequest req)
        {
             JsonResponseModel<QuerySinglePaymentResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QuerySinglePaymentResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QuerySinglePaymentResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-单笔转账结果查询
        /// </summary>
        /// <param name="req"><see cref="QuerySinglePaymentResultRequest"/></param>
        /// <returns><see cref="QuerySinglePaymentResultResponse"/></returns>
        public QuerySinglePaymentResultResponse QuerySinglePaymentResultSync(QuerySinglePaymentResultRequest req)
        {
             JsonResponseModel<QuerySinglePaymentResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QuerySinglePaymentResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QuerySinglePaymentResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询银行单笔交易状态。查询单笔交易的状态。
        /// </summary>
        /// <param name="req"><see cref="QuerySingleTransactionStatusRequest"/></param>
        /// <returns><see cref="QuerySingleTransactionStatusResponse"/></returns>
        public async Task<QuerySingleTransactionStatusResponse> QuerySingleTransactionStatus(QuerySingleTransactionStatusRequest req)
        {
             JsonResponseModel<QuerySingleTransactionStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QuerySingleTransactionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QuerySingleTransactionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询银行单笔交易状态。查询单笔交易的状态。
        /// </summary>
        /// <param name="req"><see cref="QuerySingleTransactionStatusRequest"/></param>
        /// <returns><see cref="QuerySingleTransactionStatusResponse"/></returns>
        public QuerySingleTransactionStatusResponse QuerySingleTransactionStatusSync(QuerySingleTransactionStatusRequest req)
        {
             JsonResponseModel<QuerySingleTransactionStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QuerySingleTransactionStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QuerySingleTransactionStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询小额鉴权转账结果。查询小额往账鉴权的转账状态。
        /// </summary>
        /// <param name="req"><see cref="QuerySmallAmountTransferRequest"/></param>
        /// <returns><see cref="QuerySmallAmountTransferResponse"/></returns>
        public async Task<QuerySmallAmountTransferResponse> QuerySmallAmountTransfer(QuerySmallAmountTransferRequest req)
        {
             JsonResponseModel<QuerySmallAmountTransferResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QuerySmallAmountTransfer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QuerySmallAmountTransferResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询小额鉴权转账结果。查询小额往账鉴权的转账状态。
        /// </summary>
        /// <param name="req"><see cref="QuerySmallAmountTransferRequest"/></param>
        /// <returns><see cref="QuerySmallAmountTransferResponse"/></returns>
        public QuerySmallAmountTransferResponse QuerySmallAmountTransferSync(QuerySmallAmountTransferRequest req)
        {
             JsonResponseModel<QuerySmallAmountTransferResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QuerySmallAmountTransfer");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QuerySmallAmountTransferResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-贸易材料明细查询。
        /// </summary>
        /// <param name="req"><see cref="QueryTradeRequest"/></param>
        /// <returns><see cref="QueryTradeResponse"/></returns>
        public async Task<QueryTradeResponse> QueryTrade(QueryTradeRequest req)
        {
             JsonResponseModel<QueryTradeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryTrade");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryTradeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 跨境-贸易材料明细查询。
        /// </summary>
        /// <param name="req"><see cref="QueryTradeRequest"/></param>
        /// <returns><see cref="QueryTradeResponse"/></returns>
        public QueryTradeResponse QueryTradeSync(QueryTradeRequest req)
        {
             JsonResponseModel<QueryTradeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryTrade");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryTradeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过商家批次单号或者微信批次号查询批次单
        /// </summary>
        /// <param name="req"><see cref="QueryTransferBatchRequest"/></param>
        /// <returns><see cref="QueryTransferBatchResponse"/></returns>
        public async Task<QueryTransferBatchResponse> QueryTransferBatch(QueryTransferBatchRequest req)
        {
             JsonResponseModel<QueryTransferBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryTransferBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryTransferBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过商家批次单号或者微信批次号查询批次单
        /// </summary>
        /// <param name="req"><see cref="QueryTransferBatchRequest"/></param>
        /// <returns><see cref="QueryTransferBatchResponse"/></returns>
        public QueryTransferBatchResponse QueryTransferBatchSync(QueryTransferBatchRequest req)
        {
             JsonResponseModel<QueryTransferBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryTransferBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryTransferBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过商家或者微信批次明细单号查询明细单
        /// </summary>
        /// <param name="req"><see cref="QueryTransferDetailRequest"/></param>
        /// <returns><see cref="QueryTransferDetailResponse"/></returns>
        public async Task<QueryTransferDetailResponse> QueryTransferDetail(QueryTransferDetailRequest req)
        {
             JsonResponseModel<QueryTransferDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryTransferDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryTransferDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过商家或者微信批次明细单号查询明细单
        /// </summary>
        /// <param name="req"><see cref="QueryTransferDetailRequest"/></param>
        /// <returns><see cref="QueryTransferDetailResponse"/></returns>
        public QueryTransferDetailResponse QueryTransferDetailSync(QueryTransferDetailRequest req)
        {
             JsonResponseModel<QueryTransferDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryTransferDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryTransferDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智能代发-单笔代发转账查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryTransferResultRequest"/></param>
        /// <returns><see cref="QueryTransferResultResponse"/></returns>
        public async Task<QueryTransferResultResponse> QueryTransferResult(QueryTransferResultRequest req)
        {
             JsonResponseModel<QueryTransferResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryTransferResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryTransferResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智能代发-单笔代发转账查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryTransferResultRequest"/></param>
        /// <returns><see cref="QueryTransferResultResponse"/></returns>
        public QueryTransferResultResponse QueryTransferResultSync(QueryTransferResultRequest req)
        {
             JsonResponseModel<QueryTransferResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryTransferResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryTransferResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员在途充值(经第三方支付渠道)接口
        /// </summary>
        /// <param name="req"><see cref="RechargeByThirdPayRequest"/></param>
        /// <returns><see cref="RechargeByThirdPayResponse"/></returns>
        public async Task<RechargeByThirdPayResponse> RechargeByThirdPay(RechargeByThirdPayRequest req)
        {
             JsonResponseModel<RechargeByThirdPayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RechargeByThirdPay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RechargeByThirdPayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员在途充值(经第三方支付渠道)接口
        /// </summary>
        /// <param name="req"><see cref="RechargeByThirdPayRequest"/></param>
        /// <returns><see cref="RechargeByThirdPayResponse"/></returns>
        public RechargeByThirdPayResponse RechargeByThirdPaySync(RechargeByThirdPayRequest req)
        {
             JsonResponseModel<RechargeByThirdPayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RechargeByThirdPay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RechargeByThirdPayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 见证宝-会员在途充值(经第三方支付渠道)
        /// </summary>
        /// <param name="req"><see cref="RechargeMemberThirdPayRequest"/></param>
        /// <returns><see cref="RechargeMemberThirdPayResponse"/></returns>
        public async Task<RechargeMemberThirdPayResponse> RechargeMemberThirdPay(RechargeMemberThirdPayRequest req)
        {
             JsonResponseModel<RechargeMemberThirdPayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RechargeMemberThirdPay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RechargeMemberThirdPayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 见证宝-会员在途充值(经第三方支付渠道)
        /// </summary>
        /// <param name="req"><see cref="RechargeMemberThirdPayRequest"/></param>
        /// <returns><see cref="RechargeMemberThirdPayResponse"/></returns>
        public RechargeMemberThirdPayResponse RechargeMemberThirdPaySync(RechargeMemberThirdPayRequest req)
        {
             JsonResponseModel<RechargeMemberThirdPayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RechargeMemberThirdPay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RechargeMemberThirdPayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 如交易订单需退款，可以通过本接口将支付款全部或部分退还给付款方，聚鑫将在收到退款请求并且验证成功之后，按照退款规则将支付款按原路退回到支付帐号。最长支持1年的订单退款。在订单包含多个子订单的情况下，如果使用本接口传入OutTradeNo或TransactionId退款，则只支持全单退款；如果需要部分退款，请通过传入子订单的方式来指定部分金额退款。 
        /// </summary>
        /// <param name="req"><see cref="RefundRequest"/></param>
        /// <returns><see cref="RefundResponse"/></returns>
        public async Task<RefundResponse> Refund(RefundRequest req)
        {
             JsonResponseModel<RefundResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "Refund");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefundResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 如交易订单需退款，可以通过本接口将支付款全部或部分退还给付款方，聚鑫将在收到退款请求并且验证成功之后，按照退款规则将支付款按原路退回到支付帐号。最长支持1年的订单退款。在订单包含多个子订单的情况下，如果使用本接口传入OutTradeNo或TransactionId退款，则只支持全单退款；如果需要部分退款，请通过传入子订单的方式来指定部分金额退款。 
        /// </summary>
        /// <param name="req"><see cref="RefundRequest"/></param>
        /// <returns><see cref="RefundResponse"/></returns>
        public RefundResponse RefundSync(RefundRequest req)
        {
             JsonResponseModel<RefundResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "Refund");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefundResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 如交易订单需退款，可以通过本接口将支付款全部或部分退还给付款方，聚鑫将在收到退款请求并且验证成功之后，按照退款规则将支付款按原路退回到支付帐号。最长支持1年的订单退款。在订单包含多个子订单的情况下，如果使用本接口传入OutTradeNo或TransactionId退款，则只支持全单退款；如果需要部分退款，请通过传入子订单的方式来指定部分金额退款。 
        /// </summary>
        /// <param name="req"><see cref="RefundCloudOrderRequest"/></param>
        /// <returns><see cref="RefundCloudOrderResponse"/></returns>
        public async Task<RefundCloudOrderResponse> RefundCloudOrder(RefundCloudOrderRequest req)
        {
             JsonResponseModel<RefundCloudOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RefundCloudOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefundCloudOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 如交易订单需退款，可以通过本接口将支付款全部或部分退还给付款方，聚鑫将在收到退款请求并且验证成功之后，按照退款规则将支付款按原路退回到支付帐号。最长支持1年的订单退款。在订单包含多个子订单的情况下，如果使用本接口传入OutTradeNo或TransactionId退款，则只支持全单退款；如果需要部分退款，请通过传入子订单的方式来指定部分金额退款。 
        /// </summary>
        /// <param name="req"><see cref="RefundCloudOrderRequest"/></param>
        /// <returns><see cref="RefundCloudOrderResponse"/></returns>
        public RefundCloudOrderResponse RefundCloudOrderSync(RefundCloudOrderRequest req)
        {
             JsonResponseModel<RefundCloudOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RefundCloudOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefundCloudOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员间交易退款
        /// </summary>
        /// <param name="req"><see cref="RefundMemberTransactionRequest"/></param>
        /// <returns><see cref="RefundMemberTransactionResponse"/></returns>
        public async Task<RefundMemberTransactionResponse> RefundMemberTransaction(RefundMemberTransactionRequest req)
        {
             JsonResponseModel<RefundMemberTransactionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RefundMemberTransaction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefundMemberTransactionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员间交易退款
        /// </summary>
        /// <param name="req"><see cref="RefundMemberTransactionRequest"/></param>
        /// <returns><see cref="RefundMemberTransactionResponse"/></returns>
        public RefundMemberTransactionResponse RefundMemberTransactionSync(RefundMemberTransactionRequest req)
        {
             JsonResponseModel<RefundMemberTransactionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RefundMemberTransaction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefundMemberTransactionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-退款申请
        /// </summary>
        /// <param name="req"><see cref="RefundOpenBankOrderRequest"/></param>
        /// <returns><see cref="RefundOpenBankOrderResponse"/></returns>
        public async Task<RefundOpenBankOrderResponse> RefundOpenBankOrder(RefundOpenBankOrderRequest req)
        {
             JsonResponseModel<RefundOpenBankOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RefundOpenBankOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefundOpenBankOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-退款申请
        /// </summary>
        /// <param name="req"><see cref="RefundOpenBankOrderRequest"/></param>
        /// <returns><see cref="RefundOpenBankOrderResponse"/></returns>
        public RefundOpenBankOrderResponse RefundOpenBankOrderSync(RefundOpenBankOrderRequest req)
        {
             JsonResponseModel<RefundOpenBankOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RefundOpenBankOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefundOpenBankOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云鉴-消费订单退款的接口
        /// </summary>
        /// <param name="req"><see cref="RefundOrderRequest"/></param>
        /// <returns><see cref="RefundOrderResponse"/></returns>
        public async Task<RefundOrderResponse> RefundOrder(RefundOrderRequest req)
        {
             JsonResponseModel<RefundOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RefundOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefundOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云鉴-消费订单退款的接口
        /// </summary>
        /// <param name="req"><see cref="RefundOrderRequest"/></param>
        /// <returns><see cref="RefundOrderResponse"/></returns>
        public RefundOrderResponse RefundOrderSync(RefundOrderRequest req)
        {
             JsonResponseModel<RefundOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RefundOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefundOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付订单退款接口
        /// </summary>
        /// <param name="req"><see cref="RefundTlinxOrderRequest"/></param>
        /// <returns><see cref="RefundTlinxOrderResponse"/></returns>
        public async Task<RefundTlinxOrderResponse> RefundTlinxOrder(RefundTlinxOrderRequest req)
        {
             JsonResponseModel<RefundTlinxOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RefundTlinxOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefundTlinxOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付订单退款接口
        /// </summary>
        /// <param name="req"><see cref="RefundTlinxOrderRequest"/></param>
        /// <returns><see cref="RefundTlinxOrderResponse"/></returns>
        public RefundTlinxOrderResponse RefundTlinxOrderSync(RefundTlinxOrderRequest req)
        {
             JsonResponseModel<RefundTlinxOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RefundTlinxOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RefundTlinxOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户查询是否签约和签约行为上报
        /// </summary>
        /// <param name="req"><see cref="RegisterBehaviorRequest"/></param>
        /// <returns><see cref="RegisterBehaviorResponse"/></returns>
        public async Task<RegisterBehaviorResponse> RegisterBehavior(RegisterBehaviorRequest req)
        {
             JsonResponseModel<RegisterBehaviorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterBehavior");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterBehaviorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户查询是否签约和签约行为上报
        /// </summary>
        /// <param name="req"><see cref="RegisterBehaviorRequest"/></param>
        /// <returns><see cref="RegisterBehaviorResponse"/></returns>
        public RegisterBehaviorResponse RegisterBehaviorSync(RegisterBehaviorRequest req)
        {
             JsonResponseModel<RegisterBehaviorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterBehavior");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterBehaviorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 登记挂账(支持撤销)
        /// </summary>
        /// <param name="req"><see cref="RegisterBillRequest"/></param>
        /// <returns><see cref="RegisterBillResponse"/></returns>
        public async Task<RegisterBillResponse> RegisterBill(RegisterBillRequest req)
        {
             JsonResponseModel<RegisterBillResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterBill");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterBillResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 登记挂账(支持撤销)
        /// </summary>
        /// <param name="req"><see cref="RegisterBillRequest"/></param>
        /// <returns><see cref="RegisterBillResponse"/></returns>
        public RegisterBillResponse RegisterBillSync(RegisterBillRequest req)
        {
             JsonResponseModel<RegisterBillResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterBill");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterBillResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 登记挂账(支持撤销)。此接口可实现把不明来账或自有资金等已登记在挂账子账户下的资金调整到普通会员子账户。即通过申请调用此接口，将会减少挂账子账户的资金，调增指定的普通会员子账户的可提现余额及可用余额。此接口不支持把挂账子账户资金清分到功能子账户。
        /// </summary>
        /// <param name="req"><see cref="RegisterBillSupportWithdrawRequest"/></param>
        /// <returns><see cref="RegisterBillSupportWithdrawResponse"/></returns>
        public async Task<RegisterBillSupportWithdrawResponse> RegisterBillSupportWithdraw(RegisterBillSupportWithdrawRequest req)
        {
             JsonResponseModel<RegisterBillSupportWithdrawResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterBillSupportWithdraw");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterBillSupportWithdrawResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 登记挂账(支持撤销)。此接口可实现把不明来账或自有资金等已登记在挂账子账户下的资金调整到普通会员子账户。即通过申请调用此接口，将会减少挂账子账户的资金，调增指定的普通会员子账户的可提现余额及可用余额。此接口不支持把挂账子账户资金清分到功能子账户。
        /// </summary>
        /// <param name="req"><see cref="RegisterBillSupportWithdrawRequest"/></param>
        /// <returns><see cref="RegisterBillSupportWithdrawResponse"/></returns>
        public RegisterBillSupportWithdrawResponse RegisterBillSupportWithdrawSync(RegisterBillSupportWithdrawRequest req)
        {
             JsonResponseModel<RegisterBillSupportWithdrawResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterBillSupportWithdraw");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterBillSupportWithdrawResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 登记挂账撤销。此接口可以实现把RegisterBillSupportWithdraw接口完成的登记挂账进行撤销，即调减普通会员子账户的可提现和可用余额，调增挂账子账户的可用余额。
        /// </summary>
        /// <param name="req"><see cref="RevResigterBillSupportWithdrawRequest"/></param>
        /// <returns><see cref="RevResigterBillSupportWithdrawResponse"/></returns>
        public async Task<RevResigterBillSupportWithdrawResponse> RevResigterBillSupportWithdraw(RevResigterBillSupportWithdrawRequest req)
        {
             JsonResponseModel<RevResigterBillSupportWithdrawResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RevResigterBillSupportWithdraw");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevResigterBillSupportWithdrawResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 登记挂账撤销。此接口可以实现把RegisterBillSupportWithdraw接口完成的登记挂账进行撤销，即调减普通会员子账户的可提现和可用余额，调增挂账子账户的可用余额。
        /// </summary>
        /// <param name="req"><see cref="RevResigterBillSupportWithdrawRequest"/></param>
        /// <returns><see cref="RevResigterBillSupportWithdrawResponse"/></returns>
        public RevResigterBillSupportWithdrawResponse RevResigterBillSupportWithdrawSync(RevResigterBillSupportWithdrawRequest req)
        {
             JsonResponseModel<RevResigterBillSupportWithdrawResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RevResigterBillSupportWithdraw");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevResigterBillSupportWithdrawResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改会员属性-普通商户子账户。修改会员的会员属性。
        /// </summary>
        /// <param name="req"><see cref="ReviseMbrPropertyRequest"/></param>
        /// <returns><see cref="ReviseMbrPropertyResponse"/></returns>
        public async Task<ReviseMbrPropertyResponse> ReviseMbrProperty(ReviseMbrPropertyRequest req)
        {
             JsonResponseModel<ReviseMbrPropertyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ReviseMbrProperty");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReviseMbrPropertyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改会员属性-普通商户子账户。修改会员的会员属性。
        /// </summary>
        /// <param name="req"><see cref="ReviseMbrPropertyRequest"/></param>
        /// <returns><see cref="ReviseMbrPropertyResponse"/></returns>
        public ReviseMbrPropertyResponse ReviseMbrPropertySync(ReviseMbrPropertyRequest req)
        {
             JsonResponseModel<ReviseMbrPropertyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ReviseMbrProperty");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ReviseMbrPropertyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤销会员在途充值(经第三方支付渠道)
        /// </summary>
        /// <param name="req"><see cref="RevokeMemberRechargeThirdPayRequest"/></param>
        /// <returns><see cref="RevokeMemberRechargeThirdPayResponse"/></returns>
        public async Task<RevokeMemberRechargeThirdPayResponse> RevokeMemberRechargeThirdPay(RevokeMemberRechargeThirdPayRequest req)
        {
             JsonResponseModel<RevokeMemberRechargeThirdPayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RevokeMemberRechargeThirdPay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevokeMemberRechargeThirdPayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤销会员在途充值(经第三方支付渠道)
        /// </summary>
        /// <param name="req"><see cref="RevokeMemberRechargeThirdPayRequest"/></param>
        /// <returns><see cref="RevokeMemberRechargeThirdPayResponse"/></returns>
        public RevokeMemberRechargeThirdPayResponse RevokeMemberRechargeThirdPaySync(RevokeMemberRechargeThirdPayRequest req)
        {
             JsonResponseModel<RevokeMemberRechargeThirdPayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RevokeMemberRechargeThirdPay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevokeMemberRechargeThirdPayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤销会员在途充值(经第三方支付渠道)接口
        /// </summary>
        /// <param name="req"><see cref="RevokeRechargeByThirdPayRequest"/></param>
        /// <returns><see cref="RevokeRechargeByThirdPayResponse"/></returns>
        public async Task<RevokeRechargeByThirdPayResponse> RevokeRechargeByThirdPay(RevokeRechargeByThirdPayRequest req)
        {
             JsonResponseModel<RevokeRechargeByThirdPayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RevokeRechargeByThirdPay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevokeRechargeByThirdPayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 撤销会员在途充值(经第三方支付渠道)接口
        /// </summary>
        /// <param name="req"><see cref="RevokeRechargeByThirdPayRequest"/></param>
        /// <returns><see cref="RevokeRechargeByThirdPayResponse"/></returns>
        public RevokeRechargeByThirdPayResponse RevokeRechargeByThirdPaySync(RevokeRechargeByThirdPayRequest req)
        {
             JsonResponseModel<RevokeRechargeByThirdPayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RevokeRechargeByThirdPay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevokeRechargeByThirdPayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对于存量的签约关系导入或者部分场景下米大师无法收到签约通知的场景，需要由调用方主动将签约状态同步至米大师
        /// </summary>
        /// <param name="req"><see cref="SyncContractDataRequest"/></param>
        /// <returns><see cref="SyncContractDataResponse"/></returns>
        public async Task<SyncContractDataResponse> SyncContractData(SyncContractDataRequest req)
        {
             JsonResponseModel<SyncContractDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncContractData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncContractDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对于存量的签约关系导入或者部分场景下米大师无法收到签约通知的场景，需要由调用方主动将签约状态同步至米大师
        /// </summary>
        /// <param name="req"><see cref="SyncContractDataRequest"/></param>
        /// <returns><see cref="SyncContractDataResponse"/></returns>
        public SyncContractDataResponse SyncContractDataSync(SyncContractDataRequest req)
        {
             JsonResponseModel<SyncContractDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncContractData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncContractDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口进行解约
        /// </summary>
        /// <param name="req"><see cref="TerminateContractRequest"/></param>
        /// <returns><see cref="TerminateContractResponse"/></returns>
        public async Task<TerminateContractResponse> TerminateContract(TerminateContractRequest req)
        {
             JsonResponseModel<TerminateContractResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TerminateContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口进行解约
        /// </summary>
        /// <param name="req"><see cref="TerminateContractRequest"/></param>
        /// <returns><see cref="TerminateContractResponse"/></returns>
        public TerminateContractResponse TerminateContractSync(TerminateContractRequest req)
        {
             JsonResponseModel<TerminateContractResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TerminateContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TerminateContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智能代发-单笔代发转账接口
        /// </summary>
        /// <param name="req"><see cref="TransferSinglePayRequest"/></param>
        /// <returns><see cref="TransferSinglePayResponse"/></returns>
        public async Task<TransferSinglePayResponse> TransferSinglePay(TransferSinglePayRequest req)
        {
             JsonResponseModel<TransferSinglePayResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TransferSinglePay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransferSinglePayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智能代发-单笔代发转账接口
        /// </summary>
        /// <param name="req"><see cref="TransferSinglePayRequest"/></param>
        /// <returns><see cref="TransferSinglePayResponse"/></returns>
        public TransferSinglePayResponse TransferSinglePaySync(TransferSinglePayRequest req)
        {
             JsonResponseModel<TransferSinglePayResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TransferSinglePay");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransferSinglePayResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户解除绑定的提现银行卡
        /// </summary>
        /// <param name="req"><see cref="UnBindAcctRequest"/></param>
        /// <returns><see cref="UnBindAcctResponse"/></returns>
        public async Task<UnBindAcctResponse> UnBindAcct(UnBindAcctRequest req)
        {
             JsonResponseModel<UnBindAcctResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindAcct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindAcctResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 商户解除绑定的提现银行卡
        /// </summary>
        /// <param name="req"><see cref="UnBindAcctRequest"/></param>
        /// <returns><see cref="UnBindAcctResponse"/></returns>
        public UnBindAcctResponse UnBindAcctSync(UnBindAcctRequest req)
        {
             JsonResponseModel<UnBindAcctResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindAcct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindAcctResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户银行卡解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindOpenBankExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="UnbindOpenBankExternalSubMerchantBankAccountResponse"/></returns>
        public async Task<UnbindOpenBankExternalSubMerchantBankAccountResponse> UnbindOpenBankExternalSubMerchantBankAccount(UnbindOpenBankExternalSubMerchantBankAccountRequest req)
        {
             JsonResponseModel<UnbindOpenBankExternalSubMerchantBankAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindOpenBankExternalSubMerchantBankAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindOpenBankExternalSubMerchantBankAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户银行卡解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindOpenBankExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="UnbindOpenBankExternalSubMerchantBankAccountResponse"/></returns>
        public UnbindOpenBankExternalSubMerchantBankAccountResponse UnbindOpenBankExternalSubMerchantBankAccountSync(UnbindOpenBankExternalSubMerchantBankAccountRequest req)
        {
             JsonResponseModel<UnbindOpenBankExternalSubMerchantBankAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindOpenBankExternalSubMerchantBankAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindOpenBankExternalSubMerchantBankAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员解绑提现账户。此接口可以支持会员解除名下的绑定账户关系。
        /// </summary>
        /// <param name="req"><see cref="UnbindRelateAcctRequest"/></param>
        /// <returns><see cref="UnbindRelateAcctResponse"/></returns>
        public async Task<UnbindRelateAcctResponse> UnbindRelateAcct(UnbindRelateAcctRequest req)
        {
             JsonResponseModel<UnbindRelateAcctResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindRelateAcct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindRelateAcctResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员解绑提现账户。此接口可以支持会员解除名下的绑定账户关系。
        /// </summary>
        /// <param name="req"><see cref="UnbindRelateAcctRequest"/></param>
        /// <returns><see cref="UnbindRelateAcctResponse"/></returns>
        public UnbindRelateAcctResponse UnbindRelateAcctSync(UnbindRelateAcctRequest req)
        {
             JsonResponseModel<UnbindRelateAcctResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindRelateAcct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindRelateAcctResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 应用需要先调用本接口生成支付订单号，并将应答的PayInfo透传给聚鑫SDK，拉起客户端（包括微信公众号/微信小程序/客户端App）支付。
        /// </summary>
        /// <param name="req"><see cref="UnifiedCloudOrderRequest"/></param>
        /// <returns><see cref="UnifiedCloudOrderResponse"/></returns>
        public async Task<UnifiedCloudOrderResponse> UnifiedCloudOrder(UnifiedCloudOrderRequest req)
        {
             JsonResponseModel<UnifiedCloudOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnifiedCloudOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnifiedCloudOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 应用需要先调用本接口生成支付订单号，并将应答的PayInfo透传给聚鑫SDK，拉起客户端（包括微信公众号/微信小程序/客户端App）支付。
        /// </summary>
        /// <param name="req"><see cref="UnifiedCloudOrderRequest"/></param>
        /// <returns><see cref="UnifiedCloudOrderResponse"/></returns>
        public UnifiedCloudOrderResponse UnifiedCloudOrderSync(UnifiedCloudOrderRequest req)
        {
             JsonResponseModel<UnifiedCloudOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnifiedCloudOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnifiedCloudOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 应用需要先调用本接口生成支付订单号，并将应答的PayInfo透传给聚鑫SDK，拉起客户端（包括微信公众号/微信小程序/客户端App）支付。
        /// </summary>
        /// <param name="req"><see cref="UnifiedOrderRequest"/></param>
        /// <returns><see cref="UnifiedOrderResponse"/></returns>
        public async Task<UnifiedOrderResponse> UnifiedOrder(UnifiedOrderRequest req)
        {
             JsonResponseModel<UnifiedOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnifiedOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnifiedOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 应用需要先调用本接口生成支付订单号，并将应答的PayInfo透传给聚鑫SDK，拉起客户端（包括微信公众号/微信小程序/客户端App）支付。
        /// </summary>
        /// <param name="req"><see cref="UnifiedOrderRequest"/></param>
        /// <returns><see cref="UnifiedOrderResponse"/></returns>
        public UnifiedOrderResponse UnifiedOrderSync(UnifiedOrderRequest req)
        {
             JsonResponseModel<UnifiedOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnifiedOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnifiedOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-统一下单接口
        /// </summary>
        /// <param name="req"><see cref="UnifiedTlinxOrderRequest"/></param>
        /// <returns><see cref="UnifiedTlinxOrderResponse"/></returns>
        public async Task<UnifiedTlinxOrderResponse> UnifiedTlinxOrder(UnifiedTlinxOrderRequest req)
        {
             JsonResponseModel<UnifiedTlinxOrderResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnifiedTlinxOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnifiedTlinxOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-统一下单接口
        /// </summary>
        /// <param name="req"><see cref="UnifiedTlinxOrderRequest"/></param>
        /// <returns><see cref="UnifiedTlinxOrderResponse"/></returns>
        public UnifiedTlinxOrderResponse UnifiedTlinxOrderSync(UnifiedTlinxOrderRequest req)
        {
             JsonResponseModel<UnifiedTlinxOrderResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnifiedTlinxOrder");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnifiedTlinxOrderResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-上传主播信息
        /// </summary>
        /// <param name="req"><see cref="UploadExternalAnchorInfoRequest"/></param>
        /// <returns><see cref="UploadExternalAnchorInfoResponse"/></returns>
        public async Task<UploadExternalAnchorInfoResponse> UploadExternalAnchorInfo(UploadExternalAnchorInfoRequest req)
        {
             JsonResponseModel<UploadExternalAnchorInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadExternalAnchorInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadExternalAnchorInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 灵云-上传主播信息
        /// </summary>
        /// <param name="req"><see cref="UploadExternalAnchorInfoRequest"/></param>
        /// <returns><see cref="UploadExternalAnchorInfoResponse"/></returns>
        public UploadExternalAnchorInfoResponse UploadExternalAnchorInfoSync(UploadExternalAnchorInfoRequest req)
        {
             JsonResponseModel<UploadExternalAnchorInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadExternalAnchorInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadExternalAnchorInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-文件上传
        /// </summary>
        /// <param name="req"><see cref="UploadFileRequest"/></param>
        /// <returns><see cref="UploadFileResponse"/></returns>
        public async Task<UploadFileResponse> UploadFile(UploadFileRequest req)
        {
             JsonResponseModel<UploadFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-文件上传
        /// </summary>
        /// <param name="req"><see cref="UploadFileRequest"/></param>
        /// <returns><see cref="UploadFileResponse"/></returns>
        public UploadFileResponse UploadFileSync(UploadFileRequest req)
        {
             JsonResponseModel<UploadFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户资质文件上传
        /// </summary>
        /// <param name="req"><see cref="UploadOpenBankSubMerchantCredentialRequest"/></param>
        /// <returns><see cref="UploadOpenBankSubMerchantCredentialResponse"/></returns>
        public async Task<UploadOpenBankSubMerchantCredentialResponse> UploadOpenBankSubMerchantCredential(UploadOpenBankSubMerchantCredentialRequest req)
        {
             JsonResponseModel<UploadOpenBankSubMerchantCredentialResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadOpenBankSubMerchantCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadOpenBankSubMerchantCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户资质文件上传
        /// </summary>
        /// <param name="req"><see cref="UploadOpenBankSubMerchantCredentialRequest"/></param>
        /// <returns><see cref="UploadOpenBankSubMerchantCredentialResponse"/></returns>
        public UploadOpenBankSubMerchantCredentialResponse UploadOpenBankSubMerchantCredentialSync(UploadOpenBankSubMerchantCredentialRequest req)
        {
             JsonResponseModel<UploadOpenBankSubMerchantCredentialResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadOpenBankSubMerchantCredential");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadOpenBankSubMerchantCredentialResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-上传机构文件接口
        /// </summary>
        /// <param name="req"><see cref="UploadOrgFileRequest"/></param>
        /// <returns><see cref="UploadOrgFileResponse"/></returns>
        public async Task<UploadOrgFileResponse> UploadOrgFile(UploadOrgFileRequest req)
        {
             JsonResponseModel<UploadOrgFileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadOrgFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadOrgFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-上传机构文件接口
        /// </summary>
        /// <param name="req"><see cref="UploadOrgFileRequest"/></param>
        /// <returns><see cref="UploadOrgFileResponse"/></returns>
        public UploadOrgFileResponse UploadOrgFileSync(UploadOrgFileRequest req)
        {
             JsonResponseModel<UploadOrgFileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadOrgFile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadOrgFileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-上传代理商完税列表
        /// </summary>
        /// <param name="req"><see cref="UploadTaxListRequest"/></param>
        /// <returns><see cref="UploadTaxListResponse"/></returns>
        public async Task<UploadTaxListResponse> UploadTaxList(UploadTaxListRequest req)
        {
             JsonResponseModel<UploadTaxListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadTaxList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadTaxListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-上传代理商完税列表
        /// </summary>
        /// <param name="req"><see cref="UploadTaxListRequest"/></param>
        /// <returns><see cref="UploadTaxListResponse"/></returns>
        public UploadTaxListResponse UploadTaxListSync(UploadTaxListRequest req)
        {
             JsonResponseModel<UploadTaxListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadTaxList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadTaxListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-上传代理商完税证明
        /// </summary>
        /// <param name="req"><see cref="UploadTaxPaymentRequest"/></param>
        /// <returns><see cref="UploadTaxPaymentResponse"/></returns>
        public async Task<UploadTaxPaymentResponse> UploadTaxPayment(UploadTaxPaymentRequest req)
        {
             JsonResponseModel<UploadTaxPaymentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadTaxPayment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadTaxPaymentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 直播平台-上传代理商完税证明
        /// </summary>
        /// <param name="req"><see cref="UploadTaxPaymentRequest"/></param>
        /// <returns><see cref="UploadTaxPaymentResponse"/></returns>
        public UploadTaxPaymentResponse UploadTaxPaymentSync(UploadTaxPaymentRequest req)
        {
             JsonResponseModel<UploadTaxPaymentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadTaxPayment");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadTaxPaymentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户银行卡打款验证，在接入TENPAY渠道EBANK_PAYMENT付款时，若客户期望接入担保支付，需在接入前先完成，收款商户绑定的银行卡进行打款验证。验证成功后，才可以调用CreateOpenBankPaymentOrder接口进行担保支付下单。
        /// </summary>
        /// <param name="req"><see cref="VerifyOpenBankAccountRequest"/></param>
        /// <returns><see cref="VerifyOpenBankAccountResponse"/></returns>
        public async Task<VerifyOpenBankAccountResponse> VerifyOpenBankAccount(VerifyOpenBankAccountRequest req)
        {
             JsonResponseModel<VerifyOpenBankAccountResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyOpenBankAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyOpenBankAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云企付-子商户银行卡打款验证，在接入TENPAY渠道EBANK_PAYMENT付款时，若客户期望接入担保支付，需在接入前先完成，收款商户绑定的银行卡进行打款验证。验证成功后，才可以调用CreateOpenBankPaymentOrder接口进行担保支付下单。
        /// </summary>
        /// <param name="req"><see cref="VerifyOpenBankAccountRequest"/></param>
        /// <returns><see cref="VerifyOpenBankAccountResponse"/></returns>
        public VerifyOpenBankAccountResponse VerifyOpenBankAccountSync(VerifyOpenBankAccountRequest req)
        {
             JsonResponseModel<VerifyOpenBankAccountResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyOpenBankAccount");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyOpenBankAccountResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询合同明细接口
        /// </summary>
        /// <param name="req"><see cref="ViewContractRequest"/></param>
        /// <returns><see cref="ViewContractResponse"/></returns>
        public async Task<ViewContractResponse> ViewContract(ViewContractRequest req)
        {
             JsonResponseModel<ViewContractResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ViewContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ViewContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询合同明细接口
        /// </summary>
        /// <param name="req"><see cref="ViewContractRequest"/></param>
        /// <returns><see cref="ViewContractResponse"/></returns>
        public ViewContractResponse ViewContractSync(ViewContractRequest req)
        {
             JsonResponseModel<ViewContractResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ViewContract");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ViewContractResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询商户明细接口
        /// </summary>
        /// <param name="req"><see cref="ViewMerchantRequest"/></param>
        /// <returns><see cref="ViewMerchantResponse"/></returns>
        public async Task<ViewMerchantResponse> ViewMerchant(ViewMerchantRequest req)
        {
             JsonResponseModel<ViewMerchantResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ViewMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ViewMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询商户明细接口
        /// </summary>
        /// <param name="req"><see cref="ViewMerchantRequest"/></param>
        /// <returns><see cref="ViewMerchantResponse"/></returns>
        public ViewMerchantResponse ViewMerchantSync(ViewMerchantRequest req)
        {
             JsonResponseModel<ViewMerchantResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ViewMerchant");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ViewMerchantResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询门店明细接口
        /// </summary>
        /// <param name="req"><see cref="ViewShopRequest"/></param>
        /// <returns><see cref="ViewShopResponse"/></returns>
        public async Task<ViewShopResponse> ViewShop(ViewShopRequest req)
        {
             JsonResponseModel<ViewShopResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ViewShop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ViewShopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 云支付-查询门店明细接口
        /// </summary>
        /// <param name="req"><see cref="ViewShopRequest"/></param>
        /// <returns><see cref="ViewShopResponse"/></returns>
        public ViewShopResponse ViewShopSync(ViewShopRequest req)
        {
             JsonResponseModel<ViewShopResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ViewShop");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ViewShopResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员提现-不验证。此接口受理会员发起的提现申请。会员子账户的可提现余额、可用余额会减少，市场的资金汇总账户(监管账户)会减少相应的发生金额，提现到会员申请的收款账户。		
        /// </summary>
        /// <param name="req"><see cref="WithdrawCashMembershipRequest"/></param>
        /// <returns><see cref="WithdrawCashMembershipResponse"/></returns>
        public async Task<WithdrawCashMembershipResponse> WithdrawCashMembership(WithdrawCashMembershipRequest req)
        {
             JsonResponseModel<WithdrawCashMembershipResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "WithdrawCashMembership");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<WithdrawCashMembershipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 会员提现-不验证。此接口受理会员发起的提现申请。会员子账户的可提现余额、可用余额会减少，市场的资金汇总账户(监管账户)会减少相应的发生金额，提现到会员申请的收款账户。		
        /// </summary>
        /// <param name="req"><see cref="WithdrawCashMembershipRequest"/></param>
        /// <returns><see cref="WithdrawCashMembershipResponse"/></returns>
        public WithdrawCashMembershipResponse WithdrawCashMembershipSync(WithdrawCashMembershipRequest req)
        {
             JsonResponseModel<WithdrawCashMembershipResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "WithdrawCashMembership");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<WithdrawCashMembershipResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
