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

namespace TencentCloud.Lowcode.V20210108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DocumentQuery : AbstractModel
    {
        
        /// <summary>
        /// 文件ids
        /// </summary>
        [JsonProperty("DocumentSetId")]
        public string[] DocumentSetId{ get; set; }

        /// <summary>
        /// 文件名集合
        /// </summary>
        [JsonProperty("DocumentSetName")]
        public string[] DocumentSetName{ get; set; }

        /// <summary>
        /// 使用创建 CollectionView 指定的 Filter 索引的字段设置查询过滤表达式
        /// </summary>
        [JsonProperty("Filter")]
        public string Filter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DocumentSetId.", this.DocumentSetId);
            this.SetParamArraySimple(map, prefix + "DocumentSetName.", this.DocumentSetName);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
        }
    }
}

