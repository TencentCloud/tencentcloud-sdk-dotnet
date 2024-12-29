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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigureChcAssistVpcRequest : AbstractModel
    {
        
        /// <summary>
        /// CHC物理服务器的实例Id。
        /// </summary>
        [JsonProperty("ChcIds")]
        public string[] ChcIds{ get; set; }

        /// <summary>
        /// 带外网络信息。
        /// </summary>
        [JsonProperty("BmcVirtualPrivateCloud")]
        public VirtualPrivateCloud BmcVirtualPrivateCloud{ get; set; }

        /// <summary>
        /// 带外网络的安全组列表
        /// </summary>
        [JsonProperty("BmcSecurityGroupIds")]
        public string[] BmcSecurityGroupIds{ get; set; }

        /// <summary>
        /// 部署网络信息。
        /// </summary>
        [JsonProperty("DeployVirtualPrivateCloud")]
        public VirtualPrivateCloud DeployVirtualPrivateCloud{ get; set; }

        /// <summary>
        /// 部署网络的安全组列表
        /// </summary>
        [JsonProperty("DeploySecurityGroupIds")]
        public string[] DeploySecurityGroupIds{ get; set; }

        /// <summary>
        /// 部署网络的附加参数，用于指定minios类型、bios引导模式等
        /// </summary>
        [JsonProperty("ChcDeployExtraConfig")]
        public ChcDeployExtraConfig ChcDeployExtraConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ChcIds.", this.ChcIds);
            this.SetParamObj(map, prefix + "BmcVirtualPrivateCloud.", this.BmcVirtualPrivateCloud);
            this.SetParamArraySimple(map, prefix + "BmcSecurityGroupIds.", this.BmcSecurityGroupIds);
            this.SetParamObj(map, prefix + "DeployVirtualPrivateCloud.", this.DeployVirtualPrivateCloud);
            this.SetParamArraySimple(map, prefix + "DeploySecurityGroupIds.", this.DeploySecurityGroupIds);
            this.SetParamObj(map, prefix + "ChcDeployExtraConfig.", this.ChcDeployExtraConfig);
        }
    }
}

