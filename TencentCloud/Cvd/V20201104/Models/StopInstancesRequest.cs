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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StopInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要重启的实例id列表
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 实例所在区域，保证传入的列表在统一区域，否则报错
        /// </summary>
        [JsonProperty("InstanceRegion")]
        public string InstanceRegion{ get; set; }

        /// <summary>
        /// 是否在正常重启失败后选择强制重启实例。取值范围：
        /// TRUE：表示在正常重启失败后进行强制重启
        /// FALSE：表示在正常重启失败后不进行强制重启
        /// 
        /// 默认取值：FALSE。
        /// </summary>
        [JsonProperty("Force")]
        public bool? Force{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "InstanceRegion", this.InstanceRegion);
            this.SetParamSimple(map, prefix + "Force", this.Force);
        }
    }
}

