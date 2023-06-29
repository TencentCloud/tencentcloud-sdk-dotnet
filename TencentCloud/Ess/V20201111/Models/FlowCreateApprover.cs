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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowCreateApprover : AbstractModel
    {
        
        /// <summary>
        /// 参与者类型：
        /// 0：企业
        /// 1：个人
        /// 3：企业静默签署
        /// 注：类型为3（企业静默签署）时，会默认完成该签署方的签署。静默签署仅进行盖章操作，不能是手写签名。
        /// </summary>
        [JsonProperty("ApproverType")]
        public long? ApproverType{ get; set; }

        /// <summary>
        /// 如果签署方为企业，需要填入企业全称
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 签署方经办人姓名
        /// </summary>
        [JsonProperty("ApproverName")]
        public string ApproverName{ get; set; }

        /// <summary>
        /// 签署方经办人手机号码
        /// </summary>
        [JsonProperty("ApproverMobile")]
        public string ApproverMobile{ get; set; }

        /// <summary>
        /// 签署方经办人证件类型ID_CARD 身份证
        /// HONGKONG_AND_MACAO 港澳居民来往内地通行证
        /// HONGKONG_MACAO_AND_TAIWAN 港澳台居民居住证(格式同居民身份证)
        /// </summary>
        [JsonProperty("ApproverIdCardType")]
        public string ApproverIdCardType{ get; set; }

        /// <summary>
        /// 签署方经办人证件号码
        /// </summary>
        [JsonProperty("ApproverIdCardNumber")]
        public string ApproverIdCardNumber{ get; set; }

        /// <summary>
        /// 签署方经办人在模板中的参与方ID
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }

        /// <summary>
        /// 签署意愿确认渠道,WEIXINAPP:人脸识别
        /// </summary>
        [JsonProperty("VerifyChannel")]
        public string[] VerifyChannel{ get; set; }

        /// <summary>
        /// 是否发送短信，sms--短信通知，none--不通知，默认为sms；发起方=签署方时不发送短信
        /// </summary>
        [JsonProperty("NotifyType")]
        public string NotifyType{ get; set; }

        /// <summary>
        /// 合同强制需要阅读全文，无需传此参数
        /// </summary>
        [JsonProperty("IsFullText")]
        public bool? IsFullText{ get; set; }

        /// <summary>
        /// 合同的强制预览时间：3~300s，未指定则按合同页数计算
        /// </summary>
        [JsonProperty("PreReadTime")]
        public ulong? PreReadTime{ get; set; }

        /// <summary>
        /// 签署方经办人的用户ID,和签署方经办人姓名+手机号+证件必须有一个。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 当前只支持true，默认为true
        /// </summary>
        [JsonProperty("Required")]
        public bool? Required{ get; set; }

        /// <summary>
        /// 签署人用户来源,企微侧用户请传入：WEWORKAPP
        /// </summary>
        [JsonProperty("ApproverSource")]
        public string ApproverSource{ get; set; }

        /// <summary>
        /// 客户自定义签署人标识，64位长度，保证唯一。非企微场景不使用此字段
        /// </summary>
        [JsonProperty("CustomApproverTag")]
        public string CustomApproverTag{ get; set; }

        /// <summary>
        /// 快速注册相关信息，目前暂未开放！
        /// </summary>
        [JsonProperty("RegisterInfo")]
        public RegisterInfo RegisterInfo{ get; set; }

        /// <summary>
        /// 签署人个性化能力值
        /// </summary>
        [JsonProperty("ApproverOption")]
        public ApproverOption ApproverOption{ get; set; }

        /// <summary>
        /// 签署完前端跳转的url，暂未使用
        /// </summary>
        [JsonProperty("JumpUrl")]
        [System.Obsolete]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 签署ID
        /// - 发起流程时系统自动补充
        /// - 创建签署链接时，可以通过查询详情接口获得签署人的SignId，然后可传入此值为该签署人创建签署链接，无需再传姓名、手机号、证件号等其他信息
        /// </summary>
        [JsonProperty("SignId")]
        public string SignId{ get; set; }

        /// <summary>
        /// 当前签署方进行签署操作是否需要企业内部审批，true 则为需要。为个人签署方时则由发起方企业审核。
        /// </summary>
        [JsonProperty("ApproverNeedSignReview")]
        public bool? ApproverNeedSignReview{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApproverType", this.ApproverType);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "ApproverName", this.ApproverName);
            this.SetParamSimple(map, prefix + "ApproverMobile", this.ApproverMobile);
            this.SetParamSimple(map, prefix + "ApproverIdCardType", this.ApproverIdCardType);
            this.SetParamSimple(map, prefix + "ApproverIdCardNumber", this.ApproverIdCardNumber);
            this.SetParamSimple(map, prefix + "RecipientId", this.RecipientId);
            this.SetParamArraySimple(map, prefix + "VerifyChannel.", this.VerifyChannel);
            this.SetParamSimple(map, prefix + "NotifyType", this.NotifyType);
            this.SetParamSimple(map, prefix + "IsFullText", this.IsFullText);
            this.SetParamSimple(map, prefix + "PreReadTime", this.PreReadTime);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Required", this.Required);
            this.SetParamSimple(map, prefix + "ApproverSource", this.ApproverSource);
            this.SetParamSimple(map, prefix + "CustomApproverTag", this.CustomApproverTag);
            this.SetParamObj(map, prefix + "RegisterInfo.", this.RegisterInfo);
            this.SetParamObj(map, prefix + "ApproverOption.", this.ApproverOption);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
            this.SetParamSimple(map, prefix + "ApproverNeedSignReview", this.ApproverNeedSignReview);
        }
    }
}

