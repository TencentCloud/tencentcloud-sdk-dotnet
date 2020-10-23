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

    public class DescribeAgentGroupsResponse : AbstractModel
    {
        
        /// <summary>
        /// 用户所属的系统默认拨测分组
        /// </summary>
        [JsonProperty("SysDefaultGroup")]
        public AgentGroup SysDefaultGroup{ get; set; }

        /// <summary>
        /// 用户创建的拨测分组列表
        /// </summary>
        [JsonProperty("CustomGroups")]
        public AgentGroup[] CustomGroups{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SysDefaultGroup.", this.SysDefaultGroup);
            this.SetParamArrayObj(map, prefix + "CustomGroups.", this.CustomGroups);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

