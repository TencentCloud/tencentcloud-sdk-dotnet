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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDefenseSwitchResponse : AbstractModel
    {
        
        /// <summary>
        /// 基础防御开关
        /// </summary>
        [JsonProperty("BasicRuleSwitch")]
        public long? BasicRuleSwitch{ get; set; }

        /// <summary>
        /// 安全基线开关
        /// </summary>
        [JsonProperty("BaselineAllSwitch")]
        public long? BaselineAllSwitch{ get; set; }

        /// <summary>
        /// 威胁情报开关
        /// </summary>
        [JsonProperty("TiSwitch")]
        public long? TiSwitch{ get; set; }

        /// <summary>
        /// 虚拟补丁开关
        /// </summary>
        [JsonProperty("VirtualPatchSwitch")]
        public long? VirtualPatchSwitch{ get; set; }

        /// <summary>
        /// 是否历史开启
        /// </summary>
        [JsonProperty("HistoryOpen")]
        public long? HistoryOpen{ get; set; }

        /// <summary>
        /// 状态值，0：查询成功，非0：查询失败
        /// </summary>
        [JsonProperty("ReturnCode")]
        public long? ReturnCode{ get; set; }

        /// <summary>
        /// 状态信息，success：查询成功，fail：查询失败
        /// </summary>
        [JsonProperty("ReturnMsg")]
        public string ReturnMsg{ get; set; }

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
            this.SetParamSimple(map, prefix + "BasicRuleSwitch", this.BasicRuleSwitch);
            this.SetParamSimple(map, prefix + "BaselineAllSwitch", this.BaselineAllSwitch);
            this.SetParamSimple(map, prefix + "TiSwitch", this.TiSwitch);
            this.SetParamSimple(map, prefix + "VirtualPatchSwitch", this.VirtualPatchSwitch);
            this.SetParamSimple(map, prefix + "HistoryOpen", this.HistoryOpen);
            this.SetParamSimple(map, prefix + "ReturnCode", this.ReturnCode);
            this.SetParamSimple(map, prefix + "ReturnMsg", this.ReturnMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

