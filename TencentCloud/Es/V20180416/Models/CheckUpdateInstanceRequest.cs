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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckUpdateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 已废弃，请使用NodeInfoList
        /// 变配后的节点个数（2-50个）
        /// </summary>
        [JsonProperty("NodeNum")]
        public ulong? NodeNum{ get; set; }

        /// <summary>
        /// 已废弃，请使用NodeInfoList
        /// 变配后的节点规格<li>ES.S1.SMALL2：1核2G</li><li>ES.S1.MEDIUM4：2核4G</li><li>ES.S1.MEDIUM8：2核8G</li><li>ES.S1.LARGE16：4核16G</li><li>ES.S1.2XLARGE32：8核32G</li><li>ES.S1.4XLARGE64：16核64G</li>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 已废弃，请使用NodeInfoList
        /// 变配后的磁盘大小（单位GB）
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// 已废弃，请使用NodeInfoList
        /// 变配后的专用主节点个数（仅支持3个和5个）
        /// </summary>
        [JsonProperty("MasterNodeNum")]
        public ulong? MasterNodeNum{ get; set; }

        /// <summary>
        /// 已废弃，请使用NodeInfoList
        /// 变配后的专用主节点规格<li>ES.S1.SMALL2：1核2G</li><li>ES.S1.MEDIUM4：2核4G</li><li>ES.S1.MEDIUM8：2核8G</li><li>ES.S1.LARGE16：4核16G</li><li>ES.S1.2XLARGE32：8核32G</li><li>ES.S1.4XLARGE64：16核64G</li>
        /// </summary>
        [JsonProperty("MasterNodeType")]
        public string MasterNodeType{ get; set; }

        /// <summary>
        /// 节点信息列表，可以只传递要更新的节点及其对应的规格信息。支持的操作包括<li>修改一种节点的个数</li><li>修改一种节点的节点规格及磁盘大小</li><li>增加一种节点类型（需要同时指定该节点的类型，个数，规格，磁盘等信息）</li>上述操作一次只能进行一种，且磁盘类型不支持修改
        /// </summary>
        [JsonProperty("NodeInfoList")]
        public NodeInfo[] NodeInfoList{ get; set; }

        /// <summary>
        /// 更新配置时是否强制重启<li>true强制重启</li><li>false不强制重启</li>默认值为false
        /// </summary>
        [JsonProperty("ForceRestart")]
        public bool? ForceRestart{ get; set; }

        /// <summary>
        /// 0: 蓝绿变更方式扩容，集群不重启 （默认） 1: 磁盘解挂载扩容，集群滚动重启
        /// </summary>
        [JsonProperty("ScaleType")]
        public long? ScaleType{ get; set; }

        /// <summary>
        /// 多可用区部署
        /// </summary>
        [JsonProperty("MultiZoneInfo")]
        public ZoneDetail[] MultiZoneInfo{ get; set; }

        /// <summary>
        /// 可视化节点配置
        /// </summary>
        [JsonProperty("WebNodeTypeInfo")]
        public WebNodeTypeInfo WebNodeTypeInfo{ get; set; }

        /// <summary>
        /// COS自动备份信息
        /// </summary>
        [JsonProperty("CosBackup")]
        public CosBackup CosBackup{ get; set; }

        /// <summary>
        /// 读写分离模式：-1-不开启，1-本地读写分离，2-远端读写分离
        /// </summary>
        [JsonProperty("ReadWriteMode")]
        public long? ReadWriteMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "MasterNodeNum", this.MasterNodeNum);
            this.SetParamSimple(map, prefix + "MasterNodeType", this.MasterNodeType);
            this.SetParamArrayObj(map, prefix + "NodeInfoList.", this.NodeInfoList);
            this.SetParamSimple(map, prefix + "ForceRestart", this.ForceRestart);
            this.SetParamSimple(map, prefix + "ScaleType", this.ScaleType);
            this.SetParamArrayObj(map, prefix + "MultiZoneInfo.", this.MultiZoneInfo);
            this.SetParamObj(map, prefix + "WebNodeTypeInfo.", this.WebNodeTypeInfo);
            this.SetParamObj(map, prefix + "CosBackup.", this.CosBackup);
            this.SetParamSimple(map, prefix + "ReadWriteMode", this.ReadWriteMode);
        }
    }
}

