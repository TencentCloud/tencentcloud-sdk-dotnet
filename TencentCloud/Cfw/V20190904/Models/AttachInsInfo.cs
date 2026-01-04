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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttachInsInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例对象可以是cvm类型:ins-ad21xuds1形式;路由表类型:rtb-da12daxd形式;vpc类型:vpc-1dxdad2d形式
        /// </summary>
        [JsonProperty("InsId")]
        public string InsId{ get; set; }

        /// <summary>
        /// 实例对象名称
        /// </summary>
        [JsonProperty("InsName")]
        public string InsName{ get; set; }

        /// <summary>
        /// 实例的cidr
        /// </summary>
        [JsonProperty("Cidr")]
        public string Cidr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InsId", this.InsId);
            this.SetParamSimple(map, prefix + "InsName", this.InsName);
            this.SetParamSimple(map, prefix + "Cidr", this.Cidr);
        }
    }
}

