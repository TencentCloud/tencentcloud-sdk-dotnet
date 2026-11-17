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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RotateClusterTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>集群类型，枚举类型：TKEServerless、TKE，为对应集群类型。默认TKE</p>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>执行操作，枚举类型：CreateNewToken、RevokeOldToken、RecoverOldToken。<br>CreateNewToken：创建新的token并使之生效，注意默认最多有两个token同时生效，需要多个token生效，Force必须为true。<br>RevokeOldToken：删除老的token并使之失效，此时ClusterToken是必传。<br>RecoverOldToken：恢复老的token并使之生效，此时ClusterToken是必传，必须有对应的RevokeOldToken任务且任务成功才可以调用。</p>
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// <p>集群token，只有Operation为RevokeOldToken和RecoverOldToken时需要传入。</p>
        /// </summary>
        [JsonProperty("ClusterToken")]
        public string ClusterToken{ get; set; }

        /// <summary>
        /// <p>默认false，只有Operation为CreateNewToken时需要，设置为true时，才可以超过两个token。</p>
        /// </summary>
        [JsonProperty("Force")]
        public bool? Force{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "ClusterToken", this.ClusterToken);
            this.SetParamSimple(map, prefix + "Force", this.Force);
        }
    }
}

