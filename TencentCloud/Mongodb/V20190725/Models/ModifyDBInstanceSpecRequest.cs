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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceSpecRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，例如：cmgo-p8vn****。请登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例配置变更后的内存大小。
        /// - 单位：GB。
        /// - 内存和磁盘必须同时升配或同时降配，即 Memory 与 Volume 需同时配置变更。
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// 实例配置变更后的硬盘大小，单位：GB。<ul><li>内存和磁盘必须同时升配或同时降配，即 Memory 与 Volume 需同时配置变更。</li><li>降配时，变更后的磁盘容量必须大于已用磁盘容量的1.2倍。</li></ul>
        /// </summary>
        [JsonProperty("Volume")]
        public ulong? Volume{ get; set; }

        /// <summary>
        /// (已废弃) 请使用ResizeOplog独立接口完成。
        /// 
        /// 实例配置变更后 Oplog 的大小。
        /// - 单位：GB。
        /// - 默认 Oplog 占用容量为磁盘空间的10%。系统允许设置的 Oplog 容量范围为磁盘空间的[10%,90%]。
        /// </summary>
        [JsonProperty("OplogSize")]
        public ulong? OplogSize{ get; set; }

        /// <summary>
        /// 实例变更后的节点数(mongod节点或mongos节点或readonly节点调整后的节点数，具体类型取决于AddNodeList或RemoveNodeList参数的节点类型)。
        /// <ul><li>副本集：取值范围请通过云数据库的售卖规格（DescribeSpecInfo）接口返回的参数 MinNodeNum 与 MaxNodeNum 获取。</li><li>分片集群：取值范围请通过云数据库的售卖规格（DescribeSpecInfo）接口返回的参数 MinReplicateSetNodeNum 与 MaxReplicateSetNodeNum 获取。</li></ul>
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// 实例变更后的分片数。<ul><li>取值范围请通过云数据库的售卖规格（DescribeSpecInfo）接口返回的参数MinReplicateSetNum与MaxReplicateSetNum获取。</li><li>该参数只能增加不能减少。</li></ul>
        /// </summary>
        [JsonProperty("ReplicateSetNum")]
        public ulong? ReplicateSetNum{ get; set; }

        /// <summary>
        /// 实例配置变更的切换时间。<ul><li>0：调整完成时，立即执行变配任务。默认为0。</li><li>1：在维护时间窗内，执行变配任务。
        /// <b>说明</b>：调整节点数和分片数不支持在<b>维护时间窗内</b>变更。</li></ul>
        /// </summary>
        [JsonProperty("InMaintenance")]
        public ulong? InMaintenance{ get; set; }

        /// <summary>
        /// 新增节点属性列表。
        /// </summary>
        [JsonProperty("AddNodeList")]
        public AddNodeList[] AddNodeList{ get; set; }

        /// <summary>
        /// 删除节点属性列表。
        /// </summary>
        [JsonProperty("RemoveNodeList")]
        public RemoveNodeList[] RemoveNodeList{ get; set; }


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
            this.SetParamArrayObj(map, prefix + "AddNodeList.", this.AddNodeList);
            this.SetParamArrayObj(map, prefix + "RemoveNodeList.", this.RemoveNodeList);
        }
    }
}

