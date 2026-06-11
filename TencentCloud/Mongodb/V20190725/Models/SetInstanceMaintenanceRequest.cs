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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetInstanceMaintenanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>指定实例ID。例如：cmgo-p8vn****。请登录 <a href="https://console.cloud.tencent.com/mongodb">MongoDB 控制台</a>在实例列表复制实例 ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>维护时间窗开始时间。取值范围为&quot;00:00-23:00&quot;的任意整点或半点，如00:00或00:30。</p>
        /// </summary>
        [JsonProperty("MaintenanceStart")]
        public string MaintenanceStart{ get; set; }

        /// <summary>
        /// <p>维护时间窗结束时间。</p><ul><li>取值范围为&quot;00:00-23:00&quot;的任意整点或半点，维护时间持续时长最小为30分钟，最大为3小时。</li><li>结束时间务必是基于开始时间向后的时间。</li></ul>
        /// </summary>
        [JsonProperty("MaintenanceEnd")]
        public string MaintenanceEnd{ get; set; }

        /// <summary>
        /// <p>指定每周内维护时间窗口的具体日期。  格式：请输入 1-7 之间的数字代表周一到周日（例如：1 代表周一），多个日期请用英文逗号 , 分隔。 示例：输入 1,3,5 表示维护窗口周期在每周的周一、周三、周五。 默认值：不设置，则默认为全周期 (1,2,3,4,5,6,7)。</p>
        /// </summary>
        [JsonProperty("MaintenanceDays")]
        public string MaintenanceDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MaintenanceStart", this.MaintenanceStart);
            this.SetParamSimple(map, prefix + "MaintenanceEnd", this.MaintenanceEnd);
            this.SetParamSimple(map, prefix + "MaintenanceDays", this.MaintenanceDays);
        }
    }
}

