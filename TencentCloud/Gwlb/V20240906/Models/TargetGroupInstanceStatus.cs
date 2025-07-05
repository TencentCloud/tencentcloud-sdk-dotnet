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

namespace TencentCloud.Gwlb.V20240906.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TargetGroupInstanceStatus : AbstractModel
    {
        
        /// <summary>
        /// 后端rs的IP
        /// </summary>
        [JsonProperty("InstanceIp")]
        public string InstanceIp{ get; set; }

        /// <summary>
        /// 健康检查状态，参数值及含义如下：
        /// ● on：表示探测中。
        /// ● off：表示健康检查关闭。
        /// ● health：表示健康。
        /// ● unhealth：表示异常。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceIp", this.InstanceIp);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

