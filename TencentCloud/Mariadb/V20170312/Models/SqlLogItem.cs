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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SqlLogItem : AbstractModel
    {
        
        /// <summary>
        /// 本条日志在消息队列中的偏移量。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 执行本条sql的用户。
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 执行本条sql的客户端IP+端口。
        /// </summary>
        [JsonProperty("Client")]
        public string Client{ get; set; }

        /// <summary>
        /// 数据库名称。
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 执行的sql语句。
        /// </summary>
        [JsonProperty("Sql")]
        public string Sql{ get; set; }

        /// <summary>
        /// 返回的数据行数。
        /// </summary>
        [JsonProperty("SelectRowNum")]
        public ulong? SelectRowNum{ get; set; }

        /// <summary>
        /// 影响行数。
        /// </summary>
        [JsonProperty("AffectRowNum")]
        public ulong? AffectRowNum{ get; set; }

        /// <summary>
        /// Sql执行时间戳。
        /// </summary>
        [JsonProperty("Timestamp")]
        public ulong? Timestamp{ get; set; }

        /// <summary>
        /// Sql耗时，单位为毫秒。
        /// </summary>
        [JsonProperty("TimeCostMs")]
        public ulong? TimeCostMs{ get; set; }

        /// <summary>
        /// Sql返回码，0为成功。
        /// </summary>
        [JsonProperty("ResultCode")]
        public ulong? ResultCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Client", this.Client);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "Sql", this.Sql);
            this.SetParamSimple(map, prefix + "SelectRowNum", this.SelectRowNum);
            this.SetParamSimple(map, prefix + "AffectRowNum", this.AffectRowNum);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "TimeCostMs", this.TimeCostMs);
            this.SetParamSimple(map, prefix + "ResultCode", this.ResultCode);
        }
    }
}

