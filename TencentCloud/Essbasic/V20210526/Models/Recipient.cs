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

    public class Recipient : AbstractModel
    {
        
        /// <summary>
        /// 合同参与方的角色ID
        /// </summary>
        [JsonProperty("RecipientId")]
        public string RecipientId{ get; set; }

        /// <summary>
        /// 参与者类型, 可以选择的类型如下:
        /// <ul><li> **ENTERPRISE** :此角色为企业参与方</li>
        /// <li> **INDIVIDUAL** :此角色为个人参与方</li>
        /// <li> **PROMOTER** :此角色是发起方</li></ul>
        /// </summary>
        [JsonProperty("RecipientType")]
        public string RecipientType{ get; set; }

        /// <summary>
        /// 合同参与方的角色描述，长度不能超过100，只能由中文、字母、数字和下划线组成。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 合同参与方的角色名字，长度不能超过20，只能由中文、字母、数字和下划线组成。
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// 是否需要校验，
        /// true-是，
        /// false-否
        /// </summary>
        [JsonProperty("RequireValidation")]
        public bool? RequireValidation{ get; set; }

        /// <summary>
        /// 是否必须填写，
        /// true-是，
        /// false-否
        /// </summary>
        [JsonProperty("RequireSign")]
        public bool? RequireSign{ get; set; }

        /// <summary>
        /// 内部字段，签署类型
        /// </summary>
        [JsonProperty("SignType")]
        public long? SignType{ get; set; }

        /// <summary>
        /// 签署顺序：数字越小优先级越高
        /// </summary>
        [JsonProperty("RoutingOrder")]
        public long? RoutingOrder{ get; set; }

        /// <summary>
        /// 是否是发起方，
        /// true-是 
        /// false-否
        /// </summary>
        [JsonProperty("IsPromoter")]
        public bool? IsPromoter{ get; set; }

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
            this.SetParamSimple(map, prefix + "SignType", this.SignType);
            this.SetParamSimple(map, prefix + "RoutingOrder", this.RoutingOrder);
            this.SetParamSimple(map, prefix + "IsPromoter", this.IsPromoter);
            this.SetParamArraySimple(map, prefix + "ApproverVerifyTypes.", this.ApproverVerifyTypes);
            this.SetParamArraySimple(map, prefix + "ApproverSignTypes.", this.ApproverSignTypes);
        }
    }
}

