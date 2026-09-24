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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WarehouseInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>仓库 id（格式 "dlc-wh-xxxxxxxx"）.</p>
        /// </summary>
        [JsonProperty("WarehouseId")]
        public string WarehouseId{ get; set; }

        /// <summary>
        /// <p>仓库名称，租户内唯一。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>创建者子账号 UIN。</p>
        /// </summary>
        [JsonProperty("CreatorSubUin")]
        public string CreatorSubUin{ get; set; }

        /// <summary>
        /// <p>仓库描述信息。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>fermion 合并后的单一状态。取值：STARTING / RUNNING / STOPPING / STOPPED / UPDATING / UNAVAILABLE / DESTROYING（销毁中，只读：不接受任何生命周期操作）。</p>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>资源池编码.</p>
        /// </summary>
        [JsonProperty("PartitionCode")]
        public string PartitionCode{ get; set; }

        /// <summary>
        /// <p>资源池展示名（解析不到时为空）.</p>
        /// </summary>
        [JsonProperty("PartitionName")]
        public string PartitionName{ get; set; }

        /// <summary>
        /// <p>资源组/队列名。</p>
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// <p>创建时间（毫秒时间戳）。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>最后更新时间（毫秒时间戳）。</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// <p>活跃集群数（describe 与 list 均返回）。集群明细等完整快照仅 DescribeWarehouseDetail 的 Observability 返回。</p>
        /// </summary>
        [JsonProperty("ActiveClusters")]
        public long? ActiveClusters{ get; set; }

        /// <summary>
        /// <p>最小集群数（即最小实例数下限；describe 与 list 均返回）.</p>
        /// </summary>
        [JsonProperty("MinClusters")]
        public long? MinClusters{ get; set; }

        /// <summary>
        /// <p>最大集群数（即最大实例数上限；describe 与 list 均返回）.</p>
        /// </summary>
        [JsonProperty("MaxClusters")]
        public long? MaxClusters{ get; set; }

        /// <summary>
        /// <p>运行时/镜像.</p>
        /// </summary>
        [JsonProperty("RuntimeCode")]
        public string RuntimeCode{ get; set; }

        /// <summary>
        /// <p>运行时展示名（如 Spark 3.5.5），与 RuntimeCode 配套；解析不到时为空.</p>
        /// </summary>
        [JsonProperty("RuntimeName")]
        public string RuntimeName{ get; set; }

        /// <summary>
        /// <p>Catalog 版本码.</p>
        /// </summary>
        [JsonProperty("SysCatalogVersion")]
        public string SysCatalogVersion{ get; set; }

        /// <summary>
        /// <p>环境变量.</p>
        /// </summary>
        [JsonProperty("EnvVars")]
        public KVPair[] EnvVars{ get; set; }

        /// <summary>
        /// <p>静态运行参数（RuntimeConf）：spark.* KV 的 JSON 字符串（如 "{\"spark.sql.shuffle.partitions\":\"400\"}"），spark-submit 时生效。</p>
        /// </summary>
        [JsonProperty("RuntimeConf")]
        public string RuntimeConf{ get; set; }

        /// <summary>
        /// <p>动态参数（DynamicProperties）：spark.* KV 的 JSON 字符串，运行期生效（会话级，openSession 弱注入，即改即生效）。</p>
        /// </summary>
        [JsonProperty("DynamicProperties")]
        public string DynamicProperties{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WarehouseId", this.WarehouseId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CreatorSubUin", this.CreatorSubUin);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "PartitionCode", this.PartitionCode);
            this.SetParamSimple(map, prefix + "PartitionName", this.PartitionName);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ActiveClusters", this.ActiveClusters);
            this.SetParamSimple(map, prefix + "MinClusters", this.MinClusters);
            this.SetParamSimple(map, prefix + "MaxClusters", this.MaxClusters);
            this.SetParamSimple(map, prefix + "RuntimeCode", this.RuntimeCode);
            this.SetParamSimple(map, prefix + "RuntimeName", this.RuntimeName);
            this.SetParamSimple(map, prefix + "SysCatalogVersion", this.SysCatalogVersion);
            this.SetParamArrayObj(map, prefix + "EnvVars.", this.EnvVars);
            this.SetParamSimple(map, prefix + "RuntimeConf", this.RuntimeConf);
            this.SetParamSimple(map, prefix + "DynamicProperties", this.DynamicProperties);
        }
    }
}

