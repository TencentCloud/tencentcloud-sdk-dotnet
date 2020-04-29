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

namespace TencentCloud.Rp.V20200224.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryRegisterProtectionResponse : AbstractModel
    {
        
        /// <summary>
        /// 业务侧错误码，成功时返回 Success，错误时返回具体业务错误原因。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeDesc")]
        public string CodeDesc{ get; set; }

        /// <summary>
        /// accountType 是 QQ 或微信开放账号时，用于标识 QQ 或微信用户登录后关联业务自身的账号 ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssociateAccount")]
        public string AssociateAccount{ get; set; }

        /// <summary>
        /// 注册时间戳，单位：秒。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegisterTime")]
        public string RegisterTime{ get; set; }

        /// <summary>
        /// 用户 ID 不同的 accountType 对应不同的用户 ID。如果是 QQ，则填入对应的 openid，微信用户则填入对应的 openid/unionid，手机号则填入对应真实用户手机号（如13123456789）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }

        /// <summary>
        /// 注册来源的外网 IP。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegisterIp")]
        public string RegisterIp{ get; set; }

        /// <summary>
        /// 0：表示无恶意。
        /// 1 - 4：恶意等级由低到高。
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 风险类型。
        /// </summary>
        [JsonProperty("RiskType")]
        public long?[] RiskType{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CodeDesc", this.CodeDesc);
            this.SetParamSimple(map, prefix + "AssociateAccount", this.AssociateAccount);
            this.SetParamSimple(map, prefix + "RegisterTime", this.RegisterTime);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "RegisterIp", this.RegisterIp);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamArraySimple(map, prefix + "RiskType.", this.RiskType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

