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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VersionProvisionedConcurrencyInfo : AbstractModel
    {
        
        /// <summary>
        /// 设置的预置并发数。
        /// </summary>
        [JsonProperty("AllocatedProvisionedConcurrencyNum")]
        public ulong? AllocatedProvisionedConcurrencyNum{ get; set; }

        /// <summary>
        /// 当前已完成预置的并发数。
        /// </summary>
        [JsonProperty("AvailableProvisionedConcurrencyNum")]
        public ulong? AvailableProvisionedConcurrencyNum{ get; set; }

        /// <summary>
        /// 预置任务状态，Done表示已完成，InProgress表示进行中，Failed表示部分或全部失败。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 对预置任务状态Status的说明。
        /// </summary>
        [JsonProperty("StatusReason")]
        public string StatusReason{ get; set; }

        /// <summary>
        /// 函数版本号
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllocatedProvisionedConcurrencyNum", this.AllocatedProvisionedConcurrencyNum);
            this.SetParamSimple(map, prefix + "AvailableProvisionedConcurrencyNum", this.AvailableProvisionedConcurrencyNum);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusReason", this.StatusReason);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
        }
    }
}

