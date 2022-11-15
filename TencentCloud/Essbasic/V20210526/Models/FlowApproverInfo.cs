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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowApproverInfo : AbstractModel
    {
        
        /// <summary>
        /// 签署人姓名，最大长度50个字符
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 签署人身份证件类型
        /// 1.ID_CARD 居民身份证
        /// 2.HONGKONG_MACAO_AND_TAIWAN 港澳台居民居住证
        /// 3.HONGKONG_AND_MACAO 港澳居民来往内地通行证
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 签署人证件号
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 签署人手机号，脱敏显示。大陆手机号为11位，暂不支持海外手机号。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 企业签署方工商营业执照上的企业名称，签署方为非发起方企业场景下必传，最大长度64个字符；
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 指定签署人非渠道企业下员工，在ApproverType为ORGANIZATION时指定。
        /// 默认为false，即签署人位于同一个渠道应用号下；
        /// </summary>
        [JsonProperty("NotChannelOrganization")]
        public bool? NotChannelOrganization{ get; set; }

        /// <summary>
        /// 用户侧第三方id，最大长度64个字符
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 企业签署方在同一渠道下的其他合作企业OpenId，签署方为非发起方企业场景下必传，最大长度64个字符；
        /// </summary>
        [JsonProperty("OrganizationOpenId")]
        public string OrganizationOpenId{ get; set; }

        /// <summary>
        /// 签署人类型，PERSON-个人；
        /// PERSON_AUTO_SIGN-个人自动签；
        /// ORGANIZATION-企业；
        /// ENTERPRISESERVER-企业静默签;
        /// 注：ENTERPRISESERVER 类型仅用于使用文件创建签署流程（ChannelCreateFlowByFiles）接口；
        /// </summary>
        [JsonProperty("ApproverType")]
        public string ApproverType{ get; set; }

        /// <summary>
        /// 签署流程签署人在模板中对应的签署人Id；在非单方签署、以及非B2C签署的场景下必传，用于指定当前签署方在签署流程中的位置；
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }

        /// <summary>
        /// 签署截止时间，默认一年
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 签署完回调url，最大长度1000个字符
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 使用PDF文件直接发起合同时，签署人指定的签署控件
        /// </summary>
        [JsonProperty("SignComponents")]
        public Component[] SignComponents{ get; set; }

        /// <summary>
        /// 个人签署方指定签署控件类型，目前仅支持：OCR_ESIGN(AI智慧手写签名)
        /// </summary>
        [JsonProperty("ComponentLimitType")]
        public string[] ComponentLimitType{ get; set; }

        /// <summary>
        /// 合同的强制预览时间：3~300s，未指定则按合同页数计算
        /// </summary>
        [JsonProperty("PreReadTime")]
        public long? PreReadTime{ get; set; }

        /// <summary>
        /// 签署完前端跳转的url，暂未使用
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 签署人个性化能力值
        /// </summary>
        [JsonProperty("ApproverOption")]
        public ApproverOption ApproverOption{ get; set; }

        /// <summary>
        /// 当前签署方进行签署操作是否需要企业内部审批，true 则为需要
        /// </summary>
        [JsonProperty("ApproverNeedSignReview")]
        public bool? ApproverNeedSignReview{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "NotChannelOrganization", this.NotChannelOrganization);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "OrganizationOpenId", this.OrganizationOpenId);
            this.SetParamSimple(map, prefix + "ApproverType", this.ApproverType);
            this.SetParamSimple(map, prefix + "RecipientId", this.RecipientId);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamArrayObj(map, prefix + "SignComponents.", this.SignComponents);
            this.SetParamArraySimple(map, prefix + "ComponentLimitType.", this.ComponentLimitType);
            this.SetParamSimple(map, prefix + "PreReadTime", this.PreReadTime);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamObj(map, prefix + "ApproverOption.", this.ApproverOption);
            this.SetParamSimple(map, prefix + "ApproverNeedSignReview", this.ApproverNeedSignReview);
        }
    }
}

