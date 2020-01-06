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

    public class DevicesBindInfoLoadBalancer : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例ID。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 开发商AppId。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 负载均衡所属的项目ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 黑石私有网络唯一ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 负载均衡的IP地址。
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 负载均衡对应的TGW集群类别，取值为tunnel或fullnat。tunnel表示隧道集群，fullnat表示FULLNAT集群。
        /// </summary>
        [JsonProperty("TgwSetType")]
        public string TgwSetType{ get; set; }

        /// <summary>
        /// 是否独占TGW集群。
        /// </summary>
        [JsonProperty("Exclusive")]
        public long? Exclusive{ get; set; }

        /// <summary>
        /// 具有该绑定关系的四层监听器列表。
        /// </summary>
        [JsonProperty("L4ListenerSet")]
        public DevicesBindInfoL4Listener[] L4ListenerSet{ get; set; }

        /// <summary>
        /// 具有该绑定关系的七层监听器列表。
        /// </summary>
        [JsonProperty("L7ListenerSet")]
        public DevicesBindInfoL7Listener[] L7ListenerSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "TgwSetType", this.TgwSetType);
            this.SetParamSimple(map, prefix + "Exclusive", this.Exclusive);
            this.SetParamArrayObj(map, prefix + "L4ListenerSet.", this.L4ListenerSet);
            this.SetParamArrayObj(map, prefix + "L7ListenerSet.", this.L7ListenerSet);
        }
    }
}

