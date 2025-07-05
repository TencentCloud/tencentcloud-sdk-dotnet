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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StopInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要关机的实例ID列表。在单次请求的过程中，单个region下的请求实例数上限为100。
        /// </summary>
        [JsonProperty("InstanceIdSet")]
        public string[] InstanceIdSet{ get; set; }

        /// <summary>
        /// 是否在正常关闭失败后选择强制关闭实例，默认为false，即否。
        /// </summary>
        [JsonProperty("ForceStop")]
        public bool? ForceStop{ get; set; }

        /// <summary>
        /// 实例的关闭模式。取值范围：
        /// SOFT_FIRST：表示在正常关闭失败后进行强制关闭;
        /// HARD：直接强制关闭;
        /// SOFT：仅软关机；
        /// 默认为SOFT。
        /// </summary>
        [JsonProperty("StopType")]
        public string StopType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIdSet.", this.InstanceIdSet);
            this.SetParamSimple(map, prefix + "ForceStop", this.ForceStop);
            this.SetParamSimple(map, prefix + "StopType", this.StopType);
        }
    }
}

