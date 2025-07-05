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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkGroupMessage : AbstractModel
    {
        
        /// <summary>
        /// 工作组唯一Id
        /// </summary>
        [JsonProperty("WorkGroupId")]
        public long? WorkGroupId{ get; set; }

        /// <summary>
        /// 工作组名称
        /// </summary>
        [JsonProperty("WorkGroupName")]
        public string WorkGroupName{ get; set; }

        /// <summary>
        /// 工作组描述
        /// </summary>
        [JsonProperty("WorkGroupDescription")]
        public string WorkGroupDescription{ get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 工作组创建的时间，形如2021-07-28 16:19:32
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkGroupId", this.WorkGroupId);
            this.SetParamSimple(map, prefix + "WorkGroupName", this.WorkGroupName);
            this.SetParamSimple(map, prefix + "WorkGroupDescription", this.WorkGroupDescription);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

