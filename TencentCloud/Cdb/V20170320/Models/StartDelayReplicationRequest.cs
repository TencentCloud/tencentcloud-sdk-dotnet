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

    public class StartDelayReplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 延迟复制类型。可选值 DEFAULT（按照延迟复制时间进行复制）、GTID（回放到指定GTID）、DUE_TIME（回放到指定时间点）。
        /// </summary>
        [JsonProperty("DelayReplicationType")]
        public string DelayReplicationType{ get; set; }

        /// <summary>
        /// 指定时间点，默认为0，最大值不能超过当前时间。
        /// </summary>
        [JsonProperty("DueTime")]
        public long? DueTime{ get; set; }

        /// <summary>
        /// 指定GITD。回放到指定GTID时必传。
        /// </summary>
        [JsonProperty("Gtid")]
        public string Gtid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DelayReplicationType", this.DelayReplicationType);
            this.SetParamSimple(map, prefix + "DueTime", this.DueTime);
            this.SetParamSimple(map, prefix + "Gtid", this.Gtid);
        }
    }
}

