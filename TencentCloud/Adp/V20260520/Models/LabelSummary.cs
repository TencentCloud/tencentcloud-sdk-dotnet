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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LabelSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>标签 ID</p>
        /// </summary>
        [JsonProperty("LabelId")]
        public string LabelId{ get; set; }

        /// <summary>
        /// <p>元数据配置（该标签被设置为元数据时的配置信息）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetaValue")]
        public MetaValue MetaValue{ get; set; }

        /// <summary>
        /// <p>标签名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>引用该标签的资源数</p>
        /// </summary>
        [JsonProperty("RefCount")]
        public ulong? RefCount{ get; set; }

        /// <summary>
        /// <p>标签值（标准词 + 同义词列表）</p>
        /// </summary>
        [JsonProperty("TermList")]
        public LabelTerm[] TermList{ get; set; }

        /// <summary>
        /// <p>标签值总数</p>
        /// </summary>
        [JsonProperty("TermTotalCount")]
        public ulong? TermTotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LabelId", this.LabelId);
            this.SetParamObj(map, prefix + "MetaValue.", this.MetaValue);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RefCount", this.RefCount);
            this.SetParamArrayObj(map, prefix + "TermList.", this.TermList);
            this.SetParamSimple(map, prefix + "TermTotalCount", this.TermTotalCount);
        }
    }
}

