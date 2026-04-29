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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FieldsInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>用户自定义的提取字段名。</p>
        /// </summary>
        [JsonProperty("KeyName")]
        public string KeyName{ get; set; }

        /// <summary>
        /// <p>用户自定义的提取字段名的提示词。</p>
        /// </summary>
        [JsonProperty("KeyPrompt")]
        public string KeyPrompt{ get; set; }

        /// <summary>
        /// <p>出参字段对应的值。</p><p>注意：此字段可能返回 null，表示取不到有效值。</p>
        /// </summary>
        [JsonProperty("KeyValue")]
        public string KeyValue{ get; set; }

        /// <summary>
        /// <p>出参类型。</p><p>注：与入参对应同个值。</p>
        /// </summary>
        [JsonProperty("KeyType")]
        public long? KeyType{ get; set; }

        /// <summary>
        /// <p>文本行坐标，以四个顶点坐标表示。</p><p>注：仅当入参EnableCoord不为null时生效，默认是false。</p>
        /// </summary>
        [JsonProperty("Polygon")]
        public CoordList Polygon{ get; set; }

        /// <summary>
        /// <p>嵌套FieldsInfo结构，仅当KeyType=1时有效。</p>
        /// </summary>
        [JsonProperty("SubItems")]
        public SubItemGroup[] SubItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyName", this.KeyName);
            this.SetParamSimple(map, prefix + "KeyPrompt", this.KeyPrompt);
            this.SetParamSimple(map, prefix + "KeyValue", this.KeyValue);
            this.SetParamSimple(map, prefix + "KeyType", this.KeyType);
            this.SetParamObj(map, prefix + "Polygon.", this.Polygon);
            this.SetParamArrayObj(map, prefix + "SubItems.", this.SubItems);
        }
    }
}

