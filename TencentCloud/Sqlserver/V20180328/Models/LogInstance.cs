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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogInstance : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 日志状态，create：创建中；normal：开启；close：关闭中。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 	
        /// 是否可以切换日志查询-取值：yes-可以，no-不可以。该参数主要为控制存量日志迁移到日志平台做查询使用，只有为yes状态才可以调用查询日志接口。
        /// </summary>
        [JsonProperty("EnableQuery")]
        public string EnableQuery{ get; set; }

        /// <summary>
        /// 开启时间
        /// </summary>
        [JsonProperty("CreateAt")]
        public string CreateAt{ get; set; }

        /// <summary>
        /// 高频存储天数
        /// </summary>
        [JsonProperty("HighLogExpireDay")]
        public long? HighLogExpireDay{ get; set; }

        /// <summary>
        /// 低频存储天数
        /// </summary>
        [JsonProperty("LowLogExpireDay")]
        public long? LowLogExpireDay{ get; set; }

        /// <summary>
        /// 总存储时长
        /// </summary>
        [JsonProperty("LogExpireDay")]
        public long? LogExpireDay{ get; set; }

        /// <summary>
        /// 高频存储量，单位：MB
        /// </summary>
        [JsonProperty("HighStorage")]
        public float? HighStorage{ get; set; }

        /// <summary>
        /// 低频存储量，单位：MB
        /// </summary>
        [JsonProperty("LowStorage")]
        public float? LowStorage{ get; set; }

        /// <summary>
        /// 总存储量
        /// </summary>
        [JsonProperty("LogStorage")]
        public float? LogStorage{ get; set; }

        /// <summary>
        /// 是否开启投递：ON，OFF
        /// </summary>
        [JsonProperty("Deliver")]
        public string Deliver{ get; set; }

        /// <summary>
        /// 日志投递信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeliverSummary")]
        public DeliverSummary[] DeliverSummary{ get; set; }

        /// <summary>
        /// 业务侧实例相关信息，根据业务不同，返回相关信息不同。
        /// </summary>
        [JsonProperty("InstanceInfo")]
        public InstanceInfo InstanceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EnableQuery", this.EnableQuery);
            this.SetParamSimple(map, prefix + "CreateAt", this.CreateAt);
            this.SetParamSimple(map, prefix + "HighLogExpireDay", this.HighLogExpireDay);
            this.SetParamSimple(map, prefix + "LowLogExpireDay", this.LowLogExpireDay);
            this.SetParamSimple(map, prefix + "LogExpireDay", this.LogExpireDay);
            this.SetParamSimple(map, prefix + "HighStorage", this.HighStorage);
            this.SetParamSimple(map, prefix + "LowStorage", this.LowStorage);
            this.SetParamSimple(map, prefix + "LogStorage", this.LogStorage);
            this.SetParamSimple(map, prefix + "Deliver", this.Deliver);
            this.SetParamArrayObj(map, prefix + "DeliverSummary.", this.DeliverSummary);
            this.SetParamObj(map, prefix + "InstanceInfo.", this.InstanceInfo);
        }
    }
}

