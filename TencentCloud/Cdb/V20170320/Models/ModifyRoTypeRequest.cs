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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRoTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 只读实例源类型，取值 NORMAL（普通只读实例）、DELAY_REPLICATION（延迟只读实例）。
        /// </summary>
        [JsonProperty("SrcRoInstType")]
        public string SrcRoInstType{ get; set; }

        /// <summary>
        /// 只读实例目标类型，取值 NORMAL（普通只读实例）、DELAY_REPLICATION（延迟只读实例）。
        /// </summary>
        [JsonProperty("DstRoInstType")]
        public string DstRoInstType{ get; set; }

        /// <summary>
        /// 延迟时间（s），将实例修改为延迟只读实例时必传。最小值1，最大值259200。
        /// </summary>
        [JsonProperty("ReplicationDelay")]
        public long? ReplicationDelay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SrcRoInstType", this.SrcRoInstType);
            this.SetParamSimple(map, prefix + "DstRoInstType", this.DstRoInstType);
            this.SetParamSimple(map, prefix + "ReplicationDelay", this.ReplicationDelay);
        }
    }
}

