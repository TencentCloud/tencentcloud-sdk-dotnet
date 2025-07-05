/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowApproverInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 认证方式：
        /// WEIXINAPP - 微信小程序；
        /// FACEID - 慧眼 (默认)；
        /// VERIFYCODE - 验证码；
        /// THIRD - 第三方 (暂不支持)
        /// </summary>
        [JsonProperty("VerifyChannel")]
        public string[] VerifyChannel{ get; set; }

        /// <summary>
        /// 签署状态：
        /// 0 - 待签署；
        /// 1- 已签署；
        /// 2 - 拒绝；
        /// 3 - 过期未处理；
        /// 4 - 流程已撤回,
        /// 12-审核中,
        /// 13-审核驳回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproveStatus")]
        public long? ApproveStatus{ get; set; }

        /// <summary>
        /// 拒签/签署/审核驳回原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproveMessage")]
        public string ApproveMessage{ get; set; }

        /// <summary>
        /// 签约时间的时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproveTime")]
        public long? ApproveTime{ get; set; }

        /// <summary>
        /// 签署企业ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubOrganizationId")]
        public string SubOrganizationId{ get; set; }

        /// <summary>
        /// 签署完成后跳转的URL
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }

        /// <summary>
        /// 用户签署区ID到印章ID的映射集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComponentSeals")]
        public ComponentSeal[] ComponentSeals{ get; set; }

        /// <summary>
        /// 签署前置条件：是否强制用户全文阅读，即阅读到待签署文档的最后一页。默认FALSE
        /// </summary>
        [JsonProperty("IsFullText")]
        public bool? IsFullText{ get; set; }

        /// <summary>
        /// 签署前置条件：强制阅读时长，页面停留时长不足则不允许签署。默认不限制
        /// </summary>
        [JsonProperty("PreReadTime")]
        public long? PreReadTime{ get; set; }

        /// <summary>
        /// 签署人手机号，脱敏显示
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 签署链接截止时间，默认签署流程发起后7天失效
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 是否为最后一个签署人, 若为最后一人，则其签署完成后自动归档
        /// </summary>
        [JsonProperty("IsLastApprover")]
        public bool? IsLastApprover{ get; set; }

        /// <summary>
        /// 短信模板
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SmsTemplate")]
        public SmsTemplate SmsTemplate{ get; set; }

        /// <summary>
        /// 身份证号，脱敏显示
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 是否支持线下核身
        /// </summary>
        [JsonProperty("CanOffLine")]
        public bool? CanOffLine{ get; set; }

        /// <summary>
        /// 证件号码类型：ID_CARD - 身份证，PASSPORT - 护照，MAINLAND_TRAVEL_PERMIT_FOR_HONGKONG_AND_MACAO_RESIDENTS - 港澳居民来往内地通行证; 暂不支持用于电子签自有平台实名认证，MAINLAND_TRAVEL_PERMIT_FOR_TAIWAN_RESIDENTS - 台湾居民来往大陆通行证; 暂不支持用于电子签自有平台实名认证，HOUSEHOLD_REGISTER - 户口本; 暂不支持用于电子签自有平台实名认证，TEMP_ID_CARD - 临时居民身份证; 暂不支持用于电子签自有平台实名认证
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 签署回调地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 签署任务ID，标识每一次的流程发送
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SignId")]
        public string SignId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamArraySimple(map, prefix + "VerifyChannel.", this.VerifyChannel);
            this.SetParamSimple(map, prefix + "ApproveStatus", this.ApproveStatus);
            this.SetParamSimple(map, prefix + "ApproveMessage", this.ApproveMessage);
            this.SetParamSimple(map, prefix + "ApproveTime", this.ApproveTime);
            this.SetParamSimple(map, prefix + "SubOrganizationId", this.SubOrganizationId);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
            this.SetParamArrayObj(map, prefix + "ComponentSeals.", this.ComponentSeals);
            this.SetParamSimple(map, prefix + "IsFullText", this.IsFullText);
            this.SetParamSimple(map, prefix + "PreReadTime", this.PreReadTime);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "IsLastApprover", this.IsLastApprover);
            this.SetParamObj(map, prefix + "SmsTemplate.", this.SmsTemplate);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CanOffLine", this.CanOffLine);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
        }
    }
}

