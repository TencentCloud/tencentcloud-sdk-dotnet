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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeComponentInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 组件ID。
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 组件名称。
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }

        /// <summary>
        /// 组件类型。
        /// <li>WEB：web组件</li>
        /// <li>SYSTEM：系统组件</li>
        /// </summary>
        [JsonProperty("ComponentType")]
        public string ComponentType{ get; set; }

        /// <summary>
        /// 组件官网。
        /// </summary>
        [JsonProperty("Homepage")]
        public string Homepage{ get; set; }

        /// <summary>
        /// 组件描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ComponentName", this.ComponentName);
            this.SetParamSimple(map, prefix + "ComponentType", this.ComponentType);
            this.SetParamSimple(map, prefix + "Homepage", this.Homepage);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

