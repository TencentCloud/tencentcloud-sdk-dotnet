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
        /// 签署人姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 经办人身份证号
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 签署人手机号，脱敏显示
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 签署完前端跳转的url，暂未使用
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 签署截止时间
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 签署完回调url
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 签署人类型，PERSON和ORGANIZATION
        /// </summary>
        [JsonProperty("ApproverType")]
        public string ApproverType{ get; set; }

        /// <summary>
        /// 用户侧第三方id
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 合同的强制预览时间：3~300s，未指定则按合同页数计算
        /// </summary>
        [JsonProperty("PreReadTime")]
        public long? PreReadTime{ get; set; }

        /// <summary>
        /// 个人签署方指定签署控件类型，目前仅支持：OCR_ESIGN(AI智慧手写签名)
        /// </summary>
        [JsonProperty("ComponentLimitType")]
        public string[] ComponentLimitType{ get; set; }

        /// <summary>
        /// 流程签署人在模板中对应的签署人Id；在非单方签署、以及非B2C签署的场景下必传，用于指定当前签署方在流程中的位置；
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }

        /// <summary>
        /// 企业签署方工商营业执照上的企业名称，签署方为非发起方企业场景下必传；
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 企业签署方在同一渠道下的其他合作企业OpenId，签署方为非发起方企业场景下必传；
        /// </summary>
        [JsonProperty("OrganizationOpenId")]
        public string OrganizationOpenId{ get; set; }

        /// <summary>
        /// 指定签署人非渠道企业下员工，在ApproverType为ORGANIZATION时指定。
        /// 默认为false，即签署人位于同一个渠道应用号下；
        /// </summary>
        [JsonProperty("NotChannelOrganization")]
        public bool? NotChannelOrganization{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "ApproverType", this.ApproverType);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "PreReadTime", this.PreReadTime);
            this.SetParamArraySimple(map, prefix + "ComponentLimitType.", this.ComponentLimitType);
            this.SetParamSimple(map, prefix + "RecipientId", this.RecipientId);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "OrganizationOpenId", this.OrganizationOpenId);
            this.SetParamSimple(map, prefix + "NotChannelOrganization", this.NotChannelOrganization);
        }
    }
}

