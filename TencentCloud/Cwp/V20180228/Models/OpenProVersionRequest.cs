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

    public class OpenProVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// 云主机类型。(当前参数已作废,可以留空值 )
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// 机器所属地域。(当前参数已作废,可以留空值 )
        /// </summary>
        [JsonProperty("MachineRegion")]
        public string MachineRegion{ get; set; }

        /// <summary>
        /// 主机唯一标识Uuid数组。
        /// 黑石的InstanceId，CVM的Uuid ,边缘计算的Uuid , 轻量应用服务器的Uuid ,混合云机器的Quuid 。 当前参数最大长度限制20
        /// </summary>
        [JsonProperty("Quuids")]
        public string[] Quuids{ get; set; }

        /// <summary>
        /// 活动ID。
        /// </summary>
        [JsonProperty("ActivityId")]
        public ulong? ActivityId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "MachineRegion", this.MachineRegion);
            this.SetParamArraySimple(map, prefix + "Quuids.", this.Quuids);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
        }
    }
}

