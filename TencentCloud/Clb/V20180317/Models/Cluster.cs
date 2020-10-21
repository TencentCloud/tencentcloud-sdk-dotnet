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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Cluster : AbstractModel
    {
        
        /// <summary>
        /// 集群唯一ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 集群类型，如TGW，STGW，VPCGW
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 集群标签，只有STGW集群有标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterTag")]
        public string ClusterTag{ get; set; }

        /// <summary>
        /// 集群所在可用区，如ap-guangzhou-1
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 集群网络类型，如Public，Private
        /// </summary>
        [JsonProperty("Network")]
        public string Network{ get; set; }

        /// <summary>
        /// 最大连接数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxConn")]
        public long? MaxConn{ get; set; }

        /// <summary>
        /// 最大入带宽
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxInFlow")]
        public long? MaxInFlow{ get; set; }

        /// <summary>
        /// 最大入包量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxInPkg")]
        public long? MaxInPkg{ get; set; }

        /// <summary>
        /// 最大出带宽
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxOutFlow")]
        public long? MaxOutFlow{ get; set; }

        /// <summary>
        /// 最大出包量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxOutPkg")]
        public long? MaxOutPkg{ get; set; }

        /// <summary>
        /// 最大新建连接数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxNewConn")]
        public long? MaxNewConn{ get; set; }

        /// <summary>
        /// http最大新建连接数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HTTPMaxNewConn")]
        public long? HTTPMaxNewConn{ get; set; }

        /// <summary>
        /// https最大新建连接数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HTTPSMaxNewConn")]
        public long? HTTPSMaxNewConn{ get; set; }

        /// <summary>
        /// http QPS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HTTPQps")]
        public long? HTTPQps{ get; set; }

        /// <summary>
        /// https QPS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HTTPSQps")]
        public long? HTTPSQps{ get; set; }

        /// <summary>
        /// 集群内资源总数目
        /// </summary>
        [JsonProperty("ResourceCount")]
        public long? ResourceCount{ get; set; }

        /// <summary>
        /// 集群内空闲资源数目
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdleResourceCount")]
        public long? IdleResourceCount{ get; set; }

        /// <summary>
        /// 集群内转发机的数目
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LoadBalanceDirectorCount")]
        public long? LoadBalanceDirectorCount{ get; set; }

        /// <summary>
        /// 集群的Isp属性，如："BGP","CMCC","CUCC","CTCC","INTERNAL"。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Isp")]
        public string Isp{ get; set; }

        /// <summary>
        /// 集群所在的可用区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClustersZone")]
        public ClustersZone ClustersZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterTag", this.ClusterTag);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Network", this.Network);
            this.SetParamSimple(map, prefix + "MaxConn", this.MaxConn);
            this.SetParamSimple(map, prefix + "MaxInFlow", this.MaxInFlow);
            this.SetParamSimple(map, prefix + "MaxInPkg", this.MaxInPkg);
            this.SetParamSimple(map, prefix + "MaxOutFlow", this.MaxOutFlow);
            this.SetParamSimple(map, prefix + "MaxOutPkg", this.MaxOutPkg);
            this.SetParamSimple(map, prefix + "MaxNewConn", this.MaxNewConn);
            this.SetParamSimple(map, prefix + "HTTPMaxNewConn", this.HTTPMaxNewConn);
            this.SetParamSimple(map, prefix + "HTTPSMaxNewConn", this.HTTPSMaxNewConn);
            this.SetParamSimple(map, prefix + "HTTPQps", this.HTTPQps);
            this.SetParamSimple(map, prefix + "HTTPSQps", this.HTTPSQps);
            this.SetParamSimple(map, prefix + "ResourceCount", this.ResourceCount);
            this.SetParamSimple(map, prefix + "IdleResourceCount", this.IdleResourceCount);
            this.SetParamSimple(map, prefix + "LoadBalanceDirectorCount", this.LoadBalanceDirectorCount);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamObj(map, prefix + "ClustersZone.", this.ClustersZone);
        }
    }
}

