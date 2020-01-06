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

    public class ModifyDDoSAlarmThresholdRequest : AbstractModel
    {
        
        /// <summary>
        /// 大禹子产品代号（shield表示棋牌；bgpip表示高防IP；bgp表示高防包；bgp-multip表示多ip高防包；net表示高防IP专业版）
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 资源ID,字符串类型
        /// </summary>
        [JsonProperty("RsId")]
        public string RsId{ get; set; }

        /// <summary>
        /// 告警阈值类型，0-未设置，1-入流量，2-清洗流量
        /// </summary>
        [JsonProperty("AlarmType")]
        public ulong? AlarmType{ get; set; }

        /// <summary>
        /// 告警阈值，大于0（目前暂定的值）
        /// </summary>
        [JsonProperty("AlarmThreshold")]
        public ulong? AlarmThreshold{ get; set; }

        /// <summary>
        /// 资源关联的IP列表，高防包未绑定时，传空数组，高防IP专业版传多个IP的数据
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "RsId", this.RsId);
            this.SetParamSimple(map, prefix + "AlarmType", this.AlarmType);
            this.SetParamSimple(map, prefix + "AlarmThreshold", this.AlarmThreshold);
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
        }
    }
}

