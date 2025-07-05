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

    public class ModifyVpcFwGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 编辑的防火墙(组)ID
        /// </summary>
        [JsonProperty("FwGroupId")]
        public string FwGroupId{ get; set; }

        /// <summary>
        /// 修改防火墙(组)名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 编辑的防火墙实例列表
        /// </summary>
        [JsonProperty("VpcFwInstances")]
        public VpcFwInstance[] VpcFwInstances{ get; set; }

        /// <summary>
        /// 指定防火墙使用网段信息
        /// </summary>
        [JsonProperty("FwCidrInfo")]
        public FwCidrInfo FwCidrInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FwGroupId", this.FwGroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "VpcFwInstances.", this.VpcFwInstances);
            this.SetParamObj(map, prefix + "FwCidrInfo.", this.FwCidrInfo);
        }
    }
}

