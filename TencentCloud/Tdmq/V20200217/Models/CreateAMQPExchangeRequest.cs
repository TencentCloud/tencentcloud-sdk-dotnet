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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAMQPExchangeRequest : AbstractModel
    {
        
        /// <summary>
        /// 交换机名称，3-64个字符，只能包含字母、数字、“-”及“_”
        /// </summary>
        [JsonProperty("Exchange")]
        public string Exchange{ get; set; }

        /// <summary>
        /// 交换机所在的vhost，目前支持在单个vhost下创建主题
        /// </summary>
        [JsonProperty("VHosts")]
        public string[] VHosts{ get; set; }

        /// <summary>
        /// 交换机类型，可选值为Direct, Fanout, Topic
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 交换机说明，最大128个字符
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 备用交换机名称
        /// </summary>
        [JsonProperty("AlternateExchange")]
        public string AlternateExchange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Exchange", this.Exchange);
            this.SetParamArraySimple(map, prefix + "VHosts.", this.VHosts);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AlternateExchange", this.AlternateExchange);
        }
    }
}

