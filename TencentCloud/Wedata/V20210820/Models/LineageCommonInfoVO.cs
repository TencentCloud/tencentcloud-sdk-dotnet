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

    public class LineageCommonInfoVO : AbstractModel
    {
        
        /// <summary>
        /// 当前节点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentResource")]
        public LineageResouce CurrentResource{ get; set; }

        /// <summary>
        /// 上游节点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentSet")]
        public LineageNodeInfoVO[] ParentSet{ get; set; }

        /// <summary>
        /// 下游节点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChildSet")]
        public LineageNodeInfoVO[] ChildSet{ get; set; }

        /// <summary>
        /// 下游数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DownStreamCount")]
        public long? DownStreamCount{ get; set; }

        /// <summary>
        /// 上游数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpStreamCount")]
        public long? UpStreamCount{ get; set; }

        /// <summary>
        /// 父/子节点是否展示上下游数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StreamCountFlag")]
        public bool? StreamCountFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "CurrentResource.", this.CurrentResource);
            this.SetParamArrayObj(map, prefix + "ParentSet.", this.ParentSet);
            this.SetParamArrayObj(map, prefix + "ChildSet.", this.ChildSet);
            this.SetParamSimple(map, prefix + "DownStreamCount", this.DownStreamCount);
            this.SetParamSimple(map, prefix + "UpStreamCount", this.UpStreamCount);
            this.SetParamSimple(map, prefix + "StreamCountFlag", this.StreamCountFlag);
        }
    }
}

