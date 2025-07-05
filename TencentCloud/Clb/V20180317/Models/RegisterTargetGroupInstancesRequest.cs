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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegisterTargetGroupInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 目标组ID
        /// </summary>
        [JsonProperty("TargetGroupId")]
        public string TargetGroupId{ get; set; }

        /// <summary>
        /// 服务器实例数组，服务器和目标组的 VPC 需相同。
        /// </summary>
        [JsonProperty("TargetGroupInstances")]
        public TargetGroupInstance[] TargetGroupInstances{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetGroupId", this.TargetGroupId);
            this.SetParamArrayObj(map, prefix + "TargetGroupInstances.", this.TargetGroupInstances);
        }
    }
}

