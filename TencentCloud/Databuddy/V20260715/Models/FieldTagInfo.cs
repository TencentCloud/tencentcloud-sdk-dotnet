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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FieldTagInfo : AbstractModel
    {
        
        /// <summary>
        /// 字段名称（必填）；清除标记场景（LabelId=-1）下为待清除字段名
        /// </summary>
        [JsonProperty("FieldName")]
        public string FieldName{ get; set; }

        /// <summary>
        /// <p>标签ID</p><p>特殊值：-1 表示「清除标记」，仅在 BatchAttachAssetTag 接口中生效：服务端会清除该 FieldName 下所有已有字段标签。使用 -1 时 FieldName 必填，其余字段可留空。</p>
        /// </summary>
        [JsonProperty("LabelId")]
        public string LabelId{ get; set; }

        /// <summary>
        /// 标签名称（可选）
        /// </summary>
        [JsonProperty("LabelName")]
        public string LabelName{ get; set; }

        /// <summary>
        /// <p>标签类型</p><p>枚举值：</p><ul><li>1：GOVERNANCE_LABEL：治理标签</li><li>2：CUSTOM_LABEL：自定义标签</li><li>3：PROPERTY_LABEL：属性标签</li><li>4：DESENSITIZATION_LABEL：脱敏标签</li></ul><p>字段打标规则：非脱敏标签（1/2/3）时 LabelValue 必填；脱敏标签（4）时 LabelValue 可为空</p>
        /// </summary>
        [JsonProperty("LabelType")]
        public long? LabelType{ get; set; }

        /// <summary>
        /// 字段类型（可选），如 string、int、bigint 等
        /// </summary>
        [JsonProperty("FieldType")]
        public string FieldType{ get; set; }

        /// <summary>
        /// 标签值ID（可选）；非脱敏标签（LabelType!=4）建议填充；属性标签（LabelType=3）可为0；脱敏标签（LabelType=4）及清除标记（LabelId=-1）场景可留空
        /// </summary>
        [JsonProperty("LabelValueId")]
        public string LabelValueId{ get; set; }

        /// <summary>
        /// 标签值；非脱敏标签（LabelType!=4）必填，例如治理/自定义/属性标签均需携带业务语义值；脱敏标签（LabelType=4）及清除标记（LabelId=-1）场景可为空
        /// </summary>
        [JsonProperty("LabelValue")]
        public string LabelValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FieldName", this.FieldName);
            this.SetParamSimple(map, prefix + "LabelId", this.LabelId);
            this.SetParamSimple(map, prefix + "LabelName", this.LabelName);
            this.SetParamSimple(map, prefix + "LabelType", this.LabelType);
            this.SetParamSimple(map, prefix + "FieldType", this.FieldType);
            this.SetParamSimple(map, prefix + "LabelValueId", this.LabelValueId);
            this.SetParamSimple(map, prefix + "LabelValue", this.LabelValue);
        }
    }
}

