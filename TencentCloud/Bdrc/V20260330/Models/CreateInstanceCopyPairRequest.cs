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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceCopyPairRequest : AbstractModel
    {
        
        /// <summary>
        /// 所属保护组
        /// </summary>
        [JsonProperty("ProtectGroupId")]
        public string ProtectGroupId{ get; set; }

        /// <summary>
        /// 目标端CVM创建参数列表（1~10 个）
        /// </summary>
        [JsonProperty("CreateTargetInstanceParameters")]
        public CreateInstanceModel[] CreateTargetInstanceParameters{ get; set; }

        /// <summary>
        /// 复制对名称，不传则新名称为"未命名"
        /// </summary>
        [JsonProperty("InstanceCopyPairName")]
        public string InstanceCopyPairName{ get; set; }

        /// <summary>
        /// 用于保证请求幂等性的字符串。该字符串由客户生成，需保证不同请求之间唯一，最大值不超过64个ASCII字符。若不指定该参数，则无法保证请求的幂等性
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 用户期望的RPO，单位分钟，目前仅支持15分钟
        /// </summary>
        [JsonProperty("RecoveryPointObjective")]
        public long? RecoveryPointObjective{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProtectGroupId", this.ProtectGroupId);
            this.SetParamArrayObj(map, prefix + "CreateTargetInstanceParameters.", this.CreateTargetInstanceParameters);
            this.SetParamSimple(map, prefix + "InstanceCopyPairName", this.InstanceCopyPairName);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "RecoveryPointObjective", this.RecoveryPointObjective);
        }
    }
}

