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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDisksRenewFlagRequest : AbstractModel
    {
        
        /// <summary>
        /// 云硬盘ID列表。每次批量请求云硬盘的上限为 100。可通过[DescribeDisks](https://cloud.tencent.com/document/product/1207/66093)接口返回值中的DiskId获取。
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// 自动续费标识。取值范围：
        /// 
        /// - NOTIFY_AND_AUTO_RENEW：通知过期且自动续费
        /// - NOTIFY_AND_MANUAL_RENEW：通知过期不自动续费
        /// - DISABLE_NOTIFY_AND_MANUAL_RENEW：不通知过期不自动续费
        /// 
        /// 若该参数指定为NOTIFY_AND_AUTO_RENEW，在账户余额充足的情况下，实例到期后将按月自动续费。
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
        }
    }
}

