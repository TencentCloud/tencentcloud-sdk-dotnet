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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNetAttackSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// 0 关闭网络攻击检测，1开启网络攻击检测
        /// </summary>
        [JsonProperty("NetAttackEnable")]
        public ulong? NetAttackEnable{ get; set; }

        /// <summary>
        /// 0 新增告警事件默认待处理，1新增告警事件默认已处理，3新增告警事件默认忽略
        /// </summary>
        [JsonProperty("NetAttackAlarmStatus")]
        public ulong? NetAttackAlarmStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetAttackEnable", this.NetAttackEnable);
            this.SetParamSimple(map, prefix + "NetAttackAlarmStatus", this.NetAttackAlarmStatus);
        }
    }
}

