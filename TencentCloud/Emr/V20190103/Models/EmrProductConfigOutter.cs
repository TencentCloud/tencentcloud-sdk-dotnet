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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EmrProductConfigOutter : AbstractModel
    {
        
        /// <summary>
        /// 软件信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SoftInfo")]
        public string[] SoftInfo{ get; set; }

        /// <summary>
        /// Master节点个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MasterNodeSize")]
        public long? MasterNodeSize{ get; set; }

        /// <summary>
        /// Core节点个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CoreNodeSize")]
        public long? CoreNodeSize{ get; set; }

        /// <summary>
        /// Task节点个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskNodeSize")]
        public long? TaskNodeSize{ get; set; }

        /// <summary>
        /// Common节点个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComNodeSize")]
        public long? ComNodeSize{ get; set; }

        /// <summary>
        /// Master节点资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MasterResource")]
        public OutterResource MasterResource{ get; set; }

        /// <summary>
        /// Core节点资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CoreResource")]
        public OutterResource CoreResource{ get; set; }

        /// <summary>
        /// Task节点资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskResource")]
        public OutterResource TaskResource{ get; set; }

        /// <summary>
        /// Common节点资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComResource")]
        public OutterResource ComResource{ get; set; }

        /// <summary>
        /// 是否使用COS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OnCos")]
        public bool? OnCos{ get; set; }

        /// <summary>
        /// 收费类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChargeType")]
        public long? ChargeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SoftInfo.", this.SoftInfo);
            this.SetParamSimple(map, prefix + "MasterNodeSize", this.MasterNodeSize);
            this.SetParamSimple(map, prefix + "CoreNodeSize", this.CoreNodeSize);
            this.SetParamSimple(map, prefix + "TaskNodeSize", this.TaskNodeSize);
            this.SetParamSimple(map, prefix + "ComNodeSize", this.ComNodeSize);
            this.SetParamObj(map, prefix + "MasterResource.", this.MasterResource);
            this.SetParamObj(map, prefix + "CoreResource.", this.CoreResource);
            this.SetParamObj(map, prefix + "TaskResource.", this.TaskResource);
            this.SetParamObj(map, prefix + "ComResource.", this.ComResource);
            this.SetParamSimple(map, prefix + "OnCos", this.OnCos);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
        }
    }
}

