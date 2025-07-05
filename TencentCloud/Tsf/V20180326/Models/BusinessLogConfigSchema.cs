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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BusinessLogConfigSchema : AbstractModel
    {
        
        /// <summary>
        /// 解析规则类型
        /// </summary>
        [JsonProperty("SchemaType")]
        public long? SchemaType{ get; set; }

        /// <summary>
        /// 解析规则内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchemaContent")]
        public string SchemaContent{ get; set; }

        /// <summary>
        /// 解析规则时间格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchemaDateFormat")]
        public string SchemaDateFormat{ get; set; }

        /// <summary>
        /// 解析规则对应的多行匹配规则
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchemaMultilinePattern")]
        public string SchemaMultilinePattern{ get; set; }

        /// <summary>
        /// 解析规则创建时间
        /// </summary>
        [JsonProperty("SchemaCreateTime")]
        public string SchemaCreateTime{ get; set; }

        /// <summary>
        /// 用户填写的解析规则
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchemaPatternLayout")]
        public string SchemaPatternLayout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SchemaType", this.SchemaType);
            this.SetParamSimple(map, prefix + "SchemaContent", this.SchemaContent);
            this.SetParamSimple(map, prefix + "SchemaDateFormat", this.SchemaDateFormat);
            this.SetParamSimple(map, prefix + "SchemaMultilinePattern", this.SchemaMultilinePattern);
            this.SetParamSimple(map, prefix + "SchemaCreateTime", this.SchemaCreateTime);
            this.SetParamSimple(map, prefix + "SchemaPatternLayout", this.SchemaPatternLayout);
        }
    }
}

