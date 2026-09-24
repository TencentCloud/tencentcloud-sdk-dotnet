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

namespace TencentCloud.Tdai.V20250717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentMemInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Memory实例ID</p>
        /// </summary>
        [JsonProperty("MemInstanceId")]
        public string MemInstanceId{ get; set; }

        /// <summary>
        /// <p>1=active, 0=disabled（软删/关闭/下线历史行）</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>0=待安装,1=成功,2=失败待重试,3=开启中,4=关闭中/已关闭</p>
        /// </summary>
        [JsonProperty("InstallStatus")]
        public long? InstallStatus{ get; set; }

        /// <summary>
        /// <p>creating/online/isolated/error/</p>
        /// </summary>
        [JsonProperty("MemStatus")]
        public string MemStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MemInstanceId", this.MemInstanceId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InstallStatus", this.InstallStatus);
            this.SetParamSimple(map, prefix + "MemStatus", this.MemStatus);
        }
    }
}

