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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloneInstanceModel : AbstractModel
    {
        
        /// <summary>
        /// 克隆任务结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloneEndTime")]
        public string CloneEndTime{ get; set; }

        /// <summary>
        /// 克隆记录ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloneId")]
        public long? CloneId{ get; set; }

        /// <summary>
        /// 克隆实例类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloneInsType")]
        public string CloneInsType{ get; set; }

        /// <summary>
        /// 克隆实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloneInstanceId")]
        public string CloneInstanceId{ get; set; }

        /// <summary>
        /// 克隆实例是否已经删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloneInstanceIsDeleted")]
        public bool? CloneInstanceIsDeleted{ get; set; }

        /// <summary>
        /// 克隆任务进度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloneProgress")]
        public float? CloneProgress{ get; set; }

        /// <summary>
        /// 克隆任务开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloneStartTime")]
        public string CloneStartTime{ get; set; }

        /// <summary>
        /// 克隆任务状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloneStatus")]
        public string CloneStatus{ get; set; }

        /// <summary>
        /// 克隆时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloneTime")]
        public string CloneTime{ get; set; }

        /// <summary>
        /// 克隆类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloneType")]
        public string CloneType{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 引擎类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DBType")]
        public string DBType{ get; set; }

        /// <summary>
        /// 地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 源实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceInstanceId")]
        public string SourceInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CloneEndTime", this.CloneEndTime);
            this.SetParamSimple(map, prefix + "CloneId", this.CloneId);
            this.SetParamSimple(map, prefix + "CloneInsType", this.CloneInsType);
            this.SetParamSimple(map, prefix + "CloneInstanceId", this.CloneInstanceId);
            this.SetParamSimple(map, prefix + "CloneInstanceIsDeleted", this.CloneInstanceIsDeleted);
            this.SetParamSimple(map, prefix + "CloneProgress", this.CloneProgress);
            this.SetParamSimple(map, prefix + "CloneStartTime", this.CloneStartTime);
            this.SetParamSimple(map, prefix + "CloneStatus", this.CloneStatus);
            this.SetParamSimple(map, prefix + "CloneTime", this.CloneTime);
            this.SetParamSimple(map, prefix + "CloneType", this.CloneType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DBType", this.DBType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "SourceInstanceId", this.SourceInstanceId);
        }
    }
}

