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
       private const string sdkVersion = "SDK_NET_3.0.1037";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CpdpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 云支付-添加合同接口
        /// </summary>
        /// <param name="req"><see cref="AddContractRequest"/></param>
        /// <returns><see cref="AddContractResponse"/></returns>
        public Task<AddContractResponse> AddContract(AddContractRequest req)
        {
            return InternalRequestAsync<AddContractResponse>(req, "AddContract");
        }

        /// <summary>
        /// 云支付-添加合同接口
        /// </summary>
        /// <param name="req"><see cref="AddContractRequest"/></param>
        /// <returns><see cref="AddContractResponse"/></returns>
        public AddContractResponse AddContractSync(AddContractRequest req)
        {
            return InternalRequestAsync<AddContractResponse>(req, "AddContract")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-绑定收款用户资金账号信息
        /// </summary>
        /// <param name="req"><see cref="AddFlexFundingAccountRequest"/></param>
        /// <returns><see cref="AddFlexFundingAccountResponse"/></returns>
        public Task<AddFlexFundingAccountResponse> AddFlexFundingAccount(AddFlexFundingAccountRequest req)
        {
            return InternalRequestAsync<AddFlexFundingAccountResponse>(req, "AddFlexFundingAccount");
        }

        /// <summary>
        /// 灵云V2-绑定收款用户资金账号信息
        /// </summary>
        /// <param name="req"><see cref="AddFlexFundingAccountRequest"/></param>
        /// <returns><see cref="AddFlexFundingAccountResponse"/></returns>
        public AddFlexFundingAccountResponse AddFlexFundingAccountSync(AddFlexFundingAccountRequest req)
        {
            return InternalRequestAsync<AddFlexFundingAccountResponse>(req, "AddFlexFundingAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-补充证件信息
        /// </summary>
        /// <param name="req"><see cref="AddFlexIdInfoRequest"/></param>
        /// <returns><see cref="AddFlexIdInfoResponse"/></returns>
        public Task<AddFlexIdInfoResponse> AddFlexIdInfo(AddFlexIdInfoRequest req)
        {
            return InternalRequestAsync<AddFlexIdInfoResponse>(req, "AddFlexIdInfo");
        }

        /// <summary>
        /// 灵云V2-补充证件信息
        /// </summary>
        /// <param name="req"><see cref="AddFlexIdInfoRequest"/></param>
        /// <returns><see cref="AddFlexIdInfoResponse"/></returns>
        public AddFlexIdInfoResponse AddFlexIdInfoSync(AddFlexIdInfoRequest req)
        {
            return InternalRequestAsync<AddFlexIdInfoResponse>(req, "AddFlexIdInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-补充手机号信息
        /// </summary>
        /// <param name="req"><see cref="AddFlexPhoneNoRequest"/></param>
        /// <returns><see cref="AddFlexPhoneNoResponse"/></returns>
        public Task<AddFlexPhoneNoResponse> AddFlexPhoneNo(AddFlexPhoneNoRequest req)
        {
            return InternalRequestAsync<AddFlexPhoneNoResponse>(req, "AddFlexPhoneNo");
        }

        /// <summary>
        /// 灵云V2-补充手机号信息
        /// </summary>
        /// <param name="req"><see cref="AddFlexPhoneNoRequest"/></param>
        /// <returns><see cref="AddFlexPhoneNoResponse"/></returns>
        public AddFlexPhoneNoResponse AddFlexPhoneNoSync(AddFlexPhoneNoRequest req)
        {
            return InternalRequestAsync<AddFlexPhoneNoResponse>(req, "AddFlexPhoneNo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-添加商户接口
        /// </summary>
        /// <param name="req"><see cref="AddMerchantRequest"/></param>
        /// <returns><see cref="AddMerchantResponse"/></returns>
        public Task<AddMerchantResponse> AddMerchant(AddMerchantRequest req)
        {
            return InternalRequestAsync<AddMerchantResponse>(req, "AddMerchant");
        }

        /// <summary>
        /// 云支付-添加商户接口
        /// </summary>
        /// <param name="req"><see cref="AddMerchantRequest"/></param>
        /// <returns><see cref="AddMerchantResponse"/></returns>
        public AddMerchantResponse AddMerchantSync(AddMerchantRequest req)
        {
            return InternalRequestAsync<AddMerchantResponse>(req, "AddMerchant")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-添加门店接口
        /// </summary>
        /// <param name="req"><see cref="AddShopRequest"/></param>
        /// <returns><see cref="AddShopResponse"/></returns>
        public Task<AddShopResponse> AddShop(AddShopRequest req)
        {
            return InternalRequestAsync<AddShopResponse>(req, "AddShop");
        }

        /// <summary>
        /// 云支付-添加门店接口
        /// </summary>
        /// <param name="req"><see cref="AddShopRequest"/></param>
        /// <returns><see cref="AddShopResponse"/></returns>
        public AddShopResponse AddShopSync(AddShopRequest req)
        {
            return InternalRequestAsync<AddShopResponse>(req, "AddShop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 跨境-提交申报材料。申报材料的主体是付款人，需要提前调用【跨境-付款人申请】接口提交付款人信息且审核通过后调用。
        /// </summary>
        /// <param name="req"><see cref="ApplyApplicationMaterialRequest"/></param>
        /// <returns><see cref="ApplyApplicationMaterialResponse"/></returns>
        public Task<ApplyApplicationMaterialResponse> ApplyApplicationMaterial(ApplyApplicationMaterialRequest req)
        {
            return InternalRequestAsync<ApplyApplicationMaterialResponse>(req, "ApplyApplicationMaterial");
        }

        /// <summary>
        /// 跨境-提交申报材料。申报材料的主体是付款人，需要提前调用【跨境-付款人申请】接口提交付款人信息且审核通过后调用。
        /// </summary>
        /// <param name="req"><see cref="ApplyApplicationMaterialRequest"/></param>
        /// <returns><see cref="ApplyApplicationMaterialResponse"/></returns>
        public ApplyApplicationMaterialResponse ApplyApplicationMaterialSync(ApplyApplicationMaterialRequest req)
        {
            return InternalRequestAsync<ApplyApplicationMaterialResponse>(req, "ApplyApplicationMaterial")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-付款
        /// </summary>
        /// <param name="req"><see cref="ApplyFlexPaymentRequest"/></param>
        /// <returns><see cref="ApplyFlexPaymentResponse"/></returns>
        public Task<ApplyFlexPaymentResponse> ApplyFlexPayment(ApplyFlexPaymentRequest req)
        {
            return InternalRequestAsync<ApplyFlexPaymentResponse>(req, "ApplyFlexPayment");
        }

        /// <summary>
        /// 灵云V2-付款
        /// </summary>
        /// <param name="req"><see cref="ApplyFlexPaymentRequest"/></param>
        /// <returns><see cref="ApplyFlexPaymentResponse"/></returns>
        public ApplyFlexPaymentResponse ApplyFlexPaymentSync(ApplyFlexPaymentRequest req)
        {
            return InternalRequestAsync<ApplyFlexPaymentResponse>(req, "ApplyFlexPayment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-结算
        /// </summary>
        /// <param name="req"><see cref="ApplyFlexSettlementRequest"/></param>
        /// <returns><see cref="ApplyFlexSettlementResponse"/></returns>
        public Task<ApplyFlexSettlementResponse> ApplyFlexSettlement(ApplyFlexSettlementRequest req)
        {
            return InternalRequestAsync<ApplyFlexSettlementResponse>(req, "ApplyFlexSettlement");
        }

        /// <summary>
        /// 灵云V2-结算
        /// </summary>
        /// <param name="req"><see cref="ApplyFlexSettlementRequest"/></param>
        /// <returns><see cref="ApplyFlexSettlementResponse"/></returns>
        public ApplyFlexSettlementResponse ApplyFlexSettlementSync(ApplyFlexSettlementRequest req)
        {
            return InternalRequestAsync<ApplyFlexSettlementResponse>(req, "ApplyFlexSettlement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 微工卡开通预核身接口
        /// </summary>
        /// <param name="req"><see cref="ApplyFlexWechatPreAuthRequest"/></param>
        /// <returns><see cref="ApplyFlexWechatPreAuthResponse"/></returns>
        public Task<ApplyFlexWechatPreAuthResponse> ApplyFlexWechatPreAuth(ApplyFlexWechatPreAuthRequest req)
        {
            return InternalRequestAsync<ApplyFlexWechatPreAuthResponse>(req, "ApplyFlexWechatPreAuth");
        }

        /// <summary>
        /// 微工卡开通预核身接口
        /// </summary>
        /// <param name="req"><see cref="ApplyFlexWechatPreAuthRequest"/></param>
        /// <returns><see cref="ApplyFlexWechatPreAuthResponse"/></returns>
        public ApplyFlexWechatPreAuthResponse ApplyFlexWechatPreAuthSync(ApplyFlexWechatPreAuthRequest req)
        {
            return InternalRequestAsync<ApplyFlexWechatPreAuthResponse>(req, "ApplyFlexWechatPreAuth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-申请单笔交易回单
        /// </summary>
        /// <param name="req"><see cref="ApplyOpenBankOrderDetailReceiptRequest"/></param>
        /// <returns><see cref="ApplyOpenBankOrderDetailReceiptResponse"/></returns>
        public Task<ApplyOpenBankOrderDetailReceiptResponse> ApplyOpenBankOrderDetailReceipt(ApplyOpenBankOrderDetailReceiptRequest req)
        {
            return InternalRequestAsync<ApplyOpenBankOrderDetailReceiptResponse>(req, "ApplyOpenBankOrderDetailReceipt");
        }

        /// <summary>
        /// 云企付-申请单笔交易回单
        /// </summary>
        /// <param name="req"><see cref="ApplyOpenBankOrderDetailReceiptRequest"/></param>
        /// <returns><see cref="ApplyOpenBankOrderDetailReceiptResponse"/></returns>
        public ApplyOpenBankOrderDetailReceiptResponse ApplyOpenBankOrderDetailReceiptSync(ApplyOpenBankOrderDetailReceiptRequest req)
        {
            return InternalRequestAsync<ApplyOpenBankOrderDetailReceiptResponse>(req, "ApplyOpenBankOrderDetailReceipt")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-结算申请接口
        /// </summary>
        /// <param name="req"><see cref="ApplyOpenBankSettleOrderRequest"/></param>
        /// <returns><see cref="ApplyOpenBankSettleOrderResponse"/></returns>
        public Task<ApplyOpenBankSettleOrderResponse> ApplyOpenBankSettleOrder(ApplyOpenBankSettleOrderRequest req)
        {
            return InternalRequestAsync<ApplyOpenBankSettleOrderResponse>(req, "ApplyOpenBankSettleOrder");
        }

        /// <summary>
        /// 云企付-结算申请接口
        /// </summary>
        /// <param name="req"><see cref="ApplyOpenBankSettleOrderRequest"/></param>
        /// <returns><see cref="ApplyOpenBankSettleOrderResponse"/></returns>
        public ApplyOpenBankSettleOrderResponse ApplyOpenBankSettleOrderSync(ApplyOpenBankSettleOrderRequest req)
        {
            return InternalRequestAsync<ApplyOpenBankSettleOrderResponse>(req, "ApplyOpenBankSettleOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 子商户在线签约
        /// </summary>
        /// <param name="req"><see cref="ApplyOpenBankSubMerchantSignOnlineRequest"/></param>
        /// <returns><see cref="ApplyOpenBankSubMerchantSignOnlineResponse"/></returns>
        public Task<ApplyOpenBankSubMerchantSignOnlineResponse> ApplyOpenBankSubMerchantSignOnline(ApplyOpenBankSubMerchantSignOnlineRequest req)
        {
            return InternalRequestAsync<ApplyOpenBankSubMerchantSignOnlineResponse>(req, "ApplyOpenBankSubMerchantSignOnline");
        }

        /// <summary>
        /// 子商户在线签约
        /// </summary>
        /// <param name="req"><see cref="ApplyOpenBankSubMerchantSignOnlineRequest"/></param>
        /// <returns><see cref="ApplyOpenBankSubMerchantSignOnlineResponse"/></returns>
        public ApplyOpenBankSubMerchantSignOnlineResponse ApplyOpenBankSubMerchantSignOnlineSync(ApplyOpenBankSubMerchantSignOnlineRequest req)
        {
            return InternalRequestAsync<ApplyOpenBankSubMerchantSignOnlineResponse>(req, "ApplyOpenBankSubMerchantSignOnline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 跨境-汇出指令申请。通过该接口可将对接方账户中的人民币余额汇兑成外币，再汇出至指定银行账户。
        /// </summary>
        /// <param name="req"><see cref="ApplyOutwardOrderRequest"/></param>
        /// <returns><see cref="ApplyOutwardOrderResponse"/></returns>
        public Task<ApplyOutwardOrderResponse> ApplyOutwardOrder(ApplyOutwardOrderRequest req)
        {
            return InternalRequestAsync<ApplyOutwardOrderResponse>(req, "ApplyOutwardOrder");
        }

        /// <summary>
        /// 跨境-汇出指令申请。通过该接口可将对接方账户中的人民币余额汇兑成外币，再汇出至指定银行账户。
        /// </summary>
        /// <param name="req"><see cref="ApplyOutwardOrderRequest"/></param>
        /// <returns><see cref="ApplyOutwardOrderResponse"/></returns>
        public ApplyOutwardOrderResponse ApplyOutwardOrderSync(ApplyOutwardOrderRequest req)
        {
            return InternalRequestAsync<ApplyOutwardOrderResponse>(req, "ApplyOutwardOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 跨境-付款人申请。通过该接口提交付款人信息并进行 kyc 审核。
        /// </summary>
        /// <param name="req"><see cref="ApplyPayerInfoRequest"/></param>
        /// <returns><see cref="ApplyPayerInfoResponse"/></returns>
        public Task<ApplyPayerInfoResponse> ApplyPayerInfo(ApplyPayerInfoRequest req)
        {
            return InternalRequestAsync<ApplyPayerInfoResponse>(req, "ApplyPayerInfo");
        }

        /// <summary>
        /// 跨境-付款人申请。通过该接口提交付款人信息并进行 kyc 审核。
        /// </summary>
        /// <param name="req"><see cref="ApplyPayerInfoRequest"/></param>
        /// <returns><see cref="ApplyPayerInfoResponse"/></returns>
        public ApplyPayerInfoResponse ApplyPayerInfoSync(ApplyPayerInfoRequest req)
        {
            return InternalRequestAsync<ApplyPayerInfoResponse>(req, "ApplyPayerInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 正常结算提现失败情况下，发起重新提现的请求接口
        /// </summary>
        /// <param name="req"><see cref="ApplyReWithdrawalRequest"/></param>
        /// <returns><see cref="ApplyReWithdrawalResponse"/></returns>
        public Task<ApplyReWithdrawalResponse> ApplyReWithdrawal(ApplyReWithdrawalRequest req)
        {
            return InternalRequestAsync<ApplyReWithdrawalResponse>(req, "ApplyReWithdrawal");
        }

        /// <summary>
        /// 正常结算提现失败情况下，发起重新提现的请求接口
        /// </summary>
        /// <param name="req"><see cref="ApplyReWithdrawalRequest"/></param>
        /// <returns><see cref="ApplyReWithdrawalResponse"/></returns>
        public ApplyReWithdrawalResponse ApplyReWithdrawalSync(ApplyReWithdrawalRequest req)
        {
            return InternalRequestAsync<ApplyReWithdrawalResponse>(req, "ApplyReWithdrawal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 聚鑫-申请对账文件
        /// </summary>
        /// <param name="req"><see cref="ApplyReconciliationFileRequest"/></param>
        /// <returns><see cref="ApplyReconciliationFileResponse"/></returns>
        public Task<ApplyReconciliationFileResponse> ApplyReconciliationFile(ApplyReconciliationFileRequest req)
        {
            return InternalRequestAsync<ApplyReconciliationFileResponse>(req, "ApplyReconciliationFile");
        }

        /// <summary>
        /// 聚鑫-申请对账文件
        /// </summary>
        /// <param name="req"><see cref="ApplyReconciliationFileRequest"/></param>
        /// <returns><see cref="ApplyReconciliationFileResponse"/></returns>
        public ApplyReconciliationFileResponse ApplyReconciliationFileSync(ApplyReconciliationFileRequest req)
        {
            return InternalRequestAsync<ApplyReconciliationFileResponse>(req, "ApplyReconciliationFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 跨境-提交贸易材料。通过提交贸易材料接口可为对接方累计贸易额度，在额度范围内可发起汇兑汇出交易。
        /// </summary>
        /// <param name="req"><see cref="ApplyTradeRequest"/></param>
        /// <returns><see cref="ApplyTradeResponse"/></returns>
        public Task<ApplyTradeResponse> ApplyTrade(ApplyTradeRequest req)
        {
            return InternalRequestAsync<ApplyTradeResponse>(req, "ApplyTrade");
        }

        /// <summary>
        /// 跨境-提交贸易材料。通过提交贸易材料接口可为对接方累计贸易额度，在额度范围内可发起汇兑汇出交易。
        /// </summary>
        /// <param name="req"><see cref="ApplyTradeRequest"/></param>
        /// <returns><see cref="ApplyTradeResponse"/></returns>
        public ApplyTradeResponse ApplyTradeSync(ApplyTradeRequest req)
        {
            return InternalRequestAsync<ApplyTradeResponse>(req, "ApplyTrade")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 商户提现
        /// </summary>
        /// <param name="req"><see cref="ApplyWithdrawalRequest"/></param>
        /// <returns><see cref="ApplyWithdrawalResponse"/></returns>
        public Task<ApplyWithdrawalResponse> ApplyWithdrawal(ApplyWithdrawalRequest req)
        {
            return InternalRequestAsync<ApplyWithdrawalResponse>(req, "ApplyWithdrawal");
        }

        /// <summary>
        /// 商户提现
        /// </summary>
        /// <param name="req"><see cref="ApplyWithdrawalRequest"/></param>
        /// <returns><see cref="ApplyWithdrawalResponse"/></returns>
        public ApplyWithdrawalResponse ApplyWithdrawalSync(ApplyWithdrawalRequest req)
        {
            return InternalRequestAsync<ApplyWithdrawalResponse>(req, "ApplyWithdrawal")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云-绑定账号
        /// </summary>
        /// <param name="req"><see cref="BindAccountRequest"/></param>
        /// <returns><see cref="BindAccountResponse"/></returns>
        public Task<BindAccountResponse> BindAccount(BindAccountRequest req)
        {
            return InternalRequestAsync<BindAccountResponse>(req, "BindAccount");
        }

        /// <summary>
        /// 灵云-绑定账号
        /// </summary>
        /// <param name="req"><see cref="BindAccountRequest"/></param>
        /// <returns><see cref="BindAccountResponse"/></returns>
        public BindAccountResponse BindAccountSync(BindAccountRequest req)
        {
            return InternalRequestAsync<BindAccountResponse>(req, "BindAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 商户绑定提现银行卡，每个商户只能绑定一张提现银行卡
        /// </summary>
        /// <param name="req"><see cref="BindAcctRequest"/></param>
        /// <returns><see cref="BindAcctResponse"/></returns>
        public Task<BindAcctResponse> BindAcct(BindAcctRequest req)
        {
            return InternalRequestAsync<BindAcctResponse>(req, "BindAcct");
        }

        /// <summary>
        /// 商户绑定提现银行卡，每个商户只能绑定一张提现银行卡
        /// </summary>
        /// <param name="req"><see cref="BindAcctRequest"/></param>
        /// <returns><see cref="BindAcctResponse"/></returns>
        public BindAcctResponse BindAcctSync(BindAcctRequest req)
        {
            return InternalRequestAsync<BindAcctResponse>(req, "BindAcct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-子商户银行卡绑定
        /// </summary>
        /// <param name="req"><see cref="BindOpenBankExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="BindOpenBankExternalSubMerchantBankAccountResponse"/></returns>
        public Task<BindOpenBankExternalSubMerchantBankAccountResponse> BindOpenBankExternalSubMerchantBankAccount(BindOpenBankExternalSubMerchantBankAccountRequest req)
        {
            return InternalRequestAsync<BindOpenBankExternalSubMerchantBankAccountResponse>(req, "BindOpenBankExternalSubMerchantBankAccount");
        }

        /// <summary>
        /// 云企付-子商户银行卡绑定
        /// </summary>
        /// <param name="req"><see cref="BindOpenBankExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="BindOpenBankExternalSubMerchantBankAccountResponse"/></returns>
        public BindOpenBankExternalSubMerchantBankAccountResponse BindOpenBankExternalSubMerchantBankAccountSync(BindOpenBankExternalSubMerchantBankAccountRequest req)
        {
            return InternalRequestAsync<BindOpenBankExternalSubMerchantBankAccountResponse>(req, "BindOpenBankExternalSubMerchantBankAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-绑定分账收款方
        /// </summary>
        /// <param name="req"><see cref="BindOpenBankProfitSharePayeeRequest"/></param>
        /// <returns><see cref="BindOpenBankProfitSharePayeeResponse"/></returns>
        public Task<BindOpenBankProfitSharePayeeResponse> BindOpenBankProfitSharePayee(BindOpenBankProfitSharePayeeRequest req)
        {
            return InternalRequestAsync<BindOpenBankProfitSharePayeeResponse>(req, "BindOpenBankProfitSharePayee");
        }

        /// <summary>
        /// 云企付-绑定分账收款方
        /// </summary>
        /// <param name="req"><see cref="BindOpenBankProfitSharePayeeRequest"/></param>
        /// <returns><see cref="BindOpenBankProfitSharePayeeResponse"/></returns>
        public BindOpenBankProfitSharePayeeResponse BindOpenBankProfitSharePayeeSync(BindOpenBankProfitSharePayeeRequest req)
        {
            return InternalRequestAsync<BindOpenBankProfitSharePayeeResponse>(req, "BindOpenBankProfitSharePayee")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 会员绑定提现账户-回填银联鉴权短信码。用于会员填写动态验证码后，发往银行进行验证，验证成功则完成绑定。
        /// </summary>
        /// <param name="req"><see cref="BindRelateAccReUnionPayRequest"/></param>
        /// <returns><see cref="BindRelateAccReUnionPayResponse"/></returns>
        public Task<BindRelateAccReUnionPayResponse> BindRelateAccReUnionPay(BindRelateAccReUnionPayRequest req)
        {
            return InternalRequestAsync<BindRelateAccReUnionPayResponse>(req, "BindRelateAccReUnionPay");
        }

        /// <summary>
        /// 会员绑定提现账户-回填银联鉴权短信码。用于会员填写动态验证码后，发往银行进行验证，验证成功则完成绑定。
        /// </summary>
        /// <param name="req"><see cref="BindRelateAccReUnionPayRequest"/></param>
        /// <returns><see cref="BindRelateAccReUnionPayResponse"/></returns>
        public BindRelateAccReUnionPayResponse BindRelateAccReUnionPaySync(BindRelateAccReUnionPayRequest req)
        {
            return InternalRequestAsync<BindRelateAccReUnionPayResponse>(req, "BindRelateAccReUnionPay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 会员绑定提现账户-小额鉴权。会员申请绑定提现账户，绑定后从会员子账户中提现到绑定账户。
        /// 转账鉴权有两种形式：往账鉴权和来账鉴权。
        /// 往账鉴权：该接口发起成功后，银行会向提现账户转入小于等于0.5元的随机金额，并短信通知客户查看，客户查看后，需将收到的金额大小，在电商平台页面上回填，并通知银行。银行验证通过后，完成提现账户绑定。
        /// 来账鉴权：该接口发起成功后，银行以短信通知客户查看，客户查看后，需通过待绑定的账户往市场的监管账户转入短信上指定的金额。银行检索到该笔指定金额的来账是源自待绑定账户，则绑定成功。平安银行的账户，即BankType送1时，大小额行号和超级网银号都不用送。
        /// </summary>
        /// <param name="req"><see cref="BindRelateAcctSmallAmountRequest"/></param>
        /// <returns><see cref="BindRelateAcctSmallAmountResponse"/></returns>
        public Task<BindRelateAcctSmallAmountResponse> BindRelateAcctSmallAmount(BindRelateAcctSmallAmountRequest req)
        {
            return InternalRequestAsync<BindRelateAcctSmallAmountResponse>(req, "BindRelateAcctSmallAmount");
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
            return InternalRequestAsync<BindRelateAcctSmallAmountResponse>(req, "BindRelateAcctSmallAmount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        public Task<BindRelateAcctUnionPayResponse> BindRelateAcctUnionPay(BindRelateAcctUnionPayRequest req)
        {
            return InternalRequestAsync<BindRelateAcctUnionPayResponse>(req, "BindRelateAcctUnionPay");
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
            return InternalRequestAsync<BindRelateAcctUnionPayResponse>(req, "BindRelateAcctUnionPay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 商户绑定提现银行卡的验证接口
        /// </summary>
        /// <param name="req"><see cref="CheckAcctRequest"/></param>
        /// <returns><see cref="CheckAcctResponse"/></returns>
        public Task<CheckAcctResponse> CheckAcct(CheckAcctRequest req)
        {
            return InternalRequestAsync<CheckAcctResponse>(req, "CheckAcct");
        }

        /// <summary>
        /// 商户绑定提现银行卡的验证接口
        /// </summary>
        /// <param name="req"><see cref="CheckAcctRequest"/></param>
        /// <returns><see cref="CheckAcctResponse"/></returns>
        public CheckAcctResponse CheckAcctSync(CheckAcctRequest req)
        {
            return InternalRequestAsync<CheckAcctResponse>(req, "CheckAcct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 验证鉴权金额。此接口可受理BindRelateAcctSmallAmount接口发起的转账金额（往账鉴权方式）的验证处理。若所回填的验证金额验证通过，则会绑定原申请中的银行账户作为提现账户。通过此接口也可以查得BindRelateAcctSmallAmount接口发起的来账鉴权方式的申请的当前状态。
        /// </summary>
        /// <param name="req"><see cref="CheckAmountRequest"/></param>
        /// <returns><see cref="CheckAmountResponse"/></returns>
        public Task<CheckAmountResponse> CheckAmount(CheckAmountRequest req)
        {
            return InternalRequestAsync<CheckAmountResponse>(req, "CheckAmount");
        }

        /// <summary>
        /// 验证鉴权金额。此接口可受理BindRelateAcctSmallAmount接口发起的转账金额（往账鉴权方式）的验证处理。若所回填的验证金额验证通过，则会绑定原申请中的银行账户作为提现账户。通过此接口也可以查得BindRelateAcctSmallAmount接口发起的来账鉴权方式的申请的当前状态。
        /// </summary>
        /// <param name="req"><see cref="CheckAmountRequest"/></param>
        /// <returns><see cref="CheckAmountResponse"/></returns>
        public CheckAmountResponse CheckAmountSync(CheckAmountRequest req)
        {
            return InternalRequestAsync<CheckAmountResponse>(req, "CheckAmount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过此接口关闭此前已创建的订单。关闭后，用户将无法继续付款，仅能关闭创建后未支付的订单。
        /// </summary>
        /// <param name="req"><see cref="CloseCloudOrderRequest"/></param>
        /// <returns><see cref="CloseCloudOrderResponse"/></returns>
        public Task<CloseCloudOrderResponse> CloseCloudOrder(CloseCloudOrderRequest req)
        {
            return InternalRequestAsync<CloseCloudOrderResponse>(req, "CloseCloudOrder");
        }

        /// <summary>
        /// 通过此接口关闭此前已创建的订单。关闭后，用户将无法继续付款，仅能关闭创建后未支付的订单。
        /// </summary>
        /// <param name="req"><see cref="CloseCloudOrderRequest"/></param>
        /// <returns><see cref="CloseCloudOrderResponse"/></returns>
        public CloseCloudOrderResponse CloseCloudOrderSync(CloseCloudOrderRequest req)
        {
            return InternalRequestAsync<CloseCloudOrderResponse>(req, "CloseCloudOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-关闭订单
        /// </summary>
        /// <param name="req"><see cref="CloseOpenBankPaymentOrderRequest"/></param>
        /// <returns><see cref="CloseOpenBankPaymentOrderResponse"/></returns>
        public Task<CloseOpenBankPaymentOrderResponse> CloseOpenBankPaymentOrder(CloseOpenBankPaymentOrderRequest req)
        {
            return InternalRequestAsync<CloseOpenBankPaymentOrderResponse>(req, "CloseOpenBankPaymentOrder");
        }

        /// <summary>
        /// 云企付-关闭订单
        /// </summary>
        /// <param name="req"><see cref="CloseOpenBankPaymentOrderRequest"/></param>
        /// <returns><see cref="CloseOpenBankPaymentOrderResponse"/></returns>
        public CloseOpenBankPaymentOrderResponse CloseOpenBankPaymentOrderSync(CloseOpenBankPaymentOrderRequest req)
        {
            return InternalRequestAsync<CloseOpenBankPaymentOrderResponse>(req, "CloseOpenBankPaymentOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过此接口关闭此前已创建的订单，关闭后，用户将无法继续付款。仅能关闭创建后未支付的订单
        /// </summary>
        /// <param name="req"><see cref="CloseOrderRequest"/></param>
        /// <returns><see cref="CloseOrderResponse"/></returns>
        public Task<CloseOrderResponse> CloseOrder(CloseOrderRequest req)
        {
            return InternalRequestAsync<CloseOrderResponse>(req, "CloseOrder");
        }

        /// <summary>
        /// 通过此接口关闭此前已创建的订单，关闭后，用户将无法继续付款。仅能关闭创建后未支付的订单
        /// </summary>
        /// <param name="req"><see cref="CloseOrderRequest"/></param>
        /// <returns><see cref="CloseOrderResponse"/></returns>
        public CloseOrderResponse CloseOrderSync(CloseOrderRequest req)
        {
            return InternalRequestAsync<CloseOrderResponse>(req, "CloseOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云鉴-消费订单确认接口
        /// </summary>
        /// <param name="req"><see cref="ConfirmOrderRequest"/></param>
        /// <returns><see cref="ConfirmOrderResponse"/></returns>
        public Task<ConfirmOrderResponse> ConfirmOrder(ConfirmOrderRequest req)
        {
            return InternalRequestAsync<ConfirmOrderResponse>(req, "ConfirmOrder");
        }

        /// <summary>
        /// 云鉴-消费订单确认接口
        /// </summary>
        /// <param name="req"><see cref="ConfirmOrderRequest"/></param>
        /// <returns><see cref="ConfirmOrderResponse"/></returns>
        public ConfirmOrderResponse ConfirmOrderSync(ConfirmOrderRequest req)
        {
            return InternalRequestAsync<ConfirmOrderResponse>(req, "ConfirmOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 应用需要先带上签约信息调用本接口生成支付订单号，并将应答的PayInfo透传给聚鑫SDK，拉起客户端（包括微信公众号/微信小程序/客户端App）支付。
        /// </summary>
        /// <param name="req"><see cref="ContractOrderRequest"/></param>
        /// <returns><see cref="ContractOrderResponse"/></returns>
        public Task<ContractOrderResponse> ContractOrder(ContractOrderRequest req)
        {
            return InternalRequestAsync<ContractOrderResponse>(req, "ContractOrder");
        }

        /// <summary>
        /// 应用需要先带上签约信息调用本接口生成支付订单号，并将应答的PayInfo透传给聚鑫SDK，拉起客户端（包括微信公众号/微信小程序/客户端App）支付。
        /// </summary>
        /// <param name="req"><see cref="ContractOrderRequest"/></param>
        /// <returns><see cref="ContractOrderResponse"/></returns>
        public ContractOrderResponse ContractOrderSync(ContractOrderRequest req)
        {
            return InternalRequestAsync<ContractOrderResponse>(req, "ContractOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 子商户入驻聚鑫平台
        /// </summary>
        /// <param name="req"><see cref="CreateAcctRequest"/></param>
        /// <returns><see cref="CreateAcctResponse"/></returns>
        public Task<CreateAcctResponse> CreateAcct(CreateAcctRequest req)
        {
            return InternalRequestAsync<CreateAcctResponse>(req, "CreateAcct");
        }

        /// <summary>
        /// 子商户入驻聚鑫平台
        /// </summary>
        /// <param name="req"><see cref="CreateAcctRequest"/></param>
        /// <returns><see cref="CreateAcctResponse"/></returns>
        public CreateAcctResponse CreateAcctSync(CreateAcctRequest req)
        {
            return InternalRequestAsync<CreateAcctResponse>(req, "CreateAcct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播平台-代理商完税信息录入
        /// </summary>
        /// <param name="req"><see cref="CreateAgentTaxPaymentInfosRequest"/></param>
        /// <returns><see cref="CreateAgentTaxPaymentInfosResponse"/></returns>
        public Task<CreateAgentTaxPaymentInfosResponse> CreateAgentTaxPaymentInfos(CreateAgentTaxPaymentInfosRequest req)
        {
            return InternalRequestAsync<CreateAgentTaxPaymentInfosResponse>(req, "CreateAgentTaxPaymentInfos");
        }

        /// <summary>
        /// 直播平台-代理商完税信息录入
        /// </summary>
        /// <param name="req"><see cref="CreateAgentTaxPaymentInfosRequest"/></param>
        /// <returns><see cref="CreateAgentTaxPaymentInfosResponse"/></returns>
        public CreateAgentTaxPaymentInfosResponse CreateAgentTaxPaymentInfosSync(CreateAgentTaxPaymentInfosRequest req)
        {
            return InternalRequestAsync<CreateAgentTaxPaymentInfosResponse>(req, "CreateAgentTaxPaymentInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播平台-主播入驻
        /// </summary>
        /// <param name="req"><see cref="CreateAnchorRequest"/></param>
        /// <returns><see cref="CreateAnchorResponse"/></returns>
        public Task<CreateAnchorResponse> CreateAnchor(CreateAnchorRequest req)
        {
            return InternalRequestAsync<CreateAnchorResponse>(req, "CreateAnchor");
        }

        /// <summary>
        /// 直播平台-主播入驻
        /// </summary>
        /// <param name="req"><see cref="CreateAnchorRequest"/></param>
        /// <returns><see cref="CreateAnchorResponse"/></returns>
        public CreateAnchorResponse CreateAnchorSync(CreateAnchorRequest req)
        {
            return InternalRequestAsync<CreateAnchorResponse>(req, "CreateAnchor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云-批量主播转账接口
        /// </summary>
        /// <param name="req"><see cref="CreateBatchPaymentRequest"/></param>
        /// <returns><see cref="CreateBatchPaymentResponse"/></returns>
        public Task<CreateBatchPaymentResponse> CreateBatchPayment(CreateBatchPaymentRequest req)
        {
            return InternalRequestAsync<CreateBatchPaymentResponse>(req, "CreateBatchPayment");
        }

        /// <summary>
        /// 灵云-批量主播转账接口
        /// </summary>
        /// <param name="req"><see cref="CreateBatchPaymentRequest"/></param>
        /// <returns><see cref="CreateBatchPaymentResponse"/></returns>
        public CreateBatchPaymentResponse CreateBatchPaymentSync(CreateBatchPaymentRequest req)
        {
            return InternalRequestAsync<CreateBatchPaymentResponse>(req, "CreateBatchPayment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 创建子商户
        /// </summary>
        /// <param name="req"><see cref="CreateCloudSubMerchantRequest"/></param>
        /// <returns><see cref="CreateCloudSubMerchantResponse"/></returns>
        public Task<CreateCloudSubMerchantResponse> CreateCloudSubMerchant(CreateCloudSubMerchantRequest req)
        {
            return InternalRequestAsync<CreateCloudSubMerchantResponse>(req, "CreateCloudSubMerchant");
        }

        /// <summary>
        /// 创建子商户
        /// </summary>
        /// <param name="req"><see cref="CreateCloudSubMerchantRequest"/></param>
        /// <returns><see cref="CreateCloudSubMerchantResponse"/></returns>
        public CreateCloudSubMerchantResponse CreateCloudSubMerchantSync(CreateCloudSubMerchantRequest req)
        {
            return InternalRequestAsync<CreateCloudSubMerchantResponse>(req, "CreateCloudSubMerchant")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 会员子账户开立。会员在银行注册，并开立会员子账户，交易网会员代码即会员在平台端系统的会员编号。
        /// 平台需保存银行返回的子账户账号，后续交易接口都会用到。会员属性字段为预留扩展字段，当前必须送默认值。
        /// </summary>
        /// <param name="req"><see cref="CreateCustAcctIdRequest"/></param>
        /// <returns><see cref="CreateCustAcctIdResponse"/></returns>
        public Task<CreateCustAcctIdResponse> CreateCustAcctId(CreateCustAcctIdRequest req)
        {
            return InternalRequestAsync<CreateCustAcctIdResponse>(req, "CreateCustAcctId");
        }

        /// <summary>
        /// 会员子账户开立。会员在银行注册，并开立会员子账户，交易网会员代码即会员在平台端系统的会员编号。
        /// 平台需保存银行返回的子账户账号，后续交易接口都会用到。会员属性字段为预留扩展字段，当前必须送默认值。
        /// </summary>
        /// <param name="req"><see cref="CreateCustAcctIdRequest"/></param>
        /// <returns><see cref="CreateCustAcctIdResponse"/></returns>
        public CreateCustAcctIdResponse CreateCustAcctIdSync(CreateCustAcctIdRequest req)
        {
            return InternalRequestAsync<CreateCustAcctIdResponse>(req, "CreateCustAcctId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云-主播入驻
        /// </summary>
        /// <param name="req"><see cref="CreateExternalAnchorRequest"/></param>
        /// <returns><see cref="CreateExternalAnchorResponse"/></returns>
        public Task<CreateExternalAnchorResponse> CreateExternalAnchor(CreateExternalAnchorRequest req)
        {
            return InternalRequestAsync<CreateExternalAnchorResponse>(req, "CreateExternalAnchor");
        }

        /// <summary>
        /// 灵云-主播入驻
        /// </summary>
        /// <param name="req"><see cref="CreateExternalAnchorRequest"/></param>
        /// <returns><see cref="CreateExternalAnchorResponse"/></returns>
        public CreateExternalAnchorResponse CreateExternalAnchorSync(CreateExternalAnchorRequest req)
        {
            return InternalRequestAsync<CreateExternalAnchorResponse>(req, "CreateExternalAnchor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-收款用户开立
        /// </summary>
        /// <param name="req"><see cref="CreateFlexPayeeRequest"/></param>
        /// <returns><see cref="CreateFlexPayeeResponse"/></returns>
        public Task<CreateFlexPayeeResponse> CreateFlexPayee(CreateFlexPayeeRequest req)
        {
            return InternalRequestAsync<CreateFlexPayeeResponse>(req, "CreateFlexPayee");
        }

        /// <summary>
        /// 灵云V2-收款用户开立
        /// </summary>
        /// <param name="req"><see cref="CreateFlexPayeeRequest"/></param>
        /// <returns><see cref="CreateFlexPayeeResponse"/></returns>
        public CreateFlexPayeeResponse CreateFlexPayeeSync(CreateFlexPayeeRequest req)
        {
            return InternalRequestAsync<CreateFlexPayeeResponse>(req, "CreateFlexPayee")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智慧零售-发票开具
        /// </summary>
        /// <param name="req"><see cref="CreateInvoiceRequest"/></param>
        /// <returns><see cref="CreateInvoiceResponse"/></returns>
        public Task<CreateInvoiceResponse> CreateInvoice(CreateInvoiceRequest req)
        {
            return InternalRequestAsync<CreateInvoiceResponse>(req, "CreateInvoice");
        }

        /// <summary>
        /// 智慧零售-发票开具
        /// </summary>
        /// <param name="req"><see cref="CreateInvoiceRequest"/></param>
        /// <returns><see cref="CreateInvoiceResponse"/></returns>
        public CreateInvoiceResponse CreateInvoiceSync(CreateInvoiceRequest req)
        {
            return InternalRequestAsync<CreateInvoiceResponse>(req, "CreateInvoice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智慧零售-发票开具V2
        /// </summary>
        /// <param name="req"><see cref="CreateInvoiceV2Request"/></param>
        /// <returns><see cref="CreateInvoiceV2Response"/></returns>
        public Task<CreateInvoiceV2Response> CreateInvoiceV2(CreateInvoiceV2Request req)
        {
            return InternalRequestAsync<CreateInvoiceV2Response>(req, "CreateInvoiceV2");
        }

        /// <summary>
        /// 智慧零售-发票开具V2
        /// </summary>
        /// <param name="req"><see cref="CreateInvoiceV2Request"/></param>
        /// <returns><see cref="CreateInvoiceV2Response"/></returns>
        public CreateInvoiceV2Response CreateInvoiceV2Sync(CreateInvoiceV2Request req)
        {
            return InternalRequestAsync<CreateInvoiceV2Response>(req, "CreateInvoiceV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智慧零售-商户注册
        /// </summary>
        /// <param name="req"><see cref="CreateMerchantRequest"/></param>
        /// <returns><see cref="CreateMerchantResponse"/></returns>
        public Task<CreateMerchantResponse> CreateMerchant(CreateMerchantRequest req)
        {
            return InternalRequestAsync<CreateMerchantResponse>(req, "CreateMerchant");
        }

        /// <summary>
        /// 智慧零售-商户注册
        /// </summary>
        /// <param name="req"><see cref="CreateMerchantRequest"/></param>
        /// <returns><see cref="CreateMerchantResponse"/></returns>
        public CreateMerchantResponse CreateMerchantSync(CreateMerchantRequest req)
        {
            return InternalRequestAsync<CreateMerchantResponse>(req, "CreateMerchant")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-子商户进件V2
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankAggregatedSubMerchantRegistrationRequest"/></param>
        /// <returns><see cref="CreateOpenBankAggregatedSubMerchantRegistrationResponse"/></returns>
        public Task<CreateOpenBankAggregatedSubMerchantRegistrationResponse> CreateOpenBankAggregatedSubMerchantRegistration(CreateOpenBankAggregatedSubMerchantRegistrationRequest req)
        {
            return InternalRequestAsync<CreateOpenBankAggregatedSubMerchantRegistrationResponse>(req, "CreateOpenBankAggregatedSubMerchantRegistration");
        }

        /// <summary>
        /// 云企付-子商户进件V2
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankAggregatedSubMerchantRegistrationRequest"/></param>
        /// <returns><see cref="CreateOpenBankAggregatedSubMerchantRegistrationResponse"/></returns>
        public CreateOpenBankAggregatedSubMerchantRegistrationResponse CreateOpenBankAggregatedSubMerchantRegistrationSync(CreateOpenBankAggregatedSubMerchantRegistrationRequest req)
        {
            return InternalRequestAsync<CreateOpenBankAggregatedSubMerchantRegistrationResponse>(req, "CreateOpenBankAggregatedSubMerchantRegistration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 第三方子商户电子记账本创建接口
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankExternalSubMerchantAccountBookRequest"/></param>
        /// <returns><see cref="CreateOpenBankExternalSubMerchantAccountBookResponse"/></returns>
        public Task<CreateOpenBankExternalSubMerchantAccountBookResponse> CreateOpenBankExternalSubMerchantAccountBook(CreateOpenBankExternalSubMerchantAccountBookRequest req)
        {
            return InternalRequestAsync<CreateOpenBankExternalSubMerchantAccountBookResponse>(req, "CreateOpenBankExternalSubMerchantAccountBook");
        }

        /// <summary>
        /// 第三方子商户电子记账本创建接口
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankExternalSubMerchantAccountBookRequest"/></param>
        /// <returns><see cref="CreateOpenBankExternalSubMerchantAccountBookResponse"/></returns>
        public CreateOpenBankExternalSubMerchantAccountBookResponse CreateOpenBankExternalSubMerchantAccountBookSync(CreateOpenBankExternalSubMerchantAccountBookRequest req)
        {
            return InternalRequestAsync<CreateOpenBankExternalSubMerchantAccountBookResponse>(req, "CreateOpenBankExternalSubMerchantAccountBook")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-子商户进件
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankExternalSubMerchantRegistrationRequest"/></param>
        /// <returns><see cref="CreateOpenBankExternalSubMerchantRegistrationResponse"/></returns>
        public Task<CreateOpenBankExternalSubMerchantRegistrationResponse> CreateOpenBankExternalSubMerchantRegistration(CreateOpenBankExternalSubMerchantRegistrationRequest req)
        {
            return InternalRequestAsync<CreateOpenBankExternalSubMerchantRegistrationResponse>(req, "CreateOpenBankExternalSubMerchantRegistration");
        }

        /// <summary>
        /// 云企付-子商户进件
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankExternalSubMerchantRegistrationRequest"/></param>
        /// <returns><see cref="CreateOpenBankExternalSubMerchantRegistrationResponse"/></returns>
        public CreateOpenBankExternalSubMerchantRegistrationResponse CreateOpenBankExternalSubMerchantRegistrationSync(CreateOpenBankExternalSubMerchantRegistrationRequest req)
        {
            return InternalRequestAsync<CreateOpenBankExternalSubMerchantRegistrationResponse>(req, "CreateOpenBankExternalSubMerchantRegistration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-跨境支付下单
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankGlobalPaymentOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankGlobalPaymentOrderResponse"/></returns>
        public Task<CreateOpenBankGlobalPaymentOrderResponse> CreateOpenBankGlobalPaymentOrder(CreateOpenBankGlobalPaymentOrderRequest req)
        {
            return InternalRequestAsync<CreateOpenBankGlobalPaymentOrderResponse>(req, "CreateOpenBankGlobalPaymentOrder");
        }

        /// <summary>
        /// 云企付-跨境支付下单
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankGlobalPaymentOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankGlobalPaymentOrderResponse"/></returns>
        public CreateOpenBankGlobalPaymentOrderResponse CreateOpenBankGlobalPaymentOrderSync(CreateOpenBankGlobalPaymentOrderRequest req)
        {
            return InternalRequestAsync<CreateOpenBankGlobalPaymentOrderResponse>(req, "CreateOpenBankGlobalPaymentOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-创建商户
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankMerchantRequest"/></param>
        /// <returns><see cref="CreateOpenBankMerchantResponse"/></returns>
        public Task<CreateOpenBankMerchantResponse> CreateOpenBankMerchant(CreateOpenBankMerchantRequest req)
        {
            return InternalRequestAsync<CreateOpenBankMerchantResponse>(req, "CreateOpenBankMerchant");
        }

        /// <summary>
        /// 云企付-创建商户
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankMerchantRequest"/></param>
        /// <returns><see cref="CreateOpenBankMerchantResponse"/></returns>
        public CreateOpenBankMerchantResponse CreateOpenBankMerchantSync(CreateOpenBankMerchantRequest req)
        {
            return InternalRequestAsync<CreateOpenBankMerchantResponse>(req, "CreateOpenBankMerchant")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-创建支付订单。支持B2B网关支付，B2C转账下单。
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankPaymentOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankPaymentOrderResponse"/></returns>
        public Task<CreateOpenBankPaymentOrderResponse> CreateOpenBankPaymentOrder(CreateOpenBankPaymentOrderRequest req)
        {
            return InternalRequestAsync<CreateOpenBankPaymentOrderResponse>(req, "CreateOpenBankPaymentOrder");
        }

        /// <summary>
        /// 云企付-创建支付订单。支持B2B网关支付，B2C转账下单。
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankPaymentOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankPaymentOrderResponse"/></returns>
        public CreateOpenBankPaymentOrderResponse CreateOpenBankPaymentOrderSync(CreateOpenBankPaymentOrderRequest req)
        {
            return InternalRequestAsync<CreateOpenBankPaymentOrderResponse>(req, "CreateOpenBankPaymentOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-创建充值订单
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankRechargeOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankRechargeOrderResponse"/></returns>
        public Task<CreateOpenBankRechargeOrderResponse> CreateOpenBankRechargeOrder(CreateOpenBankRechargeOrderRequest req)
        {
            return InternalRequestAsync<CreateOpenBankRechargeOrderResponse>(req, "CreateOpenBankRechargeOrder");
        }

        /// <summary>
        /// 云企付-创建充值订单
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankRechargeOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankRechargeOrderResponse"/></returns>
        public CreateOpenBankRechargeOrderResponse CreateOpenBankRechargeOrderSync(CreateOpenBankRechargeOrderRequest req)
        {
            return InternalRequestAsync<CreateOpenBankRechargeOrderResponse>(req, "CreateOpenBankRechargeOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-子商户费率配置
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankSubMerchantRateConfigureRequest"/></param>
        /// <returns><see cref="CreateOpenBankSubMerchantRateConfigureResponse"/></returns>
        public Task<CreateOpenBankSubMerchantRateConfigureResponse> CreateOpenBankSubMerchantRateConfigure(CreateOpenBankSubMerchantRateConfigureRequest req)
        {
            return InternalRequestAsync<CreateOpenBankSubMerchantRateConfigureResponse>(req, "CreateOpenBankSubMerchantRateConfigure");
        }

        /// <summary>
        /// 云企付-子商户费率配置
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankSubMerchantRateConfigureRequest"/></param>
        /// <returns><see cref="CreateOpenBankSubMerchantRateConfigureResponse"/></returns>
        public CreateOpenBankSubMerchantRateConfigureResponse CreateOpenBankSubMerchantRateConfigureSync(CreateOpenBankSubMerchantRateConfigureRequest req)
        {
            return InternalRequestAsync<CreateOpenBankSubMerchantRateConfigureResponse>(req, "CreateOpenBankSubMerchantRateConfigure")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-聚合下单
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankUnifiedOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankUnifiedOrderResponse"/></returns>
        public Task<CreateOpenBankUnifiedOrderResponse> CreateOpenBankUnifiedOrder(CreateOpenBankUnifiedOrderRequest req)
        {
            return InternalRequestAsync<CreateOpenBankUnifiedOrderResponse>(req, "CreateOpenBankUnifiedOrder");
        }

        /// <summary>
        /// 云企付-聚合下单
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankUnifiedOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankUnifiedOrderResponse"/></returns>
        public CreateOpenBankUnifiedOrderResponse CreateOpenBankUnifiedOrderSync(CreateOpenBankUnifiedOrderRequest req)
        {
            return InternalRequestAsync<CreateOpenBankUnifiedOrderResponse>(req, "CreateOpenBankUnifiedOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-创建核销申请，适用于针对支付订单维度的确认收货，解冻等业务场景。目前支持的渠道有TENPAY下的EBANK_PAYMENT付款方式创建支付订单时，选择担保支付下单的订单进行解冻。
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankVerificationOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankVerificationOrderResponse"/></returns>
        public Task<CreateOpenBankVerificationOrderResponse> CreateOpenBankVerificationOrder(CreateOpenBankVerificationOrderRequest req)
        {
            return InternalRequestAsync<CreateOpenBankVerificationOrderResponse>(req, "CreateOpenBankVerificationOrder");
        }

        /// <summary>
        /// 云企付-创建核销申请，适用于针对支付订单维度的确认收货，解冻等业务场景。目前支持的渠道有TENPAY下的EBANK_PAYMENT付款方式创建支付订单时，选择担保支付下单的订单进行解冻。
        /// </summary>
        /// <param name="req"><see cref="CreateOpenBankVerificationOrderRequest"/></param>
        /// <returns><see cref="CreateOpenBankVerificationOrderResponse"/></returns>
        public CreateOpenBankVerificationOrderResponse CreateOpenBankVerificationOrderSync(CreateOpenBankVerificationOrderRequest req)
        {
            return InternalRequestAsync<CreateOpenBankVerificationOrderResponse>(req, "CreateOpenBankVerificationOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云鉴-消费订单发起的接口
        /// </summary>
        /// <param name="req"><see cref="CreateOrderRequest"/></param>
        /// <returns><see cref="CreateOrderResponse"/></returns>
        public Task<CreateOrderResponse> CreateOrder(CreateOrderRequest req)
        {
            return InternalRequestAsync<CreateOrderResponse>(req, "CreateOrder");
        }

        /// <summary>
        /// 云鉴-消费订单发起的接口
        /// </summary>
        /// <param name="req"><see cref="CreateOrderRequest"/></param>
        /// <returns><see cref="CreateOrderResponse"/></returns>
        public CreateOrderResponse CreateOrderSync(CreateOrderRequest req)
        {
            return InternalRequestAsync<CreateOrderResponse>(req, "CreateOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 商户新增的接口
        /// </summary>
        /// <param name="req"><see cref="CreatePayMerchantRequest"/></param>
        /// <returns><see cref="CreatePayMerchantResponse"/></returns>
        public Task<CreatePayMerchantResponse> CreatePayMerchant(CreatePayMerchantRequest req)
        {
            return InternalRequestAsync<CreatePayMerchantResponse>(req, "CreatePayMerchant");
        }

        /// <summary>
        /// 商户新增的接口
        /// </summary>
        /// <param name="req"><see cref="CreatePayMerchantRequest"/></param>
        /// <returns><see cref="CreatePayMerchantResponse"/></returns>
        public CreatePayMerchantResponse CreatePayMerchantSync(CreatePayMerchantRequest req)
        {
            return InternalRequestAsync<CreatePayMerchantResponse>(req, "CreatePayMerchant")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 务工卡-核身预下单
        /// </summary>
        /// <param name="req"><see cref="CreatePayRollPreOrderRequest"/></param>
        /// <returns><see cref="CreatePayRollPreOrderResponse"/></returns>
        public Task<CreatePayRollPreOrderResponse> CreatePayRollPreOrder(CreatePayRollPreOrderRequest req)
        {
            return InternalRequestAsync<CreatePayRollPreOrderResponse>(req, "CreatePayRollPreOrder");
        }

        /// <summary>
        /// 务工卡-核身预下单
        /// </summary>
        /// <param name="req"><see cref="CreatePayRollPreOrderRequest"/></param>
        /// <returns><see cref="CreatePayRollPreOrderResponse"/></returns>
        public CreatePayRollPreOrderResponse CreatePayRollPreOrderSync(CreatePayRollPreOrderRequest req)
        {
            return InternalRequestAsync<CreatePayRollPreOrderResponse>(req, "CreatePayRollPreOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 务工卡-核身预下单带授权
        /// </summary>
        /// <param name="req"><see cref="CreatePayRollPreOrderWithAuthRequest"/></param>
        /// <returns><see cref="CreatePayRollPreOrderWithAuthResponse"/></returns>
        public Task<CreatePayRollPreOrderWithAuthResponse> CreatePayRollPreOrderWithAuth(CreatePayRollPreOrderWithAuthRequest req)
        {
            return InternalRequestAsync<CreatePayRollPreOrderWithAuthResponse>(req, "CreatePayRollPreOrderWithAuth");
        }

        /// <summary>
        /// 务工卡-核身预下单带授权
        /// </summary>
        /// <param name="req"><see cref="CreatePayRollPreOrderWithAuthRequest"/></param>
        /// <returns><see cref="CreatePayRollPreOrderWithAuthResponse"/></returns>
        public CreatePayRollPreOrderWithAuthResponse CreatePayRollPreOrderWithAuthSync(CreatePayRollPreOrderWithAuthRequest req)
        {
            return InternalRequestAsync<CreatePayRollPreOrderWithAuthResponse>(req, "CreatePayRollPreOrderWithAuth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 务工卡-生成授权令牌
        /// </summary>
        /// <param name="req"><see cref="CreatePayRollTokenRequest"/></param>
        /// <returns><see cref="CreatePayRollTokenResponse"/></returns>
        public Task<CreatePayRollTokenResponse> CreatePayRollToken(CreatePayRollTokenRequest req)
        {
            return InternalRequestAsync<CreatePayRollTokenResponse>(req, "CreatePayRollToken");
        }

        /// <summary>
        /// 务工卡-生成授权令牌
        /// </summary>
        /// <param name="req"><see cref="CreatePayRollTokenRequest"/></param>
        /// <returns><see cref="CreatePayRollTokenResponse"/></returns>
        public CreatePayRollTokenResponse CreatePayRollTokenSync(CreatePayRollTokenRequest req)
        {
            return InternalRequestAsync<CreatePayRollTokenResponse>(req, "CreatePayRollToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智慧零售-发票红冲
        /// </summary>
        /// <param name="req"><see cref="CreateRedInvoiceRequest"/></param>
        /// <returns><see cref="CreateRedInvoiceResponse"/></returns>
        public Task<CreateRedInvoiceResponse> CreateRedInvoice(CreateRedInvoiceRequest req)
        {
            return InternalRequestAsync<CreateRedInvoiceResponse>(req, "CreateRedInvoice");
        }

        /// <summary>
        /// 智慧零售-发票红冲
        /// </summary>
        /// <param name="req"><see cref="CreateRedInvoiceRequest"/></param>
        /// <returns><see cref="CreateRedInvoiceResponse"/></returns>
        public CreateRedInvoiceResponse CreateRedInvoiceSync(CreateRedInvoiceRequest req)
        {
            return InternalRequestAsync<CreateRedInvoiceResponse>(req, "CreateRedInvoice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智慧零售-发票红冲V2
        /// </summary>
        /// <param name="req"><see cref="CreateRedInvoiceV2Request"/></param>
        /// <returns><see cref="CreateRedInvoiceV2Response"/></returns>
        public Task<CreateRedInvoiceV2Response> CreateRedInvoiceV2(CreateRedInvoiceV2Request req)
        {
            return InternalRequestAsync<CreateRedInvoiceV2Response>(req, "CreateRedInvoiceV2");
        }

        /// <summary>
        /// 智慧零售-发票红冲V2
        /// </summary>
        /// <param name="req"><see cref="CreateRedInvoiceV2Request"/></param>
        /// <returns><see cref="CreateRedInvoiceV2Response"/></returns>
        public CreateRedInvoiceV2Response CreateRedInvoiceV2Sync(CreateRedInvoiceV2Request req)
        {
            return InternalRequestAsync<CreateRedInvoiceV2Response>(req, "CreateRedInvoiceV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云-单笔主播转账接口
        /// </summary>
        /// <param name="req"><see cref="CreateSinglePaymentRequest"/></param>
        /// <returns><see cref="CreateSinglePaymentResponse"/></returns>
        public Task<CreateSinglePaymentResponse> CreateSinglePayment(CreateSinglePaymentRequest req)
        {
            return InternalRequestAsync<CreateSinglePaymentResponse>(req, "CreateSinglePayment");
        }

        /// <summary>
        /// 灵云-单笔主播转账接口
        /// </summary>
        /// <param name="req"><see cref="CreateSinglePaymentRequest"/></param>
        /// <returns><see cref="CreateSinglePaymentResponse"/></returns>
        public CreateSinglePaymentResponse CreateSinglePaymentSync(CreateSinglePaymentRequest req)
        {
            return InternalRequestAsync<CreateSinglePaymentResponse>(req, "CreateSinglePayment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 微信商户发起批量转账
        /// </summary>
        /// <param name="req"><see cref="CreateTransferBatchRequest"/></param>
        /// <returns><see cref="CreateTransferBatchResponse"/></returns>
        public Task<CreateTransferBatchResponse> CreateTransferBatch(CreateTransferBatchRequest req)
        {
            return InternalRequestAsync<CreateTransferBatchResponse>(req, "CreateTransferBatch");
        }

        /// <summary>
        /// 微信商户发起批量转账
        /// </summary>
        /// <param name="req"><see cref="CreateTransferBatchRequest"/></param>
        /// <returns><see cref="CreateTransferBatchResponse"/></returns>
        public CreateTransferBatchResponse CreateTransferBatchSync(CreateTransferBatchRequest req)
        {
            return InternalRequestAsync<CreateTransferBatchResponse>(req, "CreateTransferBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播平台-扣减额度
        /// </summary>
        /// <param name="req"><see cref="DeduceQuotaRequest"/></param>
        /// <returns><see cref="DeduceQuotaResponse"/></returns>
        public Task<DeduceQuotaResponse> DeduceQuota(DeduceQuotaRequest req)
        {
            return InternalRequestAsync<DeduceQuotaResponse>(req, "DeduceQuota");
        }

        /// <summary>
        /// 直播平台-扣减额度
        /// </summary>
        /// <param name="req"><see cref="DeduceQuotaRequest"/></param>
        /// <returns><see cref="DeduceQuotaResponse"/></returns>
        public DeduceQuotaResponse DeduceQuotaSync(DeduceQuotaRequest req)
        {
            return InternalRequestAsync<DeduceQuotaResponse>(req, "DeduceQuota")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播平台-删除代理商完税信息
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentTaxPaymentInfoRequest"/></param>
        /// <returns><see cref="DeleteAgentTaxPaymentInfoResponse"/></returns>
        public Task<DeleteAgentTaxPaymentInfoResponse> DeleteAgentTaxPaymentInfo(DeleteAgentTaxPaymentInfoRequest req)
        {
            return InternalRequestAsync<DeleteAgentTaxPaymentInfoResponse>(req, "DeleteAgentTaxPaymentInfo");
        }

        /// <summary>
        /// 直播平台-删除代理商完税信息
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentTaxPaymentInfoRequest"/></param>
        /// <returns><see cref="DeleteAgentTaxPaymentInfoResponse"/></returns>
        public DeleteAgentTaxPaymentInfoResponse DeleteAgentTaxPaymentInfoSync(DeleteAgentTaxPaymentInfoRequest req)
        {
            return InternalRequestAsync<DeleteAgentTaxPaymentInfoResponse>(req, "DeleteAgentTaxPaymentInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播平台-删除代理商完税信息
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentTaxPaymentInfosRequest"/></param>
        /// <returns><see cref="DeleteAgentTaxPaymentInfosResponse"/></returns>
        public Task<DeleteAgentTaxPaymentInfosResponse> DeleteAgentTaxPaymentInfos(DeleteAgentTaxPaymentInfosRequest req)
        {
            return InternalRequestAsync<DeleteAgentTaxPaymentInfosResponse>(req, "DeleteAgentTaxPaymentInfos");
        }

        /// <summary>
        /// 直播平台-删除代理商完税信息
        /// </summary>
        /// <param name="req"><see cref="DeleteAgentTaxPaymentInfosRequest"/></param>
        /// <returns><see cref="DeleteAgentTaxPaymentInfosResponse"/></returns>
        public DeleteAgentTaxPaymentInfosResponse DeleteAgentTaxPaymentInfosSync(DeleteAgentTaxPaymentInfosRequest req)
        {
            return InternalRequestAsync<DeleteAgentTaxPaymentInfosResponse>(req, "DeleteAgentTaxPaymentInfos")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询充值明细接口
        /// </summary>
        /// <param name="req"><see cref="DescribeChargeDetailRequest"/></param>
        /// <returns><see cref="DescribeChargeDetailResponse"/></returns>
        public Task<DescribeChargeDetailResponse> DescribeChargeDetail(DescribeChargeDetailRequest req)
        {
            return InternalRequestAsync<DescribeChargeDetailResponse>(req, "DescribeChargeDetail");
        }

        /// <summary>
        /// 查询充值明细接口
        /// </summary>
        /// <param name="req"><see cref="DescribeChargeDetailRequest"/></param>
        /// <returns><see cref="DescribeChargeDetailResponse"/></returns>
        public DescribeChargeDetailResponse DescribeChargeDetailSync(DescribeChargeDetailRequest req)
        {
            return InternalRequestAsync<DescribeChargeDetailResponse>(req, "DescribeChargeDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询单笔订单交易状态
        /// </summary>
        /// <param name="req"><see cref="DescribeOrderStatusRequest"/></param>
        /// <returns><see cref="DescribeOrderStatusResponse"/></returns>
        public Task<DescribeOrderStatusResponse> DescribeOrderStatus(DescribeOrderStatusRequest req)
        {
            return InternalRequestAsync<DescribeOrderStatusResponse>(req, "DescribeOrderStatus");
        }

        /// <summary>
        /// 查询单笔订单交易状态
        /// </summary>
        /// <param name="req"><see cref="DescribeOrderStatusRequest"/></param>
        /// <returns><see cref="DescribeOrderStatusResponse"/></returns>
        public DescribeOrderStatusResponse DescribeOrderStatusSync(DescribeOrderStatusRequest req)
        {
            return InternalRequestAsync<DescribeOrderStatusResponse>(req, "DescribeOrderStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-分账授权申请查询接口
        /// </summary>
        /// <param name="req"><see cref="DistributeAccreditQueryRequest"/></param>
        /// <returns><see cref="DistributeAccreditQueryResponse"/></returns>
        public Task<DistributeAccreditQueryResponse> DistributeAccreditQuery(DistributeAccreditQueryRequest req)
        {
            return InternalRequestAsync<DistributeAccreditQueryResponse>(req, "DistributeAccreditQuery");
        }

        /// <summary>
        /// 云支付-分账授权申请查询接口
        /// </summary>
        /// <param name="req"><see cref="DistributeAccreditQueryRequest"/></param>
        /// <returns><see cref="DistributeAccreditQueryResponse"/></returns>
        public DistributeAccreditQueryResponse DistributeAccreditQuerySync(DistributeAccreditQueryRequest req)
        {
            return InternalRequestAsync<DistributeAccreditQueryResponse>(req, "DistributeAccreditQuery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-分账授权申请接口
        /// </summary>
        /// <param name="req"><see cref="DistributeAccreditTlinxRequest"/></param>
        /// <returns><see cref="DistributeAccreditTlinxResponse"/></returns>
        public Task<DistributeAccreditTlinxResponse> DistributeAccreditTlinx(DistributeAccreditTlinxRequest req)
        {
            return InternalRequestAsync<DistributeAccreditTlinxResponse>(req, "DistributeAccreditTlinx");
        }

        /// <summary>
        /// 云支付-分账授权申请接口
        /// </summary>
        /// <param name="req"><see cref="DistributeAccreditTlinxRequest"/></param>
        /// <returns><see cref="DistributeAccreditTlinxResponse"/></returns>
        public DistributeAccreditTlinxResponse DistributeAccreditTlinxSync(DistributeAccreditTlinxRequest req)
        {
            return InternalRequestAsync<DistributeAccreditTlinxResponse>(req, "DistributeAccreditTlinx")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-分账添加分账接收方接口
        /// </summary>
        /// <param name="req"><see cref="DistributeAddReceiverRequest"/></param>
        /// <returns><see cref="DistributeAddReceiverResponse"/></returns>
        public Task<DistributeAddReceiverResponse> DistributeAddReceiver(DistributeAddReceiverRequest req)
        {
            return InternalRequestAsync<DistributeAddReceiverResponse>(req, "DistributeAddReceiver");
        }

        /// <summary>
        /// 云支付-分账添加分账接收方接口
        /// </summary>
        /// <param name="req"><see cref="DistributeAddReceiverRequest"/></param>
        /// <returns><see cref="DistributeAddReceiverResponse"/></returns>
        public DistributeAddReceiverResponse DistributeAddReceiverSync(DistributeAddReceiverRequest req)
        {
            return InternalRequestAsync<DistributeAddReceiverResponse>(req, "DistributeAddReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-分账请求接口
        /// </summary>
        /// <param name="req"><see cref="DistributeApplyRequest"/></param>
        /// <returns><see cref="DistributeApplyResponse"/></returns>
        public Task<DistributeApplyResponse> DistributeApply(DistributeApplyRequest req)
        {
            return InternalRequestAsync<DistributeApplyResponse>(req, "DistributeApply");
        }

        /// <summary>
        /// 云支付-分账请求接口
        /// </summary>
        /// <param name="req"><see cref="DistributeApplyRequest"/></param>
        /// <returns><see cref="DistributeApplyResponse"/></returns>
        public DistributeApplyResponse DistributeApplySync(DistributeApplyRequest req)
        {
            return InternalRequestAsync<DistributeApplyResponse>(req, "DistributeApply")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-分账撤销接口
        /// </summary>
        /// <param name="req"><see cref="DistributeCancelRequest"/></param>
        /// <returns><see cref="DistributeCancelResponse"/></returns>
        public Task<DistributeCancelResponse> DistributeCancel(DistributeCancelRequest req)
        {
            return InternalRequestAsync<DistributeCancelResponse>(req, "DistributeCancel");
        }

        /// <summary>
        /// 云支付-分账撤销接口
        /// </summary>
        /// <param name="req"><see cref="DistributeCancelRequest"/></param>
        /// <returns><see cref="DistributeCancelResponse"/></returns>
        public DistributeCancelResponse DistributeCancelSync(DistributeCancelRequest req)
        {
            return InternalRequestAsync<DistributeCancelResponse>(req, "DistributeCancel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-分账结果查询接口
        /// </summary>
        /// <param name="req"><see cref="DistributeQueryRequest"/></param>
        /// <returns><see cref="DistributeQueryResponse"/></returns>
        public Task<DistributeQueryResponse> DistributeQuery(DistributeQueryRequest req)
        {
            return InternalRequestAsync<DistributeQueryResponse>(req, "DistributeQuery");
        }

        /// <summary>
        /// 云支付-分账结果查询接口
        /// </summary>
        /// <param name="req"><see cref="DistributeQueryRequest"/></param>
        /// <returns><see cref="DistributeQueryResponse"/></returns>
        public DistributeQueryResponse DistributeQuerySync(DistributeQueryRequest req)
        {
            return InternalRequestAsync<DistributeQueryResponse>(req, "DistributeQuery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-查询已添加分账接收方接口
        /// </summary>
        /// <param name="req"><see cref="DistributeQueryReceiverRequest"/></param>
        /// <returns><see cref="DistributeQueryReceiverResponse"/></returns>
        public Task<DistributeQueryReceiverResponse> DistributeQueryReceiver(DistributeQueryReceiverRequest req)
        {
            return InternalRequestAsync<DistributeQueryReceiverResponse>(req, "DistributeQueryReceiver");
        }

        /// <summary>
        /// 云支付-查询已添加分账接收方接口
        /// </summary>
        /// <param name="req"><see cref="DistributeQueryReceiverRequest"/></param>
        /// <returns><see cref="DistributeQueryReceiverResponse"/></returns>
        public DistributeQueryReceiverResponse DistributeQueryReceiverSync(DistributeQueryReceiverRequest req)
        {
            return InternalRequestAsync<DistributeQueryReceiverResponse>(req, "DistributeQueryReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-分账解除分账接收方接口
        /// </summary>
        /// <param name="req"><see cref="DistributeRemoveReceiverRequest"/></param>
        /// <returns><see cref="DistributeRemoveReceiverResponse"/></returns>
        public Task<DistributeRemoveReceiverResponse> DistributeRemoveReceiver(DistributeRemoveReceiverRequest req)
        {
            return InternalRequestAsync<DistributeRemoveReceiverResponse>(req, "DistributeRemoveReceiver");
        }

        /// <summary>
        /// 云支付-分账解除分账接收方接口
        /// </summary>
        /// <param name="req"><see cref="DistributeRemoveReceiverRequest"/></param>
        /// <returns><see cref="DistributeRemoveReceiverResponse"/></returns>
        public DistributeRemoveReceiverResponse DistributeRemoveReceiverSync(DistributeRemoveReceiverRequest req)
        {
            return InternalRequestAsync<DistributeRemoveReceiverResponse>(req, "DistributeRemoveReceiver")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 账单下载接口，根据本接口返回的URL地址，在D+1日下载对账单。注意，本接口返回的URL地址有时效，请尽快下载。URL超时时效后，请重新调用本接口再次获取。
        /// </summary>
        /// <param name="req"><see cref="DownloadBillRequest"/></param>
        /// <returns><see cref="DownloadBillResponse"/></returns>
        public Task<DownloadBillResponse> DownloadBill(DownloadBillRequest req)
        {
            return InternalRequestAsync<DownloadBillResponse>(req, "DownloadBill");
        }

        /// <summary>
        /// 账单下载接口，根据本接口返回的URL地址，在D+1日下载对账单。注意，本接口返回的URL地址有时效，请尽快下载。URL超时时效后，请重新调用本接口再次获取。
        /// </summary>
        /// <param name="req"><see cref="DownloadBillRequest"/></param>
        /// <returns><see cref="DownloadBillResponse"/></returns>
        public DownloadBillResponse DownloadBillSync(DownloadBillRequest req)
        {
            return InternalRequestAsync<DownloadBillResponse>(req, "DownloadBill")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-下载机构文件接口
        /// </summary>
        /// <param name="req"><see cref="DownloadOrgFileRequest"/></param>
        /// <returns><see cref="DownloadOrgFileResponse"/></returns>
        public Task<DownloadOrgFileResponse> DownloadOrgFile(DownloadOrgFileRequest req)
        {
            return InternalRequestAsync<DownloadOrgFileResponse>(req, "DownloadOrgFile");
        }

        /// <summary>
        /// 云支付-下载机构文件接口
        /// </summary>
        /// <param name="req"><see cref="DownloadOrgFileRequest"/></param>
        /// <returns><see cref="DownloadOrgFileResponse"/></returns>
        public DownloadOrgFileResponse DownloadOrgFileSync(DownloadOrgFileRequest req)
        {
            return InternalRequestAsync<DownloadOrgFileResponse>(req, "DownloadOrgFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取对账中心账单下载地址的接口
        /// </summary>
        /// <param name="req"><see cref="DownloadReconciliationUrlRequest"/></param>
        /// <returns><see cref="DownloadReconciliationUrlResponse"/></returns>
        public Task<DownloadReconciliationUrlResponse> DownloadReconciliationUrl(DownloadReconciliationUrlRequest req)
        {
            return InternalRequestAsync<DownloadReconciliationUrlResponse>(req, "DownloadReconciliationUrl");
        }

        /// <summary>
        /// 获取对账中心账单下载地址的接口
        /// </summary>
        /// <param name="req"><see cref="DownloadReconciliationUrlRequest"/></param>
        /// <returns><see cref="DownloadReconciliationUrlResponse"/></returns>
        public DownloadReconciliationUrlResponse DownloadReconciliationUrlSync(DownloadReconciliationUrlRequest req)
        {
            return InternalRequestAsync<DownloadReconciliationUrlResponse>(req, "DownloadReconciliationUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 会员间交易接口
        /// </summary>
        /// <param name="req"><see cref="ExecuteMemberTransactionRequest"/></param>
        /// <returns><see cref="ExecuteMemberTransactionResponse"/></returns>
        public Task<ExecuteMemberTransactionResponse> ExecuteMemberTransaction(ExecuteMemberTransactionRequest req)
        {
            return InternalRequestAsync<ExecuteMemberTransactionResponse>(req, "ExecuteMemberTransaction");
        }

        /// <summary>
        /// 会员间交易接口
        /// </summary>
        /// <param name="req"><see cref="ExecuteMemberTransactionRequest"/></param>
        /// <returns><see cref="ExecuteMemberTransactionResponse"/></returns>
        public ExecuteMemberTransactionResponse ExecuteMemberTransactionSync(ExecuteMemberTransactionRequest req)
        {
            return InternalRequestAsync<ExecuteMemberTransactionResponse>(req, "ExecuteMemberTransaction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-冻结余额
        /// </summary>
        /// <param name="req"><see cref="FreezeFlexBalanceRequest"/></param>
        /// <returns><see cref="FreezeFlexBalanceResponse"/></returns>
        public Task<FreezeFlexBalanceResponse> FreezeFlexBalance(FreezeFlexBalanceRequest req)
        {
            return InternalRequestAsync<FreezeFlexBalanceResponse>(req, "FreezeFlexBalance");
        }

        /// <summary>
        /// 灵云V2-冻结余额
        /// </summary>
        /// <param name="req"><see cref="FreezeFlexBalanceRequest"/></param>
        /// <returns><see cref="FreezeFlexBalanceResponse"/></returns>
        public FreezeFlexBalanceResponse FreezeFlexBalanceSync(FreezeFlexBalanceRequest req)
        {
            return InternalRequestAsync<FreezeFlexBalanceResponse>(req, "FreezeFlexBalance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调用该接口返回对账单下载地址，对账单下载URL通过GET方式访问，返回zip包，解压后为csv格式文件。文件首行如下：
        /// 订单号,订单归属日期,机构编号,订单描述,交易类型,订单状态,支付场景,原始金额,折扣金额,实际交易金额,支付渠道优惠金额,抹零金额,币种,下单时间,付款成功时间,商户编号,门店编号,付款方式编号,付款方式名称,商户手续费T1,商户扣率,是否信用卡交易,原始订单号,用户账号,外部订单号,订单备注
        /// </summary>
        /// <param name="req"><see cref="GetBillDownloadUrlRequest"/></param>
        /// <returns><see cref="GetBillDownloadUrlResponse"/></returns>
        public Task<GetBillDownloadUrlResponse> GetBillDownloadUrl(GetBillDownloadUrlRequest req)
        {
            return InternalRequestAsync<GetBillDownloadUrlResponse>(req, "GetBillDownloadUrl");
        }

        /// <summary>
        /// 调用该接口返回对账单下载地址，对账单下载URL通过GET方式访问，返回zip包，解压后为csv格式文件。文件首行如下：
        /// 订单号,订单归属日期,机构编号,订单描述,交易类型,订单状态,支付场景,原始金额,折扣金额,实际交易金额,支付渠道优惠金额,抹零金额,币种,下单时间,付款成功时间,商户编号,门店编号,付款方式编号,付款方式名称,商户手续费T1,商户扣率,是否信用卡交易,原始订单号,用户账号,外部订单号,订单备注
        /// </summary>
        /// <param name="req"><see cref="GetBillDownloadUrlRequest"/></param>
        /// <returns><see cref="GetBillDownloadUrlResponse"/></returns>
        public GetBillDownloadUrlResponse GetBillDownloadUrlSync(GetBillDownloadUrlRequest req)
        {
            return InternalRequestAsync<GetBillDownloadUrlResponse>(req, "GetBillDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 调用该接口返回对账单下载地址，对账单下载URL通过GET方式访问，返回zip包，解压后为csv格式文件。文件首行如下：
        /// 商户号,订单号,支付订单号,分账订单总金额,分账详情（通过|分割每笔明细：商户号1#分账金额1|商户号2#分账金额2）,交易手续费承担方商户号,交易手续费,发起时间,分账状态,结算日期,非交易主体分账金额,商户退款订单号,商户分账单号
        /// </summary>
        /// <param name="req"><see cref="GetDistributeBillDownloadUrlRequest"/></param>
        /// <returns><see cref="GetDistributeBillDownloadUrlResponse"/></returns>
        public Task<GetDistributeBillDownloadUrlResponse> GetDistributeBillDownloadUrl(GetDistributeBillDownloadUrlRequest req)
        {
            return InternalRequestAsync<GetDistributeBillDownloadUrlResponse>(req, "GetDistributeBillDownloadUrl");
        }

        /// <summary>
        /// 调用该接口返回对账单下载地址，对账单下载URL通过GET方式访问，返回zip包，解压后为csv格式文件。文件首行如下：
        /// 商户号,订单号,支付订单号,分账订单总金额,分账详情（通过|分割每笔明细：商户号1#分账金额1|商户号2#分账金额2）,交易手续费承担方商户号,交易手续费,发起时间,分账状态,结算日期,非交易主体分账金额,商户退款订单号,商户分账单号
        /// </summary>
        /// <param name="req"><see cref="GetDistributeBillDownloadUrlRequest"/></param>
        /// <returns><see cref="GetDistributeBillDownloadUrlResponse"/></returns>
        public GetDistributeBillDownloadUrlResponse GetDistributeBillDownloadUrlSync(GetDistributeBillDownloadUrlRequest req)
        {
            return InternalRequestAsync<GetDistributeBillDownloadUrlResponse>(req, "GetDistributeBillDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 务工卡-查询授权关系
        /// </summary>
        /// <param name="req"><see cref="GetPayRollAuthRequest"/></param>
        /// <returns><see cref="GetPayRollAuthResponse"/></returns>
        public Task<GetPayRollAuthResponse> GetPayRollAuth(GetPayRollAuthRequest req)
        {
            return InternalRequestAsync<GetPayRollAuthResponse>(req, "GetPayRollAuth");
        }

        /// <summary>
        /// 务工卡-查询授权关系
        /// </summary>
        /// <param name="req"><see cref="GetPayRollAuthRequest"/></param>
        /// <returns><see cref="GetPayRollAuthResponse"/></returns>
        public GetPayRollAuthResponse GetPayRollAuthSync(GetPayRollAuthRequest req)
        {
            return InternalRequestAsync<GetPayRollAuthResponse>(req, "GetPayRollAuth")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 务工卡-查询核身记录
        /// </summary>
        /// <param name="req"><see cref="GetPayRollAuthListRequest"/></param>
        /// <returns><see cref="GetPayRollAuthListResponse"/></returns>
        public Task<GetPayRollAuthListResponse> GetPayRollAuthList(GetPayRollAuthListRequest req)
        {
            return InternalRequestAsync<GetPayRollAuthListResponse>(req, "GetPayRollAuthList");
        }

        /// <summary>
        /// 务工卡-查询核身记录
        /// </summary>
        /// <param name="req"><see cref="GetPayRollAuthListRequest"/></param>
        /// <returns><see cref="GetPayRollAuthListResponse"/></returns>
        public GetPayRollAuthListResponse GetPayRollAuthListSync(GetPayRollAuthListRequest req)
        {
            return InternalRequestAsync<GetPayRollAuthListResponse>(req, "GetPayRollAuthList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 务工卡-获取核身结果
        /// </summary>
        /// <param name="req"><see cref="GetPayRollAuthResultRequest"/></param>
        /// <returns><see cref="GetPayRollAuthResultResponse"/></returns>
        public Task<GetPayRollAuthResultResponse> GetPayRollAuthResult(GetPayRollAuthResultRequest req)
        {
            return InternalRequestAsync<GetPayRollAuthResultResponse>(req, "GetPayRollAuthResult");
        }

        /// <summary>
        /// 务工卡-获取核身结果
        /// </summary>
        /// <param name="req"><see cref="GetPayRollAuthResultRequest"/></param>
        /// <returns><see cref="GetPayRollAuthResultResponse"/></returns>
        public GetPayRollAuthResultResponse GetPayRollAuthResultSync(GetPayRollAuthResultRequest req)
        {
            return InternalRequestAsync<GetPayRollAuthResultResponse>(req, "GetPayRollAuthResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 山姆聚合支付项目-存量订单退款接口。可以通过本接口将支付款全部或部分退还给付款方，在收到用户退款请求并且验证成功之后，按照退款规则将支付款按原路退回到支付账号。
        /// </summary>
        /// <param name="req"><see cref="MigrateOrderRefundRequest"/></param>
        /// <returns><see cref="MigrateOrderRefundResponse"/></returns>
        public Task<MigrateOrderRefundResponse> MigrateOrderRefund(MigrateOrderRefundRequest req)
        {
            return InternalRequestAsync<MigrateOrderRefundResponse>(req, "MigrateOrderRefund");
        }

        /// <summary>
        /// 山姆聚合支付项目-存量订单退款接口。可以通过本接口将支付款全部或部分退还给付款方，在收到用户退款请求并且验证成功之后，按照退款规则将支付款按原路退回到支付账号。
        /// </summary>
        /// <param name="req"><see cref="MigrateOrderRefundRequest"/></param>
        /// <returns><see cref="MigrateOrderRefundResponse"/></returns>
        public MigrateOrderRefundResponse MigrateOrderRefundSync(MigrateOrderRefundRequest req)
        {
            return InternalRequestAsync<MigrateOrderRefundResponse>(req, "MigrateOrderRefund")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交退款申请后，通过调用该接口查询退款状态。退款可能有一定延时。
        /// </summary>
        /// <param name="req"><see cref="MigrateOrderRefundQueryRequest"/></param>
        /// <returns><see cref="MigrateOrderRefundQueryResponse"/></returns>
        public Task<MigrateOrderRefundQueryResponse> MigrateOrderRefundQuery(MigrateOrderRefundQueryRequest req)
        {
            return InternalRequestAsync<MigrateOrderRefundQueryResponse>(req, "MigrateOrderRefundQuery");
        }

        /// <summary>
        /// 提交退款申请后，通过调用该接口查询退款状态。退款可能有一定延时。
        /// </summary>
        /// <param name="req"><see cref="MigrateOrderRefundQueryRequest"/></param>
        /// <returns><see cref="MigrateOrderRefundQueryResponse"/></returns>
        public MigrateOrderRefundQueryResponse MigrateOrderRefundQuerySync(MigrateOrderRefundQueryRequest req)
        {
            return InternalRequestAsync<MigrateOrderRefundQueryResponse>(req, "MigrateOrderRefundQuery")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播平台-修改代理商完税信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentTaxPaymentInfoRequest"/></param>
        /// <returns><see cref="ModifyAgentTaxPaymentInfoResponse"/></returns>
        public Task<ModifyAgentTaxPaymentInfoResponse> ModifyAgentTaxPaymentInfo(ModifyAgentTaxPaymentInfoRequest req)
        {
            return InternalRequestAsync<ModifyAgentTaxPaymentInfoResponse>(req, "ModifyAgentTaxPaymentInfo");
        }

        /// <summary>
        /// 直播平台-修改代理商完税信息
        /// </summary>
        /// <param name="req"><see cref="ModifyAgentTaxPaymentInfoRequest"/></param>
        /// <returns><see cref="ModifyAgentTaxPaymentInfoResponse"/></returns>
        public ModifyAgentTaxPaymentInfoResponse ModifyAgentTaxPaymentInfoSync(ModifyAgentTaxPaymentInfoRequest req)
        {
            return InternalRequestAsync<ModifyAgentTaxPaymentInfoResponse>(req, "ModifyAgentTaxPaymentInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云-重新绑定账号
        /// </summary>
        /// <param name="req"><see cref="ModifyBindedAccountRequest"/></param>
        /// <returns><see cref="ModifyBindedAccountResponse"/></returns>
        public Task<ModifyBindedAccountResponse> ModifyBindedAccount(ModifyBindedAccountRequest req)
        {
            return InternalRequestAsync<ModifyBindedAccountResponse>(req, "ModifyBindedAccount");
        }

        /// <summary>
        /// 灵云-重新绑定账号
        /// </summary>
        /// <param name="req"><see cref="ModifyBindedAccountRequest"/></param>
        /// <returns><see cref="ModifyBindedAccountResponse"/></returns>
        public ModifyBindedAccountResponse ModifyBindedAccountSync(ModifyBindedAccountRequest req)
        {
            return InternalRequestAsync<ModifyBindedAccountResponse>(req, "ModifyBindedAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-修改收款用户资金账号信息
        /// </summary>
        /// <param name="req"><see cref="ModifyFlexFundingAccountRequest"/></param>
        /// <returns><see cref="ModifyFlexFundingAccountResponse"/></returns>
        public Task<ModifyFlexFundingAccountResponse> ModifyFlexFundingAccount(ModifyFlexFundingAccountRequest req)
        {
            return InternalRequestAsync<ModifyFlexFundingAccountResponse>(req, "ModifyFlexFundingAccount");
        }

        /// <summary>
        /// 灵云V2-修改收款用户资金账号信息
        /// </summary>
        /// <param name="req"><see cref="ModifyFlexFundingAccountRequest"/></param>
        /// <returns><see cref="ModifyFlexFundingAccountResponse"/></returns>
        public ModifyFlexFundingAccountResponse ModifyFlexFundingAccountSync(ModifyFlexFundingAccountRequest req)
        {
            return InternalRequestAsync<ModifyFlexFundingAccountResponse>(req, "ModifyFlexFundingAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-收款用户账户权益状态修改
        /// </summary>
        /// <param name="req"><see cref="ModifyFlexPayeeAccountRightStatusRequest"/></param>
        /// <returns><see cref="ModifyFlexPayeeAccountRightStatusResponse"/></returns>
        public Task<ModifyFlexPayeeAccountRightStatusResponse> ModifyFlexPayeeAccountRightStatus(ModifyFlexPayeeAccountRightStatusRequest req)
        {
            return InternalRequestAsync<ModifyFlexPayeeAccountRightStatusResponse>(req, "ModifyFlexPayeeAccountRightStatus");
        }

        /// <summary>
        /// 灵云V2-收款用户账户权益状态修改
        /// </summary>
        /// <param name="req"><see cref="ModifyFlexPayeeAccountRightStatusRequest"/></param>
        /// <returns><see cref="ModifyFlexPayeeAccountRightStatusResponse"/></returns>
        public ModifyFlexPayeeAccountRightStatusResponse ModifyFlexPayeeAccountRightStatusSync(ModifyFlexPayeeAccountRightStatusRequest req)
        {
            return InternalRequestAsync<ModifyFlexPayeeAccountRightStatusResponse>(req, "ModifyFlexPayeeAccountRightStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云鉴-商户信息修改的接口
        /// </summary>
        /// <param name="req"><see cref="ModifyMerchantRequest"/></param>
        /// <returns><see cref="ModifyMerchantResponse"/></returns>
        public Task<ModifyMerchantResponse> ModifyMerchant(ModifyMerchantRequest req)
        {
            return InternalRequestAsync<ModifyMerchantResponse>(req, "ModifyMerchant");
        }

        /// <summary>
        /// 云鉴-商户信息修改的接口
        /// </summary>
        /// <param name="req"><see cref="ModifyMerchantRequest"/></param>
        /// <returns><see cref="ModifyMerchantResponse"/></returns>
        public ModifyMerchantResponse ModifyMerchantSync(ModifyMerchantRequest req)
        {
            return InternalRequestAsync<ModifyMerchantResponse>(req, "ModifyMerchant")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 维护会员绑定提现账户联行号。此接口可以支持市场修改会员的提现账户的开户行信息，具体包括开户行行名、开户行的银行联行号（大小额联行号）和超级网银行号。
        /// </summary>
        /// <param name="req"><see cref="ModifyMntMbrBindRelateAcctBankCodeRequest"/></param>
        /// <returns><see cref="ModifyMntMbrBindRelateAcctBankCodeResponse"/></returns>
        public Task<ModifyMntMbrBindRelateAcctBankCodeResponse> ModifyMntMbrBindRelateAcctBankCode(ModifyMntMbrBindRelateAcctBankCodeRequest req)
        {
            return InternalRequestAsync<ModifyMntMbrBindRelateAcctBankCodeResponse>(req, "ModifyMntMbrBindRelateAcctBankCode");
        }

        /// <summary>
        /// 维护会员绑定提现账户联行号。此接口可以支持市场修改会员的提现账户的开户行信息，具体包括开户行行名、开户行的银行联行号（大小额联行号）和超级网银行号。
        /// </summary>
        /// <param name="req"><see cref="ModifyMntMbrBindRelateAcctBankCodeRequest"/></param>
        /// <returns><see cref="ModifyMntMbrBindRelateAcctBankCodeResponse"/></returns>
        public ModifyMntMbrBindRelateAcctBankCodeResponse ModifyMntMbrBindRelateAcctBankCodeSync(ModifyMntMbrBindRelateAcctBankCodeRequest req)
        {
            return InternalRequestAsync<ModifyMntMbrBindRelateAcctBankCodeResponse>(req, "ModifyMntMbrBindRelateAcctBankCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 聚鑫-查询子账户绑定银行卡
        /// </summary>
        /// <param name="req"><see cref="QueryAcctBindingRequest"/></param>
        /// <returns><see cref="QueryAcctBindingResponse"/></returns>
        public Task<QueryAcctBindingResponse> QueryAcctBinding(QueryAcctBindingRequest req)
        {
            return InternalRequestAsync<QueryAcctBindingResponse>(req, "QueryAcctBinding");
        }

        /// <summary>
        /// 聚鑫-查询子账户绑定银行卡
        /// </summary>
        /// <param name="req"><see cref="QueryAcctBindingRequest"/></param>
        /// <returns><see cref="QueryAcctBindingResponse"/></returns>
        public QueryAcctBindingResponse QueryAcctBindingSync(QueryAcctBindingRequest req)
        {
            return InternalRequestAsync<QueryAcctBindingResponse>(req, "QueryAcctBinding")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 聚鑫-开户信息查询
        /// </summary>
        /// <param name="req"><see cref="QueryAcctInfoRequest"/></param>
        /// <returns><see cref="QueryAcctInfoResponse"/></returns>
        public Task<QueryAcctInfoResponse> QueryAcctInfo(QueryAcctInfoRequest req)
        {
            return InternalRequestAsync<QueryAcctInfoResponse>(req, "QueryAcctInfo");
        }

        /// <summary>
        /// 聚鑫-开户信息查询
        /// </summary>
        /// <param name="req"><see cref="QueryAcctInfoRequest"/></param>
        /// <returns><see cref="QueryAcctInfoResponse"/></returns>
        public QueryAcctInfoResponse QueryAcctInfoSync(QueryAcctInfoRequest req)
        {
            return InternalRequestAsync<QueryAcctInfoResponse>(req, "QueryAcctInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 聚鑫-开户信息列表查询, 查询某一段时间的开户信息
        /// </summary>
        /// <param name="req"><see cref="QueryAcctInfoListRequest"/></param>
        /// <returns><see cref="QueryAcctInfoListResponse"/></returns>
        public Task<QueryAcctInfoListResponse> QueryAcctInfoList(QueryAcctInfoListRequest req)
        {
            return InternalRequestAsync<QueryAcctInfoListResponse>(req, "QueryAcctInfoList");
        }

        /// <summary>
        /// 聚鑫-开户信息列表查询, 查询某一段时间的开户信息
        /// </summary>
        /// <param name="req"><see cref="QueryAcctInfoListRequest"/></param>
        /// <returns><see cref="QueryAcctInfoListResponse"/></returns>
        public QueryAcctInfoListResponse QueryAcctInfoListSync(QueryAcctInfoListRequest req)
        {
            return InternalRequestAsync<QueryAcctInfoListResponse>(req, "QueryAcctInfoList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播平台-查询代理商结算单链接
        /// </summary>
        /// <param name="req"><see cref="QueryAgentStatementsRequest"/></param>
        /// <returns><see cref="QueryAgentStatementsResponse"/></returns>
        public Task<QueryAgentStatementsResponse> QueryAgentStatements(QueryAgentStatementsRequest req)
        {
            return InternalRequestAsync<QueryAgentStatementsResponse>(req, "QueryAgentStatements");
        }

        /// <summary>
        /// 直播平台-查询代理商结算单链接
        /// </summary>
        /// <param name="req"><see cref="QueryAgentStatementsRequest"/></param>
        /// <returns><see cref="QueryAgentStatementsResponse"/></returns>
        public QueryAgentStatementsResponse QueryAgentStatementsSync(QueryAgentStatementsRequest req)
        {
            return InternalRequestAsync<QueryAgentStatementsResponse>(req, "QueryAgentStatements")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播平台-查询批次信息
        /// </summary>
        /// <param name="req"><see cref="QueryAgentTaxPaymentBatchRequest"/></param>
        /// <returns><see cref="QueryAgentTaxPaymentBatchResponse"/></returns>
        public Task<QueryAgentTaxPaymentBatchResponse> QueryAgentTaxPaymentBatch(QueryAgentTaxPaymentBatchRequest req)
        {
            return InternalRequestAsync<QueryAgentTaxPaymentBatchResponse>(req, "QueryAgentTaxPaymentBatch");
        }

        /// <summary>
        /// 直播平台-查询批次信息
        /// </summary>
        /// <param name="req"><see cref="QueryAgentTaxPaymentBatchRequest"/></param>
        /// <returns><see cref="QueryAgentTaxPaymentBatchResponse"/></returns>
        public QueryAgentTaxPaymentBatchResponse QueryAgentTaxPaymentBatchSync(QueryAgentTaxPaymentBatchRequest req)
        {
            return InternalRequestAsync<QueryAgentTaxPaymentBatchResponse>(req, "QueryAgentTaxPaymentBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播平台-查询主播签约信息
        /// </summary>
        /// <param name="req"><see cref="QueryAnchorContractInfoRequest"/></param>
        /// <returns><see cref="QueryAnchorContractInfoResponse"/></returns>
        public Task<QueryAnchorContractInfoResponse> QueryAnchorContractInfo(QueryAnchorContractInfoRequest req)
        {
            return InternalRequestAsync<QueryAnchorContractInfoResponse>(req, "QueryAnchorContractInfo");
        }

        /// <summary>
        /// 直播平台-查询主播签约信息
        /// </summary>
        /// <param name="req"><see cref="QueryAnchorContractInfoRequest"/></param>
        /// <returns><see cref="QueryAnchorContractInfoResponse"/></returns>
        public QueryAnchorContractInfoResponse QueryAnchorContractInfoSync(QueryAnchorContractInfoRequest req)
        {
            return InternalRequestAsync<QueryAnchorContractInfoResponse>(req, "QueryAnchorContractInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 跨境-成功申报材料查询。查询成功入库的申报材料。
        /// </summary>
        /// <param name="req"><see cref="QueryApplicationMaterialRequest"/></param>
        /// <returns><see cref="QueryApplicationMaterialResponse"/></returns>
        public Task<QueryApplicationMaterialResponse> QueryApplicationMaterial(QueryApplicationMaterialRequest req)
        {
            return InternalRequestAsync<QueryApplicationMaterialResponse>(req, "QueryApplicationMaterial");
        }

        /// <summary>
        /// 跨境-成功申报材料查询。查询成功入库的申报材料。
        /// </summary>
        /// <param name="req"><see cref="QueryApplicationMaterialRequest"/></param>
        /// <returns><see cref="QueryApplicationMaterialResponse"/></returns>
        public QueryApplicationMaterialResponse QueryApplicationMaterialSync(QueryApplicationMaterialRequest req)
        {
            return InternalRequestAsync<QueryApplicationMaterialResponse>(req, "QueryApplicationMaterial")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播平台-查询分配关系
        /// </summary>
        /// <param name="req"><see cref="QueryAssignmentRequest"/></param>
        /// <returns><see cref="QueryAssignmentResponse"/></returns>
        public Task<QueryAssignmentResponse> QueryAssignment(QueryAssignmentRequest req)
        {
            return InternalRequestAsync<QueryAssignmentResponse>(req, "QueryAssignment");
        }

        /// <summary>
        /// 直播平台-查询分配关系
        /// </summary>
        /// <param name="req"><see cref="QueryAssignmentRequest"/></param>
        /// <returns><see cref="QueryAssignmentResponse"/></returns>
        public QueryAssignmentResponse QueryAssignmentSync(QueryAssignmentRequest req)
        {
            return InternalRequestAsync<QueryAssignmentResponse>(req, "QueryAssignment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 子商户余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryBalanceRequest"/></param>
        /// <returns><see cref="QueryBalanceResponse"/></returns>
        public Task<QueryBalanceResponse> QueryBalance(QueryBalanceRequest req)
        {
            return InternalRequestAsync<QueryBalanceResponse>(req, "QueryBalance");
        }

        /// <summary>
        /// 子商户余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryBalanceRequest"/></param>
        /// <returns><see cref="QueryBalanceResponse"/></returns>
        public QueryBalanceResponse QueryBalanceSync(QueryBalanceRequest req)
        {
            return InternalRequestAsync<QueryBalanceResponse>(req, "QueryBalance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询银行在途清算结果。查询时间段内交易网的在途清算结果。
        /// </summary>
        /// <param name="req"><see cref="QueryBankClearRequest"/></param>
        /// <returns><see cref="QueryBankClearResponse"/></returns>
        public Task<QueryBankClearResponse> QueryBankClear(QueryBankClearRequest req)
        {
            return InternalRequestAsync<QueryBankClearResponse>(req, "QueryBankClear");
        }

        /// <summary>
        /// 查询银行在途清算结果。查询时间段内交易网的在途清算结果。
        /// </summary>
        /// <param name="req"><see cref="QueryBankClearRequest"/></param>
        /// <returns><see cref="QueryBankClearResponse"/></returns>
        public QueryBankClearResponse QueryBankClearSync(QueryBankClearRequest req)
        {
            return InternalRequestAsync<QueryBankClearResponse>(req, "QueryBankClear")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询银行时间段内交易明细。查询时间段的会员成功交易。
        /// </summary>
        /// <param name="req"><see cref="QueryBankTransactionDetailsRequest"/></param>
        /// <returns><see cref="QueryBankTransactionDetailsResponse"/></returns>
        public Task<QueryBankTransactionDetailsResponse> QueryBankTransactionDetails(QueryBankTransactionDetailsRequest req)
        {
            return InternalRequestAsync<QueryBankTransactionDetailsResponse>(req, "QueryBankTransactionDetails");
        }

        /// <summary>
        /// 查询银行时间段内交易明细。查询时间段的会员成功交易。
        /// </summary>
        /// <param name="req"><see cref="QueryBankTransactionDetailsRequest"/></param>
        /// <returns><see cref="QueryBankTransactionDetailsResponse"/></returns>
        public QueryBankTransactionDetailsResponse QueryBankTransactionDetailsSync(QueryBankTransactionDetailsRequest req)
        {
            return InternalRequestAsync<QueryBankTransactionDetailsResponse>(req, "QueryBankTransactionDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询银行时间段内清分提现明细。查询银行时间段内清分提现明细接口：若为“见证+收单退款”“见证+收单充值”记录时备注Note为“见证+收单充值,订单号”“见证+收单退款,订单号”，此接口可以查到T0/T1的充值明细和退款记录。查询标志：充值记录仍用3清分选项查询，退款记录同提现用2选项查询。
        /// </summary>
        /// <param name="req"><see cref="QueryBankWithdrawCashDetailsRequest"/></param>
        /// <returns><see cref="QueryBankWithdrawCashDetailsResponse"/></returns>
        public Task<QueryBankWithdrawCashDetailsResponse> QueryBankWithdrawCashDetails(QueryBankWithdrawCashDetailsRequest req)
        {
            return InternalRequestAsync<QueryBankWithdrawCashDetailsResponse>(req, "QueryBankWithdrawCashDetails");
        }

        /// <summary>
        /// 查询银行时间段内清分提现明细。查询银行时间段内清分提现明细接口：若为“见证+收单退款”“见证+收单充值”记录时备注Note为“见证+收单充值,订单号”“见证+收单退款,订单号”，此接口可以查到T0/T1的充值明细和退款记录。查询标志：充值记录仍用3清分选项查询，退款记录同提现用2选项查询。
        /// </summary>
        /// <param name="req"><see cref="QueryBankWithdrawCashDetailsRequest"/></param>
        /// <returns><see cref="QueryBankWithdrawCashDetailsResponse"/></returns>
        public QueryBankWithdrawCashDetailsResponse QueryBankWithdrawCashDetailsSync(QueryBankWithdrawCashDetailsRequest req)
        {
            return InternalRequestAsync<QueryBankWithdrawCashDetailsResponse>(req, "QueryBankWithdrawCashDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云-批量转账结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryBatchPaymentResultRequest"/></param>
        /// <returns><see cref="QueryBatchPaymentResultResponse"/></returns>
        public Task<QueryBatchPaymentResultResponse> QueryBatchPaymentResult(QueryBatchPaymentResultRequest req)
        {
            return InternalRequestAsync<QueryBatchPaymentResultResponse>(req, "QueryBatchPaymentResult");
        }

        /// <summary>
        /// 灵云-批量转账结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryBatchPaymentResultRequest"/></param>
        /// <returns><see cref="QueryBatchPaymentResultResponse"/></returns>
        public QueryBatchPaymentResultResponse QueryBatchPaymentResultSync(QueryBatchPaymentResultRequest req)
        {
            return InternalRequestAsync<QueryBatchPaymentResultResponse>(req, "QueryBatchPaymentResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 获取单笔代发转账对账单下载URL
        /// </summary>
        /// <param name="req"><see cref="QueryBillDownloadURLRequest"/></param>
        /// <returns><see cref="QueryBillDownloadURLResponse"/></returns>
        public Task<QueryBillDownloadURLResponse> QueryBillDownloadURL(QueryBillDownloadURLRequest req)
        {
            return InternalRequestAsync<QueryBillDownloadURLResponse>(req, "QueryBillDownloadURL");
        }

        /// <summary>
        /// 获取单笔代发转账对账单下载URL
        /// </summary>
        /// <param name="req"><see cref="QueryBillDownloadURLRequest"/></param>
        /// <returns><see cref="QueryBillDownloadURLResponse"/></returns>
        public QueryBillDownloadURLResponse QueryBillDownloadURLSync(QueryBillDownloadURLRequest req)
        {
            return InternalRequestAsync<QueryBillDownloadURLResponse>(req, "QueryBillDownloadURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-查询城市编码接口
        /// </summary>
        /// <param name="req"><see cref="QueryCityCodeRequest"/></param>
        /// <returns><see cref="QueryCityCodeResponse"/></returns>
        public Task<QueryCityCodeResponse> QueryCityCode(QueryCityCodeRequest req)
        {
            return InternalRequestAsync<QueryCityCodeResponse>(req, "QueryCityCode");
        }

        /// <summary>
        /// 云支付-查询城市编码接口
        /// </summary>
        /// <param name="req"><see cref="QueryCityCodeRequest"/></param>
        /// <returns><see cref="QueryCityCodeResponse"/></returns>
        public QueryCityCodeResponse QueryCityCodeSync(QueryCityCodeRequest req)
        {
            return InternalRequestAsync<QueryCityCodeResponse>(req, "QueryCityCode")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发起支付等渠道操作后，可以调用该接口查询渠道的数据。
        /// </summary>
        /// <param name="req"><see cref="QueryCloudChannelDataRequest"/></param>
        /// <returns><see cref="QueryCloudChannelDataResponse"/></returns>
        public Task<QueryCloudChannelDataResponse> QueryCloudChannelData(QueryCloudChannelDataRequest req)
        {
            return InternalRequestAsync<QueryCloudChannelDataResponse>(req, "QueryCloudChannelData");
        }

        /// <summary>
        /// 发起支付等渠道操作后，可以调用该接口查询渠道的数据。
        /// </summary>
        /// <param name="req"><see cref="QueryCloudChannelDataRequest"/></param>
        /// <returns><see cref="QueryCloudChannelDataResponse"/></returns>
        public QueryCloudChannelDataResponse QueryCloudChannelDataSync(QueryCloudChannelDataRequest req)
        {
            return InternalRequestAsync<QueryCloudChannelDataResponse>(req, "QueryCloudChannelData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据订单号或用户ID，查询支付订单状态。
        /// </summary>
        /// <param name="req"><see cref="QueryCloudOrderRequest"/></param>
        /// <returns><see cref="QueryCloudOrderResponse"/></returns>
        public Task<QueryCloudOrderResponse> QueryCloudOrder(QueryCloudOrderRequest req)
        {
            return InternalRequestAsync<QueryCloudOrderResponse>(req, "QueryCloudOrder");
        }

        /// <summary>
        /// 根据订单号或用户ID，查询支付订单状态。
        /// </summary>
        /// <param name="req"><see cref="QueryCloudOrderRequest"/></param>
        /// <returns><see cref="QueryCloudOrderResponse"/></returns>
        public QueryCloudOrderResponse QueryCloudOrderSync(QueryCloudOrderRequest req)
        {
            return InternalRequestAsync<QueryCloudOrderResponse>(req, "QueryCloudOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交退款申请后，通过调用该接口查询退款状态。退款可能有一定延时，用微信零钱支付的退款约20分钟内到账，银行卡支付的退款约3个工作日后到账。
        /// </summary>
        /// <param name="req"><see cref="QueryCloudRefundOrderRequest"/></param>
        /// <returns><see cref="QueryCloudRefundOrderResponse"/></returns>
        public Task<QueryCloudRefundOrderResponse> QueryCloudRefundOrder(QueryCloudRefundOrderRequest req)
        {
            return InternalRequestAsync<QueryCloudRefundOrderResponse>(req, "QueryCloudRefundOrder");
        }

        /// <summary>
        /// 提交退款申请后，通过调用该接口查询退款状态。退款可能有一定延时，用微信零钱支付的退款约20分钟内到账，银行卡支付的退款约3个工作日后到账。
        /// </summary>
        /// <param name="req"><see cref="QueryCloudRefundOrderRequest"/></param>
        /// <returns><see cref="QueryCloudRefundOrderResponse"/></returns>
        public QueryCloudRefundOrderResponse QueryCloudRefundOrderSync(QueryCloudRefundOrderRequest req)
        {
            return InternalRequestAsync<QueryCloudRefundOrderResponse>(req, "QueryCloudRefundOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询普通转账充值明细。接口用于查询会员主动转账进资金汇总账户的明细情况。若会员使用绑定账号转入，则直接入账到会员子账户。若未使用绑定账号转入，则系统无法自动清分到对应子账户，则转入挂账子账户由平台自行清分。若是 “见证+收单充值”T0充值记录时备注Note为“见证+收单充值,订单号” 此接口可以查到T0到账的“见证+收单充值”充值记录。
        /// </summary>
        /// <param name="req"><see cref="QueryCommonTransferRechargeRequest"/></param>
        /// <returns><see cref="QueryCommonTransferRechargeResponse"/></returns>
        public Task<QueryCommonTransferRechargeResponse> QueryCommonTransferRecharge(QueryCommonTransferRechargeRequest req)
        {
            return InternalRequestAsync<QueryCommonTransferRechargeResponse>(req, "QueryCommonTransferRecharge");
        }

        /// <summary>
        /// 查询普通转账充值明细。接口用于查询会员主动转账进资金汇总账户的明细情况。若会员使用绑定账号转入，则直接入账到会员子账户。若未使用绑定账号转入，则系统无法自动清分到对应子账户，则转入挂账子账户由平台自行清分。若是 “见证+收单充值”T0充值记录时备注Note为“见证+收单充值,订单号” 此接口可以查到T0到账的“见证+收单充值”充值记录。
        /// </summary>
        /// <param name="req"><see cref="QueryCommonTransferRechargeRequest"/></param>
        /// <returns><see cref="QueryCommonTransferRechargeResponse"/></returns>
        public QueryCommonTransferRechargeResponse QueryCommonTransferRechargeSync(QueryCommonTransferRechargeRequest req)
        {
            return InternalRequestAsync<QueryCommonTransferRechargeResponse>(req, "QueryCommonTransferRecharge")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智慧零售-查询公司抬头
        /// </summary>
        /// <param name="req"><see cref="QueryCompanyTitleRequest"/></param>
        /// <returns><see cref="QueryCompanyTitleResponse"/></returns>
        public Task<QueryCompanyTitleResponse> QueryCompanyTitle(QueryCompanyTitleRequest req)
        {
            return InternalRequestAsync<QueryCompanyTitleResponse>(req, "QueryCompanyTitle");
        }

        /// <summary>
        /// 智慧零售-查询公司抬头
        /// </summary>
        /// <param name="req"><see cref="QueryCompanyTitleRequest"/></param>
        /// <returns><see cref="QueryCompanyTitleResponse"/></returns>
        public QueryCompanyTitleResponse QueryCompanyTitleSync(QueryCompanyTitleRequest req)
        {
            return InternalRequestAsync<QueryCompanyTitleResponse>(req, "QueryCompanyTitle")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过此接口查询签约数据
        /// </summary>
        /// <param name="req"><see cref="QueryContractRequest"/></param>
        /// <returns><see cref="QueryContractResponse"/></returns>
        public Task<QueryContractResponse> QueryContract(QueryContractRequest req)
        {
            return InternalRequestAsync<QueryContractResponse>(req, "QueryContract");
        }

        /// <summary>
        /// 通过此接口查询签约数据
        /// </summary>
        /// <param name="req"><see cref="QueryContractRequest"/></param>
        /// <returns><see cref="QueryContractResponse"/></returns>
        public QueryContractResponse QueryContractSync(QueryContractRequest req)
        {
            return InternalRequestAsync<QueryContractResponse>(req, "QueryContract")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-查询支付方式费率及自定义表单项接口
        /// </summary>
        /// <param name="req"><see cref="QueryContractPayFeeRequest"/></param>
        /// <returns><see cref="QueryContractPayFeeResponse"/></returns>
        public Task<QueryContractPayFeeResponse> QueryContractPayFee(QueryContractPayFeeRequest req)
        {
            return InternalRequestAsync<QueryContractPayFeeResponse>(req, "QueryContractPayFee");
        }

        /// <summary>
        /// 云支付-查询支付方式费率及自定义表单项接口
        /// </summary>
        /// <param name="req"><see cref="QueryContractPayFeeRequest"/></param>
        /// <returns><see cref="QueryContractPayFeeResponse"/></returns>
        public QueryContractPayFeeResponse QueryContractPayFeeSync(QueryContractPayFeeRequest req)
        {
            return InternalRequestAsync<QueryContractPayFeeResponse>(req, "QueryContractPayFee")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-查询合同支付方式列表接口
        /// </summary>
        /// <param name="req"><see cref="QueryContractPayWayListRequest"/></param>
        /// <returns><see cref="QueryContractPayWayListResponse"/></returns>
        public Task<QueryContractPayWayListResponse> QueryContractPayWayList(QueryContractPayWayListRequest req)
        {
            return InternalRequestAsync<QueryContractPayWayListResponse>(req, "QueryContractPayWayList");
        }

        /// <summary>
        /// 云支付-查询合同支付方式列表接口
        /// </summary>
        /// <param name="req"><see cref="QueryContractPayWayListRequest"/></param>
        /// <returns><see cref="QueryContractPayWayListResponse"/></returns>
        public QueryContractPayWayListResponse QueryContractPayWayListSync(QueryContractPayWayListRequest req)
        {
            return InternalRequestAsync<QueryContractPayWayListResponse>(req, "QueryContractPayWayList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-查询合同可关联门店接口
        /// </summary>
        /// <param name="req"><see cref="QueryContractRelateShopRequest"/></param>
        /// <returns><see cref="QueryContractRelateShopResponse"/></returns>
        public Task<QueryContractRelateShopResponse> QueryContractRelateShop(QueryContractRelateShopRequest req)
        {
            return InternalRequestAsync<QueryContractRelateShopResponse>(req, "QueryContractRelateShop");
        }

        /// <summary>
        /// 云支付-查询合同可关联门店接口
        /// </summary>
        /// <param name="req"><see cref="QueryContractRelateShopRequest"/></param>
        /// <returns><see cref="QueryContractRelateShopResponse"/></returns>
        public QueryContractRelateShopResponse QueryContractRelateShopSync(QueryContractRelateShopRequest req)
        {
            return InternalRequestAsync<QueryContractRelateShopResponse>(req, "QueryContractRelateShop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询银行子账户余额。查询会员子账户以及平台的功能子账户的余额。
        /// </summary>
        /// <param name="req"><see cref="QueryCustAcctIdBalanceRequest"/></param>
        /// <returns><see cref="QueryCustAcctIdBalanceResponse"/></returns>
        public Task<QueryCustAcctIdBalanceResponse> QueryCustAcctIdBalance(QueryCustAcctIdBalanceRequest req)
        {
            return InternalRequestAsync<QueryCustAcctIdBalanceResponse>(req, "QueryCustAcctIdBalance");
        }

        /// <summary>
        /// 查询银行子账户余额。查询会员子账户以及平台的功能子账户的余额。
        /// </summary>
        /// <param name="req"><see cref="QueryCustAcctIdBalanceRequest"/></param>
        /// <returns><see cref="QueryCustAcctIdBalanceResponse"/></returns>
        public QueryCustAcctIdBalanceResponse QueryCustAcctIdBalanceSync(QueryCustAcctIdBalanceRequest req)
        {
            return InternalRequestAsync<QueryCustAcctIdBalanceResponse>(req, "QueryCustAcctIdBalance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云鉴-查询对账单下载地址的接口
        /// </summary>
        /// <param name="req"><see cref="QueryDownloadBillURLRequest"/></param>
        /// <returns><see cref="QueryDownloadBillURLResponse"/></returns>
        public Task<QueryDownloadBillURLResponse> QueryDownloadBillURL(QueryDownloadBillURLRequest req)
        {
            return InternalRequestAsync<QueryDownloadBillURLResponse>(req, "QueryDownloadBillURL");
        }

        /// <summary>
        /// 云鉴-查询对账单下载地址的接口
        /// </summary>
        /// <param name="req"><see cref="QueryDownloadBillURLRequest"/></param>
        /// <returns><see cref="QueryDownloadBillURLResponse"/></returns>
        public QueryDownloadBillURLResponse QueryDownloadBillURLSync(QueryDownloadBillURLRequest req)
        {
            return InternalRequestAsync<QueryDownloadBillURLResponse>(req, "QueryDownloadBillURL")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云-查询超额信息
        /// </summary>
        /// <param name="req"><see cref="QueryExceedingInfoRequest"/></param>
        /// <returns><see cref="QueryExceedingInfoResponse"/></returns>
        public Task<QueryExceedingInfoResponse> QueryExceedingInfo(QueryExceedingInfoRequest req)
        {
            return InternalRequestAsync<QueryExceedingInfoResponse>(req, "QueryExceedingInfo");
        }

        /// <summary>
        /// 灵云-查询超额信息
        /// </summary>
        /// <param name="req"><see cref="QueryExceedingInfoRequest"/></param>
        /// <returns><see cref="QueryExceedingInfoResponse"/></returns>
        public QueryExceedingInfoResponse QueryExceedingInfoSync(QueryExceedingInfoRequest req)
        {
            return InternalRequestAsync<QueryExceedingInfoResponse>(req, "QueryExceedingInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 跨境-查询汇率
        /// </summary>
        /// <param name="req"><see cref="QueryExchangeRateRequest"/></param>
        /// <returns><see cref="QueryExchangeRateResponse"/></returns>
        public Task<QueryExchangeRateResponse> QueryExchangeRate(QueryExchangeRateRequest req)
        {
            return InternalRequestAsync<QueryExchangeRateResponse>(req, "QueryExchangeRate");
        }

        /// <summary>
        /// 跨境-查询汇率
        /// </summary>
        /// <param name="req"><see cref="QueryExchangeRateRequest"/></param>
        /// <returns><see cref="QueryExchangeRateResponse"/></returns>
        public QueryExchangeRateResponse QueryExchangeRateSync(QueryExchangeRateRequest req)
        {
            return InternalRequestAsync<QueryExchangeRateResponse>(req, "QueryExchangeRate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 财税-查询金融数据文件下载链接
        /// </summary>
        /// <param name="req"><see cref="QueryFinancialDataUrlRequest"/></param>
        /// <returns><see cref="QueryFinancialDataUrlResponse"/></returns>
        public Task<QueryFinancialDataUrlResponse> QueryFinancialDataUrl(QueryFinancialDataUrlRequest req)
        {
            return InternalRequestAsync<QueryFinancialDataUrlResponse>(req, "QueryFinancialDataUrl");
        }

        /// <summary>
        /// 财税-查询金融数据文件下载链接
        /// </summary>
        /// <param name="req"><see cref="QueryFinancialDataUrlRequest"/></param>
        /// <returns><see cref="QueryFinancialDataUrlResponse"/></returns>
        public QueryFinancialDataUrlResponse QueryFinancialDataUrlSync(QueryFinancialDataUrlRequest req)
        {
            return InternalRequestAsync<QueryFinancialDataUrlResponse>(req, "QueryFinancialDataUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-查询税前金额
        /// </summary>
        /// <param name="req"><see cref="QueryFlexAmountBeforeTaxRequest"/></param>
        /// <returns><see cref="QueryFlexAmountBeforeTaxResponse"/></returns>
        public Task<QueryFlexAmountBeforeTaxResponse> QueryFlexAmountBeforeTax(QueryFlexAmountBeforeTaxRequest req)
        {
            return InternalRequestAsync<QueryFlexAmountBeforeTaxResponse>(req, "QueryFlexAmountBeforeTax");
        }

        /// <summary>
        /// 灵云V2-查询税前金额
        /// </summary>
        /// <param name="req"><see cref="QueryFlexAmountBeforeTaxRequest"/></param>
        /// <returns><see cref="QueryFlexAmountBeforeTaxResponse"/></returns>
        public QueryFlexAmountBeforeTaxResponse QueryFlexAmountBeforeTaxSync(QueryFlexAmountBeforeTaxRequest req)
        {
            return InternalRequestAsync<QueryFlexAmountBeforeTaxResponse>(req, "QueryFlexAmountBeforeTax")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-查询对账单文件下载链接
        /// </summary>
        /// <param name="req"><see cref="QueryFlexBillDownloadUrlRequest"/></param>
        /// <returns><see cref="QueryFlexBillDownloadUrlResponse"/></returns>
        public Task<QueryFlexBillDownloadUrlResponse> QueryFlexBillDownloadUrl(QueryFlexBillDownloadUrlRequest req)
        {
            return InternalRequestAsync<QueryFlexBillDownloadUrlResponse>(req, "QueryFlexBillDownloadUrl");
        }

        /// <summary>
        /// 灵云V2-查询对账单文件下载链接
        /// </summary>
        /// <param name="req"><see cref="QueryFlexBillDownloadUrlRequest"/></param>
        /// <returns><see cref="QueryFlexBillDownloadUrlResponse"/></returns>
        public QueryFlexBillDownloadUrlResponse QueryFlexBillDownloadUrlSync(QueryFlexBillDownloadUrlRequest req)
        {
            return InternalRequestAsync<QueryFlexBillDownloadUrlResponse>(req, "QueryFlexBillDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-查询冻结订单列表
        /// </summary>
        /// <param name="req"><see cref="QueryFlexFreezeOrderListRequest"/></param>
        /// <returns><see cref="QueryFlexFreezeOrderListResponse"/></returns>
        public Task<QueryFlexFreezeOrderListResponse> QueryFlexFreezeOrderList(QueryFlexFreezeOrderListRequest req)
        {
            return InternalRequestAsync<QueryFlexFreezeOrderListResponse>(req, "QueryFlexFreezeOrderList");
        }

        /// <summary>
        /// 灵云V2-查询冻结订单列表
        /// </summary>
        /// <param name="req"><see cref="QueryFlexFreezeOrderListRequest"/></param>
        /// <returns><see cref="QueryFlexFreezeOrderListResponse"/></returns>
        public QueryFlexFreezeOrderListResponse QueryFlexFreezeOrderListSync(QueryFlexFreezeOrderListRequest req)
        {
            return InternalRequestAsync<QueryFlexFreezeOrderListResponse>(req, "QueryFlexFreezeOrderList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-订单汇总列表查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexOrderSummaryListRequest"/></param>
        /// <returns><see cref="QueryFlexOrderSummaryListResponse"/></returns>
        public Task<QueryFlexOrderSummaryListResponse> QueryFlexOrderSummaryList(QueryFlexOrderSummaryListRequest req)
        {
            return InternalRequestAsync<QueryFlexOrderSummaryListResponse>(req, "QueryFlexOrderSummaryList");
        }

        /// <summary>
        /// 灵云V2-订单汇总列表查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexOrderSummaryListRequest"/></param>
        /// <returns><see cref="QueryFlexOrderSummaryListResponse"/></returns>
        public QueryFlexOrderSummaryListResponse QueryFlexOrderSummaryListSync(QueryFlexOrderSummaryListRequest req)
        {
            return InternalRequestAsync<QueryFlexOrderSummaryListResponse>(req, "QueryFlexOrderSummaryList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-收款用户账户余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeAccountBalanceRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeAccountBalanceResponse"/></returns>
        public Task<QueryFlexPayeeAccountBalanceResponse> QueryFlexPayeeAccountBalance(QueryFlexPayeeAccountBalanceRequest req)
        {
            return InternalRequestAsync<QueryFlexPayeeAccountBalanceResponse>(req, "QueryFlexPayeeAccountBalance");
        }

        /// <summary>
        /// 灵云V2-收款用户账户余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeAccountBalanceRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeAccountBalanceResponse"/></returns>
        public QueryFlexPayeeAccountBalanceResponse QueryFlexPayeeAccountBalanceSync(QueryFlexPayeeAccountBalanceRequest req)
        {
            return InternalRequestAsync<QueryFlexPayeeAccountBalanceResponse>(req, "QueryFlexPayeeAccountBalance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-收款用户账户信息查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeAccountInfoRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeAccountInfoResponse"/></returns>
        public Task<QueryFlexPayeeAccountInfoResponse> QueryFlexPayeeAccountInfo(QueryFlexPayeeAccountInfoRequest req)
        {
            return InternalRequestAsync<QueryFlexPayeeAccountInfoResponse>(req, "QueryFlexPayeeAccountInfo");
        }

        /// <summary>
        /// 灵云V2-收款用户账户信息查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeAccountInfoRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeAccountInfoResponse"/></returns>
        public QueryFlexPayeeAccountInfoResponse QueryFlexPayeeAccountInfoSync(QueryFlexPayeeAccountInfoRequest req)
        {
            return InternalRequestAsync<QueryFlexPayeeAccountInfoResponse>(req, "QueryFlexPayeeAccountInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-收款用户账户列表查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeAccountListRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeAccountListResponse"/></returns>
        public Task<QueryFlexPayeeAccountListResponse> QueryFlexPayeeAccountList(QueryFlexPayeeAccountListRequest req)
        {
            return InternalRequestAsync<QueryFlexPayeeAccountListResponse>(req, "QueryFlexPayeeAccountList");
        }

        /// <summary>
        /// 灵云V2-收款用户账户列表查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeAccountListRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeAccountListResponse"/></returns>
        public QueryFlexPayeeAccountListResponse QueryFlexPayeeAccountListSync(QueryFlexPayeeAccountListRequest req)
        {
            return InternalRequestAsync<QueryFlexPayeeAccountListResponse>(req, "QueryFlexPayeeAccountList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-收款用户信息查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeInfoRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeInfoResponse"/></returns>
        public Task<QueryFlexPayeeInfoResponse> QueryFlexPayeeInfo(QueryFlexPayeeInfoRequest req)
        {
            return InternalRequestAsync<QueryFlexPayeeInfoResponse>(req, "QueryFlexPayeeInfo");
        }

        /// <summary>
        /// 灵云V2-收款用户信息查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPayeeInfoRequest"/></param>
        /// <returns><see cref="QueryFlexPayeeInfoResponse"/></returns>
        public QueryFlexPayeeInfoResponse QueryFlexPayeeInfoSync(QueryFlexPayeeInfoRequest req)
        {
            return InternalRequestAsync<QueryFlexPayeeInfoResponse>(req, "QueryFlexPayeeInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-查询付款订单列表
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPaymentOrderListRequest"/></param>
        /// <returns><see cref="QueryFlexPaymentOrderListResponse"/></returns>
        public Task<QueryFlexPaymentOrderListResponse> QueryFlexPaymentOrderList(QueryFlexPaymentOrderListRequest req)
        {
            return InternalRequestAsync<QueryFlexPaymentOrderListResponse>(req, "QueryFlexPaymentOrderList");
        }

        /// <summary>
        /// 灵云V2-查询付款订单列表
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPaymentOrderListRequest"/></param>
        /// <returns><see cref="QueryFlexPaymentOrderListResponse"/></returns>
        public QueryFlexPaymentOrderListResponse QueryFlexPaymentOrderListSync(QueryFlexPaymentOrderListRequest req)
        {
            return InternalRequestAsync<QueryFlexPaymentOrderListResponse>(req, "QueryFlexPaymentOrderList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-查询付款订单状态
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPaymentOrderStatusRequest"/></param>
        /// <returns><see cref="QueryFlexPaymentOrderStatusResponse"/></returns>
        public Task<QueryFlexPaymentOrderStatusResponse> QueryFlexPaymentOrderStatus(QueryFlexPaymentOrderStatusRequest req)
        {
            return InternalRequestAsync<QueryFlexPaymentOrderStatusResponse>(req, "QueryFlexPaymentOrderStatus");
        }

        /// <summary>
        /// 灵云V2-查询付款订单状态
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPaymentOrderStatusRequest"/></param>
        /// <returns><see cref="QueryFlexPaymentOrderStatusResponse"/></returns>
        public QueryFlexPaymentOrderStatusResponse QueryFlexPaymentOrderStatusSync(QueryFlexPaymentOrderStatusRequest req)
        {
            return InternalRequestAsync<QueryFlexPaymentOrderStatusResponse>(req, "QueryFlexPaymentOrderStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-平台账户余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPlatformAccountBalanceRequest"/></param>
        /// <returns><see cref="QueryFlexPlatformAccountBalanceResponse"/></returns>
        public Task<QueryFlexPlatformAccountBalanceResponse> QueryFlexPlatformAccountBalance(QueryFlexPlatformAccountBalanceRequest req)
        {
            return InternalRequestAsync<QueryFlexPlatformAccountBalanceResponse>(req, "QueryFlexPlatformAccountBalance");
        }

        /// <summary>
        /// 灵云V2-平台账户余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryFlexPlatformAccountBalanceRequest"/></param>
        /// <returns><see cref="QueryFlexPlatformAccountBalanceResponse"/></returns>
        public QueryFlexPlatformAccountBalanceResponse QueryFlexPlatformAccountBalanceSync(QueryFlexPlatformAccountBalanceRequest req)
        {
            return InternalRequestAsync<QueryFlexPlatformAccountBalanceResponse>(req, "QueryFlexPlatformAccountBalance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-查询服务商账户余额
        /// </summary>
        /// <param name="req"><see cref="QueryFlexServiceProviderAccountBalanceRequest"/></param>
        /// <returns><see cref="QueryFlexServiceProviderAccountBalanceResponse"/></returns>
        public Task<QueryFlexServiceProviderAccountBalanceResponse> QueryFlexServiceProviderAccountBalance(QueryFlexServiceProviderAccountBalanceRequest req)
        {
            return InternalRequestAsync<QueryFlexServiceProviderAccountBalanceResponse>(req, "QueryFlexServiceProviderAccountBalance");
        }

        /// <summary>
        /// 灵云V2-查询服务商账户余额
        /// </summary>
        /// <param name="req"><see cref="QueryFlexServiceProviderAccountBalanceRequest"/></param>
        /// <returns><see cref="QueryFlexServiceProviderAccountBalanceResponse"/></returns>
        public QueryFlexServiceProviderAccountBalanceResponse QueryFlexServiceProviderAccountBalanceSync(QueryFlexServiceProviderAccountBalanceRequest req)
        {
            return InternalRequestAsync<QueryFlexServiceProviderAccountBalanceResponse>(req, "QueryFlexServiceProviderAccountBalance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云V2-查询结算订单列表
        /// </summary>
        /// <param name="req"><see cref="QueryFlexSettlementOrderListRequest"/></param>
        /// <returns><see cref="QueryFlexSettlementOrderListResponse"/></returns>
        public Task<QueryFlexSettlementOrderListResponse> QueryFlexSettlementOrderList(QueryFlexSettlementOrderListRequest req)
        {
            return InternalRequestAsync<QueryFlexSettlementOrderListResponse>(req, "QueryFlexSettlementOrderList");
        }

        /// <summary>
        /// 灵云V2-查询结算订单列表
        /// </summary>
        /// <param name="req"><see cref="QueryFlexSettlementOrderListRequest"/></param>
        /// <returns><see cref="QueryFlexSettlementOrderListResponse"/></returns>
        public QueryFlexSettlementOrderListResponse QueryFlexSettlementOrderListSync(QueryFlexSettlementOrderListRequest req)
        {
            return InternalRequestAsync<QueryFlexSettlementOrderListResponse>(req, "QueryFlexSettlementOrderList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询微工卡核身结果
        /// </summary>
        /// <param name="req"><see cref="QueryFlexWechatAuthResultRequest"/></param>
        /// <returns><see cref="QueryFlexWechatAuthResultResponse"/></returns>
        public Task<QueryFlexWechatAuthResultResponse> QueryFlexWechatAuthResult(QueryFlexWechatAuthResultRequest req)
        {
            return InternalRequestAsync<QueryFlexWechatAuthResultResponse>(req, "QueryFlexWechatAuthResult");
        }

        /// <summary>
        /// 查询微工卡核身结果
        /// </summary>
        /// <param name="req"><see cref="QueryFlexWechatAuthResultRequest"/></param>
        /// <returns><see cref="QueryFlexWechatAuthResultResponse"/></returns>
        public QueryFlexWechatAuthResultResponse QueryFlexWechatAuthResultSync(QueryFlexWechatAuthResultRequest req)
        {
            return InternalRequestAsync<QueryFlexWechatAuthResultResponse>(req, "QueryFlexWechatAuthResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 聚鑫-查询会员资金交易信息列表
        /// </summary>
        /// <param name="req"><see cref="QueryFundsTransactionDetailsRequest"/></param>
        /// <returns><see cref="QueryFundsTransactionDetailsResponse"/></returns>
        public Task<QueryFundsTransactionDetailsResponse> QueryFundsTransactionDetails(QueryFundsTransactionDetailsRequest req)
        {
            return InternalRequestAsync<QueryFundsTransactionDetailsResponse>(req, "QueryFundsTransactionDetails");
        }

        /// <summary>
        /// 聚鑫-查询会员资金交易信息列表
        /// </summary>
        /// <param name="req"><see cref="QueryFundsTransactionDetailsRequest"/></param>
        /// <returns><see cref="QueryFundsTransactionDetailsResponse"/></returns>
        public QueryFundsTransactionDetailsResponse QueryFundsTransactionDetailsSync(QueryFundsTransactionDetailsRequest req)
        {
            return InternalRequestAsync<QueryFundsTransactionDetailsResponse>(req, "QueryFundsTransactionDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智慧零售-发票查询
        /// </summary>
        /// <param name="req"><see cref="QueryInvoiceRequest"/></param>
        /// <returns><see cref="QueryInvoiceResponse"/></returns>
        public Task<QueryInvoiceResponse> QueryInvoice(QueryInvoiceRequest req)
        {
            return InternalRequestAsync<QueryInvoiceResponse>(req, "QueryInvoice");
        }

        /// <summary>
        /// 智慧零售-发票查询
        /// </summary>
        /// <param name="req"><see cref="QueryInvoiceRequest"/></param>
        /// <returns><see cref="QueryInvoiceResponse"/></returns>
        public QueryInvoiceResponse QueryInvoiceSync(QueryInvoiceRequest req)
        {
            return InternalRequestAsync<QueryInvoiceResponse>(req, "QueryInvoice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智慧零售-发票查询V2
        /// </summary>
        /// <param name="req"><see cref="QueryInvoiceV2Request"/></param>
        /// <returns><see cref="QueryInvoiceV2Response"/></returns>
        public Task<QueryInvoiceV2Response> QueryInvoiceV2(QueryInvoiceV2Request req)
        {
            return InternalRequestAsync<QueryInvoiceV2Response>(req, "QueryInvoiceV2");
        }

        /// <summary>
        /// 智慧零售-发票查询V2
        /// </summary>
        /// <param name="req"><see cref="QueryInvoiceV2Request"/></param>
        /// <returns><see cref="QueryInvoiceV2Response"/></returns>
        public QueryInvoiceV2Response QueryInvoiceV2Sync(QueryInvoiceV2Request req)
        {
            return InternalRequestAsync<QueryInvoiceV2Response>(req, "QueryInvoiceV2")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 商户恶意注册接口
        /// </summary>
        /// <param name="req"><see cref="QueryMaliciousRegistrationRequest"/></param>
        /// <returns><see cref="QueryMaliciousRegistrationResponse"/></returns>
        public Task<QueryMaliciousRegistrationResponse> QueryMaliciousRegistration(QueryMaliciousRegistrationRequest req)
        {
            return InternalRequestAsync<QueryMaliciousRegistrationResponse>(req, "QueryMaliciousRegistration");
        }

        /// <summary>
        /// 商户恶意注册接口
        /// </summary>
        /// <param name="req"><see cref="QueryMaliciousRegistrationRequest"/></param>
        /// <returns><see cref="QueryMaliciousRegistrationResponse"/></returns>
        public QueryMaliciousRegistrationResponse QueryMaliciousRegistrationSync(QueryMaliciousRegistrationRequest req)
        {
            return InternalRequestAsync<QueryMaliciousRegistrationResponse>(req, "QueryMaliciousRegistration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 会员绑定信息查询。查询标志为“单个会员”的情况下，返回该会员的有效的绑定账户信息。
        /// 查询标志为“全部会员”的情况下，返回市场下的全部的有效的绑定账户信息。查询标志为“单个会员的证件信息”的情况下，返回市场下的指定的会员的留存在电商见证宝系统的证件信息。
        /// </summary>
        /// <param name="req"><see cref="QueryMemberBindRequest"/></param>
        /// <returns><see cref="QueryMemberBindResponse"/></returns>
        public Task<QueryMemberBindResponse> QueryMemberBind(QueryMemberBindRequest req)
        {
            return InternalRequestAsync<QueryMemberBindResponse>(req, "QueryMemberBind");
        }

        /// <summary>
        /// 会员绑定信息查询。查询标志为“单个会员”的情况下，返回该会员的有效的绑定账户信息。
        /// 查询标志为“全部会员”的情况下，返回市场下的全部的有效的绑定账户信息。查询标志为“单个会员的证件信息”的情况下，返回市场下的指定的会员的留存在电商见证宝系统的证件信息。
        /// </summary>
        /// <param name="req"><see cref="QueryMemberBindRequest"/></param>
        /// <returns><see cref="QueryMemberBindResponse"/></returns>
        public QueryMemberBindResponse QueryMemberBindSync(QueryMemberBindRequest req)
        {
            return InternalRequestAsync<QueryMemberBindResponse>(req, "QueryMemberBind")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 会员间交易-不验证。此接口可以实现会员间的余额的交易，实现资金在会员之间流动。
        /// </summary>
        /// <param name="req"><see cref="QueryMemberTransactionRequest"/></param>
        /// <returns><see cref="QueryMemberTransactionResponse"/></returns>
        public Task<QueryMemberTransactionResponse> QueryMemberTransaction(QueryMemberTransactionRequest req)
        {
            return InternalRequestAsync<QueryMemberTransactionResponse>(req, "QueryMemberTransaction");
        }

        /// <summary>
        /// 会员间交易-不验证。此接口可以实现会员间的余额的交易，实现资金在会员之间流动。
        /// </summary>
        /// <param name="req"><see cref="QueryMemberTransactionRequest"/></param>
        /// <returns><see cref="QueryMemberTransactionResponse"/></returns>
        public QueryMemberTransactionResponse QueryMemberTransactionSync(QueryMemberTransactionRequest req)
        {
            return InternalRequestAsync<QueryMemberTransactionResponse>(req, "QueryMemberTransaction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 聚鑫-查询会员间交易信息列表
        /// </summary>
        /// <param name="req"><see cref="QueryMemberTransactionDetailsRequest"/></param>
        /// <returns><see cref="QueryMemberTransactionDetailsResponse"/></returns>
        public Task<QueryMemberTransactionDetailsResponse> QueryMemberTransactionDetails(QueryMemberTransactionDetailsRequest req)
        {
            return InternalRequestAsync<QueryMemberTransactionDetailsResponse>(req, "QueryMemberTransactionDetails");
        }

        /// <summary>
        /// 聚鑫-查询会员间交易信息列表
        /// </summary>
        /// <param name="req"><see cref="QueryMemberTransactionDetailsRequest"/></param>
        /// <returns><see cref="QueryMemberTransactionDetailsResponse"/></returns>
        public QueryMemberTransactionDetailsResponse QueryMemberTransactionDetailsSync(QueryMemberTransactionDetailsRequest req)
        {
            return InternalRequestAsync<QueryMemberTransactionDetailsResponse>(req, "QueryMemberTransactionDetails")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云鉴-商户信息查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantRequest"/></param>
        /// <returns><see cref="QueryMerchantResponse"/></returns>
        public Task<QueryMerchantResponse> QueryMerchant(QueryMerchantRequest req)
        {
            return InternalRequestAsync<QueryMerchantResponse>(req, "QueryMerchant");
        }

        /// <summary>
        /// 云鉴-商户信息查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantRequest"/></param>
        /// <returns><see cref="QueryMerchantResponse"/></returns>
        public QueryMerchantResponse QueryMerchantSync(QueryMerchantRequest req)
        {
            return InternalRequestAsync<QueryMerchantResponse>(req, "QueryMerchant")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 跨境-对接方账户余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantBalanceRequest"/></param>
        /// <returns><see cref="QueryMerchantBalanceResponse"/></returns>
        public Task<QueryMerchantBalanceResponse> QueryMerchantBalance(QueryMerchantBalanceRequest req)
        {
            return InternalRequestAsync<QueryMerchantBalanceResponse>(req, "QueryMerchantBalance");
        }

        /// <summary>
        /// 跨境-对接方账户余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantBalanceRequest"/></param>
        /// <returns><see cref="QueryMerchantBalanceResponse"/></returns>
        public QueryMerchantBalanceResponse QueryMerchantBalanceSync(QueryMerchantBalanceRequest req)
        {
            return InternalRequestAsync<QueryMerchantBalanceResponse>(req, "QueryMerchantBalance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-查询商户分类接口
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantClassificationRequest"/></param>
        /// <returns><see cref="QueryMerchantClassificationResponse"/></returns>
        public Task<QueryMerchantClassificationResponse> QueryMerchantClassification(QueryMerchantClassificationRequest req)
        {
            return InternalRequestAsync<QueryMerchantClassificationResponse>(req, "QueryMerchantClassification");
        }

        /// <summary>
        /// 云支付-查询商户分类接口
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantClassificationRequest"/></param>
        /// <returns><see cref="QueryMerchantClassificationResponse"/></returns>
        public QueryMerchantClassificationResponse QueryMerchantClassificationSync(QueryMerchantClassificationRequest req)
        {
            return InternalRequestAsync<QueryMerchantClassificationResponse>(req, "QueryMerchantClassification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智慧零售-查询管理端商户
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantInfoForManagementRequest"/></param>
        /// <returns><see cref="QueryMerchantInfoForManagementResponse"/></returns>
        public Task<QueryMerchantInfoForManagementResponse> QueryMerchantInfoForManagement(QueryMerchantInfoForManagementRequest req)
        {
            return InternalRequestAsync<QueryMerchantInfoForManagementResponse>(req, "QueryMerchantInfoForManagement");
        }

        /// <summary>
        /// 智慧零售-查询管理端商户
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantInfoForManagementRequest"/></param>
        /// <returns><see cref="QueryMerchantInfoForManagementResponse"/></returns>
        public QueryMerchantInfoForManagementResponse QueryMerchantInfoForManagementSync(QueryMerchantInfoForManagementRequest req)
        {
            return InternalRequestAsync<QueryMerchantInfoForManagementResponse>(req, "QueryMerchantInfoForManagement")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云鉴-消费订单查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantOrderRequest"/></param>
        /// <returns><see cref="QueryMerchantOrderResponse"/></returns>
        public Task<QueryMerchantOrderResponse> QueryMerchantOrder(QueryMerchantOrderRequest req)
        {
            return InternalRequestAsync<QueryMerchantOrderResponse>(req, "QueryMerchantOrder");
        }

        /// <summary>
        /// 云鉴-消费订单查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantOrderRequest"/></param>
        /// <returns><see cref="QueryMerchantOrderResponse"/></returns>
        public QueryMerchantOrderResponse QueryMerchantOrderSync(QueryMerchantOrderRequest req)
        {
            return InternalRequestAsync<QueryMerchantOrderResponse>(req, "QueryMerchantOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 商户查询已开通的支付方式列表
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantPayWayListRequest"/></param>
        /// <returns><see cref="QueryMerchantPayWayListResponse"/></returns>
        public Task<QueryMerchantPayWayListResponse> QueryMerchantPayWayList(QueryMerchantPayWayListRequest req)
        {
            return InternalRequestAsync<QueryMerchantPayWayListResponse>(req, "QueryMerchantPayWayList");
        }

        /// <summary>
        /// 商户查询已开通的支付方式列表
        /// </summary>
        /// <param name="req"><see cref="QueryMerchantPayWayListRequest"/></param>
        /// <returns><see cref="QueryMerchantPayWayListResponse"/></returns>
        public QueryMerchantPayWayListResponse QueryMerchantPayWayListSync(QueryMerchantPayWayListRequest req)
        {
            return InternalRequestAsync<QueryMerchantPayWayListResponse>(req, "QueryMerchantPayWayList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-子商户银行卡余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBankAccountBalanceRequest"/></param>
        /// <returns><see cref="QueryOpenBankBankAccountBalanceResponse"/></returns>
        public Task<QueryOpenBankBankAccountBalanceResponse> QueryOpenBankBankAccountBalance(QueryOpenBankBankAccountBalanceRequest req)
        {
            return InternalRequestAsync<QueryOpenBankBankAccountBalanceResponse>(req, "QueryOpenBankBankAccountBalance");
        }

        /// <summary>
        /// 云企付-子商户银行卡余额查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBankAccountBalanceRequest"/></param>
        /// <returns><see cref="QueryOpenBankBankAccountBalanceResponse"/></returns>
        public QueryOpenBankBankAccountBalanceResponse QueryOpenBankBankAccountBalanceSync(QueryOpenBankBankAccountBalanceRequest req)
        {
            return InternalRequestAsync<QueryOpenBankBankAccountBalanceResponse>(req, "QueryOpenBankBankAccountBalance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-查询联行号
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBankBranchListRequest"/></param>
        /// <returns><see cref="QueryOpenBankBankBranchListResponse"/></returns>
        public Task<QueryOpenBankBankBranchListResponse> QueryOpenBankBankBranchList(QueryOpenBankBankBranchListRequest req)
        {
            return InternalRequestAsync<QueryOpenBankBankBranchListResponse>(req, "QueryOpenBankBankBranchList");
        }

        /// <summary>
        /// 云企付-查询联行号
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBankBranchListRequest"/></param>
        /// <returns><see cref="QueryOpenBankBankBranchListResponse"/></returns>
        public QueryOpenBankBankBranchListResponse QueryOpenBankBankBranchListSync(QueryOpenBankBankBranchListRequest req)
        {
            return InternalRequestAsync<QueryOpenBankBankBranchListResponse>(req, "QueryOpenBankBankBranchList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-分页查询对账单数据
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBillDataPageRequest"/></param>
        /// <returns><see cref="QueryOpenBankBillDataPageResponse"/></returns>
        public Task<QueryOpenBankBillDataPageResponse> QueryOpenBankBillDataPage(QueryOpenBankBillDataPageRequest req)
        {
            return InternalRequestAsync<QueryOpenBankBillDataPageResponse>(req, "QueryOpenBankBillDataPage");
        }

        /// <summary>
        /// 云企付-分页查询对账单数据
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBillDataPageRequest"/></param>
        /// <returns><see cref="QueryOpenBankBillDataPageResponse"/></returns>
        public QueryOpenBankBillDataPageResponse QueryOpenBankBillDataPageSync(QueryOpenBankBillDataPageRequest req)
        {
            return InternalRequestAsync<QueryOpenBankBillDataPageResponse>(req, "QueryOpenBankBillDataPage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-子商户银行卡绑定结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBindExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="QueryOpenBankBindExternalSubMerchantBankAccountResponse"/></returns>
        public Task<QueryOpenBankBindExternalSubMerchantBankAccountResponse> QueryOpenBankBindExternalSubMerchantBankAccount(QueryOpenBankBindExternalSubMerchantBankAccountRequest req)
        {
            return InternalRequestAsync<QueryOpenBankBindExternalSubMerchantBankAccountResponse>(req, "QueryOpenBankBindExternalSubMerchantBankAccount");
        }

        /// <summary>
        /// 云企付-子商户银行卡绑定结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankBindExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="QueryOpenBankBindExternalSubMerchantBankAccountResponse"/></returns>
        public QueryOpenBankBindExternalSubMerchantBankAccountResponse QueryOpenBankBindExternalSubMerchantBankAccountSync(QueryOpenBankBindExternalSubMerchantBankAccountRequest req)
        {
            return InternalRequestAsync<QueryOpenBankBindExternalSubMerchantBankAccountResponse>(req, "QueryOpenBankBindExternalSubMerchantBankAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-按日期批量查询回单下载地址
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankDailyReceiptDownloadUrlRequest"/></param>
        /// <returns><see cref="QueryOpenBankDailyReceiptDownloadUrlResponse"/></returns>
        public Task<QueryOpenBankDailyReceiptDownloadUrlResponse> QueryOpenBankDailyReceiptDownloadUrl(QueryOpenBankDailyReceiptDownloadUrlRequest req)
        {
            return InternalRequestAsync<QueryOpenBankDailyReceiptDownloadUrlResponse>(req, "QueryOpenBankDailyReceiptDownloadUrl");
        }

        /// <summary>
        /// 云企付-按日期批量查询回单下载地址
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankDailyReceiptDownloadUrlRequest"/></param>
        /// <returns><see cref="QueryOpenBankDailyReceiptDownloadUrlResponse"/></returns>
        public QueryOpenBankDailyReceiptDownloadUrlResponse QueryOpenBankDailyReceiptDownloadUrlSync(QueryOpenBankDailyReceiptDownloadUrlRequest req)
        {
            return InternalRequestAsync<QueryOpenBankDailyReceiptDownloadUrlResponse>(req, "QueryOpenBankDailyReceiptDownloadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-查询对账单下载地址
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankDownLoadUrlRequest"/></param>
        /// <returns><see cref="QueryOpenBankDownLoadUrlResponse"/></returns>
        public Task<QueryOpenBankDownLoadUrlResponse> QueryOpenBankDownLoadUrl(QueryOpenBankDownLoadUrlRequest req)
        {
            return InternalRequestAsync<QueryOpenBankDownLoadUrlResponse>(req, "QueryOpenBankDownLoadUrl");
        }

        /// <summary>
        /// 云企付-查询对账单下载地址
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankDownLoadUrlRequest"/></param>
        /// <returns><see cref="QueryOpenBankDownLoadUrlResponse"/></returns>
        public QueryOpenBankDownLoadUrlResponse QueryOpenBankDownLoadUrlSync(QueryOpenBankDownLoadUrlRequest req)
        {
            return InternalRequestAsync<QueryOpenBankDownLoadUrlResponse>(req, "QueryOpenBankDownLoadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 第三方子商户电子记账本余额查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankExternalSubAccountBookBalanceRequest"/></param>
        /// <returns><see cref="QueryOpenBankExternalSubAccountBookBalanceResponse"/></returns>
        public Task<QueryOpenBankExternalSubAccountBookBalanceResponse> QueryOpenBankExternalSubAccountBookBalance(QueryOpenBankExternalSubAccountBookBalanceRequest req)
        {
            return InternalRequestAsync<QueryOpenBankExternalSubAccountBookBalanceResponse>(req, "QueryOpenBankExternalSubAccountBookBalance");
        }

        /// <summary>
        /// 第三方子商户电子记账本余额查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankExternalSubAccountBookBalanceRequest"/></param>
        /// <returns><see cref="QueryOpenBankExternalSubAccountBookBalanceResponse"/></returns>
        public QueryOpenBankExternalSubAccountBookBalanceResponse QueryOpenBankExternalSubAccountBookBalanceSync(QueryOpenBankExternalSubAccountBookBalanceRequest req)
        {
            return InternalRequestAsync<QueryOpenBankExternalSubAccountBookBalanceResponse>(req, "QueryOpenBankExternalSubAccountBookBalance")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-子商户银行卡列表查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="QueryOpenBankExternalSubMerchantBankAccountResponse"/></returns>
        public Task<QueryOpenBankExternalSubMerchantBankAccountResponse> QueryOpenBankExternalSubMerchantBankAccount(QueryOpenBankExternalSubMerchantBankAccountRequest req)
        {
            return InternalRequestAsync<QueryOpenBankExternalSubMerchantBankAccountResponse>(req, "QueryOpenBankExternalSubMerchantBankAccount");
        }

        /// <summary>
        /// 云企付-子商户银行卡列表查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="QueryOpenBankExternalSubMerchantBankAccountResponse"/></returns>
        public QueryOpenBankExternalSubMerchantBankAccountResponse QueryOpenBankExternalSubMerchantBankAccountSync(QueryOpenBankExternalSubMerchantBankAccountRequest req)
        {
            return InternalRequestAsync<QueryOpenBankExternalSubMerchantBankAccountResponse>(req, "QueryOpenBankExternalSubMerchantBankAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-子商户进件结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankExternalSubMerchantRegistrationRequest"/></param>
        /// <returns><see cref="QueryOpenBankExternalSubMerchantRegistrationResponse"/></returns>
        public Task<QueryOpenBankExternalSubMerchantRegistrationResponse> QueryOpenBankExternalSubMerchantRegistration(QueryOpenBankExternalSubMerchantRegistrationRequest req)
        {
            return InternalRequestAsync<QueryOpenBankExternalSubMerchantRegistrationResponse>(req, "QueryOpenBankExternalSubMerchantRegistration");
        }

        /// <summary>
        /// 云企付-子商户进件结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankExternalSubMerchantRegistrationRequest"/></param>
        /// <returns><see cref="QueryOpenBankExternalSubMerchantRegistrationResponse"/></returns>
        public QueryOpenBankExternalSubMerchantRegistrationResponse QueryOpenBankExternalSubMerchantRegistrationSync(QueryOpenBankExternalSubMerchantRegistrationRequest req)
        {
            return InternalRequestAsync<QueryOpenBankExternalSubMerchantRegistrationResponse>(req, "QueryOpenBankExternalSubMerchantRegistration")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-单笔交易回单申请结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankOrderDetailReceiptInfoRequest"/></param>
        /// <returns><see cref="QueryOpenBankOrderDetailReceiptInfoResponse"/></returns>
        public Task<QueryOpenBankOrderDetailReceiptInfoResponse> QueryOpenBankOrderDetailReceiptInfo(QueryOpenBankOrderDetailReceiptInfoRequest req)
        {
            return InternalRequestAsync<QueryOpenBankOrderDetailReceiptInfoResponse>(req, "QueryOpenBankOrderDetailReceiptInfo");
        }

        /// <summary>
        /// 云企付-单笔交易回单申请结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankOrderDetailReceiptInfoRequest"/></param>
        /// <returns><see cref="QueryOpenBankOrderDetailReceiptInfoResponse"/></returns>
        public QueryOpenBankOrderDetailReceiptInfoResponse QueryOpenBankOrderDetailReceiptInfoSync(QueryOpenBankOrderDetailReceiptInfoRequest req)
        {
            return InternalRequestAsync<QueryOpenBankOrderDetailReceiptInfoResponse>(req, "QueryOpenBankOrderDetailReceiptInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-查询订单支付结果
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankPaymentOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankPaymentOrderResponse"/></returns>
        public Task<QueryOpenBankPaymentOrderResponse> QueryOpenBankPaymentOrder(QueryOpenBankPaymentOrderRequest req)
        {
            return InternalRequestAsync<QueryOpenBankPaymentOrderResponse>(req, "QueryOpenBankPaymentOrder");
        }

        /// <summary>
        /// 云企付-查询订单支付结果
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankPaymentOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankPaymentOrderResponse"/></returns>
        public QueryOpenBankPaymentOrderResponse QueryOpenBankPaymentOrderSync(QueryOpenBankPaymentOrderRequest req)
        {
            return InternalRequestAsync<QueryOpenBankPaymentOrderResponse>(req, "QueryOpenBankPaymentOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-绑定分账收款方查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankProfitSharePayeeRequest"/></param>
        /// <returns><see cref="QueryOpenBankProfitSharePayeeResponse"/></returns>
        public Task<QueryOpenBankProfitSharePayeeResponse> QueryOpenBankProfitSharePayee(QueryOpenBankProfitSharePayeeRequest req)
        {
            return InternalRequestAsync<QueryOpenBankProfitSharePayeeResponse>(req, "QueryOpenBankProfitSharePayee");
        }

        /// <summary>
        /// 云企付-绑定分账收款方查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankProfitSharePayeeRequest"/></param>
        /// <returns><see cref="QueryOpenBankProfitSharePayeeResponse"/></returns>
        public QueryOpenBankProfitSharePayeeResponse QueryOpenBankProfitSharePayeeSync(QueryOpenBankProfitSharePayeeRequest req)
        {
            return InternalRequestAsync<QueryOpenBankProfitSharePayeeResponse>(req, "QueryOpenBankProfitSharePayee")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-退款结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankRefundOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankRefundOrderResponse"/></returns>
        public Task<QueryOpenBankRefundOrderResponse> QueryOpenBankRefundOrder(QueryOpenBankRefundOrderRequest req)
        {
            return InternalRequestAsync<QueryOpenBankRefundOrderResponse>(req, "QueryOpenBankRefundOrder");
        }

        /// <summary>
        /// 云企付-退款结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankRefundOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankRefundOrderResponse"/></returns>
        public QueryOpenBankRefundOrderResponse QueryOpenBankRefundOrderSync(QueryOpenBankRefundOrderRequest req)
        {
            return InternalRequestAsync<QueryOpenBankRefundOrderResponse>(req, "QueryOpenBankRefundOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-结算单查询结果
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSettleOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankSettleOrderResponse"/></returns>
        public Task<QueryOpenBankSettleOrderResponse> QueryOpenBankSettleOrder(QueryOpenBankSettleOrderRequest req)
        {
            return InternalRequestAsync<QueryOpenBankSettleOrderResponse>(req, "QueryOpenBankSettleOrder");
        }

        /// <summary>
        /// 云企付-结算单查询结果
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSettleOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankSettleOrderResponse"/></returns>
        public QueryOpenBankSettleOrderResponse QueryOpenBankSettleOrderSync(QueryOpenBankSettleOrderRequest req)
        {
            return InternalRequestAsync<QueryOpenBankSettleOrderResponse>(req, "QueryOpenBankSettleOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-子商户资质文件查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSubMerchantCredentialRequest"/></param>
        /// <returns><see cref="QueryOpenBankSubMerchantCredentialResponse"/></returns>
        public Task<QueryOpenBankSubMerchantCredentialResponse> QueryOpenBankSubMerchantCredential(QueryOpenBankSubMerchantCredentialRequest req)
        {
            return InternalRequestAsync<QueryOpenBankSubMerchantCredentialResponse>(req, "QueryOpenBankSubMerchantCredential");
        }

        /// <summary>
        /// 云企付-子商户资质文件查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSubMerchantCredentialRequest"/></param>
        /// <returns><see cref="QueryOpenBankSubMerchantCredentialResponse"/></returns>
        public QueryOpenBankSubMerchantCredentialResponse QueryOpenBankSubMerchantCredentialSync(QueryOpenBankSubMerchantCredentialRequest req)
        {
            return InternalRequestAsync<QueryOpenBankSubMerchantCredentialResponse>(req, "QueryOpenBankSubMerchantCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-子商户费率配置结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSubMerchantRateConfigureRequest"/></param>
        /// <returns><see cref="QueryOpenBankSubMerchantRateConfigureResponse"/></returns>
        public Task<QueryOpenBankSubMerchantRateConfigureResponse> QueryOpenBankSubMerchantRateConfigure(QueryOpenBankSubMerchantRateConfigureRequest req)
        {
            return InternalRequestAsync<QueryOpenBankSubMerchantRateConfigureResponse>(req, "QueryOpenBankSubMerchantRateConfigure");
        }

        /// <summary>
        /// 云企付-子商户费率配置结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSubMerchantRateConfigureRequest"/></param>
        /// <returns><see cref="QueryOpenBankSubMerchantRateConfigureResponse"/></returns>
        public QueryOpenBankSubMerchantRateConfigureResponse QueryOpenBankSubMerchantRateConfigureSync(QueryOpenBankSubMerchantRateConfigureRequest req)
        {
            return InternalRequestAsync<QueryOpenBankSubMerchantRateConfigureResponse>(req, "QueryOpenBankSubMerchantRateConfigure")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 子商户在线签约查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSubMerchantSignOnlineRequest"/></param>
        /// <returns><see cref="QueryOpenBankSubMerchantSignOnlineResponse"/></returns>
        public Task<QueryOpenBankSubMerchantSignOnlineResponse> QueryOpenBankSubMerchantSignOnline(QueryOpenBankSubMerchantSignOnlineRequest req)
        {
            return InternalRequestAsync<QueryOpenBankSubMerchantSignOnlineResponse>(req, "QueryOpenBankSubMerchantSignOnline");
        }

        /// <summary>
        /// 子商户在线签约查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSubMerchantSignOnlineRequest"/></param>
        /// <returns><see cref="QueryOpenBankSubMerchantSignOnlineResponse"/></returns>
        public QueryOpenBankSubMerchantSignOnlineResponse QueryOpenBankSubMerchantSignOnlineSync(QueryOpenBankSubMerchantSignOnlineRequest req)
        {
            return InternalRequestAsync<QueryOpenBankSubMerchantSignOnlineResponse>(req, "QueryOpenBankSubMerchantSignOnline")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-查询支持银行列表
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSupportBankListRequest"/></param>
        /// <returns><see cref="QueryOpenBankSupportBankListResponse"/></returns>
        public Task<QueryOpenBankSupportBankListResponse> QueryOpenBankSupportBankList(QueryOpenBankSupportBankListRequest req)
        {
            return InternalRequestAsync<QueryOpenBankSupportBankListResponse>(req, "QueryOpenBankSupportBankList");
        }

        /// <summary>
        /// 云企付-查询支持银行列表
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankSupportBankListRequest"/></param>
        /// <returns><see cref="QueryOpenBankSupportBankListResponse"/></returns>
        public QueryOpenBankSupportBankListResponse QueryOpenBankSupportBankListSync(QueryOpenBankSupportBankListRequest req)
        {
            return InternalRequestAsync<QueryOpenBankSupportBankListResponse>(req, "QueryOpenBankSupportBankList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-子商户银行卡解绑结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankUnbindExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="QueryOpenBankUnbindExternalSubMerchantBankAccountResponse"/></returns>
        public Task<QueryOpenBankUnbindExternalSubMerchantBankAccountResponse> QueryOpenBankUnbindExternalSubMerchantBankAccount(QueryOpenBankUnbindExternalSubMerchantBankAccountRequest req)
        {
            return InternalRequestAsync<QueryOpenBankUnbindExternalSubMerchantBankAccountResponse>(req, "QueryOpenBankUnbindExternalSubMerchantBankAccount");
        }

        /// <summary>
        /// 云企付-子商户银行卡解绑结果查询
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankUnbindExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="QueryOpenBankUnbindExternalSubMerchantBankAccountResponse"/></returns>
        public QueryOpenBankUnbindExternalSubMerchantBankAccountResponse QueryOpenBankUnbindExternalSubMerchantBankAccountSync(QueryOpenBankUnbindExternalSubMerchantBankAccountRequest req)
        {
            return InternalRequestAsync<QueryOpenBankUnbindExternalSubMerchantBankAccountResponse>(req, "QueryOpenBankUnbindExternalSubMerchantBankAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-查询核销订单状态，客户可以使用该接口来查询核销申请的订单状态。目前仅支持TENPAY渠道EBANK_PAYMENT付款方式的担保支付订单查询。
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankVerificationOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankVerificationOrderResponse"/></returns>
        public Task<QueryOpenBankVerificationOrderResponse> QueryOpenBankVerificationOrder(QueryOpenBankVerificationOrderRequest req)
        {
            return InternalRequestAsync<QueryOpenBankVerificationOrderResponse>(req, "QueryOpenBankVerificationOrder");
        }

        /// <summary>
        /// 云企付-查询核销订单状态，客户可以使用该接口来查询核销申请的订单状态。目前仅支持TENPAY渠道EBANK_PAYMENT付款方式的担保支付订单查询。
        /// </summary>
        /// <param name="req"><see cref="QueryOpenBankVerificationOrderRequest"/></param>
        /// <returns><see cref="QueryOpenBankVerificationOrderResponse"/></returns>
        public QueryOpenBankVerificationOrderResponse QueryOpenBankVerificationOrderSync(QueryOpenBankVerificationOrderRequest req)
        {
            return InternalRequestAsync<QueryOpenBankVerificationOrderResponse>(req, "QueryOpenBankVerificationOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 根据订单号，或者用户Id，查询支付订单状态 
        /// </summary>
        /// <param name="req"><see cref="QueryOrderRequest"/></param>
        /// <returns><see cref="QueryOrderResponse"/></returns>
        public Task<QueryOrderResponse> QueryOrder(QueryOrderRequest req)
        {
            return InternalRequestAsync<QueryOrderResponse>(req, "QueryOrder");
        }

        /// <summary>
        /// 根据订单号，或者用户Id，查询支付订单状态 
        /// </summary>
        /// <param name="req"><see cref="QueryOrderRequest"/></param>
        /// <returns><see cref="QueryOrderResponse"/></returns>
        public QueryOrderResponse QueryOrderSync(QueryOrderRequest req)
        {
            return InternalRequestAsync<QueryOrderResponse>(req, "QueryOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-查询订单付款状态
        /// </summary>
        /// <param name="req"><see cref="QueryOrderStatusRequest"/></param>
        /// <returns><see cref="QueryOrderStatusResponse"/></returns>
        public Task<QueryOrderStatusResponse> QueryOrderStatus(QueryOrderStatusRequest req)
        {
            return InternalRequestAsync<QueryOrderStatusResponse>(req, "QueryOrderStatus");
        }

        /// <summary>
        /// 云支付-查询订单付款状态
        /// </summary>
        /// <param name="req"><see cref="QueryOrderStatusRequest"/></param>
        /// <returns><see cref="QueryOrderStatusResponse"/></returns>
        public QueryOrderStatusResponse QueryOrderStatusSync(QueryOrderStatusRequest req)
        {
            return InternalRequestAsync<QueryOrderStatusResponse>(req, "QueryOrderStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 跨境-查询汇出结果
        /// </summary>
        /// <param name="req"><see cref="QueryOutwardOrderRequest"/></param>
        /// <returns><see cref="QueryOutwardOrderResponse"/></returns>
        public Task<QueryOutwardOrderResponse> QueryOutwardOrder(QueryOutwardOrderRequest req)
        {
            return InternalRequestAsync<QueryOutwardOrderResponse>(req, "QueryOutwardOrder");
        }

        /// <summary>
        /// 跨境-查询汇出结果
        /// </summary>
        /// <param name="req"><see cref="QueryOutwardOrderRequest"/></param>
        /// <returns><see cref="QueryOutwardOrderResponse"/></returns>
        public QueryOutwardOrderResponse QueryOutwardOrderSync(QueryOutwardOrderRequest req)
        {
            return InternalRequestAsync<QueryOutwardOrderResponse>(req, "QueryOutwardOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 跨境-付款人查询
        /// </summary>
        /// <param name="req"><see cref="QueryPayerInfoRequest"/></param>
        /// <returns><see cref="QueryPayerInfoResponse"/></returns>
        public Task<QueryPayerInfoResponse> QueryPayerInfo(QueryPayerInfoRequest req)
        {
            return InternalRequestAsync<QueryPayerInfoResponse>(req, "QueryPayerInfo");
        }

        /// <summary>
        /// 跨境-付款人查询
        /// </summary>
        /// <param name="req"><see cref="QueryPayerInfoRequest"/></param>
        /// <returns><see cref="QueryPayerInfoResponse"/></returns>
        public QueryPayerInfoResponse QueryPayerInfoSync(QueryPayerInfoRequest req)
        {
            return InternalRequestAsync<QueryPayerInfoResponse>(req, "QueryPayerInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询对账文件信息。平台调用该接口获取需下载对账文件的文件名称以及密钥。 平台获取到信息后， 可以再调用OPENAPI的文件下载功能。
        /// </summary>
        /// <param name="req"><see cref="QueryReconciliationDocumentRequest"/></param>
        /// <returns><see cref="QueryReconciliationDocumentResponse"/></returns>
        public Task<QueryReconciliationDocumentResponse> QueryReconciliationDocument(QueryReconciliationDocumentRequest req)
        {
            return InternalRequestAsync<QueryReconciliationDocumentResponse>(req, "QueryReconciliationDocument");
        }

        /// <summary>
        /// 查询对账文件信息。平台调用该接口获取需下载对账文件的文件名称以及密钥。 平台获取到信息后， 可以再调用OPENAPI的文件下载功能。
        /// </summary>
        /// <param name="req"><see cref="QueryReconciliationDocumentRequest"/></param>
        /// <returns><see cref="QueryReconciliationDocumentResponse"/></returns>
        public QueryReconciliationDocumentResponse QueryReconciliationDocumentSync(QueryReconciliationDocumentRequest req)
        {
            return InternalRequestAsync<QueryReconciliationDocumentResponse>(req, "QueryReconciliationDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 聚鑫-查询对账文件申请结果
        /// </summary>
        /// <param name="req"><see cref="QueryReconciliationFileApplyInfoRequest"/></param>
        /// <returns><see cref="QueryReconciliationFileApplyInfoResponse"/></returns>
        public Task<QueryReconciliationFileApplyInfoResponse> QueryReconciliationFileApplyInfo(QueryReconciliationFileApplyInfoRequest req)
        {
            return InternalRequestAsync<QueryReconciliationFileApplyInfoResponse>(req, "QueryReconciliationFileApplyInfo");
        }

        /// <summary>
        /// 聚鑫-查询对账文件申请结果
        /// </summary>
        /// <param name="req"><see cref="QueryReconciliationFileApplyInfoRequest"/></param>
        /// <returns><see cref="QueryReconciliationFileApplyInfoResponse"/></returns>
        public QueryReconciliationFileApplyInfoResponse QueryReconciliationFileApplyInfoSync(QueryReconciliationFileApplyInfoRequest req)
        {
            return InternalRequestAsync<QueryReconciliationFileApplyInfoResponse>(req, "QueryReconciliationFileApplyInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 提交退款申请后，通过调用该接口查询退款状态。退款可能有一定延时，用微信零钱支付的退款约20分钟内到账，银行卡支付的退款约3个工作日后到账。
        /// </summary>
        /// <param name="req"><see cref="QueryRefundRequest"/></param>
        /// <returns><see cref="QueryRefundResponse"/></returns>
        public Task<QueryRefundResponse> QueryRefund(QueryRefundRequest req)
        {
            return InternalRequestAsync<QueryRefundResponse>(req, "QueryRefund");
        }

        /// <summary>
        /// 提交退款申请后，通过调用该接口查询退款状态。退款可能有一定延时，用微信零钱支付的退款约20分钟内到账，银行卡支付的退款约3个工作日后到账。
        /// </summary>
        /// <param name="req"><see cref="QueryRefundRequest"/></param>
        /// <returns><see cref="QueryRefundResponse"/></returns>
        public QueryRefundResponse QueryRefundSync(QueryRefundRequest req)
        {
            return InternalRequestAsync<QueryRefundResponse>(req, "QueryRefund")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-获取门店OpenId接口
        /// </summary>
        /// <param name="req"><see cref="QueryShopOpenIdRequest"/></param>
        /// <returns><see cref="QueryShopOpenIdResponse"/></returns>
        public Task<QueryShopOpenIdResponse> QueryShopOpenId(QueryShopOpenIdRequest req)
        {
            return InternalRequestAsync<QueryShopOpenIdResponse>(req, "QueryShopOpenId");
        }

        /// <summary>
        /// 云支付-获取门店OpenId接口
        /// </summary>
        /// <param name="req"><see cref="QueryShopOpenIdRequest"/></param>
        /// <returns><see cref="QueryShopOpenIdResponse"/></returns>
        public QueryShopOpenIdResponse QueryShopOpenIdSync(QueryShopOpenIdRequest req)
        {
            return InternalRequestAsync<QueryShopOpenIdResponse>(req, "QueryShopOpenId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云-单笔转账结果查询
        /// </summary>
        /// <param name="req"><see cref="QuerySinglePaymentResultRequest"/></param>
        /// <returns><see cref="QuerySinglePaymentResultResponse"/></returns>
        public Task<QuerySinglePaymentResultResponse> QuerySinglePaymentResult(QuerySinglePaymentResultRequest req)
        {
            return InternalRequestAsync<QuerySinglePaymentResultResponse>(req, "QuerySinglePaymentResult");
        }

        /// <summary>
        /// 灵云-单笔转账结果查询
        /// </summary>
        /// <param name="req"><see cref="QuerySinglePaymentResultRequest"/></param>
        /// <returns><see cref="QuerySinglePaymentResultResponse"/></returns>
        public QuerySinglePaymentResultResponse QuerySinglePaymentResultSync(QuerySinglePaymentResultRequest req)
        {
            return InternalRequestAsync<QuerySinglePaymentResultResponse>(req, "QuerySinglePaymentResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询银行单笔交易状态。查询单笔交易的状态。
        /// </summary>
        /// <param name="req"><see cref="QuerySingleTransactionStatusRequest"/></param>
        /// <returns><see cref="QuerySingleTransactionStatusResponse"/></returns>
        public Task<QuerySingleTransactionStatusResponse> QuerySingleTransactionStatus(QuerySingleTransactionStatusRequest req)
        {
            return InternalRequestAsync<QuerySingleTransactionStatusResponse>(req, "QuerySingleTransactionStatus");
        }

        /// <summary>
        /// 查询银行单笔交易状态。查询单笔交易的状态。
        /// </summary>
        /// <param name="req"><see cref="QuerySingleTransactionStatusRequest"/></param>
        /// <returns><see cref="QuerySingleTransactionStatusResponse"/></returns>
        public QuerySingleTransactionStatusResponse QuerySingleTransactionStatusSync(QuerySingleTransactionStatusRequest req)
        {
            return InternalRequestAsync<QuerySingleTransactionStatusResponse>(req, "QuerySingleTransactionStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询小额鉴权转账结果。查询小额往账鉴权的转账状态。
        /// </summary>
        /// <param name="req"><see cref="QuerySmallAmountTransferRequest"/></param>
        /// <returns><see cref="QuerySmallAmountTransferResponse"/></returns>
        public Task<QuerySmallAmountTransferResponse> QuerySmallAmountTransfer(QuerySmallAmountTransferRequest req)
        {
            return InternalRequestAsync<QuerySmallAmountTransferResponse>(req, "QuerySmallAmountTransfer");
        }

        /// <summary>
        /// 查询小额鉴权转账结果。查询小额往账鉴权的转账状态。
        /// </summary>
        /// <param name="req"><see cref="QuerySmallAmountTransferRequest"/></param>
        /// <returns><see cref="QuerySmallAmountTransferResponse"/></returns>
        public QuerySmallAmountTransferResponse QuerySmallAmountTransferSync(QuerySmallAmountTransferRequest req)
        {
            return InternalRequestAsync<QuerySmallAmountTransferResponse>(req, "QuerySmallAmountTransfer")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 跨境-贸易材料明细查询。
        /// </summary>
        /// <param name="req"><see cref="QueryTradeRequest"/></param>
        /// <returns><see cref="QueryTradeResponse"/></returns>
        public Task<QueryTradeResponse> QueryTrade(QueryTradeRequest req)
        {
            return InternalRequestAsync<QueryTradeResponse>(req, "QueryTrade");
        }

        /// <summary>
        /// 跨境-贸易材料明细查询。
        /// </summary>
        /// <param name="req"><see cref="QueryTradeRequest"/></param>
        /// <returns><see cref="QueryTradeResponse"/></returns>
        public QueryTradeResponse QueryTradeSync(QueryTradeRequest req)
        {
            return InternalRequestAsync<QueryTradeResponse>(req, "QueryTrade")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过商家批次单号或者微信批次号查询批次单
        /// </summary>
        /// <param name="req"><see cref="QueryTransferBatchRequest"/></param>
        /// <returns><see cref="QueryTransferBatchResponse"/></returns>
        public Task<QueryTransferBatchResponse> QueryTransferBatch(QueryTransferBatchRequest req)
        {
            return InternalRequestAsync<QueryTransferBatchResponse>(req, "QueryTransferBatch");
        }

        /// <summary>
        /// 通过商家批次单号或者微信批次号查询批次单
        /// </summary>
        /// <param name="req"><see cref="QueryTransferBatchRequest"/></param>
        /// <returns><see cref="QueryTransferBatchResponse"/></returns>
        public QueryTransferBatchResponse QueryTransferBatchSync(QueryTransferBatchRequest req)
        {
            return InternalRequestAsync<QueryTransferBatchResponse>(req, "QueryTransferBatch")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过商家或者微信批次明细单号查询明细单
        /// </summary>
        /// <param name="req"><see cref="QueryTransferDetailRequest"/></param>
        /// <returns><see cref="QueryTransferDetailResponse"/></returns>
        public Task<QueryTransferDetailResponse> QueryTransferDetail(QueryTransferDetailRequest req)
        {
            return InternalRequestAsync<QueryTransferDetailResponse>(req, "QueryTransferDetail");
        }

        /// <summary>
        /// 通过商家或者微信批次明细单号查询明细单
        /// </summary>
        /// <param name="req"><see cref="QueryTransferDetailRequest"/></param>
        /// <returns><see cref="QueryTransferDetailResponse"/></returns>
        public QueryTransferDetailResponse QueryTransferDetailSync(QueryTransferDetailRequest req)
        {
            return InternalRequestAsync<QueryTransferDetailResponse>(req, "QueryTransferDetail")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智能代发-单笔代发转账查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryTransferResultRequest"/></param>
        /// <returns><see cref="QueryTransferResultResponse"/></returns>
        public Task<QueryTransferResultResponse> QueryTransferResult(QueryTransferResultRequest req)
        {
            return InternalRequestAsync<QueryTransferResultResponse>(req, "QueryTransferResult");
        }

        /// <summary>
        /// 智能代发-单笔代发转账查询接口
        /// </summary>
        /// <param name="req"><see cref="QueryTransferResultRequest"/></param>
        /// <returns><see cref="QueryTransferResultResponse"/></returns>
        public QueryTransferResultResponse QueryTransferResultSync(QueryTransferResultRequest req)
        {
            return InternalRequestAsync<QueryTransferResultResponse>(req, "QueryTransferResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 会员在途充值(经第三方支付渠道)接口
        /// </summary>
        /// <param name="req"><see cref="RechargeByThirdPayRequest"/></param>
        /// <returns><see cref="RechargeByThirdPayResponse"/></returns>
        public Task<RechargeByThirdPayResponse> RechargeByThirdPay(RechargeByThirdPayRequest req)
        {
            return InternalRequestAsync<RechargeByThirdPayResponse>(req, "RechargeByThirdPay");
        }

        /// <summary>
        /// 会员在途充值(经第三方支付渠道)接口
        /// </summary>
        /// <param name="req"><see cref="RechargeByThirdPayRequest"/></param>
        /// <returns><see cref="RechargeByThirdPayResponse"/></returns>
        public RechargeByThirdPayResponse RechargeByThirdPaySync(RechargeByThirdPayRequest req)
        {
            return InternalRequestAsync<RechargeByThirdPayResponse>(req, "RechargeByThirdPay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 见证宝-会员在途充值(经第三方支付渠道)
        /// </summary>
        /// <param name="req"><see cref="RechargeMemberThirdPayRequest"/></param>
        /// <returns><see cref="RechargeMemberThirdPayResponse"/></returns>
        public Task<RechargeMemberThirdPayResponse> RechargeMemberThirdPay(RechargeMemberThirdPayRequest req)
        {
            return InternalRequestAsync<RechargeMemberThirdPayResponse>(req, "RechargeMemberThirdPay");
        }

        /// <summary>
        /// 见证宝-会员在途充值(经第三方支付渠道)
        /// </summary>
        /// <param name="req"><see cref="RechargeMemberThirdPayRequest"/></param>
        /// <returns><see cref="RechargeMemberThirdPayResponse"/></returns>
        public RechargeMemberThirdPayResponse RechargeMemberThirdPaySync(RechargeMemberThirdPayRequest req)
        {
            return InternalRequestAsync<RechargeMemberThirdPayResponse>(req, "RechargeMemberThirdPay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 如交易订单需退款，可以通过本接口将支付款全部或部分退还给付款方，聚鑫将在收到退款请求并且验证成功之后，按照退款规则将支付款按原路退回到支付帐号。最长支持1年的订单退款。在订单包含多个子订单的情况下，如果使用本接口传入OutTradeNo或TransactionId退款，则只支持全单退款；如果需要部分退款，请通过传入子订单的方式来指定部分金额退款。 
        /// </summary>
        /// <param name="req"><see cref="RefundRequest"/></param>
        /// <returns><see cref="RefundResponse"/></returns>
        public Task<RefundResponse> Refund(RefundRequest req)
        {
            return InternalRequestAsync<RefundResponse>(req, "Refund");
        }

        /// <summary>
        /// 如交易订单需退款，可以通过本接口将支付款全部或部分退还给付款方，聚鑫将在收到退款请求并且验证成功之后，按照退款规则将支付款按原路退回到支付帐号。最长支持1年的订单退款。在订单包含多个子订单的情况下，如果使用本接口传入OutTradeNo或TransactionId退款，则只支持全单退款；如果需要部分退款，请通过传入子订单的方式来指定部分金额退款。 
        /// </summary>
        /// <param name="req"><see cref="RefundRequest"/></param>
        /// <returns><see cref="RefundResponse"/></returns>
        public RefundResponse RefundSync(RefundRequest req)
        {
            return InternalRequestAsync<RefundResponse>(req, "Refund")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 如交易订单需退款，可以通过本接口将支付款全部或部分退还给付款方，聚鑫将在收到退款请求并且验证成功之后，按照退款规则将支付款按原路退回到支付帐号。最长支持1年的订单退款。在订单包含多个子订单的情况下，如果使用本接口传入OutTradeNo或TransactionId退款，则只支持全单退款；如果需要部分退款，请通过传入子订单的方式来指定部分金额退款。 
        /// </summary>
        /// <param name="req"><see cref="RefundCloudOrderRequest"/></param>
        /// <returns><see cref="RefundCloudOrderResponse"/></returns>
        public Task<RefundCloudOrderResponse> RefundCloudOrder(RefundCloudOrderRequest req)
        {
            return InternalRequestAsync<RefundCloudOrderResponse>(req, "RefundCloudOrder");
        }

        /// <summary>
        /// 如交易订单需退款，可以通过本接口将支付款全部或部分退还给付款方，聚鑫将在收到退款请求并且验证成功之后，按照退款规则将支付款按原路退回到支付帐号。最长支持1年的订单退款。在订单包含多个子订单的情况下，如果使用本接口传入OutTradeNo或TransactionId退款，则只支持全单退款；如果需要部分退款，请通过传入子订单的方式来指定部分金额退款。 
        /// </summary>
        /// <param name="req"><see cref="RefundCloudOrderRequest"/></param>
        /// <returns><see cref="RefundCloudOrderResponse"/></returns>
        public RefundCloudOrderResponse RefundCloudOrderSync(RefundCloudOrderRequest req)
        {
            return InternalRequestAsync<RefundCloudOrderResponse>(req, "RefundCloudOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 会员间交易退款
        /// </summary>
        /// <param name="req"><see cref="RefundMemberTransactionRequest"/></param>
        /// <returns><see cref="RefundMemberTransactionResponse"/></returns>
        public Task<RefundMemberTransactionResponse> RefundMemberTransaction(RefundMemberTransactionRequest req)
        {
            return InternalRequestAsync<RefundMemberTransactionResponse>(req, "RefundMemberTransaction");
        }

        /// <summary>
        /// 会员间交易退款
        /// </summary>
        /// <param name="req"><see cref="RefundMemberTransactionRequest"/></param>
        /// <returns><see cref="RefundMemberTransactionResponse"/></returns>
        public RefundMemberTransactionResponse RefundMemberTransactionSync(RefundMemberTransactionRequest req)
        {
            return InternalRequestAsync<RefundMemberTransactionResponse>(req, "RefundMemberTransaction")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-退款申请
        /// </summary>
        /// <param name="req"><see cref="RefundOpenBankOrderRequest"/></param>
        /// <returns><see cref="RefundOpenBankOrderResponse"/></returns>
        public Task<RefundOpenBankOrderResponse> RefundOpenBankOrder(RefundOpenBankOrderRequest req)
        {
            return InternalRequestAsync<RefundOpenBankOrderResponse>(req, "RefundOpenBankOrder");
        }

        /// <summary>
        /// 云企付-退款申请
        /// </summary>
        /// <param name="req"><see cref="RefundOpenBankOrderRequest"/></param>
        /// <returns><see cref="RefundOpenBankOrderResponse"/></returns>
        public RefundOpenBankOrderResponse RefundOpenBankOrderSync(RefundOpenBankOrderRequest req)
        {
            return InternalRequestAsync<RefundOpenBankOrderResponse>(req, "RefundOpenBankOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云鉴-消费订单退款的接口
        /// </summary>
        /// <param name="req"><see cref="RefundOrderRequest"/></param>
        /// <returns><see cref="RefundOrderResponse"/></returns>
        public Task<RefundOrderResponse> RefundOrder(RefundOrderRequest req)
        {
            return InternalRequestAsync<RefundOrderResponse>(req, "RefundOrder");
        }

        /// <summary>
        /// 云鉴-消费订单退款的接口
        /// </summary>
        /// <param name="req"><see cref="RefundOrderRequest"/></param>
        /// <returns><see cref="RefundOrderResponse"/></returns>
        public RefundOrderResponse RefundOrderSync(RefundOrderRequest req)
        {
            return InternalRequestAsync<RefundOrderResponse>(req, "RefundOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付订单退款接口
        /// </summary>
        /// <param name="req"><see cref="RefundTlinxOrderRequest"/></param>
        /// <returns><see cref="RefundTlinxOrderResponse"/></returns>
        public Task<RefundTlinxOrderResponse> RefundTlinxOrder(RefundTlinxOrderRequest req)
        {
            return InternalRequestAsync<RefundTlinxOrderResponse>(req, "RefundTlinxOrder");
        }

        /// <summary>
        /// 云支付订单退款接口
        /// </summary>
        /// <param name="req"><see cref="RefundTlinxOrderRequest"/></param>
        /// <returns><see cref="RefundTlinxOrderResponse"/></returns>
        public RefundTlinxOrderResponse RefundTlinxOrderSync(RefundTlinxOrderRequest req)
        {
            return InternalRequestAsync<RefundTlinxOrderResponse>(req, "RefundTlinxOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 商户查询是否签约和签约行为上报
        /// </summary>
        /// <param name="req"><see cref="RegisterBehaviorRequest"/></param>
        /// <returns><see cref="RegisterBehaviorResponse"/></returns>
        public Task<RegisterBehaviorResponse> RegisterBehavior(RegisterBehaviorRequest req)
        {
            return InternalRequestAsync<RegisterBehaviorResponse>(req, "RegisterBehavior");
        }

        /// <summary>
        /// 商户查询是否签约和签约行为上报
        /// </summary>
        /// <param name="req"><see cref="RegisterBehaviorRequest"/></param>
        /// <returns><see cref="RegisterBehaviorResponse"/></returns>
        public RegisterBehaviorResponse RegisterBehaviorSync(RegisterBehaviorRequest req)
        {
            return InternalRequestAsync<RegisterBehaviorResponse>(req, "RegisterBehavior")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 登记挂账(支持撤销)
        /// </summary>
        /// <param name="req"><see cref="RegisterBillRequest"/></param>
        /// <returns><see cref="RegisterBillResponse"/></returns>
        public Task<RegisterBillResponse> RegisterBill(RegisterBillRequest req)
        {
            return InternalRequestAsync<RegisterBillResponse>(req, "RegisterBill");
        }

        /// <summary>
        /// 登记挂账(支持撤销)
        /// </summary>
        /// <param name="req"><see cref="RegisterBillRequest"/></param>
        /// <returns><see cref="RegisterBillResponse"/></returns>
        public RegisterBillResponse RegisterBillSync(RegisterBillRequest req)
        {
            return InternalRequestAsync<RegisterBillResponse>(req, "RegisterBill")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 登记挂账(支持撤销)。此接口可实现把不明来账或自有资金等已登记在挂账子账户下的资金调整到普通会员子账户。即通过申请调用此接口，将会减少挂账子账户的资金，调增指定的普通会员子账户的可提现余额及可用余额。此接口不支持把挂账子账户资金清分到功能子账户。
        /// </summary>
        /// <param name="req"><see cref="RegisterBillSupportWithdrawRequest"/></param>
        /// <returns><see cref="RegisterBillSupportWithdrawResponse"/></returns>
        public Task<RegisterBillSupportWithdrawResponse> RegisterBillSupportWithdraw(RegisterBillSupportWithdrawRequest req)
        {
            return InternalRequestAsync<RegisterBillSupportWithdrawResponse>(req, "RegisterBillSupportWithdraw");
        }

        /// <summary>
        /// 登记挂账(支持撤销)。此接口可实现把不明来账或自有资金等已登记在挂账子账户下的资金调整到普通会员子账户。即通过申请调用此接口，将会减少挂账子账户的资金，调增指定的普通会员子账户的可提现余额及可用余额。此接口不支持把挂账子账户资金清分到功能子账户。
        /// </summary>
        /// <param name="req"><see cref="RegisterBillSupportWithdrawRequest"/></param>
        /// <returns><see cref="RegisterBillSupportWithdrawResponse"/></returns>
        public RegisterBillSupportWithdrawResponse RegisterBillSupportWithdrawSync(RegisterBillSupportWithdrawRequest req)
        {
            return InternalRequestAsync<RegisterBillSupportWithdrawResponse>(req, "RegisterBillSupportWithdraw")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 修改会员属性-普通商户子账户。修改会员的会员属性。
        /// </summary>
        /// <param name="req"><see cref="ReviseMbrPropertyRequest"/></param>
        /// <returns><see cref="ReviseMbrPropertyResponse"/></returns>
        public Task<ReviseMbrPropertyResponse> ReviseMbrProperty(ReviseMbrPropertyRequest req)
        {
            return InternalRequestAsync<ReviseMbrPropertyResponse>(req, "ReviseMbrProperty");
        }

        /// <summary>
        /// 修改会员属性-普通商户子账户。修改会员的会员属性。
        /// </summary>
        /// <param name="req"><see cref="ReviseMbrPropertyRequest"/></param>
        /// <returns><see cref="ReviseMbrPropertyResponse"/></returns>
        public ReviseMbrPropertyResponse ReviseMbrPropertySync(ReviseMbrPropertyRequest req)
        {
            return InternalRequestAsync<ReviseMbrPropertyResponse>(req, "ReviseMbrProperty")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 撤销会员在途充值(经第三方支付渠道)
        /// </summary>
        /// <param name="req"><see cref="RevokeMemberRechargeThirdPayRequest"/></param>
        /// <returns><see cref="RevokeMemberRechargeThirdPayResponse"/></returns>
        public Task<RevokeMemberRechargeThirdPayResponse> RevokeMemberRechargeThirdPay(RevokeMemberRechargeThirdPayRequest req)
        {
            return InternalRequestAsync<RevokeMemberRechargeThirdPayResponse>(req, "RevokeMemberRechargeThirdPay");
        }

        /// <summary>
        /// 撤销会员在途充值(经第三方支付渠道)
        /// </summary>
        /// <param name="req"><see cref="RevokeMemberRechargeThirdPayRequest"/></param>
        /// <returns><see cref="RevokeMemberRechargeThirdPayResponse"/></returns>
        public RevokeMemberRechargeThirdPayResponse RevokeMemberRechargeThirdPaySync(RevokeMemberRechargeThirdPayRequest req)
        {
            return InternalRequestAsync<RevokeMemberRechargeThirdPayResponse>(req, "RevokeMemberRechargeThirdPay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 撤销会员在途充值(经第三方支付渠道)接口
        /// </summary>
        /// <param name="req"><see cref="RevokeRechargeByThirdPayRequest"/></param>
        /// <returns><see cref="RevokeRechargeByThirdPayResponse"/></returns>
        public Task<RevokeRechargeByThirdPayResponse> RevokeRechargeByThirdPay(RevokeRechargeByThirdPayRequest req)
        {
            return InternalRequestAsync<RevokeRechargeByThirdPayResponse>(req, "RevokeRechargeByThirdPay");
        }

        /// <summary>
        /// 撤销会员在途充值(经第三方支付渠道)接口
        /// </summary>
        /// <param name="req"><see cref="RevokeRechargeByThirdPayRequest"/></param>
        /// <returns><see cref="RevokeRechargeByThirdPayResponse"/></returns>
        public RevokeRechargeByThirdPayResponse RevokeRechargeByThirdPaySync(RevokeRechargeByThirdPayRequest req)
        {
            return InternalRequestAsync<RevokeRechargeByThirdPayResponse>(req, "RevokeRechargeByThirdPay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 对于存量的签约关系导入或者部分场景下米大师无法收到签约通知的场景，需要由调用方主动将签约状态同步至米大师
        /// </summary>
        /// <param name="req"><see cref="SyncContractDataRequest"/></param>
        /// <returns><see cref="SyncContractDataResponse"/></returns>
        public Task<SyncContractDataResponse> SyncContractData(SyncContractDataRequest req)
        {
            return InternalRequestAsync<SyncContractDataResponse>(req, "SyncContractData");
        }

        /// <summary>
        /// 对于存量的签约关系导入或者部分场景下米大师无法收到签约通知的场景，需要由调用方主动将签约状态同步至米大师
        /// </summary>
        /// <param name="req"><see cref="SyncContractDataRequest"/></param>
        /// <returns><see cref="SyncContractDataResponse"/></returns>
        public SyncContractDataResponse SyncContractDataSync(SyncContractDataRequest req)
        {
            return InternalRequestAsync<SyncContractDataResponse>(req, "SyncContractData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 通过此接口进行解约
        /// </summary>
        /// <param name="req"><see cref="TerminateContractRequest"/></param>
        /// <returns><see cref="TerminateContractResponse"/></returns>
        public Task<TerminateContractResponse> TerminateContract(TerminateContractRequest req)
        {
            return InternalRequestAsync<TerminateContractResponse>(req, "TerminateContract");
        }

        /// <summary>
        /// 通过此接口进行解约
        /// </summary>
        /// <param name="req"><see cref="TerminateContractRequest"/></param>
        /// <returns><see cref="TerminateContractResponse"/></returns>
        public TerminateContractResponse TerminateContractSync(TerminateContractRequest req)
        {
            return InternalRequestAsync<TerminateContractResponse>(req, "TerminateContract")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 智能代发-单笔代发转账接口
        /// </summary>
        /// <param name="req"><see cref="TransferSinglePayRequest"/></param>
        /// <returns><see cref="TransferSinglePayResponse"/></returns>
        public Task<TransferSinglePayResponse> TransferSinglePay(TransferSinglePayRequest req)
        {
            return InternalRequestAsync<TransferSinglePayResponse>(req, "TransferSinglePay");
        }

        /// <summary>
        /// 智能代发-单笔代发转账接口
        /// </summary>
        /// <param name="req"><see cref="TransferSinglePayRequest"/></param>
        /// <returns><see cref="TransferSinglePayResponse"/></returns>
        public TransferSinglePayResponse TransferSinglePaySync(TransferSinglePayRequest req)
        {
            return InternalRequestAsync<TransferSinglePayResponse>(req, "TransferSinglePay")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 商户解除绑定的提现银行卡
        /// </summary>
        /// <param name="req"><see cref="UnBindAcctRequest"/></param>
        /// <returns><see cref="UnBindAcctResponse"/></returns>
        public Task<UnBindAcctResponse> UnBindAcct(UnBindAcctRequest req)
        {
            return InternalRequestAsync<UnBindAcctResponse>(req, "UnBindAcct");
        }

        /// <summary>
        /// 商户解除绑定的提现银行卡
        /// </summary>
        /// <param name="req"><see cref="UnBindAcctRequest"/></param>
        /// <returns><see cref="UnBindAcctResponse"/></returns>
        public UnBindAcctResponse UnBindAcctSync(UnBindAcctRequest req)
        {
            return InternalRequestAsync<UnBindAcctResponse>(req, "UnBindAcct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-子商户银行卡解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindOpenBankExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="UnbindOpenBankExternalSubMerchantBankAccountResponse"/></returns>
        public Task<UnbindOpenBankExternalSubMerchantBankAccountResponse> UnbindOpenBankExternalSubMerchantBankAccount(UnbindOpenBankExternalSubMerchantBankAccountRequest req)
        {
            return InternalRequestAsync<UnbindOpenBankExternalSubMerchantBankAccountResponse>(req, "UnbindOpenBankExternalSubMerchantBankAccount");
        }

        /// <summary>
        /// 云企付-子商户银行卡解绑
        /// </summary>
        /// <param name="req"><see cref="UnbindOpenBankExternalSubMerchantBankAccountRequest"/></param>
        /// <returns><see cref="UnbindOpenBankExternalSubMerchantBankAccountResponse"/></returns>
        public UnbindOpenBankExternalSubMerchantBankAccountResponse UnbindOpenBankExternalSubMerchantBankAccountSync(UnbindOpenBankExternalSubMerchantBankAccountRequest req)
        {
            return InternalRequestAsync<UnbindOpenBankExternalSubMerchantBankAccountResponse>(req, "UnbindOpenBankExternalSubMerchantBankAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 会员解绑提现账户。此接口可以支持会员解除名下的绑定账户关系。
        /// </summary>
        /// <param name="req"><see cref="UnbindRelateAcctRequest"/></param>
        /// <returns><see cref="UnbindRelateAcctResponse"/></returns>
        public Task<UnbindRelateAcctResponse> UnbindRelateAcct(UnbindRelateAcctRequest req)
        {
            return InternalRequestAsync<UnbindRelateAcctResponse>(req, "UnbindRelateAcct");
        }

        /// <summary>
        /// 会员解绑提现账户。此接口可以支持会员解除名下的绑定账户关系。
        /// </summary>
        /// <param name="req"><see cref="UnbindRelateAcctRequest"/></param>
        /// <returns><see cref="UnbindRelateAcctResponse"/></returns>
        public UnbindRelateAcctResponse UnbindRelateAcctSync(UnbindRelateAcctRequest req)
        {
            return InternalRequestAsync<UnbindRelateAcctResponse>(req, "UnbindRelateAcct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 应用需要先调用本接口生成支付订单号，并将应答的PayInfo透传给聚鑫SDK，拉起客户端（包括微信公众号/微信小程序/客户端App）支付。
        /// </summary>
        /// <param name="req"><see cref="UnifiedCloudOrderRequest"/></param>
        /// <returns><see cref="UnifiedCloudOrderResponse"/></returns>
        public Task<UnifiedCloudOrderResponse> UnifiedCloudOrder(UnifiedCloudOrderRequest req)
        {
            return InternalRequestAsync<UnifiedCloudOrderResponse>(req, "UnifiedCloudOrder");
        }

        /// <summary>
        /// 应用需要先调用本接口生成支付订单号，并将应答的PayInfo透传给聚鑫SDK，拉起客户端（包括微信公众号/微信小程序/客户端App）支付。
        /// </summary>
        /// <param name="req"><see cref="UnifiedCloudOrderRequest"/></param>
        /// <returns><see cref="UnifiedCloudOrderResponse"/></returns>
        public UnifiedCloudOrderResponse UnifiedCloudOrderSync(UnifiedCloudOrderRequest req)
        {
            return InternalRequestAsync<UnifiedCloudOrderResponse>(req, "UnifiedCloudOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 应用需要先调用本接口生成支付订单号，并将应答的PayInfo透传给聚鑫SDK，拉起客户端（包括微信公众号/微信小程序/客户端App）支付。
        /// </summary>
        /// <param name="req"><see cref="UnifiedOrderRequest"/></param>
        /// <returns><see cref="UnifiedOrderResponse"/></returns>
        public Task<UnifiedOrderResponse> UnifiedOrder(UnifiedOrderRequest req)
        {
            return InternalRequestAsync<UnifiedOrderResponse>(req, "UnifiedOrder");
        }

        /// <summary>
        /// 应用需要先调用本接口生成支付订单号，并将应答的PayInfo透传给聚鑫SDK，拉起客户端（包括微信公众号/微信小程序/客户端App）支付。
        /// </summary>
        /// <param name="req"><see cref="UnifiedOrderRequest"/></param>
        /// <returns><see cref="UnifiedOrderResponse"/></returns>
        public UnifiedOrderResponse UnifiedOrderSync(UnifiedOrderRequest req)
        {
            return InternalRequestAsync<UnifiedOrderResponse>(req, "UnifiedOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-统一下单接口
        /// </summary>
        /// <param name="req"><see cref="UnifiedTlinxOrderRequest"/></param>
        /// <returns><see cref="UnifiedTlinxOrderResponse"/></returns>
        public Task<UnifiedTlinxOrderResponse> UnifiedTlinxOrder(UnifiedTlinxOrderRequest req)
        {
            return InternalRequestAsync<UnifiedTlinxOrderResponse>(req, "UnifiedTlinxOrder");
        }

        /// <summary>
        /// 云支付-统一下单接口
        /// </summary>
        /// <param name="req"><see cref="UnifiedTlinxOrderRequest"/></param>
        /// <returns><see cref="UnifiedTlinxOrderResponse"/></returns>
        public UnifiedTlinxOrderResponse UnifiedTlinxOrderSync(UnifiedTlinxOrderRequest req)
        {
            return InternalRequestAsync<UnifiedTlinxOrderResponse>(req, "UnifiedTlinxOrder")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 灵云-上传主播信息
        /// </summary>
        /// <param name="req"><see cref="UploadExternalAnchorInfoRequest"/></param>
        /// <returns><see cref="UploadExternalAnchorInfoResponse"/></returns>
        public Task<UploadExternalAnchorInfoResponse> UploadExternalAnchorInfo(UploadExternalAnchorInfoRequest req)
        {
            return InternalRequestAsync<UploadExternalAnchorInfoResponse>(req, "UploadExternalAnchorInfo");
        }

        /// <summary>
        /// 灵云-上传主播信息
        /// </summary>
        /// <param name="req"><see cref="UploadExternalAnchorInfoRequest"/></param>
        /// <returns><see cref="UploadExternalAnchorInfoResponse"/></returns>
        public UploadExternalAnchorInfoResponse UploadExternalAnchorInfoSync(UploadExternalAnchorInfoRequest req)
        {
            return InternalRequestAsync<UploadExternalAnchorInfoResponse>(req, "UploadExternalAnchorInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播平台-文件上传
        /// </summary>
        /// <param name="req"><see cref="UploadFileRequest"/></param>
        /// <returns><see cref="UploadFileResponse"/></returns>
        public Task<UploadFileResponse> UploadFile(UploadFileRequest req)
        {
            return InternalRequestAsync<UploadFileResponse>(req, "UploadFile");
        }

        /// <summary>
        /// 直播平台-文件上传
        /// </summary>
        /// <param name="req"><see cref="UploadFileRequest"/></param>
        /// <returns><see cref="UploadFileResponse"/></returns>
        public UploadFileResponse UploadFileSync(UploadFileRequest req)
        {
            return InternalRequestAsync<UploadFileResponse>(req, "UploadFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-子商户资质文件上传
        /// </summary>
        /// <param name="req"><see cref="UploadOpenBankSubMerchantCredentialRequest"/></param>
        /// <returns><see cref="UploadOpenBankSubMerchantCredentialResponse"/></returns>
        public Task<UploadOpenBankSubMerchantCredentialResponse> UploadOpenBankSubMerchantCredential(UploadOpenBankSubMerchantCredentialRequest req)
        {
            return InternalRequestAsync<UploadOpenBankSubMerchantCredentialResponse>(req, "UploadOpenBankSubMerchantCredential");
        }

        /// <summary>
        /// 云企付-子商户资质文件上传
        /// </summary>
        /// <param name="req"><see cref="UploadOpenBankSubMerchantCredentialRequest"/></param>
        /// <returns><see cref="UploadOpenBankSubMerchantCredentialResponse"/></returns>
        public UploadOpenBankSubMerchantCredentialResponse UploadOpenBankSubMerchantCredentialSync(UploadOpenBankSubMerchantCredentialRequest req)
        {
            return InternalRequestAsync<UploadOpenBankSubMerchantCredentialResponse>(req, "UploadOpenBankSubMerchantCredential")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-上传机构文件接口
        /// </summary>
        /// <param name="req"><see cref="UploadOrgFileRequest"/></param>
        /// <returns><see cref="UploadOrgFileResponse"/></returns>
        public Task<UploadOrgFileResponse> UploadOrgFile(UploadOrgFileRequest req)
        {
            return InternalRequestAsync<UploadOrgFileResponse>(req, "UploadOrgFile");
        }

        /// <summary>
        /// 云支付-上传机构文件接口
        /// </summary>
        /// <param name="req"><see cref="UploadOrgFileRequest"/></param>
        /// <returns><see cref="UploadOrgFileResponse"/></returns>
        public UploadOrgFileResponse UploadOrgFileSync(UploadOrgFileRequest req)
        {
            return InternalRequestAsync<UploadOrgFileResponse>(req, "UploadOrgFile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播平台-上传代理商完税列表
        /// </summary>
        /// <param name="req"><see cref="UploadTaxListRequest"/></param>
        /// <returns><see cref="UploadTaxListResponse"/></returns>
        public Task<UploadTaxListResponse> UploadTaxList(UploadTaxListRequest req)
        {
            return InternalRequestAsync<UploadTaxListResponse>(req, "UploadTaxList");
        }

        /// <summary>
        /// 直播平台-上传代理商完税列表
        /// </summary>
        /// <param name="req"><see cref="UploadTaxListRequest"/></param>
        /// <returns><see cref="UploadTaxListResponse"/></returns>
        public UploadTaxListResponse UploadTaxListSync(UploadTaxListRequest req)
        {
            return InternalRequestAsync<UploadTaxListResponse>(req, "UploadTaxList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 直播平台-上传代理商完税证明
        /// </summary>
        /// <param name="req"><see cref="UploadTaxPaymentRequest"/></param>
        /// <returns><see cref="UploadTaxPaymentResponse"/></returns>
        public Task<UploadTaxPaymentResponse> UploadTaxPayment(UploadTaxPaymentRequest req)
        {
            return InternalRequestAsync<UploadTaxPaymentResponse>(req, "UploadTaxPayment");
        }

        /// <summary>
        /// 直播平台-上传代理商完税证明
        /// </summary>
        /// <param name="req"><see cref="UploadTaxPaymentRequest"/></param>
        /// <returns><see cref="UploadTaxPaymentResponse"/></returns>
        public UploadTaxPaymentResponse UploadTaxPaymentSync(UploadTaxPaymentRequest req)
        {
            return InternalRequestAsync<UploadTaxPaymentResponse>(req, "UploadTaxPayment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云企付-子商户银行卡打款验证，在接入TENPAY渠道EBANK_PAYMENT付款时，若客户期望接入担保支付，需在接入前先完成，收款商户绑定的银行卡进行打款验证。验证成功后，才可以调用CreateOpenBankPaymentOrder接口进行担保支付下单。
        /// </summary>
        /// <param name="req"><see cref="VerifyOpenBankAccountRequest"/></param>
        /// <returns><see cref="VerifyOpenBankAccountResponse"/></returns>
        public Task<VerifyOpenBankAccountResponse> VerifyOpenBankAccount(VerifyOpenBankAccountRequest req)
        {
            return InternalRequestAsync<VerifyOpenBankAccountResponse>(req, "VerifyOpenBankAccount");
        }

        /// <summary>
        /// 云企付-子商户银行卡打款验证，在接入TENPAY渠道EBANK_PAYMENT付款时，若客户期望接入担保支付，需在接入前先完成，收款商户绑定的银行卡进行打款验证。验证成功后，才可以调用CreateOpenBankPaymentOrder接口进行担保支付下单。
        /// </summary>
        /// <param name="req"><see cref="VerifyOpenBankAccountRequest"/></param>
        /// <returns><see cref="VerifyOpenBankAccountResponse"/></returns>
        public VerifyOpenBankAccountResponse VerifyOpenBankAccountSync(VerifyOpenBankAccountRequest req)
        {
            return InternalRequestAsync<VerifyOpenBankAccountResponse>(req, "VerifyOpenBankAccount")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-查询合同明细接口
        /// </summary>
        /// <param name="req"><see cref="ViewContractRequest"/></param>
        /// <returns><see cref="ViewContractResponse"/></returns>
        public Task<ViewContractResponse> ViewContract(ViewContractRequest req)
        {
            return InternalRequestAsync<ViewContractResponse>(req, "ViewContract");
        }

        /// <summary>
        /// 云支付-查询合同明细接口
        /// </summary>
        /// <param name="req"><see cref="ViewContractRequest"/></param>
        /// <returns><see cref="ViewContractResponse"/></returns>
        public ViewContractResponse ViewContractSync(ViewContractRequest req)
        {
            return InternalRequestAsync<ViewContractResponse>(req, "ViewContract")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-查询商户明细接口
        /// </summary>
        /// <param name="req"><see cref="ViewMerchantRequest"/></param>
        /// <returns><see cref="ViewMerchantResponse"/></returns>
        public Task<ViewMerchantResponse> ViewMerchant(ViewMerchantRequest req)
        {
            return InternalRequestAsync<ViewMerchantResponse>(req, "ViewMerchant");
        }

        /// <summary>
        /// 云支付-查询商户明细接口
        /// </summary>
        /// <param name="req"><see cref="ViewMerchantRequest"/></param>
        /// <returns><see cref="ViewMerchantResponse"/></returns>
        public ViewMerchantResponse ViewMerchantSync(ViewMerchantRequest req)
        {
            return InternalRequestAsync<ViewMerchantResponse>(req, "ViewMerchant")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 云支付-查询门店明细接口
        /// </summary>
        /// <param name="req"><see cref="ViewShopRequest"/></param>
        /// <returns><see cref="ViewShopResponse"/></returns>
        public Task<ViewShopResponse> ViewShop(ViewShopRequest req)
        {
            return InternalRequestAsync<ViewShopResponse>(req, "ViewShop");
        }

        /// <summary>
        /// 云支付-查询门店明细接口
        /// </summary>
        /// <param name="req"><see cref="ViewShopRequest"/></param>
        /// <returns><see cref="ViewShopResponse"/></returns>
        public ViewShopResponse ViewShopSync(ViewShopRequest req)
        {
            return InternalRequestAsync<ViewShopResponse>(req, "ViewShop")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 会员提现-不验证。此接口受理会员发起的提现申请。会员子账户的可提现余额、可用余额会减少，市场的资金汇总账户(监管账户)会减少相应的发生金额，提现到会员申请的收款账户。		
        /// </summary>
        /// <param name="req"><see cref="WithdrawCashMembershipRequest"/></param>
        /// <returns><see cref="WithdrawCashMembershipResponse"/></returns>
        public Task<WithdrawCashMembershipResponse> WithdrawCashMembership(WithdrawCashMembershipRequest req)
        {
            return InternalRequestAsync<WithdrawCashMembershipResponse>(req, "WithdrawCashMembership");
        }

        /// <summary>
        /// 会员提现-不验证。此接口受理会员发起的提现申请。会员子账户的可提现余额、可用余额会减少，市场的资金汇总账户(监管账户)会减少相应的发生金额，提现到会员申请的收款账户。		
        /// </summary>
        /// <param name="req"><see cref="WithdrawCashMembershipRequest"/></param>
        /// <returns><see cref="WithdrawCashMembershipResponse"/></returns>
        public WithdrawCashMembershipResponse WithdrawCashMembershipSync(WithdrawCashMembershipRequest req)
        {
            return InternalRequestAsync<WithdrawCashMembershipResponse>(req, "WithdrawCashMembership")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
