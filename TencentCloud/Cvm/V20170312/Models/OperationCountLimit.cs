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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OperationCountLimit : AbstractModel
    {
        
        /// <summary>
        /// 实例操作。取值范围：<br><li>`INSTANCE_DEGRADE`：降配操作</li><li>`INTERNET_CHARGE_TYPE_CHANGE`：修改网络带宽计费模式</li>
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 当前已使用次数，如果返回值为-1表示该操作无次数限制。
        /// </summary>
        [JsonProperty("CurrentCount")]
        public long? CurrentCount{ get; set; }

        /// <summary>
        /// 操作次数最高额度，如果返回值为-1表示该操作无次数限制，如果返回值为0表示不支持调整配置。
        /// </summary>
        [JsonProperty("LimitCount")]
        public long? LimitCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CurrentCount", this.CurrentCount);
            this.SetParamSimple(map, prefix + "LimitCount", this.LimitCount);
        }
    }
}

