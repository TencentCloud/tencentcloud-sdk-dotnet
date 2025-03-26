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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlowQueryRecord : AbstractModel
    {
        
        /// <summary>
        /// 查询用户
        /// </summary>
        [JsonProperty("OsUser")]
        public string OsUser{ get; set; }

        /// <summary>
        /// 查询ID
        /// </summary>
        [JsonProperty("InitialQueryId")]
        public string InitialQueryId{ get; set; }

        /// <summary>
        /// SQL语句
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("QueryStartTime")]
        public string QueryStartTime{ get; set; }

        /// <summary>
        /// 执行耗时
        /// </summary>
        [JsonProperty("DurationMs")]
        public long? DurationMs{ get; set; }

        /// <summary>
        /// 读取行数
        /// </summary>
        [JsonProperty("ReadRows")]
        public long? ReadRows{ get; set; }

        /// <summary>
        /// 读取字节数
        /// </summary>
        [JsonProperty("ResultRows")]
        public long? ResultRows{ get; set; }

        /// <summary>
        /// 结果字节数
        /// </summary>
        [JsonProperty("ResultBytes")]
        public ulong? ResultBytes{ get; set; }

        /// <summary>
        /// 内存
        /// </summary>
        [JsonProperty("MemoryUsage")]
        public long? MemoryUsage{ get; set; }

        /// <summary>
        /// 初始查询IP
        /// </summary>
        [JsonProperty("InitialAddress")]
        public string InitialAddress{ get; set; }

        /// <summary>
        /// 数据库名
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 是否是查询，0：否，1：查询语句
        /// </summary>
        [JsonProperty("IsQuery")]
        public long? IsQuery{ get; set; }

        /// <summary>
        /// ResultBytes的MB格式
        /// </summary>
        [JsonProperty("ResultBytesMB")]
        public float? ResultBytesMB{ get; set; }

        /// <summary>
        /// MemoryUsage的MB表示
        /// </summary>
        [JsonProperty("MemoryUsageMB")]
        public float? MemoryUsageMB{ get; set; }

        /// <summary>
        /// DurationMs的秒表示
        /// </summary>
        [JsonProperty("DurationSec")]
        public float? DurationSec{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Catalog  Name
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// cpu执行时间 
        /// </summary>
        [JsonProperty("CpuTimeMs")]
        public long? CpuTimeMs{ get; set; }

        /// <summary>
        /// 计算组
        /// </summary>
        [JsonProperty("ComputeGroup")]
        public string ComputeGroup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OsUser", this.OsUser);
            this.SetParamSimple(map, prefix + "InitialQueryId", this.InitialQueryId);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "QueryStartTime", this.QueryStartTime);
            this.SetParamSimple(map, prefix + "DurationMs", this.DurationMs);
            this.SetParamSimple(map, prefix + "ReadRows", this.ReadRows);
            this.SetParamSimple(map, prefix + "ResultRows", this.ResultRows);
            this.SetParamSimple(map, prefix + "ResultBytes", this.ResultBytes);
            this.SetParamSimple(map, prefix + "MemoryUsage", this.MemoryUsage);
            this.SetParamSimple(map, prefix + "InitialAddress", this.InitialAddress);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "IsQuery", this.IsQuery);
            this.SetParamSimple(map, prefix + "ResultBytesMB", this.ResultBytesMB);
            this.SetParamSimple(map, prefix + "MemoryUsageMB", this.MemoryUsageMB);
            this.SetParamSimple(map, prefix + "DurationSec", this.DurationSec);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamSimple(map, prefix + "CpuTimeMs", this.CpuTimeMs);
            this.SetParamSimple(map, prefix + "ComputeGroup", this.ComputeGroup);
        }
    }
}

