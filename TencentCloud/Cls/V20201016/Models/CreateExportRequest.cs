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

    public class CreateExportRequest : AbstractModel
    {
        
        /// <summary>
        /// 日志主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 日志导出数量,  最大值5000万
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 日志导出检索语句，不支持<a href="https://cloud.tencent.com/document/product/614/44061" target="_blank">[SQL语句]</a>
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 日志导出起始时间，毫秒时间戳
        /// </summary>
        [JsonProperty("From")]
        public long? From{ get; set; }

        /// <summary>
        /// 日志导出结束时间，毫秒时间戳
        /// </summary>
        [JsonProperty("To")]
        public long? To{ get; set; }

        /// <summary>
        /// 日志导出时间排序。desc，asc，默认为desc
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 日志导出数据格式。json，csv，默认为json
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 语法规则,  默认值为0。
        /// 0：Lucene语法，1：CQL语法。
        /// </summary>
        [JsonProperty("SyntaxRule")]
        public ulong? SyntaxRule{ get; set; }

        /// <summary>
        /// 导出字段
        /// </summary>
        [JsonProperty("DerivedFields")]
        public string[] DerivedFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "SyntaxRule", this.SyntaxRule);
            this.SetParamArraySimple(map, prefix + "DerivedFields.", this.DerivedFields);
        }
    }
}

