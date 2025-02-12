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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrafficMirrorFilter : AbstractModel
    {
        
        /// <summary>
        /// 过滤规则的源网段
        /// </summary>
        [JsonProperty("SrcNet")]
        public string SrcNet{ get; set; }

        /// <summary>
        /// 过滤规则的目的网段
        /// </summary>
        [JsonProperty("DstNet")]
        public string DstNet{ get; set; }

        /// <summary>
        /// 过滤规则的协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 过滤规则的源端口，默认值1-65535
        /// </summary>
        [JsonProperty("SrcPort")]
        public string SrcPort{ get; set; }

        /// <summary>
        /// 过滤规则的目的端口，默认值1-65535
        /// </summary>
        [JsonProperty("DstPort")]
        public string DstPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcNet", this.SrcNet);
            this.SetParamSimple(map, prefix + "DstNet", this.DstNet);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "SrcPort", this.SrcPort);
            this.SetParamSimple(map, prefix + "DstPort", this.DstPort);
        }
    }
}

