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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowInOutResp : AbstractModel
    {
        
        /// <summary>
        /// 流Id。
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 流名称。
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 该Flow关联的媒体传输事件EventId。
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// 媒体传输输入流所属的区域，取值和InputRegion相同。
        /// </summary>
        [JsonProperty("FlowRegion")]
        public string FlowRegion{ get; set; }

        /// <summary>
        /// 当返回是输出类型时非空，output所在Region。
        /// </summary>
        [JsonProperty("OutputRegion")]
        public string OutputRegion{ get; set; }

        /// <summary>
        /// EventName。
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// InOutType为Input有效。
        /// </summary>
        [JsonProperty("InputName")]
        public string InputName{ get; set; }

        /// <summary>
        /// InOutType为Output有效。
        /// </summary>
        [JsonProperty("OutputName")]
        public string OutputName{ get; set; }

        /// <summary>
        /// Input或者Output的Id。
        /// </summary>
        [JsonProperty("InOutId")]
        public string InOutId{ get; set; }

        /// <summary>
        /// 输入/输出类型，可选值：
        /// Input：输入
        /// Outpu：输出。
        /// </summary>
        [JsonProperty("InOutType")]
        public string InOutType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "FlowRegion", this.FlowRegion);
            this.SetParamSimple(map, prefix + "OutputRegion", this.OutputRegion);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "InputName", this.InputName);
            this.SetParamSimple(map, prefix + "OutputName", this.OutputName);
            this.SetParamSimple(map, prefix + "InOutId", this.InOutId);
            this.SetParamSimple(map, prefix + "InOutType", this.InOutType);
        }
    }
}

