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

    public class DescribeAgentRunModeResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>自定义模式配置</p>
        /// </summary>
        [JsonProperty("CustomPolicy")]
        public CustomAgentRunModePolicy CustomPolicy{ get; set; }

        /// <summary>
        /// <p>高安全防护模式quuid列表</p>
        /// </summary>
        [JsonProperty("AdvanceModeQuuids")]
        public string[] AdvanceModeQuuids{ get; set; }

        /// <summary>
        /// <p>自定义模式quuid列表</p>
        /// </summary>
        [JsonProperty("CustomModeQuuids")]
        public string[] CustomModeQuuids{ get; set; }

        /// <summary>
        /// <p>日志增强开关,0：关闭，1：打开</p>
        /// </summary>
        [JsonProperty("EnhanceLogMode")]
        public ulong? EnhanceLogMode{ get; set; }

        /// <summary>
        /// <p>文件查杀自动poc模式开关，0：关闭，1：打开</p>
        /// </summary>
        [JsonProperty("MalwarePocMode")]
        public ulong? MalwarePocMode{ get; set; }

        /// <summary>
        /// <p>五元组日志是否上报源端口，0：不上报，1：上报</p>
        /// </summary>
        [JsonProperty("ReportSourcePort")]
        public ulong? ReportSourcePort{ get; set; }

        /// <summary>
        /// <p>业务优先配置</p>
        /// </summary>
        [JsonProperty("BasicPolicy")]
        public CustomAgentRunModePolicy BasicPolicy{ get; set; }

        /// <summary>
        /// <p>安全优先配置</p>
        /// </summary>
        [JsonProperty("AdvancePolicy")]
        public CustomAgentRunModePolicy AdvancePolicy{ get; set; }

        /// <summary>
        /// <p>日志采集设置，采集TCP源端口tcp_src_port，TCP入向日志tcp_ingress，HTTP出向连接日志http_egress，HTTP入向连接日志http_ingress，应用访问日志app_access</p>
        /// </summary>
        [JsonProperty("LogCollectSettings")]
        public string[] LogCollectSettings{ get; set; }

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
            this.SetParamObj(map, prefix + "CustomPolicy.", this.CustomPolicy);
            this.SetParamArraySimple(map, prefix + "AdvanceModeQuuids.", this.AdvanceModeQuuids);
            this.SetParamArraySimple(map, prefix + "CustomModeQuuids.", this.CustomModeQuuids);
            this.SetParamSimple(map, prefix + "EnhanceLogMode", this.EnhanceLogMode);
            this.SetParamSimple(map, prefix + "MalwarePocMode", this.MalwarePocMode);
            this.SetParamSimple(map, prefix + "ReportSourcePort", this.ReportSourcePort);
            this.SetParamObj(map, prefix + "BasicPolicy.", this.BasicPolicy);
            this.SetParamObj(map, prefix + "AdvancePolicy.", this.AdvancePolicy);
            this.SetParamArraySimple(map, prefix + "LogCollectSettings.", this.LogCollectSettings);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

