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
        /// ApplyWithdrawal接口的同步版本，商户提现
        /// </summary>
        /// <param name="req">参考<see cref="ApplyWithdrawalRequest"/></param>
        /// <returns>参考<see cref="ApplyWithdrawalResponse"/>实例</returns>
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
        /// BindAcct接口的同步版本，商户绑定提现银行卡，每个商户只能绑定一张提现银行卡
        /// </summary>
        /// <param name="req">参考<see cref="BindAcctRequest"/></param>
        /// <returns>参考<see cref="BindAcctResponse"/>实例</returns>
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
        /// BindRelateAccReUnionPay接口的同步版本，会员绑定提现账户-回填银联鉴权短信码。用于会员填写动态验证码后，发往银行进行验证，验证成功则完成绑定。
        /// </summary>
        /// <param name="req">参考<see cref="BindRelateAccReUnionPayRequest"/></param>
        /// <returns>参考<see cref="BindRelateAccReUnionPayResponse"/>实例</returns>
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
        /// BindRelateAcctSmallAmount接口的同步版本，会员绑定提现账户-小额鉴权。会员申请绑定提现账户，绑定后从会员子账户中提现到绑定账户。
        /// 转账鉴权有两种形式：往账鉴权和来账鉴权。
        /// 往账鉴权：该接口发起成功后，银行会向提现账户转入小于等于0.5元的随机金额，并短信通知客户查看，客户查看后，需将收到的金额大小，在电商平台页面上回填，并通知银行。银行验证通过后，完成提现账户绑定。
        /// 来账鉴权：该接口发起成功后，银行以短信通知客户查看，客户查看后，需通过待绑定的账户往市场的监管账户转入短信上指定的金额。银行检索到该笔指定金额的来账是源自待绑定账户，则绑定成功。平安银行的账户，即BankType送1时，大小额行号和超级网银号都不用送。
        /// </summary>
        /// <param name="req">参考<see cref="BindRelateAcctSmallAmountRequest"/></param>
        /// <returns>参考<see cref="BindRelateAcctSmallAmountResponse"/>实例</returns>
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
        /// BindRelateAcctUnionPay接口的同步版本，会员绑定提现账户-银联鉴权。用于会员申请绑定提现账户，申请后银行前往银联验证卡信息：姓名、证件、卡号、银行预留手机是否相符，相符则发送给会员手机动态验证码并返回成功，不相符则返回失败。
        /// 平台接收到银行返回成功后，进入输入动态验证码的页面，有效期120秒，若120秒未输入，客户可点击重新发送动态验证码，这个步骤重新调用该接口即可。
        /// 平安银行的账户，大小额行号和超级网银号都不用送。
        /// 超级网银号：单笔转账金额不超过5万，不限制笔数，只用选XX银行，不用具体到支行，可实时知道对方是否收款成功。
        /// 大小额联行号：单笔转账可超过5万，需具体到支行，不能实时知道对方是否收款成功。金额超过5万的，在工作日的8点30-17点间才会成功。
        /// </summary>
        /// <param name="req">参考<see cref="BindRelateAcctUnionPayRequest"/></param>
        /// <returns>参考<see cref="BindRelateAcctUnionPayResponse"/>实例</returns>
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
        /// CheckAcct接口的同步版本，商户绑定提现银行卡的验证接口
        /// </summary>
        /// <param name="req">参考<see cref="CheckAcctRequest"/></param>
        /// <returns>参考<see cref="CheckAcctResponse"/>实例</returns>
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
        /// CheckAmount接口的同步版本，验证鉴权金额。此接口可受理BindRelateAcctSmallAmount接口发起的转账金额（往账鉴权方式）的验证处理。若所回填的验证金额验证通过，则会绑定原申请中的银行账户作为提现账户。通过此接口也可以查得BindRelateAcctSmallAmount接口发起的来账鉴权方式的申请的当前状态。
        /// </summary>
        /// <param name="req">参考<see cref="CheckAmountRequest"/></param>
        /// <returns>参考<see cref="CheckAmountResponse"/>实例</returns>
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
        /// CloseOrder接口的同步版本，通过此接口关闭此前已创建的订单，关闭后，用户将无法继续付款。仅能关闭创建后未支付的订单
        /// </summary>
        /// <param name="req">参考<see cref="CloseOrderRequest"/></param>
        /// <returns>参考<see cref="CloseOrderResponse"/>实例</returns>
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
        /// CreateAcct接口的同步版本，子商户入驻聚鑫平台
        /// </summary>
        /// <param name="req">参考<see cref="CreateAcctRequest"/></param>
        /// <returns>参考<see cref="CreateAcctResponse"/>实例</returns>
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
        /// CreateCustAcctId接口的同步版本，会员子账户开立。会员在银行注册，并开立会员子账户，交易网会员代码即会员在平台端系统的会员编号。
        /// 平台需保存银行返回的子账户账号，后续交易接口都会用到。会员属性字段为预留扩展字段，当前必须送默认值。
        /// </summary>
        /// <param name="req">参考<see cref="CreateCustAcctIdRequest"/></param>
        /// <returns>参考<see cref="CreateCustAcctIdResponse"/>实例</returns>
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
        /// DownloadBill接口的同步版本，账单下载接口，根据本接口返回的URL地址，在D+1日下载对账单。注意，本接口返回的URL地址有时效，请尽快下载。URL超时时效后，请重新调用本接口再次获取。
        /// </summary>
        /// <param name="req">参考<see cref="DownloadBillRequest"/></param>
        /// <returns>参考<see cref="DownloadBillResponse"/>实例</returns>
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
        /// ModifyMntMbrBindRelateAcctBankCode接口的同步版本，维护会员绑定提现账户联行号。此接口可以支持市场修改会员的提现账户的开户行信息，具体包括开户行行名、开户行的银行联行号（大小额联行号）和超级网银行号。
        /// </summary>
        /// <param name="req">参考<see cref="ModifyMntMbrBindRelateAcctBankCodeRequest"/></param>
        /// <returns>参考<see cref="ModifyMntMbrBindRelateAcctBankCodeResponse"/>实例</returns>
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
        /// QueryBalance接口的同步版本，子商户余额查询
        /// </summary>
        /// <param name="req">参考<see cref="QueryBalanceRequest"/></param>
        /// <returns>参考<see cref="QueryBalanceResponse"/>实例</returns>
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
        /// QueryBankClear接口的同步版本，查询银行在途清算结果。查询时间段内交易网的在途清算结果。
        /// </summary>
        /// <param name="req">参考<see cref="QueryBankClearRequest"/></param>
        /// <returns>参考<see cref="QueryBankClearResponse"/>实例</returns>
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
        /// QueryBankTransactionDetails接口的同步版本，查询银行时间段内交易明细。查询时间段的会员成功交易。
        /// </summary>
        /// <param name="req">参考<see cref="QueryBankTransactionDetailsRequest"/></param>
        /// <returns>参考<see cref="QueryBankTransactionDetailsResponse"/>实例</returns>
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
        /// QueryBankWithdrawCashDetails接口的同步版本，查询银行时间段内清分提现明细。查询银行时间段内清分提现明细接口：若为“见证+收单退款”“见证+收单充值”记录时备注Note为“见证+收单充值,订单号”“见证+收单退款,订单号”，此接口可以查到T0/T1的充值明细和退款记录。查询标志：充值记录仍用3清分选项查询，退款记录同提现用2选项查询。
        /// </summary>
        /// <param name="req">参考<see cref="QueryBankWithdrawCashDetailsRequest"/></param>
        /// <returns>参考<see cref="QueryBankWithdrawCashDetailsResponse"/>实例</returns>
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
        /// QueryCommonTransferRecharge接口的同步版本，查询普通转账充值明细。接口用于查询会员主动转账进资金汇总账户的明细情况。若会员使用绑定账号转入，则直接入账到会员子账户。若未使用绑定账号转入，则系统无法自动清分到对应子账户，则转入挂账子账户由平台自行清分。若是 “见证+收单充值”T0充值记录时备注Note为“见证+收单充值,订单号” 此接口可以查到T0到账的“见证+收单充值”充值记录。
        /// </summary>
        /// <param name="req">参考<see cref="QueryCommonTransferRechargeRequest"/></param>
        /// <returns>参考<see cref="QueryCommonTransferRechargeResponse"/>实例</returns>
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
        /// QueryCustAcctIdBalance接口的同步版本，查询银行子账户余额。查询会员子账户以及平台的功能子账户的余额。
        /// </summary>
        /// <param name="req">参考<see cref="QueryCustAcctIdBalanceRequest"/></param>
        /// <returns>参考<see cref="QueryCustAcctIdBalanceResponse"/>实例</returns>
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
        /// QueryMemberBind接口的同步版本，会员绑定信息查询。查询标志为“单个会员”的情况下，返回该会员的有效的绑定账户信息。
        /// 查询标志为“全部会员”的情况下，返回市场下的全部的有效的绑定账户信息。查询标志为“单个会员的证件信息”的情况下，返回市场下的指定的会员的留存在电商见证宝系统的证件信息。
        /// </summary>
        /// <param name="req">参考<see cref="QueryMemberBindRequest"/></param>
        /// <returns>参考<see cref="QueryMemberBindResponse"/>实例</returns>
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
        /// QueryMemberTransaction接口的同步版本，会员间交易-不验证。此接口可以实现会员间的余额的交易，实现资金在会员之间流动。
        /// </summary>
        /// <param name="req">参考<see cref="QueryMemberTransactionRequest"/></param>
        /// <returns>参考<see cref="QueryMemberTransactionResponse"/>实例</returns>
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
        /// QueryOrder接口的同步版本，根据订单号，或者用户Id，查询支付订单状态 
        /// </summary>
        /// <param name="req">参考<see cref="QueryOrderRequest"/></param>
        /// <returns>参考<see cref="QueryOrderResponse"/>实例</returns>
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
        /// QueryReconciliationDocument接口的同步版本，查询对账文件信息。平台调用该接口获取需下载对账文件的文件名称以及密钥。 平台获取到信息后， 可以再调用OPENAPI的文件下载功能。
        /// </summary>
        /// <param name="req">参考<see cref="QueryReconciliationDocumentRequest"/></param>
        /// <returns>参考<see cref="QueryReconciliationDocumentResponse"/>实例</returns>
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
        /// QueryRefund接口的同步版本，提交退款申请后，通过调用该接口查询退款状态。退款可能有一定延时，用微信零钱支付的退款约20分钟内到账，银行卡支付的退款约3个工作日后到账。
        /// </summary>
        /// <param name="req">参考<see cref="QueryRefundRequest"/></param>
        /// <returns>参考<see cref="QueryRefundResponse"/>实例</returns>
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
        /// QuerySingleTransactionStatus接口的同步版本，查询银行单笔交易状态。查询单笔交易的状态。
        /// </summary>
        /// <param name="req">参考<see cref="QuerySingleTransactionStatusRequest"/></param>
        /// <returns>参考<see cref="QuerySingleTransactionStatusResponse"/>实例</returns>
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
        /// QuerySmallAmountTransfer接口的同步版本，查询小额鉴权转账结果。查询小额往账鉴权的转账状态。
        /// </summary>
        /// <param name="req">参考<see cref="QuerySmallAmountTransferRequest"/></param>
        /// <returns>参考<see cref="QuerySmallAmountTransferResponse"/>实例</returns>
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
        /// RechargeMemberThirdPay接口的同步版本，见证宝-会员在途充值(经第三方支付渠道)
        /// </summary>
        /// <param name="req">参考<see cref="RechargeMemberThirdPayRequest"/></param>
        /// <returns>参考<see cref="RechargeMemberThirdPayResponse"/>实例</returns>
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
        /// Refund接口的同步版本，如交易订单需退款，可以通过本接口将支付款全部或部分退还给付款方，聚鑫将在收到退款请求并且验证成功之后，按照退款规则将支付款按原路退回到支付帐号。最长支持1年的订单退款。在订单包含多个子订单的情况下，如果使用本接口传入OutTradeNo或TransactionId退款，则只支持全单退款；如果需要部分退款，请通过传入子订单的方式来指定部分金额退款。 
        /// </summary>
        /// <param name="req">参考<see cref="RefundRequest"/></param>
        /// <returns>参考<see cref="RefundResponse"/>实例</returns>
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
        /// RegisterBillSupportWithdraw接口的同步版本，登记挂账(支持撤销)。此接口可实现把不明来账或自有资金等已登记在挂账子账户下的资金调整到普通会员子账户。即通过申请调用此接口，将会减少挂账子账户的资金，调增指定的普通会员子账户的可提现余额及可用余额。此接口不支持把挂账子账户资金清分到功能子账户。
        /// </summary>
        /// <param name="req">参考<see cref="RegisterBillSupportWithdrawRequest"/></param>
        /// <returns>参考<see cref="RegisterBillSupportWithdrawResponse"/>实例</returns>
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
        /// <param name="req"><see cref="RevRegisterBillSupportWithdrawRequest"/></param>
        /// <returns><see cref="RevRegisterBillSupportWithdrawResponse"/></returns>
        public async Task<RevRegisterBillSupportWithdrawResponse> RevRegisterBillSupportWithdraw(RevRegisterBillSupportWithdrawRequest req)
        {
             JsonResponseModel<RevRegisterBillSupportWithdrawResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RevRegisterBillSupportWithdraw");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevRegisterBillSupportWithdrawResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// RevRegisterBillSupportWithdraw接口的同步版本，登记挂账撤销。此接口可以实现把RegisterBillSupportWithdraw接口完成的登记挂账进行撤销，即调减普通会员子账户的可提现和可用余额，调增挂账子账户的可用余额。
        /// </summary>
        /// <param name="req">参考<see cref="RevRegisterBillSupportWithdrawRequest"/></param>
        /// <returns>参考<see cref="RevRegisterBillSupportWithdrawResponse"/>实例</returns>
        public RevRegisterBillSupportWithdrawResponse RevRegisterBillSupportWithdrawSync(RevRegisterBillSupportWithdrawRequest req)
        {
             JsonResponseModel<RevRegisterBillSupportWithdrawResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RevRegisterBillSupportWithdraw");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevRegisterBillSupportWithdrawResponse>>(strResp);
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
        /// ReviseMbrProperty接口的同步版本，修改会员属性-普通商户子账户。修改会员的会员属性。
        /// </summary>
        /// <param name="req">参考<see cref="ReviseMbrPropertyRequest"/></param>
        /// <returns>参考<see cref="ReviseMbrPropertyResponse"/>实例</returns>
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
        /// RevokeMemberRechargeThirdPay接口的同步版本，撤销会员在途充值(经第三方支付渠道)
        /// </summary>
        /// <param name="req">参考<see cref="RevokeMemberRechargeThirdPayRequest"/></param>
        /// <returns>参考<see cref="RevokeMemberRechargeThirdPayResponse"/>实例</returns>
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
        /// UnBindAcct接口的同步版本，商户解除绑定的提现银行卡
        /// </summary>
        /// <param name="req">参考<see cref="UnBindAcctRequest"/></param>
        /// <returns>参考<see cref="UnBindAcctResponse"/>实例</returns>
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
        /// UnbindRelateAcct接口的同步版本，会员解绑提现账户。此接口可以支持会员解除名下的绑定账户关系。
        /// </summary>
        /// <param name="req">参考<see cref="UnbindRelateAcctRequest"/></param>
        /// <returns>参考<see cref="UnbindRelateAcctResponse"/>实例</returns>
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
        /// 应用需要先调用本接口生成支付订单号，并将应答的pay_info透传给聚鑫SDK，拉起客户端（包括微信公众号/微信小程序/客户端App）支付。
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
        /// UnifiedOrder接口的同步版本，应用需要先调用本接口生成支付订单号，并将应答的pay_info透传给聚鑫SDK，拉起客户端（包括微信公众号/微信小程序/客户端App）支付。
        /// </summary>
        /// <param name="req">参考<see cref="UnifiedOrderRequest"/></param>
        /// <returns>参考<see cref="UnifiedOrderResponse"/>实例</returns>
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
        /// WithdrawCashMembership接口的同步版本，会员提现-不验证。此接口受理会员发起的提现申请。会员子账户的可提现余额、可用余额会减少，市场的资金汇总账户(监管账户)会减少相应的发生金额，提现到会员申请的收款账户。		
        /// </summary>
        /// <param name="req">参考<see cref="WithdrawCashMembershipRequest"/></param>
        /// <returns>参考<see cref="WithdrawCashMembershipResponse"/>实例</returns>
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
