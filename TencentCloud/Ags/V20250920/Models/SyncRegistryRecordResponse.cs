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

    public class SyncRegistryRecordResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>同步结果：UNCHANGED（远端无变化）/ VERSION_CREATED（远端有变化，已生成新 Version）/ FAILED（同步失败）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SyncStatus")]
        public string SyncStatus{ get; set; }

        /// <summary>
        /// <p>作为同步来源解析出的 Version ID（可能由 Label 解析而来）；不为空。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResolvedVersionId")]
        public string ResolvedVersionId{ get; set; }

        /// <summary>
        /// <p>SyncStatus=VERSION_CREATED 时返回：本次新建的 Version。</p>
        /// </summary>
        [JsonProperty("CreatedVersion")]
        public CloudRecordVersion CreatedVersion{ get; set; }

        /// <summary>
        /// <p>SyncStatus=VERSION_CREATED 时返回：同步后的最新 Record。</p>
        /// </summary>
        [JsonProperty("Record")]
        public CloudRecord Record{ get; set; }

        /// <summary>
        /// <p>最后一次同步时间，ISO 8601 UTC。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastSyncTime")]
        public string LastSyncTime{ get; set; }

        /// <summary>
        /// <p>失败错误码；SyncStatus=FAILED 时返回。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorCode")]
        public string ErrorCode{ get; set; }

        /// <summary>
        /// <p>失败错误信息；SyncStatus=FAILED 时返回。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

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
            this.SetParamSimple(map, prefix + "SyncStatus", this.SyncStatus);
            this.SetParamSimple(map, prefix + "ResolvedVersionId", this.ResolvedVersionId);
            this.SetParamObj(map, prefix + "CreatedVersion.", this.CreatedVersion);
            this.SetParamObj(map, prefix + "Record.", this.Record);
            this.SetParamSimple(map, prefix + "LastSyncTime", this.LastSyncTime);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

