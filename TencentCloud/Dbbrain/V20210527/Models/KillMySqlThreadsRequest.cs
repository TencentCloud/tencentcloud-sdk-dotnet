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

    public class KillMySqlThreadsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。可通过 [DescribeDiagDBInstances](https://cloud.tencent.com/document/api/1130/57798) 接口获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// kill会话任务的阶段，取值包括："Prepare"-准备阶段，"Commit"-提交阶段。
        /// </summary>
        [JsonProperty("Stage")]
        public string Stage{ get; set; }

        /// <summary>
        /// 需要kill的sql会话ID列表，通过接口[查询实时线程列表](https://cloud.tencent.com/document/product/1130/57824)
        /// 此参数用于Prepare阶段。
        /// </summary>
        [JsonProperty("Threads")]
        public long?[] Threads{ get; set; }

        /// <summary>
        /// 执行ID，此参数用于Commit阶段。
        /// </summary>
        [JsonProperty("SqlExecId")]
        public string SqlExecId{ get; set; }

        /// <summary>
        /// 服务产品类型，支持值包括： "mysql" - 云数据库 MySQL， "cynosdb" - 云数据库 CynosDB  for MySQL，默认为"mysql"。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 默认是true，会记录下kill的记录；该参数为true, 则在kill操作前校验目标会话是否存在，存在则继续kill，否则取消kill。为了加快kill速度，可设置为false。
        /// </summary>
        [JsonProperty("RecordHistory")]
        public bool? RecordHistory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Stage", this.Stage);
            this.SetParamArraySimple(map, prefix + "Threads.", this.Threads);
            this.SetParamSimple(map, prefix + "SqlExecId", this.SqlExecId);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamSimple(map, prefix + "RecordHistory", this.RecordHistory);
        }
    }
}

