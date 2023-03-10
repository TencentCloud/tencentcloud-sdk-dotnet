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

namespace TencentCloud.Cloudhsm.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlarmPolicy : AbstractModel
    {
        
        /// <summary>
        /// 用户账号
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 告警事件
        /// </summary>
        [JsonProperty("Event")]
        public string Event{ get; set; }

        /// <summary>
        /// 告警阈值
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 告警策略是否生效，0：停用，1：启用
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 在这个时间后才允许发送告警
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 在这个时间前才允许发送告警
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Event", this.Event);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

