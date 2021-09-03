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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KillMySqlThreadsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// kill会话任务的阶段，取值包括："Prepare"-准备阶段，"Commit"-提交阶段。
        /// </summary>
        [JsonProperty("Stage")]
        public string Stage{ get; set; }

        /// <summary>
        /// 需要kill的sql会话ID列表，此参数用于Prepare阶段。
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Stage", this.Stage);
            this.SetParamArraySimple(map, prefix + "Threads.", this.Threads);
            this.SetParamSimple(map, prefix + "SqlExecId", this.SqlExecId);
            this.SetParamSimple(map, prefix + "Product", this.Product);
        }
    }
}

