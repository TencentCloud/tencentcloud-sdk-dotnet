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

namespace TencentCloud.Ic.V20190307
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ic.V20190307.Models;

   public class IcClient : AbstractClient{

       private const string endpoint = "ic.tencentcloudapi.com";
       private const string version = "2019-03-07";
       private const string sdkVersion = "SDK_NET_3.0.1078";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.ZH_CN })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// 根据应用id查询物联卡应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAppRequest"/></param>
        /// <returns><see cref="DescribeAppResponse"/></returns>
        public Task<DescribeAppResponse> DescribeApp(DescribeAppRequest req)
        {
            return InternalRequestAsync<DescribeAppResponse>(req, "DescribeApp");
        }

        /// <summary>
        /// 根据应用id查询物联卡应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAppRequest"/></param>
        /// <returns><see cref="DescribeAppResponse"/></returns>
        public DescribeAppResponse DescribeAppSync(DescribeAppRequest req)
        {
            return InternalRequestAsync<DescribeAppResponse>(req, "DescribeApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询卡片详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCardRequest"/></param>
        /// <returns><see cref="DescribeCardResponse"/></returns>
        public Task<DescribeCardResponse> DescribeCard(DescribeCardRequest req)
        {
            return InternalRequestAsync<DescribeCardResponse>(req, "DescribeCard");
        }

        /// <summary>
        /// 查询卡片详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCardRequest"/></param>
        /// <returns><see cref="DescribeCardResponse"/></returns>
        public DescribeCardResponse DescribeCardSync(DescribeCardRequest req)
        {
            return InternalRequestAsync<DescribeCardResponse>(req, "DescribeCard")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询卡片列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCardsRequest"/></param>
        /// <returns><see cref="DescribeCardsResponse"/></returns>
        public Task<DescribeCardsResponse> DescribeCards(DescribeCardsRequest req)
        {
            return InternalRequestAsync<DescribeCardsResponse>(req, "DescribeCards");
        }

        /// <summary>
        /// 查询卡片列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCardsRequest"/></param>
        /// <returns><see cref="DescribeCardsResponse"/></returns>
        public DescribeCardsResponse DescribeCardsSync(DescribeCardsRequest req)
        {
            return InternalRequestAsync<DescribeCardsResponse>(req, "DescribeCards")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 查询短信列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsRequest"/></param>
        /// <returns><see cref="DescribeSmsResponse"/></returns>
        public Task<DescribeSmsResponse> DescribeSms(DescribeSmsRequest req)
        {
            return InternalRequestAsync<DescribeSmsResponse>(req, "DescribeSms");
        }

        /// <summary>
        /// 查询短信列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsRequest"/></param>
        /// <returns><see cref="DescribeSmsResponse"/></returns>
        public DescribeSmsResponse DescribeSmsSync(DescribeSmsRequest req)
        {
            return InternalRequestAsync<DescribeSmsResponse>(req, "DescribeSms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 编辑卡片备注
        /// </summary>
        /// <param name="req"><see cref="ModifyUserCardRemarkRequest"/></param>
        /// <returns><see cref="ModifyUserCardRemarkResponse"/></returns>
        public Task<ModifyUserCardRemarkResponse> ModifyUserCardRemark(ModifyUserCardRemarkRequest req)
        {
            return InternalRequestAsync<ModifyUserCardRemarkResponse>(req, "ModifyUserCardRemark");
        }

        /// <summary>
        /// 编辑卡片备注
        /// </summary>
        /// <param name="req"><see cref="ModifyUserCardRemarkRequest"/></param>
        /// <returns><see cref="ModifyUserCardRemarkResponse"/></returns>
        public ModifyUserCardRemarkResponse ModifyUserCardRemarkSync(ModifyUserCardRemarkRequest req)
        {
            return InternalRequestAsync<ModifyUserCardRemarkResponse>(req, "ModifyUserCardRemark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 购买套外流量包
        /// </summary>
        /// <param name="req"><see cref="PayForExtendDataRequest"/></param>
        /// <returns><see cref="PayForExtendDataResponse"/></returns>
        public Task<PayForExtendDataResponse> PayForExtendData(PayForExtendDataRequest req)
        {
            return InternalRequestAsync<PayForExtendDataResponse>(req, "PayForExtendData");
        }

        /// <summary>
        /// 购买套外流量包
        /// </summary>
        /// <param name="req"><see cref="PayForExtendDataRequest"/></param>
        /// <returns><see cref="PayForExtendDataResponse"/></returns>
        public PayForExtendDataResponse PayForExtendDataSync(PayForExtendDataRequest req)
        {
            return InternalRequestAsync<PayForExtendDataResponse>(req, "PayForExtendData")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 批量为卡片续费，此接口建议调用至少间隔10s,如果出现返回deal lock failed相关的错误，请过10s再重试。
        /// 续费的必要条件：
        /// 1、单次续费的卡片不可以超过 100张。
        /// 2、接口只支持在控制台购买的卡片进行续费
        /// 3、销户和未激活的卡片不支持续费。
        /// 4、每张物联网卡，续费总周期不能超过24个月
        /// </summary>
        /// <param name="req"><see cref="RenewCardsRequest"/></param>
        /// <returns><see cref="RenewCardsResponse"/></returns>
        public Task<RenewCardsResponse> RenewCards(RenewCardsRequest req)
        {
            return InternalRequestAsync<RenewCardsResponse>(req, "RenewCards");
        }

        /// <summary>
        /// 批量为卡片续费，此接口建议调用至少间隔10s,如果出现返回deal lock failed相关的错误，请过10s再重试。
        /// 续费的必要条件：
        /// 1、单次续费的卡片不可以超过 100张。
        /// 2、接口只支持在控制台购买的卡片进行续费
        /// 3、销户和未激活的卡片不支持续费。
        /// 4、每张物联网卡，续费总周期不能超过24个月
        /// </summary>
        /// <param name="req"><see cref="RenewCardsRequest"/></param>
        /// <returns><see cref="RenewCardsResponse"/></returns>
        public RenewCardsResponse RenewCardsSync(RenewCardsRequest req)
        {
            return InternalRequestAsync<RenewCardsResponse>(req, "RenewCards")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 群发短信
        /// </summary>
        /// <param name="req"><see cref="SendMultiSmsRequest"/></param>
        /// <returns><see cref="SendMultiSmsResponse"/></returns>
        public Task<SendMultiSmsResponse> SendMultiSms(SendMultiSmsRequest req)
        {
            return InternalRequestAsync<SendMultiSmsResponse>(req, "SendMultiSms");
        }

        /// <summary>
        /// 群发短信
        /// </summary>
        /// <param name="req"><see cref="SendMultiSmsRequest"/></param>
        /// <returns><see cref="SendMultiSmsResponse"/></returns>
        public SendMultiSmsResponse SendMultiSmsSync(SendMultiSmsRequest req)
        {
            return InternalRequestAsync<SendMultiSmsResponse>(req, "SendMultiSms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 发送短信息接口
        /// </summary>
        /// <param name="req"><see cref="SendSmsRequest"/></param>
        /// <returns><see cref="SendSmsResponse"/></returns>
        public Task<SendSmsResponse> SendSms(SendSmsRequest req)
        {
            return InternalRequestAsync<SendSmsResponse>(req, "SendSms");
        }

        /// <summary>
        /// 发送短信息接口
        /// </summary>
        /// <param name="req"><see cref="SendSmsRequest"/></param>
        /// <returns><see cref="SendSmsResponse"/></returns>
        public SendSmsResponse SendSmsSync(SendSmsRequest req)
        {
            return InternalRequestAsync<SendSmsResponse>(req, "SendSms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
