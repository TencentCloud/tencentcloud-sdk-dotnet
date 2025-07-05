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
        /// </summary>
        [JsonProperty("HostIDs")]
        public string[] HostIDs{ get; set; }

        /// <summary>
        /// 开通容器安全的主机总数
        /// </summary>
        [JsonProperty("HostTotalCount")]
        public long? HostTotalCount{ get; set; }

        /// <summary>
        /// 支持防御的漏洞数
        /// </summary>
        [JsonProperty("SupportDefenseVulCount")]
        public long? SupportDefenseVulCount{ get; set; }

        /// <summary>
        /// 普通节点个数
        /// </summary>
        [JsonProperty("HostNodeCount")]
        public long? HostNodeCount{ get; set; }

        /// <summary>
        /// 超级节点范围
        /// </summary>
        [JsonProperty("SuperScope")]
        public long? SuperScope{ get; set; }

        /// <summary>
        /// 超级节点个数
        /// </summary>
        [JsonProperty("SuperNodeCount")]
        public long? SuperNodeCount{ get; set; }

        /// <summary>
        /// 超级节点Id列表
        /// </summary>
        [JsonProperty("SuperNodeIds")]
        public string[] SuperNodeIds{ get; set; }

        /// <summary>
        /// 开通容器安全的超级结点总数
        /// </summary>
        [JsonProperty("NodeTotalCount")]
        public long? NodeTotalCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
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
            this.SetParamSimple(map, prefix + "HostNodeCount", this.HostNodeCount);
            this.SetParamSimple(map, prefix + "SuperScope", this.SuperScope);
            this.SetParamSimple(map, prefix + "SuperNodeCount", this.SuperNodeCount);
            this.SetParamArraySimple(map, prefix + "SuperNodeIds.", this.SuperNodeIds);
            this.SetParamSimple(map, prefix + "NodeTotalCount", this.NodeTotalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

