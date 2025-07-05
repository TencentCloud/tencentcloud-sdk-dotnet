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

    public class ModifyDisksRenewFlagRequest : AbstractModel
    {
        
        /// <summary>
        /// 一个或多个待操作的云硬盘ID，该参数可以通过[DescribeDisks](/document/product/362/16315)接口查询。
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// 云硬盘的自动续费标识。取值范围：<ul><li>NOTIFY_AND_AUTO_RENEW：通知过期且自动续费</li><li>NOTIFY_AND_MANUAL_RENEW：通知过期不自动续费</li><li>DISABLE_NOTIFY_AND_MANUAL_RENEW：不通知过期不自动续费</li></ul>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 该参数支持设置云硬盘的自动续费周期，单位为月。取值范围：[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 24, 36]
        /// </summary>
        [JsonProperty("AutoRenewPeriod")]
        public ulong? AutoRenewPeriod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "AutoRenewPeriod", this.AutoRenewPeriod);
        }
    }
}

