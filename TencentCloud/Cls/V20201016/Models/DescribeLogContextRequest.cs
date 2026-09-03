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

    public class DescribeLogContextRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>要查询的日志主题Id。</p><ul><li>通过 <a href="https://cloud.tencent.com/document/product/614/56454">获取日志主题列表</a> 获取日志主题Id。</li><li>通过 <a href="https://cloud.tencent.com/document/product/614/56456">创建日志主题</a> 获取日志主题Id。</li></ul>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>日志时间,  即 <a href="https://cloud.tencent.com/document/product/614/56447">检索分析日志</a> 接口返回信息中Results结构体中的Time，需按照 UTC+8 时区将该毫秒级Unix时间戳转换为 YYYY-mm-dd HH:MM:SS.FFF 格式的字符串。</p>
        /// </summary>
        [JsonProperty("BTime")]
        public string BTime{ get; set; }

        /// <summary>
        /// <p>日志包序号，即 <a href="https://cloud.tencent.com/document/product/614/56447">检索分析日志</a> 接口返回信息中Results结构体中的PkgId。</p>
        /// </summary>
        [JsonProperty("PkgId")]
        public string PkgId{ get; set; }

        /// <summary>
        /// <p>日志包内一条日志的序号，即 <a href="https://cloud.tencent.com/document/product/614/56447">检索分析日志</a> 接口返回信息中Results结构中的PkgLogId。</p>
        /// </summary>
        [JsonProperty("PkgLogId")]
        public long? PkgLogId{ get; set; }

        /// <summary>
        /// <p>前${PrevLogs}条日志，默认值10，最大100。</p>
        /// </summary>
        [JsonProperty("PrevLogs")]
        public long? PrevLogs{ get; set; }

        /// <summary>
        /// <p>后${NextLogs}条日志，默认值10，最大100。</p>
        /// </summary>
        [JsonProperty("NextLogs")]
        public long? NextLogs{ get; set; }

        /// <summary>
        /// <p>检索语句，对日志上下文进行过滤，最大长度为12KB<br>语句由 <a href="https://cloud.tencent.com/document/product/614/47044" target="_blank">[检索条件]</a>构成，不支持SQL语句</p>
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// <p>上下文检索的开始时间，单位：毫秒级时间戳<br>注意：</p><ul><li>From为空时，表示上下文检索的开始时间不做限制</li><li>From和To非空时，From &lt; To</li></ul>
        /// </summary>
        [JsonProperty("From")]
        public ulong? From{ get; set; }

        /// <summary>
        /// <p>上下文检索的结束时间，单位：毫秒级时间戳。<br>注意：</p><ul><li>To为空时，表示上下文检索的结束时间不做限制</li><li>From和To非空时，From &lt; To</li></ul>
        /// </summary>
        [JsonProperty("To")]
        public ulong? To{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "BTime", this.BTime);
            this.SetParamSimple(map, prefix + "PkgId", this.PkgId);
            this.SetParamSimple(map, prefix + "PkgLogId", this.PkgLogId);
            this.SetParamSimple(map, prefix + "PrevLogs", this.PrevLogs);
            this.SetParamSimple(map, prefix + "NextLogs", this.NextLogs);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
        }
    }
}

