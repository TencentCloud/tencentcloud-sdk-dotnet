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

    public class AiRecognitionTaskFaceResultItem : AbstractModel
    {
        
        /// <summary>
        /// 人物唯一标识 ID。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 人物库类型，表示识别出的人物来自哪个人物库：
        /// <li>Default：默认人物库；</li>
        /// <li>UserDefine：用户自定义人物库。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 人物名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 人物出现的片段结果集。
        /// </summary>
        [JsonProperty("SegmentSet")]
        public AiRecognitionTaskFaceSegmentItem[] SegmentSet{ get; set; }

        /// <summary>
        /// 人物性别：
        /// <li>Male：男性；</li>
        /// <li>Female：女性。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// 人物出生日期。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }

        /// <summary>
        /// 人物职业或者职务。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Profession")]
        public string Profession{ get; set; }

        /// <summary>
        /// 人物毕业院校。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchoolOfGraduation")]
        public string SchoolOfGraduation{ get; set; }

        /// <summary>
        /// 人物简介。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Abstract")]
        public string Abstract{ get; set; }

        /// <summary>
        /// 人物出生地或者籍贯。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlaceOfBirth")]
        public string PlaceOfBirth{ get; set; }

        /// <summary>
        /// 人物类型：
        /// <li>Politician：官员；</li>
        /// <li>Artist：艺人。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PersonType")]
        public string PersonType{ get; set; }

        /// <summary>
        /// 敏感度标注：
        /// <li>Normal：正常；</li>
        /// <li>Sensitive：敏感。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 截图链接
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "SegmentSet.", this.SegmentSet);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Birthday", this.Birthday);
            this.SetParamSimple(map, prefix + "Profession", this.Profession);
            this.SetParamSimple(map, prefix + "SchoolOfGraduation", this.SchoolOfGraduation);
            this.SetParamSimple(map, prefix + "Abstract", this.Abstract);
            this.SetParamSimple(map, prefix + "PlaceOfBirth", this.PlaceOfBirth);
            this.SetParamSimple(map, prefix + "PersonType", this.PersonType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

