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

namespace TencentCloud.Tcm.V20210413.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Mesh : AbstractModel
    {
        
        /// <summary>
        /// Mesh实例Id
        /// </summary>
        [JsonProperty("MeshId")]
        public string MeshId{ get; set; }

        /// <summary>
        /// Mesh名称
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// Mesh类型，取值范围：
        /// - STANDALONE：独立网格
        /// - HOSTED：托管网格
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Mesh状态，取值范围：
        /// - PENDING：等待中
        /// - CREATING：创建中
        /// - RUNNING：运行中
        /// - ABNORMAL：异常
        /// - UPGRADING：升级中
        /// - CANARY_UPGRADED：升级灰度完成
        /// - ROLLBACKING：升级回滚
        /// - DELETING：删除中
        /// - CREATE_FAILED：安装失败
        /// - DELETE_FAILED：删除失败
        /// - UPGRADE_FAILED：升级失败
        /// - ROLLBACK_FAILED：回滚失败
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// 集群列表
        /// </summary>
        [JsonProperty("ClusterList")]
        public Cluster[] ClusterList{ get; set; }

        /// <summary>
        /// Mesh配置
        /// </summary>
        [JsonProperty("Config")]
        public MeshConfig Config{ get; set; }

        /// <summary>
        /// Mesh详细状态
        /// </summary>
        [JsonProperty("Status")]
        public MeshStatus Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MeshId", this.MeshId);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamArrayObj(map, prefix + "ClusterList.", this.ClusterList);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamObj(map, prefix + "Status.", this.Status);
        }
    }
}

