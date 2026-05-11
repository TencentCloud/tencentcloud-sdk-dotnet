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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>回收站锁定设置，true时不可手动销毁，到预设时间后自动销毁</p><p>默认值：false</p>
        /// </summary>
        [JsonProperty("LockEnabled")]
        public bool? LockEnabled{ get; set; }

        /// <summary>
        /// <p>放入回收站的锁定时间</p><p>取值范围：[1, 7]</p><p>单位：天</p><p>默认值：1</p>
        /// </summary>
        [JsonProperty("LockDuration")]
        public long? LockDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LockEnabled", this.LockEnabled);
            this.SetParamSimple(map, prefix + "LockDuration", this.LockDuration);
        }
    }
}

