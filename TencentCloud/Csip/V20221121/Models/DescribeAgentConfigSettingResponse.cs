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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAgentConfigSettingResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>增强日志模式开关，0-关闭 1-开启（未配置时为空）</p>
        /// </summary>
        [JsonProperty("EnhanceLogMode")]
        public ulong? EnhanceLogMode{ get; set; }

        /// <summary>
        /// <p>恶意软件 POC 模式开关，0-关闭 1-开启（未配置时为空）</p>
        /// </summary>
        [JsonProperty("MalwarePocMode")]
        public ulong? MalwarePocMode{ get; set; }

        /// <summary>
        /// <p>上报源端口开关（兼容旧版本），0-关闭 1-开启</p>
        /// </summary>
        [JsonProperty("ReportSourcePort")]
        public ulong? ReportSourcePort{ get; set; }

        /// <summary>
        /// <p>已开启的日志采集类型列表，如 tcp_ingress、tcp_src_port、http_egress、http_ingress、app_access</p>
        /// </summary>
        [JsonProperty("LogCollectSettings")]
        public string[] LogCollectSettings{ get; set; }

        /// <summary>
        /// <p>资产选择方式：all/tag/direct</p>
        /// </summary>
        [JsonProperty("AssetSelectionType")]
        public string AssetSelectionType{ get; set; }

        /// <summary>
        /// <p>按标签选择时的标签ID数组</p>
        /// </summary>
        [JsonProperty("TagIds")]
        public string[] TagIds{ get; set; }

        /// <summary>
        /// <p>直接选择的主机instance_id列表</p>
        /// </summary>
        [JsonProperty("InstanceIDs")]
        public string[] InstanceIDs{ get; set; }

        /// <summary>
        /// <p>排除的主机instance_id列表</p>
        /// </summary>
        [JsonProperty("ExcludeInstanceIDs")]
        public string[] ExcludeInstanceIDs{ get; set; }

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
            this.SetParamSimple(map, prefix + "EnhanceLogMode", this.EnhanceLogMode);
            this.SetParamSimple(map, prefix + "MalwarePocMode", this.MalwarePocMode);
            this.SetParamSimple(map, prefix + "ReportSourcePort", this.ReportSourcePort);
            this.SetParamArraySimple(map, prefix + "LogCollectSettings.", this.LogCollectSettings);
            this.SetParamSimple(map, prefix + "AssetSelectionType", this.AssetSelectionType);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
            this.SetParamArraySimple(map, prefix + "InstanceIDs.", this.InstanceIDs);
            this.SetParamArraySimple(map, prefix + "ExcludeInstanceIDs.", this.ExcludeInstanceIDs);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

