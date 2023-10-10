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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 全文索引的相关配置
        /// </summary>
        [JsonProperty("FullText")]
        public FullTextInfo FullText{ get; set; }

        /// <summary>
        /// 键值索引的相关配置
        /// </summary>
        [JsonProperty("KeyValue")]
        public KeyValueInfo KeyValue{ get; set; }

        /// <summary>
        /// 元字段索引配置
        /// </summary>
        [JsonProperty("Tag")]
        public KeyValueInfo Tag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FullText.", this.FullText);
            this.SetParamObj(map, prefix + "KeyValue.", this.KeyValue);
            this.SetParamObj(map, prefix + "Tag.", this.Tag);
        }
    }
}

