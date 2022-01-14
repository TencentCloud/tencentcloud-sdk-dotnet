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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateEKSClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// 弹性集群Id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 弹性集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 弹性集群描述信息
        /// </summary>
        [JsonProperty("ClusterDesc")]
        public string ClusterDesc{ get; set; }

        /// <summary>
        /// 子网Id 列表
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// 弹性容器集群公网访问LB信息
        /// </summary>
        [JsonProperty("PublicLB")]
        public ClusterPublicLB PublicLB{ get; set; }

        /// <summary>
        /// 弹性容器集群内网访问LB信息
        /// </summary>
        [JsonProperty("InternalLB")]
        public ClusterInternalLB InternalLB{ get; set; }

        /// <summary>
        /// Service 子网Id
        /// </summary>
        [JsonProperty("ServiceSubnetId")]
        public string ServiceSubnetId{ get; set; }

        /// <summary>
        /// 集群自定义的dns 服务器信息
        /// </summary>
        [JsonProperty("DnsServers")]
        public DnsServerConf[] DnsServers{ get; set; }

        /// <summary>
        /// 是否清空自定义dns 服务器设置。为1 表示 是。其他表示 否。
        /// </summary>
        [JsonProperty("ClearDnsServer")]
        public string ClearDnsServer{ get; set; }

        /// <summary>
        /// 将来删除集群时是否要删除cbs。默认为 FALSE
        /// </summary>
        [JsonProperty("NeedDeleteCbs")]
        public bool? NeedDeleteCbs{ get; set; }

        /// <summary>
        /// 标记是否是新的内外网。默认为false
        /// </summary>
        [JsonProperty("ProxyLB")]
        public bool? ProxyLB{ get; set; }

        /// <summary>
        /// 扩展参数。须是map[string]string 的json 格式。
        /// </summary>
        [JsonProperty("ExtraParam")]
        public string ExtraParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterDesc", this.ClusterDesc);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamObj(map, prefix + "PublicLB.", this.PublicLB);
            this.SetParamObj(map, prefix + "InternalLB.", this.InternalLB);
            this.SetParamSimple(map, prefix + "ServiceSubnetId", this.ServiceSubnetId);
            this.SetParamArrayObj(map, prefix + "DnsServers.", this.DnsServers);
            this.SetParamSimple(map, prefix + "ClearDnsServer", this.ClearDnsServer);
            this.SetParamSimple(map, prefix + "NeedDeleteCbs", this.NeedDeleteCbs);
            this.SetParamSimple(map, prefix + "ProxyLB", this.ProxyLB);
            this.SetParamSimple(map, prefix + "ExtraParam", this.ExtraParam);
        }
    }
}

