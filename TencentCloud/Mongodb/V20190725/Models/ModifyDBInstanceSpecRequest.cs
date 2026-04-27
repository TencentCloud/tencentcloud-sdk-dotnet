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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceSpecRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID。请登录 <a href="https://console.cloud.tencent.com/mongodb">MongoDB 控制台</a>在实例列表复制实例 ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例配置变更后的内存大小。单位：GB。该参数为空值时，默认取实例当前的内存大小。当前所支持的内存规格，请参见<a href="https://cloud.tencent.com/document/product/240/64125">产品规格</a>。<br><strong>注意</strong>：内存和磁盘必须同时升配或同时降配，即 Memory 与 Volume 需同时配置变更。</p>
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// <p>实例配置变更后的硬盘大小，单位：GB。该参数为空值时，默认取当前实例的磁盘大小。当前所支持的磁盘容量，请参见<a href="https://cloud.tencent.com/document/product/240/64125">产品规格</a>。</p><ul><li>内存和磁盘必须同时升配或同时降配，即 Memory 与 Volume 需同时配置变更。</li><li>降配时，变更后的磁盘容量必须大于已用磁盘容量的1.2倍。</li></ul>
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }

        /// <summary>
        /// <p>(已废弃) 请使用ResizeOplog独立接口完成。</p><p>实例配置变更后 Oplog 的大小。</p><ul><li>单位：GB。</li><li>默认 Oplog 占用容量为磁盘空间的10%。系统允许设置的 Oplog 容量范围为磁盘空间的[10%,90%]。</li></ul>
        /// </summary>
        [JsonProperty("OplogSize")]
        [System.Obsolete]
        public ulong? OplogSize{ get; set; }

        /// <summary>
        /// <p>实例变更后 mongod 的节点数（不包含 readonly 只读节点数）。</p><ul><li>副本集节点数：请通过 <a href="https://cloud.tencent.com/document/product/240/38567">DescribeSpecInfo </a>接口返回的参数 MinNodeNum 与 MaxNodeNum 获取节点数量取值范围。</li><li>分片集群每个分片节点数：请通过 <a href="https://cloud.tencent.com/document/product/240/38567">DescribeSpecInfo </a>接口返回的参数 MinReplicateSetNodeNum 与 MaxReplicateSetNodeNum 获取节点数量取值范围。<br><strong>说明</strong>：变更 mongod 或 mongos 的 CPU 与内存规格时，该参数可以不配置或者输入当前 mongod 或 mongos（不包含readonly）节点数量。</li></ul>
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// <p>实例变更后的分片数。</p><ul><li>请通过 <a href="https://cloud.tencent.com/document/product/240/38567">DescribeSpecInfo</a> 接口返回的参数<strong>MinReplicateSetNum</strong>与<strong>MaxReplicateSetNum</strong>获取实例分片数取值范围。</li><li>实例分片数量只允许增加不允许减少。</li></ul>
        /// </summary>
        [JsonProperty("ReplicateSetNum")]
        public ulong? ReplicateSetNum{ get; set; }

        /// <summary>
        /// <p>实例配置变更的切换时间。</p><ul><li>0：调整完成时，立即执行变配任务。默认为0。</li><li>1：在维护时间窗内，执行变配任务。<br><strong>说明</strong>：调整节点数和分片数不支持在<b>维护时间窗内</b>变更。</li></ul>
        /// </summary>
        [JsonProperty("InMaintenance")]
        public ulong? InMaintenance{ get; set; }

        /// <summary>
        /// <p>分片实例配置变更后的 mongos 内存大小。单位：GB。实例支持的规格，请参见<a href="https://cloud.tencent.com/document/product/240/64125">产品规格</a>。</p>
        /// </summary>
        [JsonProperty("MongosMemory")]
        public string MongosMemory{ get; set; }

        /// <summary>
        /// <p>新增节点列表，节点类型及可用区信息。</p>
        /// </summary>
        [JsonProperty("AddNodeList")]
        public AddNodeList[] AddNodeList{ get; set; }

        /// <summary>
        /// <p>删除节点列表。<br><strong>注意</strong>：基于分片实例各片节点的一致性原则，删除分片实例节点时，只需指定0分片对应的节点即可，如：cmgo-9nl1czif_0-node-readonly0 将删除每个分片的第1个只读节点。</p>
        /// </summary>
        [JsonProperty("RemoveNodeList")]
        public RemoveNodeList[] RemoveNodeList{ get; set; }

        /// <summary>
        /// <p>实例配置变更后的CPU大小。单位：C。该参数为空值时，默认取实例当前的 CPU 大小。当前所支持的CPU规格，请参见<a href="https://cloud.tencent.com/document/product/240/64125">产品规格</a>。</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>实例配置变更后的产品规格类型。该参数为空值时，默认取实例当前的产品规格类型。<br>当前支持的产品规格类型如下：<br>产品推荐规格类型：</p><ul><li>GE.LD.T1：本地盘（通用I型）。</li><li>GE.CD.T1：云盘（通用I型）。</li></ul><p>产品白名单规格类型：</p><ul><li>HIO10G：本地盘（高IO万兆型）。</li><li>HCD：云盘（云盘版）。</li></ul><p>注意：</p><ol><li>白名单规格类型为白名单控制，如若需要，请 <a href="https://console.cloud.tencent.com/workorder/category">提交工单</a> 申请</li><li>通用 I 型不能变更到白名单规格类型</li></ol>
        /// </summary>
        [JsonProperty("MachineCode")]
        public string MachineCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "OplogSize", this.OplogSize);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "ReplicateSetNum", this.ReplicateSetNum);
            this.SetParamSimple(map, prefix + "InMaintenance", this.InMaintenance);
            this.SetParamSimple(map, prefix + "MongosMemory", this.MongosMemory);
            this.SetParamArrayObj(map, prefix + "AddNodeList.", this.AddNodeList);
            this.SetParamArrayObj(map, prefix + "RemoveNodeList.", this.RemoveNodeList);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "MachineCode", this.MachineCode);
        }
    }
}

