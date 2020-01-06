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

namespace TencentCloud.Bmlb.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class L7ListenerInfoLocation : AbstractModel
    {
        
        /// <summary>
        /// 转发路径。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 转发路径实例ID。
        /// </summary>
        [JsonProperty("LocationId")]
        public string LocationId{ get; set; }

        /// <summary>
        /// 会话保持时间。
        /// </summary>
        [JsonProperty("SessionExpire")]
        public long? SessionExpire{ get; set; }

        /// <summary>
        /// 是否开启健康检查。
        /// </summary>
        [JsonProperty("HealthSwitch")]
        public long? HealthSwitch{ get; set; }

        /// <summary>
        /// 健康检查检查路径。
        /// </summary>
        [JsonProperty("HttpCheckPath")]
        public string HttpCheckPath{ get; set; }

        /// <summary>
        /// 健康检查检查域名。
        /// </summary>
        [JsonProperty("HttpCheckDomain")]
        public string HttpCheckDomain{ get; set; }

        /// <summary>
        /// 健康检查检查间隔时间。
        /// </summary>
        [JsonProperty("IntervalTime")]
        public long? IntervalTime{ get; set; }

        /// <summary>
        /// 健康检查健康阈值。
        /// </summary>
        [JsonProperty("HealthNum")]
        public long? HealthNum{ get; set; }

        /// <summary>
        /// 健康检查不健康阈值。
        /// </summary>
        [JsonProperty("UnhealthNum")]
        public long? UnhealthNum{ get; set; }

        /// <summary>
        /// 健康检查中认为健康的HTTP返回码的组合。可选值为1~5的集合，1表示HTTP返回码为1xx认为健康。2表示HTTP返回码为2xx认为健康。3表示HTTP返回码为3xx认为健康。4表示HTTP返回码为4xx认为健康。5表示HTTP返回码为5xx认为健康。
        /// </summary>
        [JsonProperty("HttpCodes")]
        public ulong?[] HttpCodes{ get; set; }

        /// <summary>
        /// 均衡方式。
        /// </summary>
        [JsonProperty("BalanceMode")]
        public string BalanceMode{ get; set; }

        /// <summary>
        /// 当前绑定关系的健康检查状态（Dead代表不健康，Alive代表健康）。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 创建时间戳。
        /// </summary>
        [JsonProperty("AddTimestamp")]
        public string AddTimestamp{ get; set; }

        /// <summary>
        /// 该转发路径所绑定的主机列表。
        /// </summary>
        [JsonProperty("BackendSet")]
        public L7ListenerInfoBackend[] BackendSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "LocationId", this.LocationId);
            this.SetParamSimple(map, prefix + "SessionExpire", this.SessionExpire);
            this.SetParamSimple(map, prefix + "HealthSwitch", this.HealthSwitch);
            this.SetParamSimple(map, prefix + "HttpCheckPath", this.HttpCheckPath);
            this.SetParamSimple(map, prefix + "HttpCheckDomain", this.HttpCheckDomain);
            this.SetParamSimple(map, prefix + "IntervalTime", this.IntervalTime);
            this.SetParamSimple(map, prefix + "HealthNum", this.HealthNum);
            this.SetParamSimple(map, prefix + "UnhealthNum", this.UnhealthNum);
            this.SetParamArraySimple(map, prefix + "HttpCodes.", this.HttpCodes);
            this.SetParamSimple(map, prefix + "BalanceMode", this.BalanceMode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AddTimestamp", this.AddTimestamp);
            this.SetParamArrayObj(map, prefix + "BackendSet.", this.BackendSet);
        }
    }
}

