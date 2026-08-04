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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>流程ID（数据库主键）</p>
        /// </summary>
        [JsonProperty("FlowId")]
        public long? FlowId{ get; set; }

        /// <summary>
        /// <p>Temporal Workflow ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkFlowId")]
        public string WorkFlowId{ get; set; }

        /// <summary>
        /// <p>流程编码</p>
        /// </summary>
        [JsonProperty("WorkFlowCode")]
        public string WorkFlowCode{ get; set; }

        /// <summary>
        /// <p>流程进度，0~100</p>
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// <p>流程状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>流程活动列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Activities")]
        public FlowActivityDetail[] Activities{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "WorkFlowId", this.WorkFlowId);
            this.SetParamSimple(map, prefix + "WorkFlowCode", this.WorkFlowCode);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "Activities.", this.Activities);
        }
    }
}

