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

    public class DescribeNetAttackSettingResponse : AbstractModel
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
        /// 1 全部旗舰版主机，0 InstanceIds列表主机
        /// </summary>
        [JsonProperty("Scope")]
        public ulong? Scope{ get; set; }

        /// <summary>
        /// 自选主机
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 自选排除主机
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExcludeInstanceIds")]
        public string[] ExcludeInstanceIds{ get; set; }

        /// <summary>
        /// 新增资产自动包含 0 不包含 1包含
        /// </summary>
        [JsonProperty("AutoInclude")]
        public ulong? AutoInclude{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetAttackEnable", this.NetAttackEnable);
            this.SetParamSimple(map, prefix + "NetAttackAlarmStatus", this.NetAttackAlarmStatus);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "ExcludeInstanceIds.", this.ExcludeInstanceIds);
            this.SetParamSimple(map, prefix + "AutoInclude", this.AutoInclude);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

