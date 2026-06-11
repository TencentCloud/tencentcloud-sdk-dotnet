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

    public class InquirePriceRenewRemoteDisksRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>预付费模式，即包年包月相关参数设置。通过该参数可以指定包年包月云盘的购买时长。如果在该参数中指定CurInstanceDeadline，则会按对齐到子机到期时间来续费。如果是批量续费询价，该参数与Disks参数一一对应，元素数量需保持一致。</p>
        /// </summary>
        [JsonProperty("DiskChargePrepaidSet")]
        public RemoteDiskChargePrepaid[] DiskChargePrepaidSet{ get; set; }

        /// <summary>
        /// <p>一个或多个单副本SSD硬盘ID。</p>
        /// </summary>
        [JsonProperty("RemoteDiskIds")]
        public string[] RemoteDiskIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "DiskChargePrepaidSet.", this.DiskChargePrepaidSet);
            this.SetParamArraySimple(map, prefix + "RemoteDiskIds.", this.RemoteDiskIds);
        }
    }
}

