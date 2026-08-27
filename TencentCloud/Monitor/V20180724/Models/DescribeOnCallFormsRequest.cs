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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOnCallFormsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>固定值，为&quot;monitor&quot;</p>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// <p>分页查询起始位</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>分页查询页数</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>支持userId进行检索</p>
        /// </summary>
        [JsonProperty("OnCallFormStaffIDs")]
        public string[] OnCallFormStaffIDs{ get; set; }

        /// <summary>
        /// <p>值班类型</p>
        /// </summary>
        [JsonProperty("RotationType")]
        public string RotationType{ get; set; }

        /// <summary>
        /// <p>排序方式</p>
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// <p>支持id、name进行检索</p>
        /// </summary>
        [JsonProperty("OnCallFormName")]
        public string OnCallFormName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "OnCallFormStaffIDs.", this.OnCallFormStaffIDs);
            this.SetParamSimple(map, prefix + "RotationType", this.RotationType);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OnCallFormName", this.OnCallFormName);
        }
    }
}

