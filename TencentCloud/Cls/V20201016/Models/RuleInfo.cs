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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 全文索引配置, 如果为空时代表未开启全文索引
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FullText")]
        public FullTextInfo FullText{ get; set; }

        /// <summary>
        /// 键值索引配置，如果为空时代表未开启键值索引
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KeyValue")]
        public RuleKeyValueInfo KeyValue{ get; set; }

        /// <summary>
        /// 元字段索引配置，如果为空时代表未开启元字段索引
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tag")]
        public RuleTagInfo Tag{ get; set; }

        /// <summary>
        /// 动态索引配置，为空时代表未开启动态索引。
        /// 启用后将自动把日志内的字段添加到键值索引字段列表中，包括日志中新增的字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DynamicIndex")]
        public DynamicIndex DynamicIndex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FullText.", this.FullText);
            this.SetParamObj(map, prefix + "KeyValue.", this.KeyValue);
            this.SetParamObj(map, prefix + "Tag.", this.Tag);
            this.SetParamObj(map, prefix + "DynamicIndex.", this.DynamicIndex);
        }
    }
}

