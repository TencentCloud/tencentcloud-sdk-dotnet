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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MongoAsset : AbstractModel
    {
        
        /// <summary>
        /// DB总数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbNums")]
        public long? DbNums{ get; set; }

        /// <summary>
        /// 敏感DB数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveDbNums")]
        public long? SensitiveDbNums{ get; set; }

        /// <summary>
        /// 集合数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColNums")]
        public long? ColNums{ get; set; }

        /// <summary>
        /// 敏感集合的数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveColNums")]
        public long? SensitiveColNums{ get; set; }

        /// <summary>
        /// 字段数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FieldNums")]
        public long? FieldNums{ get; set; }

        /// <summary>
        /// 敏感的字段数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SensitiveFieldNums")]
        public long? SensitiveFieldNums{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DbNums", this.DbNums);
            this.SetParamSimple(map, prefix + "SensitiveDbNums", this.SensitiveDbNums);
            this.SetParamSimple(map, prefix + "ColNums", this.ColNums);
            this.SetParamSimple(map, prefix + "SensitiveColNums", this.SensitiveColNums);
            this.SetParamSimple(map, prefix + "FieldNums", this.FieldNums);
            this.SetParamSimple(map, prefix + "SensitiveFieldNums", this.SensitiveFieldNums);
        }
    }
}

