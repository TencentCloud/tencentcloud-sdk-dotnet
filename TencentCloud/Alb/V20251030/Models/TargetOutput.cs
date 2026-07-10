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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TargetOutput : AbstractModel
    {
        
        /// <summary>
        /// 弹性网卡 ID。
        /// </summary>
        [JsonProperty("EniId")]
        public string EniId{ get; set; }

        /// <summary>
        /// 后端服务器使用的端口。取值范围：**1 - 65535**。
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 后端服务实例 ID，CVM 实例格式为 ins- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("TargetId")]
        public string TargetId{ get; set; }

        /// <summary>
        /// 后端服务IP。**TargetIp**和**TargetId**需要至少传一个。
        /// 
        /// - 当服务器组为 **Instance** 类型时，该参数为 **Eni** 的主内网 IP 或辅助内网 IP。
        /// </summary>
        [JsonProperty("TargetIp")]
        public string TargetIp{ get; set; }

        /// <summary>
        /// 后端服务名称。当前只有CVM后端类型后端服务返回有效名称。
        /// </summary>
        [JsonProperty("TargetName")]
        public string TargetName{ get; set; }

        /// <summary>
        /// 后端服务的状态。取值：
        /// - **Adding**：添加中。
        /// - **Active**：正常可用状态。
        /// - **Configuring**：配置中。
        /// - **Removing**：移除中。
        /// </summary>
        [JsonProperty("TargetStatus")]
        public string TargetStatus{ get; set; }

        /// <summary>
        /// 后端服务类型。
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// 后端服务的权重，取值范围：**0 - 100**。默认值为**100**。如果设置权重为**0**，则不会将请求转发给该后端服务。
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EniId", this.EniId);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "TargetId", this.TargetId);
            this.SetParamSimple(map, prefix + "TargetIp", this.TargetIp);
            this.SetParamSimple(map, prefix + "TargetName", this.TargetName);
            this.SetParamSimple(map, prefix + "TargetStatus", this.TargetStatus);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
        }
    }
}

