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

    public class PageQuery : AbstractModel
    {
        
        /// <summary>
        /// 文件id数组，表示要查询的文件的所有 ID，支持批量查询，数组元素范围[1,20]。
        /// </summary>
        [JsonProperty("DocumentSetId")]
        public string[] DocumentSetId{ get; set; }

        /// <summary>
        /// 表示要查询的文档名称，支持批量查询，数组元素范围[1,20]。
        /// </summary>
        [JsonProperty("DocumentSetName")]
        public string[] DocumentSetName{ get; set; }

        /// <summary>
        /// 取值范围：[1,16384]
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 设置分页偏移量，用于控制分页查询返回结果的起始位置，方便用户对数据进行分页展示和浏览。
        /// 取值：为 limit 整数倍。
        /// 计算公式：offset=limit*(page-1)。
        /// 例如：当 limit = 10，page = 2 时，分页偏移量 offset = 10 * (2 - 1) = 10，表示从查询结果的第 11 条记录开始返回数据。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 设置后，其他字段为空值
        /// </summary>
        [JsonProperty("OutputFields")]
        public string[] OutputFields{ get; set; }

        /// <summary>
        /// 使用创建 CollectionView 指定的 Filter 索引的字段设置查询过滤表达式。
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
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArraySimple(map, prefix + "OutputFields.", this.OutputFields);
            this.SetParamSimple(map, prefix + "Filter", this.Filter);
        }
    }
}

