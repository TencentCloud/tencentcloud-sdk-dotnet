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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindAlarmPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 拨测任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 告警策略组Id
        /// </summary>
        [JsonProperty("PolicyGroupId")]
        public ulong? PolicyGroupId{ get; set; }

        /// <summary>
        /// 是否绑定操作。非0 为绑定， 0 为 解绑。缺省表示 绑定。
        /// </summary>
        [JsonProperty("IfBind")]
        public ulong? IfBind{ get; set; }

        /// <summary>
        /// 告警主题Id
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "PolicyGroupId", this.PolicyGroupId);
            this.SetParamSimple(map, prefix + "IfBind", this.IfBind);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
        }
    }
}

