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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanCSIPTaskAgainRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>扫描任务ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>限定本次重扫的目标主机列表；为空时取主表对应子表的全量 实例ID；长度上限 1000</p>
        /// </summary>
        [JsonProperty("InstanceIDList")]
        public string[] InstanceIDList{ get; set; }

        /// <summary>
        /// <p>扫描超时时长（秒），可选。非零时更新一键扫描超时配置并同步更新子表 timeout 字段。上限 7200 秒（2小时），超出返回 InvalidParameter。</p>
        /// </summary>
        [JsonProperty("TimeoutPeriod")]
        public ulong? TimeoutPeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "InstanceIDList.", this.InstanceIDList);
            this.SetParamSimple(map, prefix + "TimeoutPeriod", this.TimeoutPeriod);
        }
    }
}

