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

    public class CreateVpcFwGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// VPC防火墙(组)名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 模式 1：CCN云联网模式；0：私有网络模式 2: sase 模式 3：ccn 高级模式 4: 私有网络(跨租户单边模式)
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// 防火墙(组)下的防火墙实例列表
        /// </summary>
        [JsonProperty("VpcFwInstances")]
        public VpcFwInstance[] VpcFwInstances{ get; set; }

        /// <summary>
        /// 防火墙实例的开关模式
        /// 1: 单点互通
        /// 2: 多点互通
        /// 3: 全互通
        /// 4: 自定义路由
        /// </summary>
        [JsonProperty("SwitchMode")]
        public long? SwitchMode{ get; set; }

        /// <summary>
        /// auto 自动选择防火墙网段
        /// 10.10.10.0/24 用户输入的防火墙网段
        /// </summary>
        [JsonProperty("FwVpcCidr")]
        public string FwVpcCidr{ get; set; }

        /// <summary>
        /// 云联网id ，适用于云联网模式
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// 指定防火墙使用网段信息
        /// </summary>
        [JsonProperty("FwCidrInfo")]
        public FwCidrInfo FwCidrInfo{ get; set; }

        /// <summary>
        /// 跨租户管理员模式  1管理员 2多账号
        /// </summary>
        [JsonProperty("CrossUserMode")]
        public string CrossUserMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArrayObj(map, prefix + "VpcFwInstances.", this.VpcFwInstances);
            this.SetParamSimple(map, prefix + "SwitchMode", this.SwitchMode);
            this.SetParamSimple(map, prefix + "FwVpcCidr", this.FwVpcCidr);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamObj(map, prefix + "FwCidrInfo.", this.FwCidrInfo);
            this.SetParamSimple(map, prefix + "CrossUserMode", this.CrossUserMode);
        }
    }
}

