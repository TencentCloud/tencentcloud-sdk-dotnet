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

    public class CreateIndexRequest : AbstractModel
    {
        
        /// <summary>
        /// 日志主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 索引规则
        /// </summary>
        [JsonProperty("Rule")]
        public RuleInfo Rule{ get; set; }

        /// <summary>
        /// 是否生效，默认为true
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// 全文索引系统预置字段标记，默认false。  false:不包含系统预置字段， true:包含系统预置字段
        /// </summary>
        [JsonProperty("IncludeInternalFields")]
        public bool? IncludeInternalFields{ get; set; }

        /// <summary>
        /// 元数据相关标志位，默认为0。 0：全文索引包括开启键值索引的元数据字段， 1：全文索引包括所有元数据字段，2：全文索引不包括元数据字段。
        /// </summary>
        [JsonProperty("MetadataFlag")]
        public ulong? MetadataFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamObj(map, prefix + "Rule.", this.Rule);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IncludeInternalFields", this.IncludeInternalFields);
            this.SetParamSimple(map, prefix + "MetadataFlag", this.MetadataFlag);
        }
    }
}

