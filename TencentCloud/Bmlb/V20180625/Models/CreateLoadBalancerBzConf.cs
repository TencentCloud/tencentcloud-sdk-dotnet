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

namespace TencentCloud.Bmlb.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLoadBalancerBzConf : AbstractModel
    {
        
        /// <summary>
        /// 按月/按小时计费。
        /// </summary>
        [JsonProperty("BzPayMode")]
        public string BzPayMode{ get; set; }

        /// <summary>
        /// 四层可选按带宽，连接数衡量。
        /// </summary>
        [JsonProperty("BzL4Metrics")]
        public string BzL4Metrics{ get; set; }

        /// <summary>
        /// 七层可选按qps衡量。
        /// </summary>
        [JsonProperty("BzL7Metrics")]
        public string BzL7Metrics{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BzPayMode", this.BzPayMode);
            this.SetParamSimple(map, prefix + "BzL4Metrics", this.BzL4Metrics);
            this.SetParamSimple(map, prefix + "BzL7Metrics", this.BzL7Metrics);
        }
    }
}

