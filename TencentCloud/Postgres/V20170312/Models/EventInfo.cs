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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventInfo : AbstractModel
    {
        
        /// <summary>
        /// 参数名
        /// </summary>
        [JsonProperty("ParamName")]
        public string ParamName{ get; set; }

        /// <summary>
        /// 原参数值
        /// </summary>
        [JsonProperty("OldValue")]
        public string OldValue{ get; set; }

        /// <summary>
        /// 本次修改期望参数值
        /// </summary>
        [JsonProperty("NewValue")]
        public string NewValue{ get; set; }

        /// <summary>
        /// 后台参数修改开始时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 后台参数生效开始时间
        /// </summary>
        [JsonProperty("EffectiveTime")]
        public string EffectiveTime{ get; set; }

        /// <summary>
        /// 修改状态
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 操作者（一般为用户sub UIN）
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 时间日志。
        /// </summary>
        [JsonProperty("EventLog")]
        public string EventLog{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParamName", this.ParamName);
            this.SetParamSimple(map, prefix + "OldValue", this.OldValue);
            this.SetParamSimple(map, prefix + "NewValue", this.NewValue);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "EffectiveTime", this.EffectiveTime);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "EventLog", this.EventLog);
        }
    }
}

