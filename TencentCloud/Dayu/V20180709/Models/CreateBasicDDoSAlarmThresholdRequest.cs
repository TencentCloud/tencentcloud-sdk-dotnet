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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBasicDDoSAlarmThresholdRequest : AbstractModel
    {
        
        /// <summary>
        /// 大禹子产品代号（basic表示DDoS基础防护）
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// =get表示读取告警阈值；=set表示设置告警阈值；
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 可选，告警阈值类型，1-入流量，2-清洗流量；当Method为set时必须填写；
        /// </summary>
        [JsonProperty("AlarmType")]
        public ulong? AlarmType{ get; set; }

        /// <summary>
        /// 可选，告警阈值，当Method为set时必须填写；当设置阈值为0时表示清除告警阈值配置；
        /// </summary>
        [JsonProperty("AlarmThreshold")]
        public ulong? AlarmThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "AlarmType", this.AlarmType);
            this.SetParamSimple(map, prefix + "AlarmThreshold", this.AlarmThreshold);
        }
    }
}

