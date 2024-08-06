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

    public class Recipient : AbstractModel
    {
        
        /// <summary>
        /// 签署参与者ID，唯一标识
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }

        /// <summary>
        /// 参与者类型。
        /// 默认为空。
        /// ENTERPRISE-企业；
        /// INDIVIDUAL-个人；
        /// PROMOTER-发起方
        /// </summary>
        [JsonProperty("RecipientType")]
        public string RecipientType{ get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// 是否需要验证，
        /// 默认为false-不需要验证
        /// </summary>
        [JsonProperty("RequireValidation")]
        public bool? RequireValidation{ get; set; }

        /// <summary>
        /// 是否需要签署，
        /// 默认为true-需要签署
        /// </summary>
        [JsonProperty("RequireSign")]
        public bool? RequireSign{ get; set; }

        /// <summary>
        /// 此参与方添加的顺序，从0～N
        /// </summary>
        [JsonProperty("RoutingOrder")]
        public long? RoutingOrder{ get; set; }

        /// <summary>
        /// 是否需要发送，
        /// 默认为true-需要发送
        /// </summary>
        [JsonProperty("RequireDelivery")]
        public bool? RequireDelivery{ get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 关联的用户ID，电子签系统的用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 发送方式，默认为EMAIL。
        /// EMAIL-邮件；
        /// MOBILE-手机短信；
        /// WECHAT-微信通知
        /// </summary>
        [JsonProperty("DeliveryMethod")]
        public string DeliveryMethod{ get; set; }

        /// <summary>
        /// 参与方的一些附属信息，json格式
        /// </summary>
        [JsonProperty("RecipientExtra")]
        public string RecipientExtra{ get; set; }

        /// <summary>
        /// 签署人查看合同校验方式, 支持的类型如下:
        /// <ul><li> 1 :实名认证查看</li>
        /// <li> 2 :手机号校验查看</li></ul>
        /// </summary>
        [JsonProperty("ApproverVerifyTypes")]
        public long?[] ApproverVerifyTypes{ get; set; }

        /// <summary>
        /// 签署人进行合同签署时的认证方式，支持的类型如下:
        /// <ul><li> 1 :人脸认证</li>
        /// <li> 2 :签署密码</li>
        /// <li> 3 :运营商三要素认证</li>
        /// <li> 4 :UKey认证</li>
        /// <li> 5 :设备指纹识别</li>
        /// <li> 6 :设备面容识别</li></ul>
        /// </summary>
        [JsonProperty("ApproverSignTypes")]
        public long?[] ApproverSignTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RecipientId", this.RecipientId);
            this.SetParamSimple(map, prefix + "RecipientType", this.RecipientType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "RequireValidation", this.RequireValidation);
            this.SetParamSimple(map, prefix + "RequireSign", this.RequireSign);
            this.SetParamSimple(map, prefix + "RoutingOrder", this.RoutingOrder);
            this.SetParamSimple(map, prefix + "RequireDelivery", this.RequireDelivery);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "DeliveryMethod", this.DeliveryMethod);
            this.SetParamSimple(map, prefix + "RecipientExtra", this.RecipientExtra);
            this.SetParamArraySimple(map, prefix + "ApproverVerifyTypes.", this.ApproverVerifyTypes);
            this.SetParamArraySimple(map, prefix + "ApproverSignTypes.", this.ApproverSignTypes);
        }
    }
}

