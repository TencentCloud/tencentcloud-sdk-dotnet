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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RenewDiskRequest : AbstractModel
    {
        
        /// <summary>
        /// 预付费模式，即包年包月相关参数设置。通过该参数可以指定包年包月云盘的续费时长。<br>在云盘与挂载的实例一起续费的场景下，可以指定参数CurInstanceDeadline，此时云盘会按对齐到实例续费后的到期时间来续费。
        /// </summary>
        [JsonProperty("DiskChargePrepaid")]
        public DiskChargePrepaid DiskChargePrepaid{ get; set; }

        /// <summary>
        /// 云硬盘ID， 通过[DescribeDisks](/document/product/362/16315)接口查询。
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DiskChargePrepaid.", this.DiskChargePrepaid);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
        }
    }
}

