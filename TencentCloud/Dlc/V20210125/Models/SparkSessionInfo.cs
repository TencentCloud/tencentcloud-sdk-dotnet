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
        /// <p>spark session id</p>
        /// </summary>
        [JsonProperty("SparkSessionId")]
        public string SparkSessionId{ get; set; }

        /// <summary>
        /// <p>spark session名称</p>
        /// </summary>
        [JsonProperty("SparkSessionName")]
        public string SparkSessionName{ get; set; }

        /// <summary>
        /// <p>资源组id</p>
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// <p>engine session id</p>
        /// </summary>
        [JsonProperty("EngineSessionId")]
        public string EngineSessionId{ get; set; }

        /// <summary>
        /// <p>engine session<br>name</p>
        /// </summary>
        [JsonProperty("EngineSessionName")]
        public string EngineSessionName{ get; set; }

        /// <summary>
        /// <p>自动销毁时间</p>
        /// </summary>
        [JsonProperty("IdleTimeoutMin")]
        public long? IdleTimeoutMin{ get; set; }

        /// <summary>
        /// <p>driver规格</p>
        /// </summary>
        [JsonProperty("DriverSpec")]
        public string DriverSpec{ get; set; }

        /// <summary>
        /// <p>executor规格</p>
        /// </summary>
        [JsonProperty("ExecutorSpec")]
        public string ExecutorSpec{ get; set; }

        /// <summary>
        /// <p>executor最小数量</p>
        /// </summary>
        [JsonProperty("ExecutorNumMin")]
        public long? ExecutorNumMin{ get; set; }

        /// <summary>
        /// <p>executor最大数量</p>
        /// </summary>
        [JsonProperty("ExecutorNumMax")]
        public long? ExecutorNumMax{ get; set; }

        /// <summary>
        /// <p>总规格最小</p>
        /// </summary>
        [JsonProperty("TotalSpecMin")]
        public long? TotalSpecMin{ get; set; }

        /// <summary>
        /// <p>总规格最大</p>
        /// </summary>
        [JsonProperty("TotalSpecMax")]
        public long? TotalSpecMax{ get; set; }

        /// <summary>
        /// <p>状态，STARTING、RUNNING、TERMINATED</p>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>应用 ID</p>
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// <p>应用启动时间</p>
        /// </summary>
        [JsonProperty("ApplicationStartTime")]
        public long? ApplicationStartTime{ get; set; }


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
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationStartTime", this.ApplicationStartTime);
        }
    }
}

