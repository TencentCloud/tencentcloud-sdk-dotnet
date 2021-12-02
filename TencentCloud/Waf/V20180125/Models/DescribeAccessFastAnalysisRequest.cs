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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccessFastAnalysisRequest : AbstractModel
    {
        
        /// <summary>
        /// 客户要查询的日志主题ID，每个客户都有对应的一个主题
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 要查询的日志的起始时间，Unix时间戳，单位ms
        /// </summary>
        [JsonProperty("From")]
        public long? From{ get; set; }

        /// <summary>
        /// 要查询的日志的结束时间，Unix时间戳，单位ms
        /// </summary>
        [JsonProperty("To")]
        public long? To{ get; set; }

        /// <summary>
        /// 查询语句，语句长度最大为4096，由于本接口是分析接口，如果无过滤条件，必须传 * 表示匹配所有，参考CLS的分析统计语句的文档
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 需要分析统计的字段名
        /// </summary>
        [JsonProperty("FieldName")]
        public string FieldName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "FieldName", this.FieldName);
        }
    }
}

