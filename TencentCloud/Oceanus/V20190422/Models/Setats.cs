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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Setats : AbstractModel
    {
        
        /// <summary>
        /// <p>setats serialId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SetatsSerialId")]
        public string SetatsSerialId{ get; set; }

        /// <summary>
        /// <p>1  // 停止<br>2  // 运行中<br>3  // 初始化中<br>4  // 扩容中<br>5  // Warehoouse未配置<br>6  // Warehoouse配置中<br>7  // 重启中<br>-2 // 已删除(集群被销毁时更新为此状态)</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>setats warehouse</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Warehouse")]
        public Warehouse Warehouse{ get; set; }

        /// <summary>
        /// <p>setats master 机器规格</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MasterInfo")]
        public SetatsCvmInfo MasterInfo{ get; set; }

        /// <summary>
        /// <p>setats worker规格</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkerInfo")]
        public SetatsCvmInfo WorkerInfo{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>自动续费</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>过期时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>过期时间 秒</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecondsUntilExpiry")]
        public string SecondsUntilExpiry{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>manager url</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ManagerUrl")]
        public string ManagerUrl{ get; set; }

        /// <summary>
        /// <p>隔离时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public string IsolatedTime{ get; set; }

        /// <summary>
        /// <p>Setats集群自己的id</p>
        /// </summary>
        [JsonProperty("OwnerClusterGroupSerialId")]
        public string OwnerClusterGroupSerialId{ get; set; }

        /// <summary>
        /// <p>setats 集群类型</p>
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// <p>Setats UI url</p>
        /// </summary>
        [JsonProperty("SetatsUiUrl")]
        public string SetatsUiUrl{ get; set; }

        /// <summary>
        /// <p>setats镜像版本</p>
        /// </summary>
        [JsonProperty("ImageVersion")]
        public string ImageVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SetatsSerialId", this.SetatsSerialId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "Warehouse.", this.Warehouse);
            this.SetParamObj(map, prefix + "MasterInfo.", this.MasterInfo);
            this.SetParamObj(map, prefix + "WorkerInfo.", this.WorkerInfo);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "SecondsUntilExpiry", this.SecondsUntilExpiry);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ManagerUrl", this.ManagerUrl);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "OwnerClusterGroupSerialId", this.OwnerClusterGroupSerialId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SetatsUiUrl", this.SetatsUiUrl);
            this.SetParamSimple(map, prefix + "ImageVersion", this.ImageVersion);
        }
    }
}

