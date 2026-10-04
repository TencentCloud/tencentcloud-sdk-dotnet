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

    public class CommonTagInfo : AbstractModel
    {
        
        /// <summary>
        /// 标签ID
        /// </summary>
        [JsonProperty("LabelId")]
        public string LabelId{ get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonProperty("LabelName")]
        public string LabelName{ get; set; }

        /// <summary>
        /// 标签值ID，属性标签（LabelType=3）可为0
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelValueId")]
        public string LabelValueId{ get; set; }

        /// <summary>
        /// 标签值，脱敏标签（LabelType=4）时可为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LabelValue")]
        public string LabelValue{ get; set; }

        /// <summary>
        /// 标签类型，取值参考LabelType枚举定义：1-治理标签，2-自定义标签，3-属性标签，4-脱敏标签
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 标签是否已删除。true表示该LabelId在meta_biz_label中查不到记录，标签已被物理删除；false（默认）表示标签仍存在
        /// </summary>
        [JsonProperty("Deleted")]
        public bool? Deleted{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LabelId", this.LabelId);
            this.SetParamSimple(map, prefix + "LabelName", this.LabelName);
            this.SetParamSimple(map, prefix + "LabelValueId", this.LabelValueId);
            this.SetParamSimple(map, prefix + "LabelValue", this.LabelValue);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Deleted", this.Deleted);
        }
    }
}

