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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIndexResponse : AbstractModel
    {
        
        /// <summary>
        /// 日志主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 是否生效
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// 索引配置信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Rule")]
        public RuleInfo Rule{ get; set; }

        /// <summary>
        /// 索引修改时间，初始值为索引创建时间。
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 内置保留字段（`__FILENAME__`，`__HOSTNAME__`及`__SOURCE__`）是否包含至全文索引
        /// * false:不包含
        /// * true:包含
        /// </summary>
        [JsonProperty("IncludeInternalFields")]
        public bool? IncludeInternalFields{ get; set; }

        /// <summary>
        /// 元数据字段（前缀为`__TAG__`的字段）是否包含至全文索引
        /// * 0:仅包含开启键值索引的元数据字段
        /// * 1:包含所有元数据字段
        /// * 2:不包含任何元数据字段
        /// </summary>
        [JsonProperty("MetadataFlag")]
        public ulong? MetadataFlag{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Rule.", this.Rule);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "IncludeInternalFields", this.IncludeInternalFields);
            this.SetParamSimple(map, prefix + "MetadataFlag", this.MetadataFlag);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

