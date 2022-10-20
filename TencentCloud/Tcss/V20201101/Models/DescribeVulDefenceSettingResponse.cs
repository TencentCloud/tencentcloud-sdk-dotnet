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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulDefenceSettingResponse : AbstractModel
    {
        
        /// <summary>
        /// 是否开启:0: 关闭 1:开启
        /// </summary>
        [JsonProperty("IsEnabled")]
        public long? IsEnabled{ get; set; }

        /// <summary>
        /// 漏洞防御主机范围: 0:自选主机节点，1:全部
        /// </summary>
        [JsonProperty("Scope")]
        public long? Scope{ get; set; }

        /// <summary>
        /// 漏洞防御主机数量
        /// </summary>
        [JsonProperty("HostCount")]
        public long? HostCount{ get; set; }

        /// <summary>
        /// 开启漏洞防御异常主机数量
        /// </summary>
        [JsonProperty("ExceptionHostCount")]
        public long? ExceptionHostCount{ get; set; }

        /// <summary>
        /// 自选漏洞防御主机
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostIDs")]
        public string[] HostIDs{ get; set; }

        /// <summary>
        /// 开通容器安全的主机总数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostTotalCount")]
        public long? HostTotalCount{ get; set; }

        /// <summary>
        /// 支持防御的漏洞数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SupportDefenseVulCount")]
        public long? SupportDefenseVulCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsEnabled", this.IsEnabled);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "ExceptionHostCount", this.ExceptionHostCount);
            this.SetParamArraySimple(map, prefix + "HostIDs.", this.HostIDs);
            this.SetParamSimple(map, prefix + "HostTotalCount", this.HostTotalCount);
            this.SetParamSimple(map, prefix + "SupportDefenseVulCount", this.SupportDefenseVulCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

