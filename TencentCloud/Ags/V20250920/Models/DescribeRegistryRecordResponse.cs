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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRegistryRecordResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>Record 元数据和全部 Label。</p>
        /// </summary>
        [JsonProperty("Record")]
        public CloudRecord Record{ get; set; }

        /// <summary>
        /// <p>根据 VersionId / Label 解析得到的完整 Version。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Version")]
        public CloudRecordVersion Version{ get; set; }

        /// <summary>
        /// <p>解析方式：DEFAULT_STABLE / LABEL / VERSION_ID。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResolvedBy")]
        public string ResolvedBy{ get; set; }

        /// <summary>
        /// <p>通过 Label 解析（ResolvedBy=LABEL 或 DEFAULT_STABLE）时返回该 Label 名称，例如 stable。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResolvedLabel")]
        public string ResolvedLabel{ get; set; }

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
            this.SetParamObj(map, prefix + "Record.", this.Record);
            this.SetParamObj(map, prefix + "Version.", this.Version);
            this.SetParamSimple(map, prefix + "ResolvedBy", this.ResolvedBy);
            this.SetParamSimple(map, prefix + "ResolvedLabel", this.ResolvedLabel);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

