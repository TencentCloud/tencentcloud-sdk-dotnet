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

namespace TencentCloud.Cdwpg.V20201230.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NormQueryItem : AbstractModel
    {
        
        /// <summary>
        /// 调用次数
        /// </summary>
        [JsonProperty("CallTimes")]
        public long? CallTimes{ get; set; }

        /// <summary>
        /// 读共享内存块数
        /// </summary>
        [JsonProperty("SharedReadBlocks")]
        public long? SharedReadBlocks{ get; set; }

        /// <summary>
        /// 写共享内存块数
        /// </summary>
        [JsonProperty("SharedWriteBlocks")]
        public long? SharedWriteBlocks{ get; set; }

        /// <summary>
        /// 数据库
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 脱敏后语句
        /// </summary>
        [JsonProperty("NormalQuery")]
        public string NormalQuery{ get; set; }

        /// <summary>
        /// 执行时间最长的语句
        /// </summary>
        [JsonProperty("MaxElapsedQuery")]
        public string MaxElapsedQuery{ get; set; }

        /// <summary>
        /// 花费总时间
        /// </summary>
        [JsonProperty("CostTime")]
        public float? CostTime{ get; set; }

        /// <summary>
        /// 客户端ip
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 总次数占比
        /// </summary>
        [JsonProperty("TotalCallTimesPercent")]
        public float? TotalCallTimesPercent{ get; set; }

        /// <summary>
        /// 总耗时占比
        /// </summary>
        [JsonProperty("TotalCostTimePercent")]
        public float? TotalCostTimePercent{ get; set; }

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
        /// 最早一条时间
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// 最晚一条时间
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// 读io总耗时
        /// </summary>
        [JsonProperty("ReadCostTime")]
        public float? ReadCostTime{ get; set; }

        /// <summary>
        /// 写io总耗时
        /// </summary>
        [JsonProperty("WriteCostTime")]
        public float? WriteCostTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallTimes", this.CallTimes);
            this.SetParamSimple(map, prefix + "SharedReadBlocks", this.SharedReadBlocks);
            this.SetParamSimple(map, prefix + "SharedWriteBlocks", this.SharedWriteBlocks);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "NormalQuery", this.NormalQuery);
            this.SetParamSimple(map, prefix + "MaxElapsedQuery", this.MaxElapsedQuery);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "TotalCallTimesPercent", this.TotalCallTimesPercent);
            this.SetParamSimple(map, prefix + "TotalCostTimePercent", this.TotalCostTimePercent);
            this.SetParamSimple(map, prefix + "MinCostTime", this.MinCostTime);
            this.SetParamSimple(map, prefix + "MaxCostTime", this.MaxCostTime);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "ReadCostTime", this.ReadCostTime);
            this.SetParamSimple(map, prefix + "WriteCostTime", this.WriteCostTime);
        }
    }
}

