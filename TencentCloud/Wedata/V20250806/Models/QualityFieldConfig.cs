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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QualityFieldConfig : AbstractModel
    {
        
        /// <summary>
        /// 字段key
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FieldKey")]
        public string FieldKey{ get; set; }

        /// <summary>
        /// 字段值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FieldValue")]
        public string FieldValue{ get; set; }

        /// <summary>
        /// 字段值类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FieldDataType")]
        public string FieldDataType{ get; set; }

        /// <summary>
        /// 字段值变量信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueConfig")]
        public QualityColumnValueConfig ValueConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FieldKey", this.FieldKey);
            this.SetParamSimple(map, prefix + "FieldValue", this.FieldValue);
            this.SetParamSimple(map, prefix + "FieldDataType", this.FieldDataType);
            this.SetParamObj(map, prefix + "ValueConfig.", this.ValueConfig);
        }
    }
}

