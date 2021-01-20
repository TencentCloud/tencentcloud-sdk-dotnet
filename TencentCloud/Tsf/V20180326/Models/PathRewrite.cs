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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PathRewrite : AbstractModel
    {
        
        /// <summary>
        /// 路径重写规则ID
        /// </summary>
        [JsonProperty("PathRewriteId")]
        public string PathRewriteId{ get; set; }

        /// <summary>
        /// 网关部署组ID
        /// </summary>
        [JsonProperty("GatewayGroupId")]
        public string GatewayGroupId{ get; set; }

        /// <summary>
        /// 正则表达式
        /// </summary>
        [JsonProperty("Regex")]
        public string Regex{ get; set; }

        /// <summary>
        /// 替换的内容
        /// </summary>
        [JsonProperty("Replacement")]
        public string Replacement{ get; set; }

        /// <summary>
        /// 是否屏蔽映射后路径，Y: 是 N: 否
        /// </summary>
        [JsonProperty("Blocked")]
        public string Blocked{ get; set; }

        /// <summary>
        /// 规则顺序，越小优先级越高
        /// </summary>
        [JsonProperty("Order")]
        public long? Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PathRewriteId", this.PathRewriteId);
            this.SetParamSimple(map, prefix + "GatewayGroupId", this.GatewayGroupId);
            this.SetParamSimple(map, prefix + "Regex", this.Regex);
            this.SetParamSimple(map, prefix + "Replacement", this.Replacement);
            this.SetParamSimple(map, prefix + "Blocked", this.Blocked);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}

