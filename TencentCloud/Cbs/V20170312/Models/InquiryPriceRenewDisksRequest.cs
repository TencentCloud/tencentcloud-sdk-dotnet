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

    public class InquiryPriceRenewDisksRequest : AbstractModel
    {
        
        /// <summary>
        /// 云硬盘ID， 通过[DescribeDisks](/document/product/362/16315)接口查询。
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// 预付费模式，即包年包月相关参数设置。通过该参数可以指定包年包月云盘的购买时长。如果在该参数中指定CurInstanceDeadline，则会按对齐到子机到期时间来续费。如果是批量续费询价，该参数与Disks参数一一对应，元素数量需保持一致。
        /// </summary>
        [JsonProperty("DiskChargePrepaids")]
        public DiskChargePrepaid[] DiskChargePrepaids{ get; set; }

        /// <summary>
        /// 指定云盘新的到期时间，形式如：2017-12-17 00:00:00。参数`NewDeadline`和`DiskChargePrepaids`是两种指定询价时长的方式，两者必传一个。
        /// </summary>
        [JsonProperty("NewDeadline")]
        public string NewDeadline{ get; set; }

        /// <summary>
        /// 云盘所属项目ID。 如传入则仅用于鉴权。
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
            this.SetParamArrayObj(map, prefix + "DiskChargePrepaids.", this.DiskChargePrepaids);
            this.SetParamSimple(map, prefix + "NewDeadline", this.NewDeadline);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
        }
    }
}

