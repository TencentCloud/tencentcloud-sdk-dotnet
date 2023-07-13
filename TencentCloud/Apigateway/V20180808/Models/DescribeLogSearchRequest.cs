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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLogSearchRequest : AbstractModel
    {
        
        /// <summary>
        /// 日志开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 日志结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// 保留字段
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 单次要返回的日志条数，单次返回的最大条数为100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 根据上次返回的ConText，获取后续的内容，最多可获取10000条
        /// </summary>
        [JsonProperty("ConText")]
        public string ConText{ get; set; }

        /// <summary>
        /// 按时间排序 asc（升序）或者 desc（降序），默认为 desc
        /// </summary>
        [JsonProperty("Sort")]
        public string Sort{ get; set; }

        /// <summary>
        /// 保留字段
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 检索条件,支持的检索条件如下：
        /// req_id：“=”
        /// api_id：“=”
        /// cip：“=”
        /// uip：“:”
        /// err_msg：“:”
        /// rsp_st：“=” 、“!=” 、 “:” 、 “>” 、 “<”
        /// req_t：”>=“ 、 ”<=“
        /// 
        /// 说明：
        /// “:”表示包含，“!=”表示不等于，字段含义见输出参数的LogSet说明
        /// </summary>
        [JsonProperty("LogQuerys")]
        [System.Obsolete]
        public LogQuery[] LogQuerys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ConText", this.ConText);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamArrayObj(map, prefix + "LogQuerys.", this.LogQuerys);
        }
    }
}

