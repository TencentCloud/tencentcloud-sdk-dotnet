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

namespace TencentCloud.Eb.V20210416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ESTargetParams : AbstractModel
    {
        
        /// <summary>
        /// <p>网络连接类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetMode")]
        public string NetMode{ get; set; }

        /// <summary>
        /// <p>索引前缀</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexPrefix")]
        public string IndexPrefix{ get; set; }

        /// <summary>
        /// <p>es日志轮换粒度</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RotationInterval")]
        public string RotationInterval{ get; set; }

        /// <summary>
        /// <p>DTS事件配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputMode")]
        public string OutputMode{ get; set; }

        /// <summary>
        /// <p>DTS索引配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexSuffixMode")]
        public string IndexSuffixMode{ get; set; }

        /// <summary>
        /// <p>es模版类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IndexTemplateType")]
        public string IndexTemplateType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetMode", this.NetMode);
            this.SetParamSimple(map, prefix + "IndexPrefix", this.IndexPrefix);
            this.SetParamSimple(map, prefix + "RotationInterval", this.RotationInterval);
            this.SetParamSimple(map, prefix + "OutputMode", this.OutputMode);
            this.SetParamSimple(map, prefix + "IndexSuffixMode", this.IndexSuffixMode);
            this.SetParamSimple(map, prefix + "IndexTemplateType", this.IndexTemplateType);
        }
    }
}

