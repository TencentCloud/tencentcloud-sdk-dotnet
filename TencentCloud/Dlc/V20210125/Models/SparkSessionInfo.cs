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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SparkSessionInfo : AbstractModel
    {
        
        /// <summary>
        /// spark session id
        /// </summary>
        [JsonProperty("SparkSessionId")]
        public string SparkSessionId{ get; set; }

        /// <summary>
        /// spark session名称
        /// </summary>
        [JsonProperty("SparkSessionName")]
        public string SparkSessionName{ get; set; }

        /// <summary>
        /// 资源组id
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// engine session id
        /// </summary>
        [JsonProperty("EngineSessionId")]
        public string EngineSessionId{ get; set; }

        /// <summary>
        /// engine session   
        /// name
        /// </summary>
        [JsonProperty("EngineSessionName")]
        public string EngineSessionName{ get; set; }

        /// <summary>
        /// 自动销毁时间
        /// </summary>
        [JsonProperty("IdleTimeoutMin")]
        public long? IdleTimeoutMin{ get; set; }

        /// <summary>
        /// driver规格
        /// </summary>
        [JsonProperty("DriverSpec")]
        public string DriverSpec{ get; set; }

        /// <summary>
        /// executor规格
        /// </summary>
        [JsonProperty("ExecutorSpec")]
        public string ExecutorSpec{ get; set; }

        /// <summary>
        /// executor最小数量
        /// </summary>
        [JsonProperty("ExecutorNumMin")]
        public long? ExecutorNumMin{ get; set; }

        /// <summary>
        /// executor最大数量
        /// </summary>
        [JsonProperty("ExecutorNumMax")]
        public long? ExecutorNumMax{ get; set; }

        /// <summary>
        /// 总规格最小
        /// </summary>
        [JsonProperty("TotalSpecMin")]
        public long? TotalSpecMin{ get; set; }

        /// <summary>
        /// 总规格最大
        /// </summary>
        [JsonProperty("TotalSpecMax")]
        public long? TotalSpecMax{ get; set; }

        /// <summary>
        /// 状态，STARTING、RUNNING、TERMINATED
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SparkSessionId", this.SparkSessionId);
            this.SetParamSimple(map, prefix + "SparkSessionName", this.SparkSessionName);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "EngineSessionId", this.EngineSessionId);
            this.SetParamSimple(map, prefix + "EngineSessionName", this.EngineSessionName);
            this.SetParamSimple(map, prefix + "IdleTimeoutMin", this.IdleTimeoutMin);
            this.SetParamSimple(map, prefix + "DriverSpec", this.DriverSpec);
            this.SetParamSimple(map, prefix + "ExecutorSpec", this.ExecutorSpec);
            this.SetParamSimple(map, prefix + "ExecutorNumMin", this.ExecutorNumMin);
            this.SetParamSimple(map, prefix + "ExecutorNumMax", this.ExecutorNumMax);
            this.SetParamSimple(map, prefix + "TotalSpecMin", this.TotalSpecMin);
            this.SetParamSimple(map, prefix + "TotalSpecMax", this.TotalSpecMax);
            this.SetParamSimple(map, prefix + "State", this.State);
        }
    }
}

