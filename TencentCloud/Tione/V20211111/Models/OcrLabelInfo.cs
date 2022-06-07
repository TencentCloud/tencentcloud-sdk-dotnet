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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OcrLabelInfo : AbstractModel
    {
        
        /// <summary>
        /// 坐标点围起来的框
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Points")]
        public PointInfo[] Points{ get; set; }

        /// <summary>
        /// 框的形状：
        /// FRAME_TYPE_RECTANGLE
        /// FRAME_TYPE_POLYGON
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrameType")]
        public string FrameType{ get; set; }

        /// <summary>
        /// 智能结构化：key区域对应的内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 智能结构化：上述key的ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 识别：框区域的内容
        /// 智能结构化：value区域对应的内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// 智能结构化：value区域所关联的key 区域的keyID的集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeyIdsForValue")]
        public string[] KeyIdsForValue{ get; set; }

        /// <summary>
        /// key或者value区域内容的方向：
        /// DIRECTION_VERTICAL
        /// DIRECTION_HORIZONTAL
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Points.", this.Points);
            this.SetParamSimple(map, prefix + "FrameType", this.FrameType);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamArraySimple(map, prefix + "KeyIdsForValue.", this.KeyIdsForValue);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
        }
    }
}

