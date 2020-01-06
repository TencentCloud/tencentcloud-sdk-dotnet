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

    public class DescribeL4RulesErrHealthResponse : AbstractModel
    {
        
        /// <summary>
        /// 异常规则的总数
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// 异常规则列表，返回值说明: Key值为规则ID，Value值为异常IP，多个IP用","分割
        /// </summary>
        [JsonProperty("ErrHealths")]
        public KeyValue[] ErrHealths{ get; set; }

        /// <summary>
        /// 异常规则列表(提供更多的错误相关信息)，返回值说明:
        /// Key值为RuleId时，Value值为规则ID；
        /// Key值为Protocol时，Value值为规则的转发协议；
        /// Key值为VirtualPort时，Value值为规则的转发端口；
        /// Key值为ErrMessage时，Value值为健康检查异常信息；
        /// 健康检查异常信息的格式为"SourceIp:1.1.1.1|SourcePort:1234|AbnormalStatTime:1570689065|AbnormalReason:connection time out|Interval:20|CheckNum:6|FailNum:6" 多个源IP的错误信息用，分割,
        /// SourceIp表示源站IP，SourcePort表示源站端口，AbnormalStatTime表示异常时间，AbnormalReason表示异常原因，Interval表示检查周期，CheckNum表示检查次数，FailNum表示失败次数；
        /// </summary>
        [JsonProperty("ExtErrHealths")]
        public KeyValueRecord[] ExtErrHealths{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamArrayObj(map, prefix + "ErrHealths.", this.ErrHealths);
            this.SetParamArrayObj(map, prefix + "ExtErrHealths.", this.ExtErrHealths);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

