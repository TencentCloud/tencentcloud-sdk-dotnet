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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RebootInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 待重启的实例ID列表。在单次请求的过程中，单个region下的请求实例数上限为100。
        /// </summary>
        [JsonProperty("InstanceIdSet")]
        public string[] InstanceIdSet{ get; set; }

        /// <summary>
        /// 是否在正常重启失败后选择强制重启实例。取值范围：
        /// TRUE：表示在正常重启失败后进行强制重启；
        /// FALSE：表示在正常重启失败后不进行强制重启；
        /// 默认取值：FALSE。
        /// </summary>
        [JsonProperty("ForceReboot")]
        public bool? ForceReboot{ get; set; }

        /// <summary>
        /// 关机类型。取值范围：
        /// SOFT：表示软关机
        /// HARD：表示硬关机
        /// SOFT_FIRST：表示优先软关机，失败再执行硬关机
        /// 
        /// 默认取值：SOFT。
        /// </summary>
        [JsonProperty("StopType")]
        public string StopType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIdSet.", this.InstanceIdSet);
            this.SetParamSimple(map, prefix + "ForceReboot", this.ForceReboot);
            this.SetParamSimple(map, prefix + "StopType", this.StopType);
        }
    }
}

