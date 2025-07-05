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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtResourceFlagDto : AbstractModel
    {
        
        /// <summary>
        /// 父任务信息获取标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentTask")]
        public bool? ParentTask{ get; set; }

        /// <summary>
        /// 生产事件获取标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventListener")]
        public string EventListener{ get; set; }

        /// <summary>
        /// Dlc相关配置获取标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DlcResourceConfig")]
        public string DlcResourceConfig{ get; set; }

        /// <summary>
        /// 脚本信息获取标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Script")]
        public string Script{ get; set; }

        /// <summary>
        /// 离线任务信息获取标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OfflineSyncTask")]
        public string OfflineSyncTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParentTask", this.ParentTask);
            this.SetParamSimple(map, prefix + "EventListener", this.EventListener);
            this.SetParamSimple(map, prefix + "DlcResourceConfig", this.DlcResourceConfig);
            this.SetParamSimple(map, prefix + "Script", this.Script);
            this.SetParamSimple(map, prefix + "OfflineSyncTask", this.OfflineSyncTask);
        }
    }
}

