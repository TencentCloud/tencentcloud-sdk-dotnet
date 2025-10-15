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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMySqlProcessListRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。可通过 [DescribeDiagDBInstances](https://cloud.tencent.com/document/api/1130/57798) 接口获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 线程的ID，用于筛选线程列表。
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// 线程的操作账号名，用于筛选线程列表。
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 线程的操作主机地址，用于筛选线程列表。
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 线程的操作数据库，用于筛选线程列表。
        /// </summary>
        [JsonProperty("DB")]
        public string DB{ get; set; }

        /// <summary>
        /// 线程的操作状态。包含以下枚举值：Sending data​-线程正在处理查询结果， ​Sorting result​-线程正在对查询结果进行排序​，Creating tmp table​-线程正在创建临时表，Altering table​-线程正在执行表结构变更，Updating-线程执行更新中。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 线程的执行类型。包含以下枚举值：Sleep-线程处于空闲状态，Query-线程正在执行一个查询，Connect-从服务器连接到主服务器，Execute-线程正在执行预处理语句。
        /// </summary>
        [JsonProperty("Command")]
        public string Command{ get; set; }

        /// <summary>
        /// 线程的操作时长最小值，单位秒，用于筛选操作时长大于该值的线程列表。
        /// </summary>
        [JsonProperty("Time")]
        public ulong? Time{ get; set; }

        /// <summary>
        /// 线程的操作语句，用于筛选线程列表。
        /// </summary>
        [JsonProperty("Info")]
        public string Info{ get; set; }

        /// <summary>
        /// 返回数量，默认20。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 服务产品类型，支持值："mysql" - 云数据库 MySQL；"mariadb"-mariadb;"cynosdb"-TDSQL-C for MySQL ;"dcdb"-TDSQL MySQL 默认为"mysql"。
        /// 
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 会话统计的维度信息,可以多个维度。
        /// </summary>
        [JsonProperty("StatDimensions")]
        public StatDimension[] StatDimensions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "DB", this.DB);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Command", this.Command);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Info", this.Info);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamArrayObj(map, prefix + "StatDimensions.", this.StatDimensions);
        }
    }
}

