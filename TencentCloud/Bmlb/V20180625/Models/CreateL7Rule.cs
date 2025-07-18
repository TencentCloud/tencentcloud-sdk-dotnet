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

namespace TencentCloud.Bmlb.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateL7Rule : AbstractModel
    {
        
        /// <summary>
        /// 七层转发规则的转发域名。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 七层转发规则的转发路径。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 会话保持时间，单位：秒。可选值：30~3600。默认值0，表示不开启会话保持。
        /// </summary>
        [JsonProperty("SessionExpire")]
        public long? SessionExpire{ get; set; }

        /// <summary>
        /// 健康检查开关：1（开启）、0（关闭）。默认值0，表示关闭。
        /// </summary>
        [JsonProperty("HealthSwitch")]
        public long? HealthSwitch{ get; set; }

        /// <summary>
        /// 健康检查检查间隔时间，默认值：5，可选值：5-300，单位：秒。
        /// </summary>
        [JsonProperty("IntervalTime")]
        public long? IntervalTime{ get; set; }

        /// <summary>
        /// 健康检查健康阈值，默认值：3，表示当连续探测三次健康则表示该转发正常，可选值：2-10，单位：次。
        /// </summary>
        [JsonProperty("HealthNum")]
        public long? HealthNum{ get; set; }

        /// <summary>
        /// 健康检查不健康阈值，默认值：5，表示当连续探测五次不健康则表示该转发不正常，可选值：2-10，单位：次。
        /// </summary>
        [JsonProperty("UnhealthNum")]
        public long? UnhealthNum{ get; set; }

        /// <summary>
        /// 健康检查中认为健康的HTTP返回码的组合。可选值为1~5的集合，1表示HTTP返回码为1xx认为健康。2表示HTTP返回码为2xx认为健康。3表示HTTP返回码为3xx认为健康。4表示HTTP返回码为4xx认为健康。5表示HTTP返回码为5xx认为健康。
        /// </summary>
        [JsonProperty("HttpCodes")]
        public ulong?[] HttpCodes{ get; set; }

        /// <summary>
        /// 健康检查检查路径。
        /// </summary>
        [JsonProperty("HttpCheckPath")]
        public string HttpCheckPath{ get; set; }

        /// <summary>
        /// 健康检查检查域名。如果创建规则的域名使用通配符或正则表达式，则健康检查检查域名可自定义，否则必须跟健康检查检查域名一样。
        /// </summary>
        [JsonProperty("HttpCheckDomain")]
        public string HttpCheckDomain{ get; set; }

        /// <summary>
        /// 均衡方式：ip_hash、wrr。默认值wrr。
        /// </summary>
        [JsonProperty("BalanceMode")]
        public string BalanceMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "SessionExpire", this.SessionExpire);
            this.SetParamSimple(map, prefix + "HealthSwitch", this.HealthSwitch);
            this.SetParamSimple(map, prefix + "IntervalTime", this.IntervalTime);
            this.SetParamSimple(map, prefix + "HealthNum", this.HealthNum);
            this.SetParamSimple(map, prefix + "UnhealthNum", this.UnhealthNum);
            this.SetParamArraySimple(map, prefix + "HttpCodes.", this.HttpCodes);
            this.SetParamSimple(map, prefix + "HttpCheckPath", this.HttpCheckPath);
            this.SetParamSimple(map, prefix + "HttpCheckDomain", this.HttpCheckDomain);
            this.SetParamSimple(map, prefix + "BalanceMode", this.BalanceMode);
        }
    }
}

