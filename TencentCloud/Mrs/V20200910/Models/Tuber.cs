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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Tuber : AbstractModel
    {
        
        /// <summary>
        /// 部位信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Part")]
        public Attribute Part{ get; set; }

        /// <summary>
        /// 类型信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public Attribute Type{ get; set; }

        /// <summary>
        /// 大小信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SizeList")]
        public Attribute[] SizeList{ get; set; }

        /// <summary>
        /// 形态信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Shape")]
        public Attribute Shape{ get; set; }

        /// <summary>
        /// 边缘信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Edge")]
        public Attribute Edge{ get; set; }

        /// <summary>
        /// CDFI信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CDFI")]
        public Attribute CDFI{ get; set; }

        /// <summary>
        /// 代谢信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Metabolism")]
        public Attribute Metabolism{ get; set; }

        /// <summary>
        /// 淋巴结信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LymphGland")]
        public Attribute LymphGland{ get; set; }

        /// <summary>
        /// 淋巴门信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LymphDoor")]
        public Attribute LymphDoor{ get; set; }

        /// <summary>
        /// 皮髓质信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SkinMedulla")]
        public Attribute SkinMedulla{ get; set; }

        /// <summary>
        /// 内部回声信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerEcho")]
        public Attribute InnerEcho{ get; set; }

        /// <summary>
        /// 外部回声信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RearEcho")]
        public Attribute RearEcho{ get; set; }

        /// <summary>
        /// 包膜信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Envelope")]
        public Attribute Envelope{ get; set; }

        /// <summary>
        /// 钙化信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Calcification")]
        public Attribute Calcification{ get; set; }

        /// <summary>
        /// 强化信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Enhancement")]
        public Attribute Enhancement{ get; set; }

        /// <summary>
        /// 纵横比信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AspectRatio")]
        public Attribute AspectRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Part.", this.Part);
            this.SetParamObj(map, prefix + "Type.", this.Type);
            this.SetParamArrayObj(map, prefix + "SizeList.", this.SizeList);
            this.SetParamObj(map, prefix + "Shape.", this.Shape);
            this.SetParamObj(map, prefix + "Edge.", this.Edge);
            this.SetParamObj(map, prefix + "CDFI.", this.CDFI);
            this.SetParamObj(map, prefix + "Metabolism.", this.Metabolism);
            this.SetParamObj(map, prefix + "LymphGland.", this.LymphGland);
            this.SetParamObj(map, prefix + "LymphDoor.", this.LymphDoor);
            this.SetParamObj(map, prefix + "SkinMedulla.", this.SkinMedulla);
            this.SetParamObj(map, prefix + "InnerEcho.", this.InnerEcho);
            this.SetParamObj(map, prefix + "RearEcho.", this.RearEcho);
            this.SetParamObj(map, prefix + "Envelope.", this.Envelope);
            this.SetParamObj(map, prefix + "Calcification.", this.Calcification);
            this.SetParamObj(map, prefix + "Enhancement.", this.Enhancement);
            this.SetParamObj(map, prefix + "AspectRatio.", this.AspectRatio);
        }
    }
}

