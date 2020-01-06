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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NormalQueryItem : AbstractModel
    {
        
        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 调用次数
        /// </summary>
        [JsonProperty("Calls")]
        public long? Calls{ get; set; }

        /// <summary>
        /// 粒度点
        /// </summary>
        [JsonProperty("CallsGrids")]
        public long?[] CallsGrids{ get; set; }

        /// <summary>
        /// 花费总时间
        /// </summary>
        [JsonProperty("CostTime")]
        public float? CostTime{ get; set; }

        /// <summary>
        /// 影响的行数
        /// </summary>
        [JsonProperty("Rows")]
        public long? Rows{ get; set; }

        /// <summary>
        /// 花费最小时间
        /// </summary>
        [JsonProperty("MinCostTime")]
        public float? MinCostTime{ get; set; }

        /// <summary>
        /// 花费最大时间
        /// </summary>
        [JsonProperty("MaxCostTime")]
        public float? MaxCostTime{ get; set; }

        /// <summary>
        /// 最早一条慢SQL时间
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// 最晚一条慢SQL时间
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// 读共享内存块数
        /// </summary>
        [JsonProperty("SharedReadBlks")]
        public long? SharedReadBlks{ get; set; }

        /// <summary>
        /// 写共享内存块数
        /// </summary>
        [JsonProperty("SharedWriteBlks")]
        public long? SharedWriteBlks{ get; set; }

        /// <summary>
        /// 读io总耗时
        /// </summary>
        [JsonProperty("ReadCostTime")]
        public long? ReadCostTime{ get; set; }

        /// <summary>
        /// 写io总耗时
        /// </summary>
        [JsonProperty("WriteCostTime")]
        public long? WriteCostTime{ get; set; }

        /// <summary>
        /// 数据库名字
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 脱敏后的慢SQL
        /// </summary>
        [JsonProperty("NormalQuery")]
        public string NormalQuery{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Calls", this.Calls);
            this.SetParamArraySimple(map, prefix + "CallsGrids.", this.CallsGrids);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "Rows", this.Rows);
            this.SetParamSimple(map, prefix + "MinCostTime", this.MinCostTime);
            this.SetParamSimple(map, prefix + "MaxCostTime", this.MaxCostTime);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "SharedReadBlks", this.SharedReadBlks);
            this.SetParamSimple(map, prefix + "SharedWriteBlks", this.SharedWriteBlks);
            this.SetParamSimple(map, prefix + "ReadCostTime", this.ReadCostTime);
            this.SetParamSimple(map, prefix + "WriteCostTime", this.WriteCostTime);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "NormalQuery", this.NormalQuery);
        }
    }
}

