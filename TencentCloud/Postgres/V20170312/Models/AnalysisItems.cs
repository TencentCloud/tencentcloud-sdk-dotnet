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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AnalysisItems : AbstractModel
    {
        
        /// <summary>
        /// 慢SQL查询的数据库名
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 慢SQL执行的用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 抽象参数之后的慢SQL
        /// </summary>
        [JsonProperty("NormalQuery")]
        public string NormalQuery{ get; set; }

        /// <summary>
        /// 慢SQL执行的客户端地址
        /// </summary>
        [JsonProperty("ClientAddr")]
        public string ClientAddr{ get; set; }

        /// <summary>
        /// 在选定时间范围内慢SQL语句执行的次数
        /// </summary>
        [JsonProperty("CallNum")]
        public ulong? CallNum{ get; set; }

        /// <summary>
        /// 在选定时间范围内，慢SQL语句执行的次数占所有慢SQL的百分比。
        /// </summary>
        [JsonProperty("CallPercent")]
        public float? CallPercent{ get; set; }

        /// <summary>
        /// 在选定时间范围内，慢SQL执行的总时间
        /// </summary>
        [JsonProperty("CostTime")]
        public float? CostTime{ get; set; }

        /// <summary>
        /// 在选定时间范围内，慢SQL语句执行的总时间占所有慢SQL的比例（小数返回）
        /// </summary>
        [JsonProperty("CostPercent")]
        public float? CostPercent{ get; set; }

        /// <summary>
        /// 在选定时间范围内，慢SQL语句执行的耗时最短的时间（单位：ms）
        /// </summary>
        [JsonProperty("MinCostTime")]
        public float? MinCostTime{ get; set; }

        /// <summary>
        /// 在选定时间范围内，慢SQL语句执行的耗时最长的时间（单位：ms）
        /// </summary>
        [JsonProperty("MaxCostTime")]
        public float? MaxCostTime{ get; set; }

        /// <summary>
        /// 在选定时间范围内，慢SQL语句执行的耗时平均时间（单位：ms）
        /// </summary>
        [JsonProperty("AvgCostTime")]
        public float? AvgCostTime{ get; set; }

        /// <summary>
        /// 在选定时间范围内，慢SQL第一条开始执行的时间
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// 在选定时间范围内，慢SQL最后一条开始执行的时间
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "NormalQuery", this.NormalQuery);
            this.SetParamSimple(map, prefix + "ClientAddr", this.ClientAddr);
            this.SetParamSimple(map, prefix + "CallNum", this.CallNum);
            this.SetParamSimple(map, prefix + "CallPercent", this.CallPercent);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "CostPercent", this.CostPercent);
            this.SetParamSimple(map, prefix + "MinCostTime", this.MinCostTime);
            this.SetParamSimple(map, prefix + "MaxCostTime", this.MaxCostTime);
            this.SetParamSimple(map, prefix + "AvgCostTime", this.AvgCostTime);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
        }
    }
}

