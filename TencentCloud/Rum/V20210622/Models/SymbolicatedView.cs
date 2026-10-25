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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SymbolicatedView : AbstractModel
    {
        
        /// <summary>
        /// <p>符号化版本</p>
        /// </summary>
        [JsonProperty("SymbolicationVersion")]
        public long? SymbolicationVersion{ get; set; }

        /// <summary>
        /// <p>符号化时间</p>
        /// </summary>
        [JsonProperty("SymbolicatedAt")]
        public string SymbolicatedAt{ get; set; }

        /// <summary>
        /// <p>状态：success / missing / skipped</p>
        /// </summary>
        [JsonProperty("SymbolicationStatus")]
        public string SymbolicationStatus{ get; set; }

        /// <summary>
        /// <p>跳过原因</p>
        /// </summary>
        [JsonProperty("SymbolicationSkipReason")]
        public string SymbolicationSkipReason{ get; set; }

        /// <summary>
        /// <p>来源</p>
        /// </summary>
        [JsonProperty("SymbolicationSource")]
        public string SymbolicationSource{ get; set; }

        /// <summary>
        /// <p>release</p>
        /// </summary>
        [JsonProperty("SymbolicationRelease")]
        public string SymbolicationRelease{ get; set; }

        /// <summary>
        /// <p>dist</p>
        /// </summary>
        [JsonProperty("SymbolicationDist")]
        public string SymbolicationDist{ get; set; }

        /// <summary>
        /// <p>耗时毫秒</p>
        /// </summary>
        [JsonProperty("SymbolicationDurationMs")]
        public long? SymbolicationDurationMs{ get; set; }

        /// <summary>
        /// <p>Symbolicator 请求 ID</p>
        /// </summary>
        [JsonProperty("SymbolicatorRequestId")]
        public string SymbolicatorRequestId{ get; set; }

        /// <summary>
        /// <p>翻译后堆栈帧</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Frames")]
        public EventFrame[] Frames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SymbolicationVersion", this.SymbolicationVersion);
            this.SetParamSimple(map, prefix + "SymbolicatedAt", this.SymbolicatedAt);
            this.SetParamSimple(map, prefix + "SymbolicationStatus", this.SymbolicationStatus);
            this.SetParamSimple(map, prefix + "SymbolicationSkipReason", this.SymbolicationSkipReason);
            this.SetParamSimple(map, prefix + "SymbolicationSource", this.SymbolicationSource);
            this.SetParamSimple(map, prefix + "SymbolicationRelease", this.SymbolicationRelease);
            this.SetParamSimple(map, prefix + "SymbolicationDist", this.SymbolicationDist);
            this.SetParamSimple(map, prefix + "SymbolicationDurationMs", this.SymbolicationDurationMs);
            this.SetParamSimple(map, prefix + "SymbolicatorRequestId", this.SymbolicatorRequestId);
            this.SetParamArrayObj(map, prefix + "Frames.", this.Frames);
        }
    }
}

