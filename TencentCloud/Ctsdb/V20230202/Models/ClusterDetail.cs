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

namespace TencentCloud.Ctsdb.V20230202.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>用户APPID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>实例id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// <p>账号id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountID")]
        public string AccountID{ get; set; }

        /// <summary>
        /// <p>自定义实例名</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>网络信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Networks")]
        public Network[] Networks{ get; set; }

        /// <summary>
        /// <p>实例状态</p>枚举值：<ul><li> 0： 运行中</li><li> 1： 创建中</li><li> 16： 变配中</li><li> 17： 隔离中</li><li> 18： 已隔离</li><li> 19： 恢复中</li><li> 20： 已关机</li><li> 21： 销毁中</li><li> 22： 已销毁</li><li> 30： 扩展节点添加中</li><li> 31： 扩展节点变配中</li><li> 32： 扩展节点删除中</li><li> 33： 扩展节点禁用中</li><li> 34： 扩展节点启用中</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>最后修改时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>安全组信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Security")]
        public string[] Security{ get; set; }

        /// <summary>
        /// <p>组件信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Components")]
        public Component[] Components{ get; set; }

        /// <summary>
        /// <p>过期时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpiredAt")]
        public string ExpiredAt{ get; set; }

        /// <summary>
        /// <p>续费标识</p>枚举值：<ul><li> 0： 默认</li><li> 1： 自动续费</li><li> 2： 不自动续费</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>关机时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShutdownAt")]
        public string ShutdownAt{ get; set; }

        /// <summary>
        /// <p>隔离时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsolatedAt")]
        public string IsolatedAt{ get; set; }

        /// <summary>
        /// <p>实例类型</p>枚举值：<ul><li> 0： 共享型</li><li> 1： 独享型</li><li> 2： 标准型</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "AccountID", this.AccountID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArrayObj(map, prefix + "Networks.", this.Networks);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "Security.", this.Security);
            this.SetParamArrayObj(map, prefix + "Components.", this.Components);
            this.SetParamSimple(map, prefix + "ExpiredAt", this.ExpiredAt);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "ShutdownAt", this.ShutdownAt);
            this.SetParamSimple(map, prefix + "IsolatedAt", this.IsolatedAt);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

