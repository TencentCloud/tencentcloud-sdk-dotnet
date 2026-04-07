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

    public class AdBreakInfo : AbstractModel
    {
        
        /// <summary>
        /// SourceLocationId。
        /// </summary>
        [JsonProperty("SourceLocationId")]
        public string SourceLocationId{ get; set; }

        /// <summary>
        /// VodSourceName。
        /// </summary>
        [JsonProperty("VodSourceName")]
        public string VodSourceName{ get; set; }

        /// <summary>
        /// Offset。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// MessageType，分SpliceInsert和TimeSignal。
        /// </summary>
        [JsonProperty("MessageType")]
        public string MessageType{ get; set; }

        /// <summary>
        /// TimeSignalConf。
        /// </summary>
        [JsonProperty("TimeSignalConf")]
        public TimeSignalInfo TimeSignalConf{ get; set; }

        /// <summary>
        /// SpliceInsertConf。
        /// </summary>
        [JsonProperty("SpliceInsertConf")]
        public SpliceInsertInfo SpliceInsertConf{ get; set; }

        /// <summary>
        /// Metadatas。
        /// </summary>
        [JsonProperty("Metadatas")]
        public Metadata[] Metadatas{ get; set; }

        /// <summary>
        /// SourceLocationName。
        /// </summary>
        [JsonProperty("SourceLocationName")]
        public string SourceLocationName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceLocationId", this.SourceLocationId);
            this.SetParamSimple(map, prefix + "VodSourceName", this.VodSourceName);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "MessageType", this.MessageType);
            this.SetParamObj(map, prefix + "TimeSignalConf.", this.TimeSignalConf);
            this.SetParamObj(map, prefix + "SpliceInsertConf.", this.SpliceInsertConf);
            this.SetParamArrayObj(map, prefix + "Metadatas.", this.Metadatas);
            this.SetParamSimple(map, prefix + "SourceLocationName", this.SourceLocationName);
        }
    }
}

