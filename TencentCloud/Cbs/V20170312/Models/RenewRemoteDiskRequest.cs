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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RenewRemoteDiskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>预付费模式，即包年包月相关参数设置。通过该参数可以指定包年包月单副本SSD硬盘的续费时长。 在云硬盘与挂载的实例一起续费的场景下，可以指定参数CurInstanceDeadline，此时单副本SSD硬盘会按对齐到实例续费后的到期时间来续费。</p>
        /// </summary>
        [JsonProperty("DiskChargePrepaid")]
        public RemoteDiskChargePrepaid DiskChargePrepaid{ get; set; }

        /// <summary>
        /// <p>单副本SSD硬盘ID。</p>
        /// </summary>
        [JsonProperty("RemoteDiskId")]
        public string RemoteDiskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DiskChargePrepaid.", this.DiskChargePrepaid);
            this.SetParamSimple(map, prefix + "RemoteDiskId", this.RemoteDiskId);
        }
    }
}

