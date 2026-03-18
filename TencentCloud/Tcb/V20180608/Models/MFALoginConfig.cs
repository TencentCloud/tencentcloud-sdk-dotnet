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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MFALoginConfig : AbstractModel
    {
        
        /// <summary>
        /// MFA 多因子认证开关。取值范围：
        /// TRUE：开启 MFA 多因子认证
        /// FALSE：关闭 MFA 多因子认证
        /// 不传则不修改当前配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("On")]
        public string On{ get; set; }

        /// <summary>
        /// 短信验证开关，控制是否在 MFA 流程中启用短信验证码校验。取值范围：
        /// TRUE：开启短信验证
        /// FALSE：关闭短信验证
        /// 不传则不修改当前配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Sms")]
        public string Sms{ get; set; }

        /// <summary>
        /// 邮箱验证开关，控制是否在 MFA 流程中启用邮箱验证码校验。取值范围：
        /// TRUE：开启邮箱验证
        /// FALSE：关闭邮箱验证
        /// 不传则不修改当前配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 强制绑定手机号开关，控制用户在完成 MFA 认证前是否必须绑定手机号。取值范围：
        /// TRUE：要求绑定手机号
        /// FALSE：不要求绑定手机号
        /// 不传则不修改当前配置。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RequiredBindPhone")]
        public string RequiredBindPhone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "On", this.On);
            this.SetParamSimple(map, prefix + "Sms", this.Sms);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "RequiredBindPhone", this.RequiredBindPhone);
        }
    }
}

